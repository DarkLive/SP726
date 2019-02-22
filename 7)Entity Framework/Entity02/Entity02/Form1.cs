using System;
using System.Windows.Forms;

namespace Entity02 {
   public partial class Form1 : Form {
      public Form1() {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e) {
         DBCord Cord = new DBCord();

         Course Cou = new Course();
         Cou.CourseName = "Web & Mobile Programming";
         Cou.CourseAddress = "SmartPRO";

         Student Stu = new Student();
         Stu.CourseId = 1;

         Cord.Courses.Add(Cou);
         Cord.Students.Add(Stu);
         Cord.SaveChanges();
      }
   }
}
