using System;
using System.Collections.Generic;

// ## Instructor

// You must define a type for representing an instructor in code.

// 1. First name
// 1. Last name
// 1. Slack handle
// 1. The instructor's cohort
// 1. The instructor's specialty (e.g. jokes, snack cakes, dancing, etc.)
// 1. A method to assign an exercise to a student

namespace StudentExercises
{
    public class Instructor
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public string Specialty { get; set; }

        // Constructor
        public Instructor(string firstName, string lastName, string slackHandle, Cohort cohort, string specialty)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Specialty = specialty;
            Cohort = cohort;
        }

        // Method to assign an exercise to a student
        public void AssignExercise(Exercise exercise, Student student)
        {
            student.Exercises.Add(exercise);
        }
    }
}