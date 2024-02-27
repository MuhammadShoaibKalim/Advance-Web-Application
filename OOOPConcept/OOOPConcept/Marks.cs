using System;

namespace OOOPConcept
{
    public class Marks : Student
    {
        // Fields specific to Marks class
        private int physicsMarks;
        private int chemistryMarks;
        private int mathMarks;

        // Constructor
        public Marks(string name, int rollNumber, int physicsMarks, int chemistryMarks, int mathMarks)
            : base(0, "") // Initialize base class fields with default values
        {
            this.physicsMarks = physicsMarks;
            this.chemistryMarks = chemistryMarks;
            this.mathMarks = mathMarks;
        }

        // Method to display marks along with student details
        public void DisplayMarks()
        {
            // Call the method from the superclass to display student details
            StudentData();

            // Display marks
            Console.WriteLine("Physics Marks: " + physicsMarks);
            Console.WriteLine("Chemistry Marks: " + chemistryMarks);
            Console.WriteLine("Math Marks: " + mathMarks);
        }
    }
}
