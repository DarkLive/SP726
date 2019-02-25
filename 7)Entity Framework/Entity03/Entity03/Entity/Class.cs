using System.Collections.Generic;

public enum EducationProvider { Goverment, Public }
public enum EducationType { Web, SyberSecurity, System }

namespace Entity03.Entity {
   public class Class {
      public int classID { get; set; }
      public string classCode { get; set; }

      public EducationProvider educationProvider { get; set; }
      public EducationType educationType { get; set; }

      public Classroom classClassroom { get; set; }
      public Teacher classroomTeacher { get; set; }

      public IList<Student> classStudents { get; set; }
   }
}
