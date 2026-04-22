using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //part 1
            List<string> students = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter student name " + (i + 1) + ": ");
                string name = Console.ReadLine();

                name = name.Trim().ToUpper();

                students.Add(name);

            }
            foreach (string s in students)
            {
                Console.WriteLine(s);
            }
            //part2
            Console.Write("Enter name to search: ");
            string search = Console.ReadLine();
            search = search.Trim().ToUpper();
            bool found = false;

            foreach (string s in students)
            {
                if (s == search)
                {
                    found = true;
                    break;
                }

            }
            if (found)
                Console.WriteLine("Student Found");
            else
                Console.WriteLine("Student Not Found");

            Console.Write("Enter student name to remove: ");



            //part 3
            string f = Console.ReadLine();

            f = f.Trim().ToUpper();

            bool ex = false;

            foreach (string s in students)
            {
                if (s == f)
                {
                    ex = true;
                    break;
                }
            }

            if (ex)
            {
                students.Remove(f);
                Console.WriteLine("Student Removed");
            }
            else
            {
                Console.WriteLine("Student Not Found");
            }
            //part 4
            students.Sort();
            foreach (string s in students) { 
            Console.WriteLine(s);
            }
            //part5
            Console.WriteLine("Enter skills (comma separated): ");
            string input = Console.ReadLine();

            // تحويل النص إلى Array
            string[] skills = input.Split(',');

            // طباعة كل skill
            foreach (string skill in skills)
            {
                Console.WriteLine(skill);
            }

            //part6
            // 2D Array
            int[,] grades = new int[3, 3];

            // Input
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter grade for student " + (i + 1) + ", subject " + (j + 1) + ": ");
                    grades[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Modify one grade
            grades[0, 1] = 100;

            // Output
            Console.WriteLine("\nGrades:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(grades[i, j] + " ");
                }
                Console.WriteLine();
            }



            //part 7
            // 15. Create jagged array (3 students)
            int[][] exams = new int[3][];

            // 16. Initialize with different sizes
            exams[0] = new int[2]; // Student 1 has 2 exams
            exams[1] = new int[4]; // Student 2 has 4 exams
            exams[2] = new int[3]; // Student 3 has 3 exams

            // Input values
            for (int i = 0; i < exams.Length; i++)
            {
                for (int j = 0; j < exams[i].Length; j++)
                {
                    Console.Write("Enter score for student " + (i + 1) +
                                  ", exam " + (j + 1) + ": ");
                    exams[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // 17. Print all values
            Console.WriteLine("\nAll Exam Scores:");

            for (int i = 0; i < exams.Length; i++)
            {
                for (int j = 0; j < exams[i].Length; j++)
                {
                    Console.Write(exams[i][j] + " ");
                }
                Console.WriteLine();
            }


            //part 8

            Console.Write("Enter admin password: ");
            string password = Console.ReadLine();

            if (password == "ADMIN123")
            {
                Console.WriteLine("Access Granted");
            }
            else
            {
                Console.WriteLine("Access Denied");
            }
        }
        }
    }
