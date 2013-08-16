/*Title:            Countdown.cs
 *Purpose:          Input an integer.  Display all integers in a countdown to zero.
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
    class Countdown
    {
        public static void RunCountdown(int number)
        {
            for (int num = number; num >= 0; num--)
            {
                Console.WriteLine(num);
            }
        }
    }
}
