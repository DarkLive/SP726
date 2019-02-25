namespace Entity04 {
   using System.Data.Entity;
   using Entity04.Entity;

   public class DBCord : DbContext {
      public DBCord()
          : base("name=DBCord") {
      }

      // public virtual DbSet<MyEntity> MyEntities { get; set; }

      public virtual DbSet<Actor> Actors { get; set; }
      public virtual DbSet<Director> Directors { get; set; }
      public virtual DbSet<Movie> Movies { get; set; }
   }
}