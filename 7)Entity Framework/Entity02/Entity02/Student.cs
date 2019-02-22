using System.Collections.Generic;

namespace Entity02 {
   public class Student {
      public int StudentId { get; set; }
      public int CourseId { get; set; }

      public ICollection<Course> OnCourse { get; set; }
   }
}
