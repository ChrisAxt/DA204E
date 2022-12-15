using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackerManager
{
    class TaskManager
    {
        private List<Task> taskList = new List<Task>();
        TimeManager timeMgr = new TimeManager();
        /// <summary>
        /// Default constructor with no parameters
        /// </summary>
        public TaskManager()
        { }
        /// <summary>
        /// Count property
        /// Both read and write function
        /// </summary>
        public int Count
        {
            get { return taskList.Count; }
        }
        /// <summary>
        /// Method to Get a specific task from the taskList
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Task GetTask(int index)
        {
            return taskList[index];
        }

        /// <summary>
        /// Method to add a task to the taskList
        /// One parameter
        /// </summary>
        /// <param name="task"></param>
        public void Add(Task newTask)
        {
            if (newTask != null)
            {
                //newTask.TimeLeft = newTask.AllocatedTime;
                taskList.Add(newTask);
            }
        }
        /// <summary>
        /// Method Change a specific task in the taskList
        /// Two parameters
        /// </summary>
        /// <param name="task"></param>
        public void Add(Task newTask, int index)
        {
            if (newTask != null)
            {
                taskList[index] = newTask;
            }
            taskList.Sort((x, y) => x.Date.CompareTo(y.Date));
        }
        public bool ChangeTask(Task taskInfo, int index)
        {
            taskList[index] = taskInfo;

            return true;
        }
        /// <summary>
        /// Method to delete a specific task from the taskList
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteTask(int index)
        {
            bool isValid = false;

            if (index < taskList.Count)
            {
                taskList.RemoveAt(index);
                isValid = true;
            }
            return isValid;
        }
        /// <summary>
        /// Method to delete all tasks in taskList
        /// </summary>
        /// <returns></returns>
        public bool DeleteAllTasks()
        {
            bool isValid = false;

            if (taskList.Count > 0)
            {
                taskList.Clear();
                isValid = true;
            }
            return isValid;
        }
        /// <summary>
        /// Method to get each task to string
        /// </summary>
        /// <returns></returns>
        public List<string> TaskListToString()
        {
            List<string> taskList = new List<string>();

            for (int index = 0; index < Count; index++)
            {
                if (this.taskList[index] != null)
                {
                    taskList.Add(this.taskList[index].ToString());
                }
            }
            return taskList;
        }
        /// <summary>
        /// Method To get the remaining time of a task
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Remaining task time</returns>
        public string GetTimeLeft(int index)
        {
            return timeMgr.Timer(GetTask(index));
        }
        /// <summary>
        /// Method to get the Time spent on a task
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Time spent on task</returns>
        public string GetTimeSpent(int index)
        {
            return GetTask(index).TimeSpent.ToString();
        }
        /// <summary>
        /// Method to change status of task
        /// </summary>
        /// <param name="status"></param>
        /// <param name="index"></param>
        /// <returns>Status of task</returns>
        public string ChangeStatus(string status, int index)
        {
            GetTask(index).Status = status;
            return status;
        }
        /// <summary>
        /// Method for filtering by task
        /// </summary>
        public void FilterByTask()
        {
            taskList = taskList.OrderBy(Task => Task.Description).ToList();
        }
        /// <summary>
        /// Method for filtering by date
        /// </summary>
        public void FilterByDate()
        {
            taskList = taskList.OrderBy(Task => Task.Date).ToList();
        }
        /// <summary>
        /// Method for filtering by status
        /// </summary>
        public void FilterByStatus()
        {
            taskList = taskList.OrderBy(Task => (Task.Status)).ToList();
        }
        /// <summary>
        /// Method for filtering by task type
        /// </summary>
        public void FilterByTaskType()
        {
            taskList = taskList.OrderBy(Task => (int) (Task.TaskType)).ToList();
        }
        /// <summary>
        /// Method for filtering by allocated time
        /// </summary>
        public void FilterByAllocatedTime()
        {
            taskList = taskList.OrderBy(Task => (int) Task.AllocatedTime.ToSeconds()).ToList();
        }
        /// <summary>
        /// /// <summary>
        /// Method for filtering by time left
        /// </summary>
        /// </summary>
        public void FilterByTimeleft()
        {
            taskList = taskList.OrderBy(Task => (int) Task.TimeLeft.ToSeconds()).ToList();
        }
        /// <summary>
        /// /// <summary>
        /// Method for filtering by time spent
        /// </summary>
        /// </summary>
        public void FilterByTimeSpent()
        {
            taskList = taskList.OrderBy(Task => (int) Task.TimeSpent.ToSeconds()).ToList();
        }
    }
}
