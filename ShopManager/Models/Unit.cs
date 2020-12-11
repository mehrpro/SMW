namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("Unit")]
    public class Unit
    {
        public Unit()
        {
            ProductLists = new HashSet<ProductList>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UnitId { get; set; }

        [Required]
        [StringLength(150)]
        public string UnitName { get; set; }

        public bool Enabled { get; set; }

        public DateTime DateRegister { get; set; }

        public virtual ICollection<ProductList> ProductLists { get; set; }
    }
}
