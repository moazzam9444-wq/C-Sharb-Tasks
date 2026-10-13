using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Mohammad", 23);
            person1.DisplayInfo();
            Console.WriteLine();
 
            Student student1 = new Student("Tala",23,89,1);
            Student student2 = new Student("Ali",25,78,2);
            student1.DisplayInfo();
            student1.ShowSchoolName();
            Console.WriteLine();
            student2.DisplayInfo();
            student2.ShowSchoolName();

            Console.WriteLine();
            Teacher teacher1 = new Teacher("Ramiz", 45, "Math");
            teacher1.DisplayTeacherInfo();
            //teacher1.SchoolName = "Mryas Academy"; We Cant access to this field in the main because it is a protected field and we can use it only in the deriven class only not in main 
            //person1._internalCode=5 we cant access to this field because it is private field and we can use it only in its class
            Console.WriteLine();

            SchoolReport rep1 = new SchoolReport("Patience");
            rep1.DisplayReportTitle();
        }
    }
}
