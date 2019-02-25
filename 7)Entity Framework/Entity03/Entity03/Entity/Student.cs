using System;

namespace Entity03.Entity {
   public class Student {
      public int studentID { get; set; }
      public string studentIdentityNo { get; set; }
      public string studentName { get; set; }
      public string studentSurname { get; set; }
      public DateTime studentCourseStart { get; set; }
      public DateTime studentCourseEnd { get; set; }

      //public int classID { get; set; } //Same Naming
      //[ForeignKey("classID")] public int StudentClass { get; set; }
      //[ForeignKey("classID")] public Class StudentClass { get; set; } 
      public Class StudentClass { get; set; } //Default: int StudentClass : StudentClass_classID // Default Behavior
   }
}
