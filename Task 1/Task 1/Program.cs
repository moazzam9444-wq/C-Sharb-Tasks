using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Mohamamd Azzam";
            int age = 22;
            int grade = 12;
            float average = 89.5f;
            char gender = 'M';
            bool status = true;
            Console.WriteLine("===== Student Information =====");
            Console.WriteLine();
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Active: " + status);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Part * 2 *");
            string[] students = { "Mohammad", "Ahmad", "Sara", "Tala" };
            Console.WriteLine("Student 1: " + students[0]);
            Console.WriteLine("Student 2: " + students[1]);
            Console.WriteLine("Student 3: " + students[2]);
            Console.WriteLine("Student 4: " + students[3]);
            Console.WriteLine("Total Of Students: " + students.Length);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Part * 3 *");
            Console.WriteLine("The First Index " + students[0]);
            Console.WriteLine("The Last Index " + students[3]);
            students[2] = "Rama";
            Console.WriteLine("Student 1: " + students[0]);
            Console.WriteLine("Student 2: " + students[1]);
            Console.WriteLine("Student 3: " + students[2]);
            Console.WriteLine("Student 4: " + students[3]);

        }
    }
}
