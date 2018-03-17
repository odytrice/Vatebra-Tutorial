using System;
using System.Collections.Generic;
using System.Text;

namespace Testing.Lecture05
{
    class Person
    {
        public Person(string name, int height)
        {
            Name = name;
            Height = height;
        }

        public void PrintInformation()
        {
            Console.WriteLine($"My Name is {Name} and I am {Height} feet tall");
        }

        public string Name { get; set; }


        public int Height { get; set; }
    }
}
