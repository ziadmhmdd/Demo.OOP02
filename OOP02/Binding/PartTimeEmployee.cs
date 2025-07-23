using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.Binding
{
    internal class PartTimeEmployee : Employee
    {
     
        public double Hourrate { get; set; }
        public int NumberOfHour { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("I am PartTimeEmployee");
        }

        public override void Fun02()
        {
            Console.WriteLine($"Salary: {Hourrate * NumberOfHour}");
        }


    }
}
