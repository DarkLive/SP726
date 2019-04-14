namespace WebAPI01.Models.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Article")]
    public partial class Article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Article()
        {
            Rel_Article_Category = new HashSet<Rel_Article_Category>();
        }

        [Key]
        public int artID { get; set; }

        [Required]
        [StringLength(150)]
        public string artTitle { get; set; }

        [Required]
        public string artText { get; set; }

        public DateTime artPublishDate { get; set; }

        public DateTime artUpdateDate { get; set; }

        [Required]
        [StringLength(300)]
        public string artImage { get; set; }

        public int artWriter { get; set; }

        public bool artActive { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rel_Article_Category> Rel_Article_Category { get; set; }
    }
}
