using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class BuildHouse: ManualJob
    {
        public BuildHouse()
        {

        }

        public override void DoJob()
        {
            Console.WriteLine("DoJob BuildHouse");
        }
    }
}
