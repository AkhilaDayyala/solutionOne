using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Operations
    {
        public void operates()
        {
            Console.WriteLine("Arithmetic Operators");
            int x = 10;
            int y = 5;
            Console.WriteLine($"Sum of {x} and {y} is {x + y}");
            Console.WriteLine($"Substraction of {x}and {y} is {x - y}");
            Console.WriteLine($"product of {x} and {y} is {x * y}");
            Console.WriteLine($"remainder of {x} and {y} is {x % y}");
        }
    }
}
