using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class CSharpCoding: AbstractJob
    {
        public CSharpCoding()
        {

        }

        public override void DoJob()
        {
            Console.WriteLine("DoJob CSharp");
        }

        public override String GetJobName()
        {
            return "GetJobName CSharp";
        }

        public void RunningExample()
        {
            Console.WriteLine("RunningExample");
        }
    }
}
