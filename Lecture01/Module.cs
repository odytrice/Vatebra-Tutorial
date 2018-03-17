using System;
using System.Collections.Generic;
using System.Text;

namespace Testing.Lecture01
{
    class Module
    {
        public static void Run()
        {
            //Get the Number
            Console.Write("Enter the First Number: ");
            string inputText = Console.ReadLine();
            int number = int.Parse(inputText);


            /*
             * Solution 1: if the number is 0..10 then it should say if it is odd or even.
             * Any other thing should say invalid
             */

            switch (number)
            {
                case 0: Console.WriteLine("Even"); break;
                case 1: Console.WriteLine("Odd"); break;
                case 2: Console.WriteLine("Even"); break;
                case 3: Console.WriteLine("Odd"); break;
                case 4: Console.WriteLine("Even"); break;
                case 5: Console.WriteLine("Odd"); break;
                case 6: Console.WriteLine("Even"); break;
                case 7: Console.WriteLine("Odd"); break;
                case 8: Console.WriteLine("Even"); break;
                case 9: Console.WriteLine("Odd"); break;
                case 10: Console.WriteLine("Even"); break;
                default: Console.WriteLine("Invalid Number"); break;
            }

            switch (number)
            {
                case 0:
                case 2:
                case 4:
                case 6:
                case 8:
                case 10: Console.WriteLine("Even"); break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 9: Console.WriteLine("Odd"); break;

                default: Console.WriteLine("Invalid Number"); break;
            }

            /*
             * Solution 2: if the number is < 0 or > 10 then it should say invalid.
             * Any other thing should say if it is odd or even
             */

            if (number < 0)
            {
                Console.WriteLine("Invalid Number");
            }
            else if (number > 10)
            {
                Console.WriteLine("Invalid Number");
            }
            else
            {
                //This means that number is between 0 and 10
                switch (number)
                {
                    case 0:
                    case 2:
                    case 4:
                    case 6:
                    case 8:
                    case 10: Console.WriteLine("Even"); break;
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 9: Console.WriteLine("Odd"); break;
                }
            }

            /*
             * Solution 3: if the number is < 0 or > 10 then it should say invalid.
             * if the remainder of dividing the number by 2 is 0 then it should say even
             * otherwise it should say odd
             */

            if (number < 0)
            {
                Console.WriteLine("Invalid Number");
            }
            else if (number > 10)
            {
                Console.WriteLine("Invalid Number");
            }
            else
            {
                //This means that number is between 0 and 10
                if (number % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }

            //Using Combinations
            if (number < 0 || number > 10)
            {
                Console.WriteLine("Invalid Number");
            }
            else
            {
                //This means that number is between 0 and 10
                if (number % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }


            if (number >= 0 && number <= 10)
            {
                //This means that number is between 0 and 10
                if (number % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }
    }
}
