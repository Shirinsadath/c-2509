using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment_7
{
    public class Process
    {
        public delegate void EventHandler(object sender, EventArgs e);
        public event EventHandler OnCompleted;
        //Method to start the process
        public void StarttheProcess()
        {
            Console.WriteLine("Process completed !!!");
            System.Threading.Thread.Sleep(3000);
            ProcessCompleted();
        }
        //method to start an event
        protected virtual void ProcessCompleted()
        {
            if (OnCompleted != null)
            {
                OnCompleted(this, EventArgs.Empty);
            }
        }
    }
}
