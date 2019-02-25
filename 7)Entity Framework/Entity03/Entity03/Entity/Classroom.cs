using System.Collections.Generic;

namespace Entity03.Entity {
   public enum Locations { Kadikoy, Sancaktepe }

   public class Classroom {
      public int classroomID { get; set; }
      public Locations classroomLocation { get; set; }
      public byte classroomFloor { get; set; }
      public string classroomName { get; set; }

      public IList<Class> classroomClass { get; set; }
   }
}
