namespace WebAPI01.Models.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            Articles = new HashSet<Article>();
        }

        [Key]
        public int usrID { get; set; }

        [Required]
        [StringLength(150)]
        public string usrFullName { get; set; }

        [Required]
        [StringLength(225)]
        public string usrEmail { get; set; }

        [Required]
        [StringLength(50)]
        public string usrPassword { get; set; }

        [Column(TypeName = "date")]
        public DateTime usrBirthDay { get; set; }

        public DateTime usrRegistered { get; set; }

        [Column(TypeName = "date")]
        public DateTime? usrRemoved { get; set; }

        [Required]
        [StringLength(350)]
        public string usrImg { get; set; }

        public bool usrActive { get; set; }

        public byte usrRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Article> Articles { get; set; }
    }
}
