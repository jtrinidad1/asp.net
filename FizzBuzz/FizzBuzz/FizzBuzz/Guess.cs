/*Title:            Guess.cs
 *Purpose:          Number Guessing Game.  Generates a random non-negative integer and prompts the user to input an integer.
 *                  Responses returned if user input is too high, too low, or close.
 *                  Idea came from final exam project in "Intro to C++" class in 2007.
 *Author:           Juan Trinidad Jr
 *Date Created:     8/16/2013
 *Last Modified:    8/16/2013
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class Guess
    {
        public static void RunGuess()
        {
            int input;
            int gen;

            Random e = new Random();
            gen = e.Next(100);
            Ask();
            input = GetInput();

            while (input != gen)
            {
                if (input == -1)
                {
                    Program.WrongAnswer();
                    Console.Write("Try again: ");
                    input = GetInput();
                }
                else if (input == gen - 1 || input == gen - 2 || input == gen - 3)
                {
                    Console.Write("You're too low, but you're close! Try again: ");
                    input = GetInput();
                }
                else if (input == gen + 1 || input == gen + 2 || input == gen + 3)
                {
                    Console.Write("You're too high, but you're close! Try again: ");
                    input = GetInput();
                }
                else if (input > gen)
                {
                    Console.Write("You're too high.  Try again: ");
                    input = GetInput();
                }
                else if (input < gen)
                {
                    Console.Write("You're too low.  Try again: ");
                    input = GetInput();
                }
            }
            Console.Write("My number was " + gen + ".  Your guess was correct!\n");
        }

        protected static void Ask()
        {
            Console.Write("Try to guess my number!\nI'll tell you if you are too high, too low, or very close!\nEnter an integer between 0 and 100: ");
        }

        protected static int GetInput()
        {
            try
            {
                int input1 = Convert.ToInt32(Console.ReadLine());
                return input1;
            }
            catch 
            {
                return -1;
            }
        }
    }
}