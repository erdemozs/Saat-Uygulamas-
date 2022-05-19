using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClockProject
{
    internal class ClockHand
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public ClockHand()
        {
            this.Name = "Belirsiz";
            this.Value = 0;
        }

        public ClockHand(string name, int value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
