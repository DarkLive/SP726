using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entity03.Entity;

namespace Entity03 {
   public partial class Form1 : Form {
      public Form1() {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e) {
         DBCord Cord = new DBCord();

         Teacher teach = new Teacher();
         teach.teacherIdentityNo = "55253268962";
         teach.teacherName = "Mehmet Demir";
         teach.teacherEmployementStart = DateTime.Today;
         teach.teacherEmployementEnd = DateTime.Today.AddDays(6).AddYears(2);
         teach.teacherActive = true;

         Cord.Teachers.Add(teach);
         Cord.SaveChanges();

         Student stu = new Student();
         stu.studentName = "Ege";
         stu.studentSurname = "Turan";
         stu.studentIdentityNo = "23154578985";
         stu.studentCourseStart = DateTime.Today;
         stu.studentCourseEnd = DateTime.Today.AddDays(4).AddMonths(3);

         Cord.Students.Add(stu);
         Cord.SaveChanges();

         Class cl = new Class();
         cl.classCode = "723726";
         cl.educationProvider = EducationProvider.Goverment;
         cl.educationType = EducationType.System;
         cl.classroomTeacher = teach;
         List<Student> temp1 = new List<Student>(); temp1.Add(stu);
         cl.classStudents = temp1;

         Cord.Classes.Add(cl);
         Cord.SaveChanges();

         Classroom clroom = new Classroom();
         clroom.classroomName = "404";
         clroom.classroomLocation = Locations.Kadikoy;
         clroom.classroomFloor = 4;
         List<Class> temp2 = new List<Class>(); temp2.Add(cl);
         clroom.classroomClass = temp2;

         Cord.Classrooms.Add(clroom);
         Cord.SaveChanges();
      }
   }
}
