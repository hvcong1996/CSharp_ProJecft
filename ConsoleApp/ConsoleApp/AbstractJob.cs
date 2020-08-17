using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public abstract class AbstractJob
    {
        public AbstractJob()
        {

        }

        public abstract String GetJobName();

        public abstract void DoJob();

        public void StopJob()
        {
            Console.WriteLine("Stop Job");
        }
    }
}
