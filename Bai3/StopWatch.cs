using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Bai3
{
    class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public StopWatch()
        {

        }
        public StopWatch(DateTime startTime, DateTime endTime)
            {
            this.StartTime = startTime;
            this.endTime = endTime;
            }
        public void GetStartTime()
        {
            DateTime startTime = DateTime.Now;
            Console.WriteLine(" StartTime is :" + startTime);
        }
        public void ResetStartTime()
        {
            DateTime startTime = DateTime.Now;
        }
        public void Stop()
        {
            DateTime endTime = DateTime.Now;
            Console.WriteLine(" EndTime is :" + endTime);

        }
        public void GetElapsedTime()
        {
            TimeSpan elapsedTime = endTime.Subtract(StartTime);
            Console.WriteLine($"interval from start to end {elapsedTime}");

        }
    }
}
