using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManager.Models
{
    public partial class PurchaseInvoicy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseInvoicy()
        {
            Goods = new HashSet<Good>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PurchaseInvoiceId { get; set; }


        public DateTime InvoiceDate { get; set; }

        public byte InvoiceType_FK { get; set; }

        public int ProductList_FK { get; set; }

        public int Saller_FK { get; set; }

        public double PurchasePrice { get; set; }

        public int Unit_FK { get; set; }

        public double Numbers { get; set; }
        
        public double SumCurrency { get; set; }
        public DateTime DateRegister { get; set; }
        [StringLength(100)]
        public string InvoiceNumber { get; set; }

        public bool Enabled { get; set; }

        public int AppUser_FK { get; set; }

        public virtual AppUser AppUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Good> Goods { get; set; }

        public virtual InvoiceType InvoiceType { get; set; }

        public virtual ProductList ProductList { get; set; }

        public virtual Saller Saller { get; set; }

        public virtual Unit Unit { get; set; }
    }
}
