/*Title:            Program.cs
 *Purpose:          Parent class for FizzBuzz console application.
 *                  Users are promted to enter a number to start the correspoinding application.
 *                  Application ideas come from here: http://blog.craigtp.co.uk/post/Alternative-FizzBuzz-style-Interview-Questions.aspx
 *Author:           Juan Trinidad Jr
 *Date Created:     8/15/2013
 *Last Modified:    8/16/2013
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            string entry = "";
            //string a;
            Console.WriteLine("\nWhich program would you like to run?\nType the number to the corresponding program, then press \"Enter\".\nType \"exit\" to exit the application.\n");
            Console.WriteLine("1. FizzBuzz - Displays numbers 1-100.  Kind of.\n");
            Console.WriteLine("2. Reverse - Input a string.  Reverse the input string - by letter.\n");
            Console.WriteLine("3. Reverse Sentence - Input a string.  Reverse the input string - by word.\n");
            Console.WriteLine("4. Countdown - Input an integer.  Countdown to 0.\n");
            Console.WriteLine("5. Guess - Generates a random non-negative integer.  You have to guess it.\n");
            Console.Write("Option: ");
            entry = Console.ReadLine();
            switch (entry)
            {
                case "1":
                    FizzBuzz.RunFizzBuzz();
                    Main();
                    break;
                case "2":
                    Console.Write("Enter a string: ");
                    entry = Console.ReadLine();
                    Reverse.RunReverse(entry);
                    Main();
                    break;
                case "3":
                    Console.Write("Enter a string: ");
                    entry = Console.ReadLine();
                    Reverse.RunReverseSentence(entry);
                    Main();
                    break;
                case "4":
                    Console.Write("Enter an integer: ");
                    entry = Console.ReadLine();
                    try 
                    { 
                        int num = Convert.ToInt32(entry);
                        Countdown.RunCountdown(num);
                        Main();
                    }
                    catch 
                    { 
                        WrongAnswer();
                        goto case "4";
                    }
                    break;
                case "exit":
                    break;
                case "5":
                    Guess.RunGuess();
                    Main();
                    break;
                default:
                    WrongAnswer();
                    Main();
                    break;
            }
        }

        public static void WrongAnswer()
        {
            Console.WriteLine("Please enter a valid response.\n");
        }
    }
}
