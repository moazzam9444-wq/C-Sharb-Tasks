using System;

class Student
{
    public string name;
    public int age;

    public Student(string studentName, int studentAge)
    {
        name = studentName;
        age = studentAge;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student("Sara", 20);
        Student s2 = new Student("Ahmad", 22);
        Student s3 = new Student("Lina", 19);

        s1.DisplayInfo();

        Console.WriteLine("----------");

        s2.DisplayInfo();

        Console.WriteLine("----------");

        s3.DisplayInfo();
    }
}