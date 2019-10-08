using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
        // Once you have defined all of your custom types, go to your Main() method in Program.cs and implement the following logic.

        // Create 4, or more, exercises.
        // Create 3, or more, cohorts.
        // Create 4, or more, students and assign them to one of the cohorts.
        // Create 3, or more, instructors and assign them to one of the cohorts.
        // Have each instructor assign 2 exercises to each of the students.

            // Create exercises
            Exercise chickenMonkey = new Exercise("Chicken Monkey", "JavaScript");
            Exercise fizzBuzz = new Exercise("FizzBuzz", "JavaScript");
            Exercise dailyJournal = new Exercise("Daily Journal", "JavaScript");
            Exercise frontEndCapstone = new Exercise("Front End Capstone", "JavaScript");
            Exercise urbanPlanner = new Exercise("Urban Planner", "C#");
            Exercise englishIdioms = new Exercise("English Idioms", "C#");

            // Create cohorts
            Cohort day34 = new Cohort("Day Cohort 34");
            Cohort day33 = new Cohort("Day Cohort 33");
            Cohort day35 = new Cohort("Day Cohort 35");

            // Create students
            Student joe = new Student("Joe", "Snyder", "Joe Snyder", day34);
            Student brian = new Student("Brian", "Wilson", "Brian Wilson", day34);
            Student curtis = new Student("Curtis", "Crutchfield", "Curtis Crutchfield", day34);
            Student allie = new Student("Allie", "Patton", "Allison Patton", day34);
            Student george = new Student("George", "Kelley", "George Kelley", day35);
            Student taylor = new Student("Taylor", "Carroll", "Taylor Carroll", day35);

            // Assign students to their respective cohorts
            day34.Students.Add(joe);
            day34.Students.Add(brian);
            day34.Students.Add(curtis);
            day34.Students.Add(allie);
            day35.Students.Add(george);
            day35.Students.Add(taylor);

            // Create instructors
            Instructor andy = new Instructor("Andy", "Collins", "Andy C", day34, "C#");
            Instructor bryan = new Instructor("Bryan", "Nilsen", "Bryan N", day34, "High fives");
            Instructor steve = new Instructor("Steve", "Brownlee", "Steve B", day35, "Dad jokes");

            // Assign instructors to their respective cohorts
            day34.Instructors.Add(andy);
            day34.Instructors.Add(bryan);
            day35.Instructors.Add(steve);

            // Have andy assign chickenMoney and fizzBuzz to each of the students in day34
            andy.AssignExercise(chickenMonkey, joe);
            andy.AssignExercise(fizzBuzz, joe);
            andy.AssignExercise(chickenMonkey, brian);
            andy.AssignExercise(fizzBuzz, brian);
            andy.AssignExercise(chickenMonkey, curtis);
            andy.AssignExercise(fizzBuzz, curtis);
            andy.AssignExercise(chickenMonkey, allie);
            andy.AssignExercise(fizzBuzz, allie);

            // Have bryan assign urbanPlanner and englishIdioms to each of the students in day34
            bryan.AssignExercise(urbanPlanner, joe);
            bryan.AssignExercise(englishIdioms, joe);
            bryan.AssignExercise(urbanPlanner, brian);
            bryan.AssignExercise(englishIdioms, brian);
            bryan.AssignExercise(urbanPlanner, curtis);
            bryan.AssignExercise(englishIdioms, curtis);
            bryan.AssignExercise(urbanPlanner, allie);
            bryan.AssignExercise(englishIdioms, allie);

            // Have steve assign dailyJournal and frontEndCapstone to each student in day35
            steve.AssignExercise(frontEndCapstone, george);
            steve.AssignExercise(dailyJournal, george);
            steve.AssignExercise(frontEndCapstone, taylor);
            steve.AssignExercise(dailyJournal, taylor);

            // Create a list of all the students
            List<Student> allStudents = new List<Student>(){
                joe, brian, curtis, allie, george, taylor
            };

            // Create a list of all the exercises
            List<Exercise> allExercises = new List<Exercise>(){
                chickenMonkey, fizzBuzz, dailyJournal, frontEndCapstone, urbanPlanner, englishIdioms
            };

            // Generate a report that displays which students are working on which exercises
            foreach(Exercise exercise in allExercises)
            {
                Console.Write($"{exercise.Name}: ");
                foreach(Student student in allStudents)
                {
                    if (student.Exercises.Contains(exercise))
                    {
                        Console.Write($"{student.FirstName} {student.LastName}, ");
                    }
                }
                Console.WriteLine();
            }






        }
    }
}
