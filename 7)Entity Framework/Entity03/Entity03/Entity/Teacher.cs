using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity03.Entity {
   public class Teacher {
      public int teacherID { get; set; }
      public string teacherIdentityNo { get; set; }
      [Index()] [Required] [MaxLength(30)]public string teacherName { get; set; }
      public DateTime teacherEmployementStart { get; set; }
      public DateTime teacherEmployementEnd { get; set; }
      public bool teacherActive { get; set; }

      public IList<Class> teacherClasses { get; set; }
   }
}
