using System;
using System.Collections.Generic;
using System.Text;

namespace Testing.Lecture03
{
    public class GuessingGame
    {
        public static void Run()
        {
            var number = GuessNumber();

            Console.WriteLine("Enter a Number between 1 and 20");
            Console.WriteLine("You have three tries");

            bool hasWon = false;

            for(int i = 1; i <= 3; i++)
            {
                int guess = int.Parse(Console.ReadLine());

                if (number > guess)
                {
                    Console.WriteLine($"The number is greater than {guess}");
                }
                else if (number < guess)
                {
                    Console.WriteLine($"The number is less than {guess}");
                }
                else
                {
                    hasWon = true;
                    break;
                }
            }

            if (hasWon)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lost!");
            }
            
        }

        static int GuessNumber()
        {
            var random = new Random();

            var guess = random.Next(1, 20);

            return guess;
        }
    }
}
