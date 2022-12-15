using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTrackerManager
{
    public partial class TaskForm : Form
    {
        private Task newTask = new Task();
        /// <summary>
        /// Constructor with one parameter
        /// </summary>
        /// <param name="heading"></param>
        public TaskForm(string heading)
        {
            InitializeComponent();
            InitializeGUI();
        }
        /// <summary>
        /// TaskData property with read and write function
        /// </summary>
        public Task TaskData
        {
            get { return newTask; }
            set { newTask = value; }
        }
        /// <summary>
        /// Method to initialize GUI
        /// </summary>
        private void InitializeGUI()
        {
            this.Text = "Add new task";
            txtTaskDescription.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            cbxTaskType.DataSource = Enum.GetNames(typeof(TaskType));
            cbxTaskType.SelectedIndex = -1;
            txtHour.Text = string.Empty;
            txtMin.Text = string.Empty;   
        }
        /// <summary>
        /// Event handler for add 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ReadInput())
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        /// <summary>
        /// Method to read user input
        /// </summary>
        /// <returns>bool isValid</returns>
        public bool ReadInput()
        {
            bool isvalid = false;

            newTask.Description = ReadDescription();
            newTask.Date = dateTimePicker1.Value;
            newTask.TaskType = CheckTaskType();
            if (newTask.Description == null || newTask.TaskType < 0)
            {
                return isvalid;
            }

            newTask.AllocatedTime = ReadTime();
            if (newTask.AllocatedTime != null)
            {
                newTask.TimeLeft.Hour = newTask.AllocatedTime.Hour;
                newTask.TimeLeft.Min = newTask.AllocatedTime.Min;
                isvalid = true;
            }
            return isvalid;
        }
        /// <summary>
        /// Method to check task type with error control
        /// </summary>
        /// <returns></returns>
        private TaskType CheckTaskType()
        {

            if (cbxTaskType.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a task type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return (TaskType)cbxTaskType.SelectedIndex;
        }
        /// <summary>
        /// Method to read description with error control
        /// </summary>
        /// <returns></returns>
        private string ReadDescription()
        {
            if (string.IsNullOrEmpty(txtTaskDescription.Text))
            {
                MessageBox.Show("Please enter a task description!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return txtTaskDescription.Text;
        }
        /// <summary>
        /// Method to read time with error control
        /// </summary>
        /// <returns></returns>
        private Time ReadTime()
        {
            int hour = 0;
            int min = 0;
            Time time = null;

            if (string.IsNullOrEmpty(txtHour.Text))
            {
                txtHour.Text = "0"; 
            }

            if (string.IsNullOrEmpty(txtMin.Text))
            {
                txtMin.Text = "0";
            }

            if (!int.TryParse(txtHour.Text,out hour))
            {
                MessageBox.Show("Please enter a valid hour!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else if (!int.TryParse(txtMin.Text, out min))
            {
                MessageBox.Show("Please enter a valid min!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else if (min == 0 && hour == 0)
            {
                MessageBox.Show("Please allocate time to this task!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else 
            {
                if (min < 0 || min > 59)
                {
                    MessageBox.Show("Please enter a number between 0 and 59 for min!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else if (hour > 24)
                {
                    MessageBox.Show("Please enter a number between 0 and 24 for hour!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    time = new Time(hour, min);
                }
            }
            return time;
        }
        /// <summary>
        /// Method to displat selected task when editing task
        /// </summary>
        public void DispaySelectedTask()
        {
            txtTaskDescription.Text = newTask.Description;
            dateTimePicker1.Value = newTask.Date;
            cbxTaskType.Text = newTask.TaskType.ToString();
            txtHour.Text = newTask.AllocatedTime.Hour.ToString();
            txtMin.Text = newTask.AllocatedTime.Min.ToString();
        }

        
    }
}
