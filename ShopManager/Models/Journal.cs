namespace ShopManager.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Journal")]
    public class Journal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long JournalID { get; set; }
        public DateTime Registered { get; set; }
        public double Debtor { get; set; }
        public double Creditor { get; set; }

        [Required]
        [ForeignKey("InvoiceType")]
        public byte InvoiceTypeID_FK { get; set; }
        public virtual InvoiceType InvoiceType { get; set; }


        public int InvoiceID { get; set; }

        [Required]
        [ForeignKey("AppUser")]
        public int AppUserID_FK { get; set; }
        public virtual AppUser AppUser { get; set; }


        [Required]
        [ForeignKey("GeneralLedgerEntity")]
        public int GLEID_FK { get; set; }
        public GeneralLedgerEntity GeneralLedgerEntity { get; set; }








    }
}
