using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class EvenDemo
    {
        public void even()
        {
            Console.WriteLine("Display all even numbers");
            Console.WriteLine("by using for loop");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
            Console.WriteLine("By using while loop");
            int k = 0;

            while (k <= 10)
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine(k);
                }
                k++;
            }

            Console.WriteLine("by using do-while loop");
            int j = 1;
            do
            {
                if (j % 2 == 0) Console.WriteLine(j);
                j++;
            } while (j <= 10);

        }
    }
}