using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.Entities
{
    public class Invoice
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceId { get; set; }

        public Order Order { get; set; }
        [Required]
        [ForeignKey("Order")]
        public int OrderId { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime InvoiceDate { get; set; } = DateTime.Now;
    }
}
