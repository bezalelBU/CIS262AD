// Katlyn Quinn
// kat2342618
// CIS262AD 10549
// Lesson 1
// 2/10/2024

using System;
using System.Numerics;

namespace Lesson1_kat2342618
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Dictionary<int, Student> students = CreateStudents();
            List<Exam> exams = CreateExamsAndAddThem(students);

            // Group the exams by student id
            Dictionary<int, List<Exam>> examsGroupedByStudentId = new Dictionary<int, List<Exam>>();
            foreach ( Exam exam in exams )
            {
                if ( !examsGroupedByStudentId.ContainsKey( exam.StudentId ) )
                {
                    examsGroupedByStudentId.Add( exam.StudentId, new List<Exam>() );
                }
                examsGroupedByStudentId[exam.StudentId].Add( exam );
            }

            //Loop through students and display names and score averages
            foreach ( int id in students.Keys )
            {
                double scoreAverage = examsGroupedByStudentId[id].Average( n => n.Score );
                Console.WriteLine("Student " + id + " (" + students[id].FullName + "): " + Math.Round( scoreAverage, 2, MidpointRounding.AwayFromZero ) );                            

            }

            Console.ReadLine();
        }

        static Dictionary<int, Student> CreateStudents()
        {
            // Create a Random generator
            Random random = new Random();

            // Create a list of people
            List<Student> people = new List<Student>();            

            // Create a list of common first names
            List<string> commonFirstNames = new List<string>();
            commonFirstNames.Add( "Susan" );
            commonFirstNames.Add( "Matthew" );
            commonFirstNames.Add( "John" );
            commonFirstNames.Add( "James" );
            commonFirstNames.Add( "Rachel" );
            commonFirstNames.Add( "Anna" );
            commonFirstNames.Add( "Harold" );
            commonFirstNames.Add( "Lilly" );
            commonFirstNames.Add( "April" );
            commonFirstNames.Add( "Sean" );
            commonFirstNames.Add( "Shawn" );
            commonFirstNames.Add( "Stephen" );
            commonFirstNames.Add( "Kate" );
            commonFirstNames.Add( "Britney" );
            commonFirstNames.Add( "Benjamin" );
            commonFirstNames.Add( "Lindsay" );

            // Create a list of common last names
            List<string> commonLastNames = new List<string>();
            commonLastNames.Add( "Martinez" );
            commonLastNames.Add( "Smith" );
            commonLastNames.Add( "Kim" );
            commonLastNames.Add( "Johnson" );
            commonLastNames.Add( "Wang" );
            commonLastNames.Add( "Clark" );
            commonLastNames.Add( "Hernandez" );
            commonLastNames.Add( "Long" );
            commonLastNames.Add( "Williams" );
            commonLastNames.Add( "Ruiz" );
            commonLastNames.Add( "Lee" );
            commonLastNames.Add( "Brown" );
            commonLastNames.Add( "White" );
            commonLastNames.Add( "Walker" );
            commonLastNames.Add( "Rodriguez" );
            commonLastNames.Add( "King" );
            commonLastNames.Add( "Lim" );

            const int peopleToGenerate = 10;

            Dictionary<int, Student> peopleDictionary = new Dictionary<int, Student>();
            for ( int i = 0; i < peopleToGenerate; i++ )
            {
                Student person = new Student();
                person.Id = i;

                // Now we need to generate the persons name
                // We will get a random integer between 0 and the size of our list
                int firstNameValue = random.Next( 0, commonFirstNames.Count() - 1 );

                // next we'll do the same for last names
                int lastNameValue = random.Next( 0, commonLastNames.Count() - 1 );

                person.FirstName = commonFirstNames[firstNameValue];
                person.LastName = commonLastNames[lastNameValue];

                peopleDictionary.Add( person.Id, person );

            }     

            return peopleDictionary;

        }

        static List<Exam> CreateExamsAndAddThem(Dictionary<int, Student> students)
        {
            // Create a Random generator
            Random random = new Random();

            // Create a list of people
            List<Exam> exams = new List<Exam>();
            const int examsToGenerate = 3;

            //loop through students in the dictionary
            foreach ( int id in students.Keys )
            {
                // create 1,2,3 exams with random scores
                for ( int i = 0; i < examsToGenerate; i++ )
                {
                    Exam exam = new Exam();
                    exam.StudentId = students[id].Id;
                    exam.Score = random.Next( 0, 100 ); //returns random number between 0-99
                    exam.ExamNumber = i + 1;
                    exams.Add( exam );
                }
            }

            return exams;

        }

    }
}
