using System;
using System.Collections.Generic;
using System.Text;

namespace Testing.Lecture03
{
    class Module
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
