using System;
using System.Collections;

namespace ConsoleHomework02 {
   class Program {
      public static void CalculateGrade(Student std) { std.CalculateGrade(); }
      static void Main(string[] args) {
         HighSchool hschool = new HighSchool("Stu1", "TestSchool1", 12, GradeLevel.HighSchool, 40, 60);
         Undergraduate underg = new Undergraduate("Stu2", "TestSchool2", 16, GradeLevel.Undergraduate, 90, 85,"Engineering");
         CalculateGrade(hschool); CalculateGrade(underg);
         Console.ReadKey();
      }
   }

   enum GradeLevel : byte { Primary, Secondary, HighSchool, Undergraduate }

   class Student {
      public ArrayList StudentList = new ArrayList();
      public string StudentFullName, SchoolName = "Distance Learning"; public int StudentNumber;
      GradeLevel Grade;
      public Student(string studentname, string schoolname, int studentnum, GradeLevel gradeen) {
         StudentFullName = studentname; SchoolName = schoolname; StudentNumber = studentnum; Grade = gradeen;
      } 

      public virtual void CalculateGrade() {
         Console.WriteLine("Grade info is insufficient!");
      }
   }
   class HighSchool : Student {

      public HighSchool(string studentname, string schoolname, int studentnum, GradeLevel gradeen, double grade1, double grade2) : base(studentname, schoolname, studentnum, gradeen) {
         SchoolName = schoolname; StudentList.Add(grade1); StudentList.Add(grade2);
      }
      public override void CalculateGrade() {
         double total = ( (double)StudentList[0] + (double)StudentList[1] ) / 2;
         if ( total >= 0 && total <= 44.99 ) { Console.WriteLine("Failed/Retry"); }
         else if ( total >= 45.00 && total <= 49.99 ) { Console.WriteLine("Pass"); }
         else if ( total >= 50.00 && total <= 59.99 ) { Console.WriteLine("Fine"); }
         else if ( total >= 60.00 && total <= 69.99 ) { Console.WriteLine("Good"); }
         else if ( total >= 70.00 && total <= 84.99 ) { Console.WriteLine("Very good"); }
         else if ( total >= 85.00 && total <= 100 ) { Console.WriteLine("Excellent"); }
         else { Console.WriteLine("X"); }
      }
   }
   class Undergraduate : Student {
      public string Faculty;
      public Undergraduate(string studentname, string schoolname, int studentnum, GradeLevel gradeen, double grade1, double grade2, string faculty) : base(studentname, schoolname, studentnum, gradeen) {
         Faculty = faculty; StudentList.Add(grade1); StudentList.Add(grade2);
      }
      public override void CalculateGrade() {
         double total = ( (double)StudentList[0] * 0.4 ) + ( (double)StudentList[1] * 0.6 );
         if ( total >= 0 && total <= 44.99 ) { Console.WriteLine("F"); }
         else if ( total >= 45.00 && total <= 49.99 ) { Console.WriteLine("E"); }
         else if ( total >= 50.00 && total <= 59.99 ) { Console.WriteLine("D"); }
         else if ( total >= 60.00 && total <= 69.99 ) { Console.WriteLine("C"); }
         else if ( total >= 70.00 && total <= 84.99 ) { Console.WriteLine("B"); }
         else if ( total >= 85.00 && total <= 100 ) { Console.WriteLine("A"); }
         else { Console.WriteLine("X"); }
      }
   }
}
