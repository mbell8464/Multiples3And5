using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3And5
{
    class Program
    {
        static void Main(string[] args)
        {

            //**********Coding Challenge 1******************
            //     Find the sum of all multiples of 3 or 5 below 1000



            //int sumOfMultiples = 0;
            //do
            //{
            //    if (Multiple == )
            //} while (true);


            //multiple means that it is evenly divisable by a certain number.. (3 or 5).
            //if a number is evenly divisable, that means there is no remainder, so I need to check the remainder.aka %

            int sum = 0;
            int i = 1;
            while (i < 1000)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                    i++; //if you leave this out, it doesn't hit the else therefore never increase the number, resulting in an infinte loop
                }
                else
                {
                    i++;
                }
                Console.WriteLine(sum);
            }


            int sumOfMultiples = 0;
            //counter; condition; update (this is saying x starts at one and keeps running until it gets to 999... or <1000, and the update adds 1 number each time it runs the through the code)
            for (int x = 1; x < 1000; x++)
            {
                if (x % 3 == 0 || x % 5 == 0)
                {
                    sumOfMultiples += x;
                }
                Console.WriteLine(sumOfMultiples);
            }


        }
    }
}
