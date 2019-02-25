using System;
using System.Collections.Generic;

namespace Entity04.Entity {
   public class Actor {
      public int actorID { get; set; }
      public string actorFullName { get; set; }
      public DateTime actorBirthday { get; set; }

      public IList<Movie> actorOnMovie { get; set; }
   }
}
