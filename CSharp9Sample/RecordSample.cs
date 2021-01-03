﻿using System;

namespace CSharp9Sample
{
    internal class RecordSample
    {
        record RecordPerson
        {
            public string Name { get; init; }

            public int Age { get; init; }
        }

        record RecordPerson2(string Name, int Age);

        public static void MainTest()
        {
            var p1 = new RecordPerson()
            {
                Name = "Tom",
                Age = 12,
            };
            Console.WriteLine(p1);

            var p2 = p1 with { Age = 10 };
            Console.WriteLine(p2);

            var p3 = new RecordPerson() { Name = "Tom", Age = 12 };
            Console.WriteLine(p3);
            Console.WriteLine($"p1 Equals p3 =:{p1 == p3}");

            RecordPerson2 p4 = new("Tom", 12);
            Console.WriteLine(p4);
        }
    }
}
