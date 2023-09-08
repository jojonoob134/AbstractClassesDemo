using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public string HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            
        }
        public override void DriveVirtual()
        {
            base.DriveVirtual();
            Console.WriteLine("this baby can drive");
        }
    }
}
