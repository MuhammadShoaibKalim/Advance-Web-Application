using System;
using OOOPConcept;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student(0, ""); 
        student.StudentData();

        Console.WriteLine(student.stdId);

        Student student1 = new Student(456, "Township Lahore");
        student1.StudentData();
    }
}
