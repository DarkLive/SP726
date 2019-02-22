using System.Collections.Generic;

namespace Entity02 {
   public class Course {
      public int CourseId { get; set; }
      public string CourseName { get; set; }
      public string CourseAddress { get; set; }

      public ICollection<Student> StudentOnCourse { get; set; }
   }
}
