using System;

namespace activity4
{
    abstract class Grading
    {
        protected string studentName;
        protected double grade;
        public void SetData(string studentName, double grade)
        {
            this.studentName = studentName;
            this.grade = grade;
        }
        public abstract void DisplayInfo();
        public abstract string GetRemarks();
    }
    class SeniorHigh: Grading
    {
   public override void DisplayInfo()
    {
        Console.WriteLine($" Senior High Student: {studentName}, Grade: {grade}");
        Console.WriteLine($" Remarks: {GetRemarks()}");
    }
        public override string GetRemarks()
        {
        return grade >= 75 ? "Passed" : "Failed";
        }
    }
 class College : Grading
 {
    public override void DisplayInfo()
    {
        Console.WriteLine($" StudentName: {studentName}, Grade: {grade}");
        Console.WriteLine($" Remarks: {GetRemarks()}");
    }
        public override string GetRemarks()
        {
            if (grade == 4.00)
                return "Failed";
            else if (grade >= 1.00 && grade < 4.00)
                return "Passed";
            else
                return "Invalid Grade";
            
    }
 }
 class Program
    {
        static void Main(string[] args)
        {
            Grading student1 = new SeniorHigh();
            student1.SetData("Borromeo", 95);
            student1.DisplayInfo();

            Grading student2 = new SeniorHigh();
            student2.SetData("Cedillo", 73);
            student2.DisplayInfo();

            Grading student3 = new College();
            student3.SetData("Salas", 4.00);
            student3.DisplayInfo();

            Grading student4 = new College();
            student4.SetData("Ramilo", 1.00);
            student4.DisplayInfo();
        }
}
}