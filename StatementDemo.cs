using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class StatementDemo
    {
        public void statement()
        {
            int x=20; int y = 10;
            Console.WriteLine("by using else if  statement");
            int ch;
            Console.WriteLine("enter the value of ch");
            ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
                Console.WriteLine($"Sum of {x} and {y} is {x + y}");
            else if (ch == 2)
                Console.WriteLine($"Substraction of {x}and {y} is {x - y}");
            else if (ch == 3)
                Console.WriteLine($"product of {x} and {y} is {x * y}");
            else if (ch == 4)
                Console.WriteLine($"remainder of {x} and {y} is {x % y}");
            else
                Console.WriteLine("you entered Invalid number");

            Console.WriteLine("by using switch statement");
            Console.WriteLine("enter the value of z");
            int z;
            z = Convert.ToInt32(Console.ReadLine());
            switch (z)
            {
                case 1:
                    Console.WriteLine($"Sum of {{x}} and {{y}} is {{x + y}}");
                    break;
                case 2:
                    Console.WriteLine($"Substraction of {x}and {y} is {x - y}");
                    break;
                case 3:
                    Console.WriteLine($"product of {x} and {y} is {x * y}");
                    break;
                case 4:
                    Console.WriteLine($"remainder of {x} and {y} is {x % y}");
                    break;
                default:
                    Console.WriteLine("please enter in between 1-4 ");
                    break;
            }

        }
    }
}
