using System.Collections.Generic;

namespace Entity04.Entity {
   public class Director {
      public int directorID { get; set; }
      public string directorName { get; set; }

      public IList<Movie> directorOnMovie { get; set; }
   }
}
