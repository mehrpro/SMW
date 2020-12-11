using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.Models
{
   public class GeneralLedgerEntity
    {


        public GeneralLedgerEntity()
        {
            Journals = new HashSet<Journal>();
            Accounts = new HashSet<Account>();
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GLEntityID { get; set; }

        [Required]
        [MaxLength(150)]
        public string LedgerEntityName { get; set; }



        public virtual ICollection<Journal> Journals { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }

    }
}
