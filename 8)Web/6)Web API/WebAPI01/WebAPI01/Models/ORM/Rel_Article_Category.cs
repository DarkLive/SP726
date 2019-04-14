namespace WebAPI01.Models.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Rel_Article_Category
    {
        public int ID { get; set; }

        public int relArtID { get; set; }

        public int relCatID { get; set; }

        public virtual Article Article { get; set; }

        public virtual Category Category { get; set; }
    }
}
