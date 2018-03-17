using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vatebra.Testing
{
    public class Program4
    {
        public static void Run()
        {
            // 1! = 1
            // 2! = 2 * 1!
            // 3! = 3 * 2!
            // 4! = 4 * 3!
            // 5! = 5 * 4!
            // 6! = 6 * 5!
            // n! = n * (n -1)!

            var n = 11454326;
            var result = Factorial(n);
            Console.WriteLine($"{n}! = {result}");
        }

        public static int Factorial(int n)
        {
            if(n <= 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        public static int FactorialByLoop(int n)
        {
            //What to do?
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }

        public void Methods()
        {
            var result = Operation(2, 2);

            var result2 = Operation(3, 5);

            var result3 = Operation(2, 7);

            var final = Operation(result2, result3);

            Console.WriteLine(final);
        }

        public static int Operation(int x, int y)
        {
            var sum = x * y;
            Console.WriteLine($"{x} * {y} = {sum}");
            return sum;
        }
    }
}
