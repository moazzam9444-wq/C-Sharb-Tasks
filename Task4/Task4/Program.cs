using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ahmad",22,59);
            //s1.Name = "Ahmad";
            //s1.Age = 22;
            //s1.Grade = 89;
            //s1.DisplayInfo();
            Console.WriteLine();
            Student s2 = new Student("Ali",35,67);
            Student s3 = new Student("Sara",23,98);
            //s2.Name = "Ahmad";
            //s2.Age = 25;
            //s2.Grade = 95;
            //s3.Name = "Sara";
            //s3.Age = 28;
            //s3.Grade = 75;
            //s2.DisplayInfo();
            //s3.DisplayInfo();
            Console.WriteLine("===== Student Information =====");
            Console.WriteLine() ;
            s1.DisplayInfo();
            Console.WriteLine();
            s2.DisplayInfo();
            Console.WriteLine();
            s3.DisplayInfo();




        }
    }
}
