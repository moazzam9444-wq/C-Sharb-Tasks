
using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess The Number Game");
            Random random = new Random();
            int guessNumber = random.Next(50, 76);
            Console.WriteLine($"The Number Is:{guessNumber}");
            Console.WriteLine("Pls Enter Your Gussing Number :)");

            int number = 0;
            int attempts = 0;

            while (number != guessNumber)
            {
                number = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (number > guessNumber)
                {
                    Console.WriteLine("Try Lower :)");
                }
                else if (number < guessNumber)
                {
                    Console.WriteLine("Try Upper :)");
                }
                else
                {
                    Console.WriteLine("Yes It is hhh :)");
                }
            }

            int point = 0;

            if (attempts == 1)
            {
                point = 10;
            }
            else if (attempts == 2)
            {
                point = 7;
            }
            else if (attempts == 3)
            {
                point = 5;
            }
            else
            {
                point = 0;
            }

            Console.WriteLine($"Your Attempts Is: {attempts}\nYou Achieved {point}!");

            Console.WriteLine();
            Console.WriteLine("***** Part 2 *****");

            string[] studentNames = { "Ahmad", "Mohammad", "Ali", "Abdullah", "Rami" };

            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine(studentNames[i]);
            }

            Console.WriteLine();
            Console.WriteLine("***** Part 3 *****");

            int[] grades = { 50, 56, 98, 67, 69 };

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }

            Console.WriteLine();
            Console.WriteLine("***** Part 4 *****");

            Console.WriteLine("Pls Enter The Name Of Student!");
            string student = Console.ReadLine();

            int a = 0;
            bool found = false;

            while (a < studentNames.Length)
            {
                if (studentNames[a] == student)
                {
                    found = true;
                    Console.WriteLine("Student Found!");
                    break;
                }

                a++;
            }

            if (!found)
            {
                Console.WriteLine("Student Not Found.");
            }

            Console.WriteLine("Enter Student Grade:");
            int gradess = Convert.ToInt32(Console.ReadLine());

            if (gradess >= 90 && gradess <= 100)
            {
                Console.WriteLine("Excellent");
            }
            else if (gradess >= 80 && gradess < 90)
            {
                Console.WriteLine("Very Good");
            }
            else if (gradess >= 70 && gradess < 80)
            {
                Console.WriteLine("Good");
            }
            else if (gradess >= 60 && gradess < 70)
            {
                Console.WriteLine("Pass");
            }
            else if (gradess >= 0 && gradess < 60)
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("Invalid Grade!");
            }

            Console.WriteLine();
            Console.WriteLine("***** Part 5 *****");

            int choice;

            do
            {
                Console.WriteLine("\n===== School System =====");
                Console.WriteLine("1. Display Students");
                Console.WriteLine("2. Search for Student");
                Console.WriteLine("3. Check Student Result");
                Console.WriteLine("4. Exit");

                Console.WriteLine("Enter Your Choice:");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("===== Students =====");

                        for (int i = 0; i < studentNames.Length; i++)
                        {
                            Console.WriteLine(studentNames[i]);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Pls Enter The Name Of Student!");
                        string searchStudent = Console.ReadLine();

                        int searchIndex = 0;
                        bool studentFound = false;

                        while (searchIndex < studentNames.Length)
                        {
                            if (studentNames[searchIndex] == searchStudent)
                            {
                                studentFound = true;
                                Console.WriteLine("Student Found!");
                                break;
                            }

                            searchIndex++;
                        }

                        if (!studentFound)
                        {
                            Console.WriteLine("Student Not Found.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter Student Grade:");
                        int menuGrade = Convert.ToInt32(Console.ReadLine());

                        if (menuGrade >= 90 && menuGrade <= 100)
                        {
                            Console.WriteLine("Excellent");
                        }
                        else if (menuGrade >= 80 && menuGrade < 90)
                        {
                            Console.WriteLine("Very Good");
                        }
                        else if (menuGrade >= 70 && menuGrade < 80)
                        {
                            Console.WriteLine("Good");
                        }
                        else if (menuGrade >= 60 && menuGrade < 70)
                        {
                            Console.WriteLine("Pass");
                        }
                        else if (menuGrade >= 0 && menuGrade < 60)
                        {
                            Console.WriteLine("Fail");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Grade!");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (choice != 4);
        }
    }
}
