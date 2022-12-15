using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TimeTrackerManager
{
    
    class TimeManager
    {
        /// <summary>
        /// Method to control the timer and ensure values are changed
        /// </summary>
        /// <param name="selectedTask"></param>
        /// <returns>tasks time left</returns>
        public string Timer(Task selectedTask)
        {
            int timeSpent = selectedTask.TimeSpent.ToSeconds();
            timeSpent++;
            selectedTask.TimeSpent = selectedTask.TimeSpent.ToTime(timeSpent);

            int secondsLeft = selectedTask.TimeLeft.ToSeconds();
            secondsLeft --;
            selectedTask.TimeLeft = selectedTask.TimeLeft.ToTime(secondsLeft);

            return selectedTask.TimeLeft.ToString();
        }
        /// <summary>
        /// Method to calculate and format time
        /// </summary>
        /// <param name="input"></param>
        /// <returns>calculated and formatted time string</returns>
        public string CalculateSecToHrMinSec(int input)
        {
            int min = input / 60;
            int sec = input % 60;
            int hour = min / 60;
            min = min % 60;

            string strOut = string.Format("{0}:{1}:{2}", hour, min, sec);

            return strOut;
        }

    }
}
