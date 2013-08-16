/*Title:            FizzBuzz.cs
 *Purpose:          Displays numbers 1-100.  Integers divisble by 3 are displayed as "Fizz".
 *                  Integers divisible by 5 are displayed as "Buzz".  
 *                  Integers divisible by 3 AND 5 as displayed as "FizzBuzz".
 *Author:           Juan Trinidad Jr
 *Date Created:     8/15/2013
 *Last Modified:    8/15/2013
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class FizzBuzz
    {
        public static void RunFizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) { Console.WriteLine("FizzBuzz (" + i + ")"); }
                else if (i % 3 == 0) { Console.WriteLine("Fizz (" + i + ")"); }
                else if (i % 5 == 0) { Console.WriteLine("Buzz (" + i + ")"); }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
