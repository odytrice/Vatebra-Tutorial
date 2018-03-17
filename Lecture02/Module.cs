using System;
using System.Collections.Generic;
using System.Text;

namespace Testing.Lecture02
{
    class Module
    {
        public static void Run()
        {
            int x = 0;
            while (x <= 10)
            {
                Console.WriteLine(x);
                x = x + 1;
            }

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(j);
            }
        }
    }
}
