//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _1_Blog
{
    using System;
    using System.Collections.Generic;
    
    public partial class Article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Article()
        {
            this.artActive = true;
            this.Rel_Article_Category = new HashSet<Rel_Article_Category>();
        }
    
        public int artID { get; set; }
        public string artTitle { get; set; }
        public string artText { get; set; }
        public System.DateTime artPublishDate { get; set; }
        public System.DateTime artUpdateDate { get; set; }
        public string artImage { get; set; }
        public int artWriter { get; set; }
        public bool artActive { get; set; }
    
        public virtual Account Account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rel_Article_Category> Rel_Article_Category { get; set; }
    }
}
