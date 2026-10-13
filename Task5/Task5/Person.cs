using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Person
    {
        public string Name {  get; set; }
        public int Age {  get; set; }

        private int _internalCode; //we cant access to this field out side this class becaue its private and if we want access to this field we must use probrity set and get 
        protected string SchoolName { get; set; }

        public Person(string name, int age){

            Name = name;
            Age = age;
        
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name:{Name}\nAge:{Age}");
        }
    }
}
