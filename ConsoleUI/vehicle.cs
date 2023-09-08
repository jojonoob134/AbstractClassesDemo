using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public string Year { get; set; } = "2020";
        public string Make { get; set; } = "insert funny make";

        public string Model { get; set; } = "beg boy";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            
        }

    }
}
