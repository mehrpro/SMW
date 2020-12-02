using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManager.Models
{
    [Table("Logger")]
    public partial class Logger
    {
        [Key]
        public int LogId { get; set; }

        public int LogMessage_FK { get; set; }

        public int AppUsers_FK { get; set; }

        public virtual LogMessage LogMessage { get; set; }
    }
}
