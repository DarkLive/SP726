namespace WebAPI01.Models.ORM {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Cord : DbContext {
        public Cord()
            : base("name=Cord") {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Rel_Article_Category> Rel_Article_Category { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Account>()
                .HasMany(e => e.Articles)
                .WithRequired(e => e.Account)
                .HasForeignKey(e => e.artWriter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Article>()
                .HasMany(e => e.Rel_Article_Category)
                .WithRequired(e => e.Article)
                .HasForeignKey(e => e.relArtID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Rel_Article_Category)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.relCatID)
                .WillCascadeOnDelete(false);
        }
    }
}
