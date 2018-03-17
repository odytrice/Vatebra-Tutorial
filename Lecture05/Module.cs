using System;
using System.Collections.Generic;
using System.Text;

namespace Testing.Lecture05
{
    public class Module
    {
        public static void Run()
        {
            Person ody = new Person("Okwudili Mbegbu",6);

            Person constance = new Person("Constance Okosodo", 6);

            Person[] people = new[] { ody, constance };

            foreach(var person in people)
            {
                Console.WriteLine($"Processing: {person.Name}");
                person.Height = person.Height * 2;
                person.PrintInformation();
            }
        }
    }
}