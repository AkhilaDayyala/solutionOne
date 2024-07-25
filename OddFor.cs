using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class OddFor
    { 
        public void odd()
        {
            Console.WriteLine("Display all odd numbers");
            Console.WriteLine("by using for loop");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }
            Console.WriteLine("by using while loop");
            int j = 0;
           
            while (j < 10)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }
            Console.WriteLine("by using do-while loop");
            int k = 0;
            do
            {
                if (k % 2 != 0){
                    Console.WriteLine(k);


                }
                k++;

            } while (k <= 10);


        }
    }
}
