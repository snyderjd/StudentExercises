using System;
using System.Linq;
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
            Student alex = new Student("Alex", "Rumsey", "Alex Rumsey", day33);

            // Assign students to their respective cohorts
            day34.Students.Add(joe);
            day34.Students.Add(brian);
            day34.Students.Add(curtis);
            day34.Students.Add(allie);
            day35.Students.Add(george);
            day35.Students.Add(taylor);
            day33.Students.Add(alex);

            // Create instructors
            Instructor andy = new Instructor("Andy", "Collins", "Andy C", day34, "C#");
            Instructor bryan = new Instructor("Bryan", "Nilsen", "Bryan N", day33, "High fives");
            Instructor steve = new Instructor("Steve", "Brownlee", "Steve B", day35, "Dad jokes");

            // Assign instructors to their respective cohorts
            day34.Instructors.Add(andy);
            day33.Instructors.Add(bryan);
            day35.Instructors.Add(steve);

            foreach(Instructor instructor in day34.Instructors)
            {
                foreach(Student student in day34.Students)
                {
                    instructor.AssignExercise(chickenMonkey, student);
                    instructor.AssignExercise(fizzBuzz, student);
                }
            }

            foreach(Instructor instructor in day33.Instructors)
            {
                foreach(Student student in day33.Students)
                {
                    instructor.AssignExercise(dailyJournal, student);
                    instructor.AssignExercise(frontEndCapstone, student);
                }
            }

            foreach(Instructor instructor in day35.Instructors)
            {
                foreach(Student student in day35.Students)
                {
                    instructor.AssignExercise(urbanPlanner, student);
                    instructor.AssignExercise(englishIdioms, student);
                }
            }

            // Create master lists for all cohorts, exercises, students, and instructors
            List<Cohort> allCohorts = new List<Cohort>()
            {
                day33, day34, day35
            };

            List<Exercise> allExercises = new List<Exercise>(){
                chickenMonkey, fizzBuzz, dailyJournal, frontEndCapstone, urbanPlanner, englishIdioms
            };

            List<Student> allStudents = new List<Student>(){
                joe, brian, curtis, allie, george, taylor, alex
            };

            List<Instructor> allInstructors = new List<Instructor>(){
                andy, bryan, steve
            };

            // Generate a report that displays which students are working on which exercises
            foreach(Exercise exercise in allExercises)
            {
                // Console.WriteLine($"----- {exercise.Name} ----- ");
                foreach(Cohort cohort in allCohorts)
                {
                    foreach(Student student in cohort.Students)
                    {
                        if (student.Exercises.Contains(exercise))
                        {
                            // Console.WriteLine($"{student.FirstName} {student.LastName}, ");
                        }
                    }
                    
                }
            }

            // List exercises for the JavaScript language by using the Where() LINQ method.
            List<Exercise> javascriptExercise = allExercises
                .Where(exercise => exercise.Language == "JavaScript").ToList();

            // Print out all the javascript exercises
            foreach(Exercise exercise in javascriptExercise)
            {
                // Console.WriteLine($"{exercise.Name}: {exercise.Language}");
            }

            // List students in a particular cohort by using the Where() LINQ method.
            List<Student> cohort34Students = allStudents
                .Where(student => student.Cohort.Name == "Day Cohort 34").ToList();

            // Print out all the students in cohort 34
            // Console.WriteLine("===== Cohort 34 Students =====");
            foreach(Student student in cohort34Students)
            {
                // Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            // List instructors in a particular cohort by using the Where() LINQ method
            List<Instructor> cohort34Instructors = allInstructors
                .Where(Instructor => Instructor.Cohort.Name == "Day Cohort 34").ToList();

            // Print out all the instructors in cohort 34
            // Console.WriteLine("===== Cohort 34 Instructors =====");
            foreach(Instructor instructor in cohort34Instructors)
            {
                // Console.WriteLine($"{instructor.FirstName} {instructor.LastName}"); 
            }

            // Sort the students by their last name
            List<Student> sortedStudents = allStudents
                .OrderBy(student => student.LastName).ToList();

            // Print out a list of the sorted students
            // Console.WriteLine("===== Sorted Students =====");
            foreach(Student student in sortedStudents)
            {
                // Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            // Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)

            Student michael = new Student("Michael", "Stiles", "mstiles", day34);
            Student michelle = new Student("Michelle", "Jimenez", "mjimenez", day34);
            allStudents.Add(michael);
            allStudents.Add(michelle);

            List<Student> slackers = allStudents
                .Where(student => student.Exercises.Count() == 0).ToList();

            // Print all the students that aren't working on any exercises
            // Console.WriteLine("=== Students with No Exercises ===");
            foreach(Student student in slackers)
            {
                // Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            
        }
    }
}
