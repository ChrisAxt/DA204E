using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackerManager
{
    public class Time
    {
        int hour;
        int min;
        int sec;
        /// <summary>
        /// Constructor with no parameters
        /// </summary>
        public Time()
        {
            hour = 0;
            min = 0;
            sec = 0;
        }
        /// <summary>
        /// Constructor with two parameters
        /// </summary>
        /// <param name="hour"></param>
        /// <param name="min"></param>
        public Time(int hour, int min) 
        {
            this.hour = hour;
            this.min = min;
            sec = 0;
        }
        /// <summary>
        /// Hour property
        /// Both read and write function
        /// </summary>
        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }
        /// <summary>
        /// Min property
        /// Both read and write function
        /// </summary>
        public int Min
        {
            get { return min; }
            set { min = value; }
        }
        /// <summary>
        /// Sec property
        /// Both read and write function
        /// </summary>
        public int Sec
        {
            get { return sec; }
            set { sec = value; }
        }
        /// <summary>
        /// Method to convert hours to seconds
        /// </summary>
        /// <returns></returns>
        public int ToSeconds()
        {
            return hour * 3600 + min * 60 + sec;
        }
        /// <summary>
        /// Method to Convert seconds into hours, min and sec
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Time ToTime(int input)
        {
            min = input / 60;
            sec = input % 60;
            hour = min / 60;
            min = min % 60;

            return this;
        }
        /// <summary>
        /// Override string method
        /// </summary>
        /// <returns>Formatted time string</returns>
        public override string ToString()
        {
            return (string.Format("{0}:{1}:{2}", hour.ToString("D2"), min.ToString("D2"), sec.ToString("D2")));
        }
    }
}
