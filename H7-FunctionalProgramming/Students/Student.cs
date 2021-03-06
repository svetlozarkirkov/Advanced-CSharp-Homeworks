﻿namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    internal class Student
    {
        private const string EmailRegex =
            @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

        private string firstName;
        private string lastName;
        private int age;
        private string email;
        private int groupNumber;

        public Student(string firstName, string lastName, int age, string phoneNumber, string email, int facultyNumber, int groupNumber, IList<int> marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Phone = phoneNumber;
            this.Email = email;
            this.FacultyNumber = facultyNumber;
            this.Marks = new List<int>();
            this.GroupNumber = groupNumber;
            this.Marks = marks;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("First name must not be empty.");
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentException("Last name must not be empty.");
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value > 0 && value < 120)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("Invalid age.");
                }
            }
        }

        public int FacultyNumber { get; set; }

        public string Phone { get; set; }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (Regex.IsMatch(value, EmailRegex, RegexOptions.IgnoreCase))
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException("Invalid e-mail.");
                }
            }
        }

        public IList<int> Marks { get; set; }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }

            set
            {
                if (value > 0)
                {
                    this.groupNumber = value;
                }
                else
                {
                    throw new ArgumentException("Invalid group number.");
                }
            }
        }

        public string GroupName { get; set; }

        public override string ToString()
        {
            string output = string.Format(
                "\r\nFull name: {0} {1}\nAge: {2}\nPhone: {3}\nE-mail: {4}\nFaculty number: {5}\nGroup number: {6}\nMarks: [ {7} ]\r\n",
                this.FirstName,
                this.LastName,
                this.Age,
                this.Phone,
                this.Email,
                this.FacultyNumber,
                this.GroupNumber,
                string.Join(", ", this.Marks));

            return output;
        }
    }
}