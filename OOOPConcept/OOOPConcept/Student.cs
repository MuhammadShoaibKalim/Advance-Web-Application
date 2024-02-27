using System;

namespace OOOPConcept
{
    public class Student
    {
        // Data Members
        public int stdId = 1234;
        private string stdName = "Ali Awan"; // Changed to private
        public int markss;
        public string add;

        // Constructor
        public Student(int marks, string addres)
        {
            markss = marks;
            add = addres;
        }

        // Method to display student data
        public void StudentData()
        {
            Console.WriteLine("The student name: " + stdName);
            Console.WriteLine("The student id: " + stdId);
        }
    }
}
