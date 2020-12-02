using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ShopManager.Models;

namespace ShopManager.Models
{
    public partial class LogMessage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LogMessage()
        {
            Loggers = new HashSet<Logger>();
        }

        public int LogMessageId { get; set; }

        [Column("LogMessage")]
        [Required]
        public string LogMessage1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Logger> Loggers { get; set; }
    }
}
