using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Pls Enter Your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Pls Enter Your Grade");
            int grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Pls Enter The Average");
            double average = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Pls Enter Your Gender ");
            string gender = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("===== Student Report =====");
            Console.WriteLine();
            Console.WriteLine($"Welcome {name}!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine();
            Console.WriteLine("* Part 3 *");
            Console.WriteLine($"Orgiginal Name: {name}");
            Console.WriteLine($"UpperCase:{name.ToUpper()}");
            Console.WriteLine($"LowerCase:{name.ToLower()}");
            Console.WriteLine($"First Character {name[0]}");
            Console.WriteLine();
            Console.WriteLine("* Part 4 *");
            int marks = 5;
            double newAverage = average + marks;
            Console.WriteLine($"Orginial Average:{average}");
            Console.WriteLine($"Bonus Marks:{marks}");
            Console.WriteLine($"New Average:{newAverage}");
            Console.WriteLine();
            Console.WriteLine("* Part 5 *");
            string result = average >= 50 ? "Passed" : "Failed";
            string ageResult = age >= 18 ? "True" : "Under 18";

            Console.WriteLine($"Welcome{name}!");
            Console.WriteLine($"Age:{name}");
            Console.WriteLine($"Grade:{grade}");
            Console.WriteLine($"Average:{average}");
            Console.WriteLine($"NewAverage:{newAverage}");
            Console.WriteLine($"Gender:{gender}");
            Console.WriteLine($"Result:{result}");
            Console.WriteLine($"Agult:{ageResult}");

        }
    }
}
