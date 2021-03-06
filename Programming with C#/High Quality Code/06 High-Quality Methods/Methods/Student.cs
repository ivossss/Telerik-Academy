﻿namespace Methods
{
    using System;

    public class Student
    {
        public Student(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public DateTime DateOfBirth { get; private set; }

        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            return this.DateOfBirth > other.DateOfBirth;
        }
    }
}
