namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Unit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Unit()
        {
            ProductLists = new HashSet<ProductList>();
        }

        public int UnitId { get; set; }

        [Required]
        [StringLength(150)]
        public string UnitName { get; set; }

        public bool Enabled { get; set; }

        public DateTime DateRegister { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductList> ProductLists { get; set; }
    }
}
