using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Loops
    { 
        public void loop()
        {
            Console.WriteLine("Display name 10 times");
            string name = "Akhila";
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(name);
            }
        }
    }
}
