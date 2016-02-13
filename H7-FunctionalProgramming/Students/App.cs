namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class App
    {
        internal static void Main()
        {
            var studentsList = new List<Student>();

            // P1 - Populating the list with fake data using Faker.NET
            for (int i = 0; i < 50; i++)
            {
                studentsList.Add(new Student(
                    Faker.Name.First(),
                    Faker.Name.Last(),
                    Faker.RandomNumber.Next(15, 63),
                    Faker.Phone.Number(),
                    Faker.Internet.Email(),
                    Faker.RandomNumber.Next(222222222, 888888888),
                    Faker.RandomNumber.Next(1, 3),
                    new List<int>
                    {
                        Faker.RandomNumber.Next(2,6),
                        Faker.RandomNumber.Next(2,6),
                        Faker.RandomNumber.Next(2,6),
                        Faker.RandomNumber.Next(2,6),
                        Faker.RandomNumber.Next(2,6),
                        Faker.RandomNumber.Next(2,6)
                    }));
            }

            // P2 - Students by Group
            studentsList
                .Where(st => st.GroupNumber == 2)
                .OrderBy(st => st.FirstName)
                .ToList()
                .ForEach(Console.WriteLine);

            Utility.DrawSeparator();

            // P3 - Students by First and Last Name
            studentsList
                .Where(st => st.FirstName.CompareTo(st.LastName) == -1)
                .ToList()
                .ForEach(Console.WriteLine);

            Utility.DrawSeparator();

            // P4 - Students by Age
            studentsList
                .Where(st => st.Age >= 18 && st.Age <= 24)
                .ToList()
                .ForEach(st => Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\n", st.FirstName, st.LastName, st.Age));

            // P4 - Students by Age (Variant)
            var studentsByAge =
                from st in studentsList
                where st.Age >= 18 && st.Age <= 24
                select st;

            Utility.DrawSeparator();

            // P5 - Sort Students
            studentsList
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName)
                .ToList()
                .ForEach(Console.WriteLine);

            // P5 - Sort Students (Variant)
            var sortedStudents =
                from st in studentsList
                orderby st.FirstName descending, st.LastName descending
                select st;

            Utility.DrawSeparator();

            // P6 - Filter students by Email Domain
            // adding some students with abv.bg email domain
            studentsList.Add(new Student(
                    Faker.Name.First(),
                    Faker.Name.Last(),
                    Faker.RandomNumber.Next(15, 63),
                    Faker.Phone.Number(),
                    "dominator@abv.bg",
                    Faker.RandomNumber.Next(222222222, 888888888),
                    Faker.RandomNumber.Next(1, 3),
                    new List<int>
                    {
                        Faker.RandomNumber.Next(2,6),
                        Faker.RandomNumber.Next(2,6),
                        Faker.RandomNumber.Next(2,6),
                        Faker.RandomNumber.Next(2,6),
                        Faker.RandomNumber.Next(2,6),
                        Faker.RandomNumber.Next(2,6)
                    }));

            studentsList.Add(new Student(
                    Faker.Name.First(),
                    Faker.Name.Last(),
                    Faker.RandomNumber.Next(15, 63),
                    Faker.Phone.Number(),
                    "judaspriest@abv.bg",
                    Faker.RandomNumber.Next(222222222, 888888888),
                    Faker.RandomNumber.Next(1, 3),
                    new List<int>
                    {
                        Faker.RandomNumber.Next(2,6),
                        Faker.RandomNumber.Next(2,6),
                        Faker.RandomNumber.Next(2,6),
                        Faker.RandomNumber.Next(2,6),
                        Faker.RandomNumber.Next(2,6),
                        Faker.RandomNumber.Next(2,6)
                    }));

            // shuffling the list
            studentsList = studentsList.OrderBy(a => Guid.NewGuid()).ToList();

            // printing the students with abv.bg email domain
            studentsList
                .Where(st => st.Email.EndsWith("@abv.bg"))
                .ToList()
                .ForEach(Console.WriteLine);

            Utility.DrawSeparator();
        }
    }
}