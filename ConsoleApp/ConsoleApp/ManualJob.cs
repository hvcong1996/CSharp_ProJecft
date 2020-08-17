using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public abstract class ManualJob: AbstractJob
    {
        public ManualJob()
        {

        }

        public override String GetJobName()
        {
            return "GetJobName ManualJob";
        }
    }
}
