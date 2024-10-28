using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment_1
{
    public class Time
    {
        private int hours;
        private int minutes;
        private int seconds;
        public void DisplayTime(int Hours, int Minutes)
        {
            this.hours = Hours + Minutes / 60;

            this.minutes = Minutes % 60;
            Console.WriteLine($"{this.hours} : {this.minutes}");
        }
        public void DisplayTime(int Seconds)
        {
            this.hours = Seconds / 3600;
            Seconds %= 3600;
            this.minutes = Seconds / 60;
            this.seconds = Seconds % 60;
            Console.WriteLine($"{this.hours}:{this.minutes}:{this.seconds}");
        }
    }
}
