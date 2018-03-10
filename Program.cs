using System;
using System.Linq;

namespace Vatebra.Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 10, 15, 27, 33 };

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            foreach(int item in Enumerable.Range(1, 50))
            {
                Console.WriteLine(item);
            }
        }
    }
}
