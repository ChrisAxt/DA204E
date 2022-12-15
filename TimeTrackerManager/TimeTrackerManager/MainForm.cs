using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTrackerManager
{
    public partial class MainForm : Form
    {

        private TaskManager taskManager = new TaskManager();
        Settings settings = new Settings();

        /// <summary>
        /// Constructor with no parameters
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Method to initialize the GUI 
        /// </summary>
        private void InitializeGUI()
        {
            this.Text = "Time Manager";
            cbxFilter.DataSource = Enum.GetNames(typeof(FilterTypes));
            lblSelectedTaskName.Text = "Please select a task to be displayed here.";
            lblSelectedTaskType.Text = "-";
            lblSelectedAllocatedTime.Text = "-";
            lblSelectedTimeSpent.Text = "-";
            lblSelectedTimeLeft.Text = "-";
            lblSelectedDate.Text = "-";
            UpdateTaskList();
        }

        /// <summary>
        /// Event handler to add a new task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TaskForm frmTask = new TaskForm("Add new task");
            frmTask.ShowDialog();
            if (frmTask.DialogResult == DialogResult.OK)
            {
                    taskManager.Add(frmTask.TaskData);
                    CheckTasksTotalTime(frmTask);
                    UpdateGUI();
                    UpdateTaskList();
            }
        }
        /// <summary>
        /// Event handler to start timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {

            int index = lbxTaskList.SelectedIndex;
            taskManager.ChangeStatus("Active", index);
            UpdateTaskList();
            lbxTaskList.SelectedIndex = index;
            BtnAdd.Enabled = false;
            timer1.Start();

        }
        /// <summary>
        /// Event handler to stop timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPause_Click(object sender, EventArgs e)
        {

            int index = lbxTaskList.SelectedIndex;
            taskManager.ChangeStatus("Paused", index);
            UpdateTaskList();
            lbxTaskList.SelectedIndex = index;
            BtnAdd.Enabled = true;
            timer1.Stop();

        }
        /// <summary>
        /// Event handler to stop timer and change status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComplete_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            BtnAdd.Enabled = true;
            int index = lbxTaskList.SelectedIndex;
            taskManager.ChangeStatus("Completed", index);
            UpdateTaskList();
            lbxTaskList.SelectedIndex = index;
        }
        /// <summary>
        /// Event handler to edit an existing task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbxTaskList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a task to edit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                timer1.Stop();
                int index = lbxTaskList.SelectedIndex;
                Task editTask = new Task();
                editTask = taskManager.GetTask(index);
                TaskForm frmTask = new TaskForm("Edit task: " + editTask.Description);

                frmTask.TaskData = editTask;
                frmTask.DispaySelectedTask();

                if (frmTask.ShowDialog() == DialogResult.OK)
                {
                    frmTask.ReadInput();
                    taskManager.ChangeTask(editTask, index);
                    UpdateTaskList();
                }
            }

        }
        /// <summary>
        /// Event handler to delete an existing task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        { 
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Delete task", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                timer1.Stop();
                taskManager.DeleteTask(lbxTaskList.SelectedIndex);
                InitializeGUI();
            }
        }
        /// <summary>
        /// Event handler to clear the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileNew_Click(object sender, EventArgs e)
        {
            int taskCount = taskManager.Count;
            if (DialogResult.Yes == MessageBox.Show("If you continue, all previous tasks data will be erased. Continue?", "New form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                taskManager.DeleteAllTasks();
                InitializeGUI();
            }
        }
        /// <summary>
        /// Event handler to exit the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileExit_Click(object sender, EventArgs e)
        {
            if (ResultFromQuitDialog() == true)
                Close();
        }
        /// <summary>
        /// Exit event handler 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !ResultFromQuitDialog();
        }
        /// <summary>
        /// Method called from the event handler when exiting the program from the menu
        /// </summary>
        /// <returns></returns>
        private bool ResultFromQuitDialog()
        {
            bool quit = false;

            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to quit?", "Confirm"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                quit = true;
                Close();
            }
            return quit;
        }
        /// <summary>
        /// Event handler to show about box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }
        /// <summary>
        /// Event handler for listbox selected index change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxTaskList.SelectedIndex < 0)
            {
                MessageBox.Show("Please make a valid selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnStart.Enabled = true;
                btnPause.Enabled = true;
                btnComplete.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                int index = lbxTaskList.SelectedIndex;
                lblSelectedTaskName.Text = taskManager.GetTask(index).Description;
                lblSelectedTaskType.Text = taskManager.GetTask(index).TaskType.ToString();
                lblSelectedDate.Text = taskManager.GetTask(index).Date.ToString();
                lblSelectedAllocatedTime.Text = taskManager.GetTask(index).AllocatedTime.ToString();
                lblSelectedTimeSpent.Text = taskManager.GetTask(index).TimeSpent.ToString();
                lblSelectedTimeLeft.Text = taskManager.GetTask(index).TimeLeft.ToString();
            }
        }
        /// <summary>
        /// Timer tick controler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            int timeLeft = taskManager.GetTask(lbxTaskList.SelectedIndex).TimeLeft.ToSeconds();
            if (timeLeft == 0)
            {
                timer1.Stop();
                MessageBox.Show("Task " + taskManager.GetTask(lbxTaskList.SelectedIndex).Description +
                    " allocated time complete!", "Allocated time depleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taskManager.ChangeStatus("Completed", lbxTaskList.SelectedIndex);
                return;
            }
            else
            {
                lblSelectedTimeLeft.Text = taskManager.GetTimeLeft(lbxTaskList.SelectedIndex);//TimeLeft
                lblSelectedTimeSpent.Text = taskManager.GetTimeSpent(lbxTaskList.SelectedIndex);
            }
        }
        /// <summary>
        /// Event handler to show settings form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();

        }
        /// <summary>
        /// Method to check total time for each task type
        /// </summary>
        /// <param name="taskData"></param>
        /// <returns></returns>
        public bool CheckTasksTotalTime(TaskForm taskData)
        {
            bool isValid = false;
            int count = taskManager.Count;
            int personalTotalTime = 0;
            int workTotalTime = 0;
            int relaxTotalTime = 0;
            int index;

            for (index = 0; index < count; index++)
            {
                if (taskManager.GetTask(index).TaskType.ToString() == "Personal")
                {
                    int taskTimeInMin = taskManager.GetTask(index).AllocatedTime.ToSeconds() / 60;
                    personalTotalTime += taskTimeInMin;
                }
                else if (taskManager.GetTask(index).TaskType.ToString() == "Work")
                {
                    int taskTimeInMin = taskManager.GetTask(index).AllocatedTime.ToSeconds() / 60;
                    workTotalTime += taskTimeInMin;
                }
                else if (taskManager.GetTask(index).TaskType.ToString() == "Relax")
                {
                    int taskTimeInMin = taskManager.GetTask(index).AllocatedTime.ToSeconds() / 60;
                    relaxTotalTime += taskTimeInMin;
                }
            }
            if (personalTotalTime > settings.PersonalHours * 60)
            {

                MessageBox.Show("Time allocation for this task type exceeded, the allocated amount of time for this task type is " 
                    + settings.PersonalHours.ToString() + " hours. The task type's allocated time can be changed in settings."
                    , "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                taskManager.DeleteTask(index - 1);
                return isValid;
            }
            if (workTotalTime > settings.WorkHours * 60)
            {

                MessageBox.Show("Time allocation for this task type exceeded, the allocated amount of time for this task type is "
                    + settings.WorkHours.ToString() + " hours. The task type's allocated time can be changed in settings."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                taskManager.DeleteTask(index - 1);
                return isValid;
            }
            if (relaxTotalTime > settings.RelaxHours * 60)
            {

                MessageBox.Show("Time allocation for this task type exceeded, the allocated amount of time for this task type is "
                    + settings.RelaxHours.ToString() + " hours. The task type's allocated time can be changed in settings."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                taskManager.DeleteTask(index - 1);
                return isValid;
            }
            return isValid;
        }
        /// <summary>
        /// Method to update GUI
        /// </summary>
        private void UpdateGUI()
        {

            btnStart.Enabled = false;
            btnPause.Enabled = false;
            btnComplete.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }
        /// <summary>
        /// Method to uptade the tasklist shown in the listbox
        /// </summary>
        private void UpdateTaskList()
        {
            lbxTaskList.Items.Clear();

            string[] tasksArray = new string[taskManager.Count];
            List<string> tasks = new List<string>();
            tasks = taskManager.TaskListToString();

            for (int index = 0; index < taskManager.Count; index++)
            {
                tasksArray[index] = tasks[index];
            }

            lbxTaskList.Items.AddRange(tasksArray);
            lblHeadings.Text = GetToStringItemsHeadings();
        }
        /// <summary>
        /// Event handler for combo box selected index change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbxFilter.SelectedIndex)
            {
                case 0:
                    taskManager.FilterByTask();
                    break;
                case 1:
                    taskManager.FilterByDate();
                    break;
                case 2:
                    taskManager.FilterByStatus();
                    break;
                case 3:
                    taskManager.FilterByTaskType();
                    break;
                case 4:
                    taskManager.FilterByAllocatedTime();
                    break;
                case 5:
                    taskManager.FilterByTimeleft();
                    break;
                case 6:
                    taskManager.FilterByTimeSpent();
                    break;
            }
            UpdateTaskList();
        }
        /// <summary>
        /// Method to format heading 
        /// </summary>
        /// <returns>formatted string (strOut)</returns>
        public string GetToStringItemsHeadings()
        {
            string strOut = string.Format("{0, -21} {1, -9} {2, -10} {3, -10} {4, -9} {5}",
                "Date and Time", "Type", "Allocated", "Remaining", "Status", "Description");
            return strOut;
        }
    }
}
