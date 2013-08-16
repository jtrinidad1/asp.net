/*Title:            Reverse.cs
 *Purpose:          Input a string.  Reverse the input string.
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
    class Reverse
    {
        public static void RunReverse(string input)
        {
            Console.WriteLine("Result: " + new string(input.ToArray().Reverse().ToArray()));
        }

        public static void RunReverseSentence(string input)
        {
            string[] sentence = input.Split(' ').ToArray().Reverse().ToArray();
            Console.Write("Result: ");
            foreach (string word in sentence)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }
    }
}
