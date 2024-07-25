using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class LoopsDemo
    {
        public void loop()
        {
           
         
            Console.WriteLine("Display Table");
            Console.WriteLine("enter number");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            int i = 1;
                while (i <= 10)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}");
                    i++;
                }

           
            Console.WriteLine("Display 100 to 5 with gap of 3");
            for(int k = 100; k >= 5; k -= 3)
            {
                Console.WriteLine(k);
            }

            int a = 10;
            int b = 20;
            int c = 30;
            int d = 40;
            Console.WriteLine("Display values in one line");
            Console.WriteLine($"a:{a} b:{b} c:{c} d:{d}");
            Console.WriteLine("Display values in separate line");
            Console.WriteLine($"a:{a}");
            Console.WriteLine($"b:{b}");
            Console.WriteLine($"c:{c}");
            Console.WriteLine($"d:{d}");
        }
    }
}
