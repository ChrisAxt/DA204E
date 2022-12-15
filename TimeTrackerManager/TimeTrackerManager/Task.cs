using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackerManager
{
    public class Task
    {
        private string description;
        private DateTime date;
        private TaskType taskType;
        private Time allocatedTime = new Time();
        private Time timeSpent = new Time();
        private Time timeLeft = new Time();
        private string status;
        /// <summary>
        /// Constructor with no paramenters
        /// </summary>
        public Task()
        {}
        /// <summary>
        /// Constructor with four parameters
        /// </summary>
        /// <param name="description"></param>
        /// <param name="date"></param>
        /// <param name="taskType"></param>
        /// <param name="allocatedTime"></param>
        public Task(string description, DateTime date, TaskType taskType, Time allocatedTime)
        {}
        /// <summary>
        /// Description property
        /// Both read and write function
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        /// <summary>
        /// Date property
        /// Both read and write function
        /// </summary>
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        /// <summary>
        /// Task type property
        /// Both read and write function
        /// </summary>
        public TaskType TaskType
        {
            get { return taskType; }
            set { taskType = value; }
        }
        /// <summary>
        /// Allocated time property
        /// Both read and write function
        /// </summary>
        public Time AllocatedTime
        {
            get { return allocatedTime; }
            set { allocatedTime = value; }
        }
        /// <summary>
        /// Time spent property
        /// Both read and write function
        /// </summary>
        public Time TimeSpent
        {
            get { return timeSpent; }
            set { timeSpent = value; }
        }
        /// <summary>
        /// Time left property
        /// Both read and write function
        /// </summary>
        public Time TimeLeft
        {
            get { return timeLeft; }
            set { timeLeft = value; }
        }
        /// <summary>
        /// Status property
        /// Both read and write function
        /// </summary>
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        /// <summary>
        /// Override sting method
        /// </summary>
        /// <returns>formatted task string</returns>
        public override string ToString()
        {
            string totalTime = allocatedTime.ToString();
            string timeremaining = timeLeft.ToString();
            string strOut = string.Format("{0, -21} {1, -9} {2, -10} {3, -10} {4, -9} {5}", date, taskType, totalTime, timeremaining, status, description);

            return strOut;
        }
    }
}
