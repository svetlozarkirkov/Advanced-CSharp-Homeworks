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
                    Faker.RandomNumber.Next(222222, 888888),
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

            // P3 - Students by First and Last Name
            studentsList
                .Where(st => st.FirstName.CompareTo(st.LastName) == -1)
                .ToList()
                .ForEach(Console.WriteLine);

            // P4 - Students by Age (Finds the needed students and prints the required data only)
            studentsList
                .Where(st => st.Age >= 18 && st.Age <= 24)
                .ToList()
                .ForEach(st => Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\n", st.FirstName, st.LastName, st.Age));

            // P4 - Students by Age (Variant) (Returns IEnumerable of anonymous type which has only the properties we need)
            var studentsByAge =
                from st in studentsList
                where st.Age >= 18 && st.Age <= 24
                select new {st.FirstName, st.LastName, st.Age};

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

            // P6 - Filter students by Email Domain
            // changing some students email with abv.bg domain
            studentsList[2].Email = "dominator@abv.bg";
            studentsList[10].Email = "judaspriest@abv.bg";
            studentsList[28].Email = "softuni@abv.bg";

            // printing the students with abv.bg email domain
            studentsList
                .Where(st => st.Email.EndsWith("@abv.bg"))
                .ToList()
                .ForEach(Console.WriteLine);

            // P7 - Filter students by Phone
            // changing some students phone with Sofia numbers
            studentsList[8].Phone = "023432435";
            studentsList[20].Phone = "+35923332211";
            studentsList[30].Phone = "+359 2 1222211";

            // printing the students with Sofia numbers
            studentsList
                .Where(st => st.Phone.StartsWith("02") || st.Phone.StartsWith("+3592") || st.Phone.StartsWith("+359 2"))
                .ToList()
                .ForEach(Console.WriteLine);

            // P8 - Excellent students
            //(Creates IEnumerable of an anonymous type taken from the students which have at least one 6 mark)
            var excellentStudents =
                from st in studentsList
                where st.Marks.Contains(6)
                select new {FullName = st.FirstName + " " + st.LastName, st.Marks};

            // P9 - Weak students

            // P10 - Students enrolled in 2014
            // changing some of the students' faculty numbers to satisfy the condition
            studentsList[13].FacultyNumber = 111114;
            studentsList[23].FacultyNumber = 222214;
            studentsList[33].FacultyNumber = 333314;

            // printing the marks of the students with faculty number ending with "14"
            studentsList
                .Where(st => st.FacultyNumber.ToString().EndsWith("14"))
                .Select(st => new {st.FirstName, st.LastName, st.FacultyNumber, st.Marks})
                .ToList()
                .ForEach(st => Console.WriteLine("[ " + string.Join(", ", st.Marks) + " ]"));

            // P11 - Students by Groups
            // creating two group names for odd and even items in the students list
            for (int i = 0; i < studentsList.Count; i++)
            {
                studentsList[i].GroupName = i % 2 == 0 ? "Masters" : "Slaves";
            }

            // grouping students into IEnumerable
            var studentsByGroups =
                from st in studentsList
                group st by st.GroupName
                into groupName
                select groupName;

            // printing each student's first and last name from every group
            foreach (var groupName in studentsByGroups)
            {
                Console.Write("\r\n\nGroup: {0}\n", groupName.Key);
                foreach (var student in groupName)
                {
                    Console.Write("[ {0} {1} ] ", student.FirstName, student.LastName);
                }
                Console.WriteLine();
            }

            // P12 - Students Joined to Specialties
            var studentSpecialties = new List<StudentSpecialty>
            {
                new StudentSpecialty("PHP Developer", 203314),
                new StudentSpecialty("Web Developer", 203114),
                new StudentSpecialty("QA Engineer", 203814),
                new StudentSpecialty("PHP Developer", 203914),
                new StudentSpecialty("Web Developer", 203314),
                new StudentSpecialty("QA Engineer", 203914),
            };

            // changing some students' faculty numbers to satisfy the conditions above
            studentsList[2].FacultyNumber = 203314;
            studentsList[12].FacultyNumber = 203114;
            studentsList[22].FacultyNumber = 203814;
            studentsList[32].FacultyNumber = 203914;
            studentsList[42].FacultyNumber = 203314;

            var query =
                from st in studentsList
                join sp in studentSpecialties
                on st.FacultyNumber equals sp.FacultyNumber
                select new { Name = st.FirstName + " " + st.LastName, st.FacultyNumber, Specialty = sp.SpecialtyName };

            foreach (var item in query)
            {
                Console.WriteLine("\n" + item);
            }
        }
    }
}