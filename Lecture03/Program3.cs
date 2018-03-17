using System;
using System.Collections.Generic;
using System.Text;

namespace Testing.Lecture03
{
    class Program3
    {
        public static void Run()
        {
            int[] array = new[] { 1, 3 };
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
