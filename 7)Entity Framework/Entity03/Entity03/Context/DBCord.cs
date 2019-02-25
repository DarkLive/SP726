namespace Entity03 {
   using Entity;
   using System.Data.Entity;


   public class DBCord : DbContext {
      public DBCord()
          : base("name=DBCord") {
      }
      // public virtual DbSet<MyEntity> MyEntities { get; set; }
      public virtual DbSet<Teacher> Teachers { get; set; }
      public virtual DbSet<Student> Students { get; set; }
      public virtual DbSet<Classroom> Classrooms { get; set; }
      public virtual DbSet<Class> Classes { get; set; }
   }
}