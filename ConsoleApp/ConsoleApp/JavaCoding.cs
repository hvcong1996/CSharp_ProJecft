using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class JavaCoding: AbstractJob
    {
        public JavaCoding()
        {

        }

        public override void DoJob()
        {
            Console.WriteLine("DoJob Java");
        }

        public override String GetJobName()
        {
            return "GetJobName Java";
        }

        public void TestExample()
        {
            Console.WriteLine("Testing");
        }
    }
}
