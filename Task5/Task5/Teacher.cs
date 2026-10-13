using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Teacher : Person
    {
        public string Subject {  get; set; }
        public Teacher(string name, int age, string subject): base(name, age)
        {
            Subject = subject;

        }
        public void DisplayTeacherInfo()
        {
            Console.WriteLine($"Teacher Name:{Name}\nAge:{Age}\nSubject:{Subject}");
        }

    }
}
