using System.Collections.Generic;

namespace Entity04.Entity {
   public class Movie {
      public int movieID { get; set; }
      public Director movieDirectorID { get; set; }
      public string movieName { get; set; }
      public IList<Actor> movieActorsID { get; set; }
   }
}
