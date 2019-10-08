using System;
using System.Collections.Generic;

// ## Student

// You must define a type for representing a student in code.A student can only be in one cohort at a time.A student can be working on many exercises at a time.

// ### Properties

// 1. First name
// 1. Last name
// 1. Slack handle
// 1. The student's cohort
// 1. The collection of exercises that the student is currently working on

namespace StudentExercises
{
    public class Student
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public List<Exercise> Exercises { get; set; }

        // Constructor
        public Student(string firstName, string lastName, string slackHandle, Cohort cohort)
        {
            Exercises = new List<Exercise>();
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
        }

    }
}