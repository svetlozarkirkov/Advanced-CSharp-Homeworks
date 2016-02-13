namespace Students
{
    using System;

    internal class StudentSpecialty
    {
        private string specialtyName;

        public StudentSpecialty(string specialtyName, int facultyNumber)
        {
            this.SpecialtyName = specialtyName;
            this.FacultyNumber = facultyNumber;
        }

        public string SpecialtyName
        {
            get
            {
                return this.specialtyName;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.specialtyName = value;
                }
                else
                {
                    throw new ArgumentException("Invalid specialty name.");
                }
            }
        }

        public int FacultyNumber { get; }
    }
}