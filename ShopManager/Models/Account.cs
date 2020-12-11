using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManager.Models
{
   public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountID { get; set; }

        [Required]
        [ForeignKey("GeneralLedgerEntity")]
        public int GLEID_FK { get; set; }
        public GeneralLedgerEntity GeneralLedgerEntity { get; set; }

        [Required]
        [MaxLength(300)]
        public string FullName { get; set; }

        
        [StringLength(11)]
        public string PhoneNumber { get; set; }

        [StringLength(10)]
        public string Mobile { get; set; }

        [StringLength(10)]
        public string FaxNumber { get; set; }

        [MaxLength(350)]
        public string Address { get; set; }

        [EmailAddress]
        [MaxLength(350)]
        public string Email { get; set; }




    }
}
