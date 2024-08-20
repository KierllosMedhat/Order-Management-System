using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace System.Data.Entities
{
    public class OrderItem
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderItemId { get; set; }

        public Order Order { get; set; }
        [Required]
        [ForeignKey("Order")]
        public int OrderId { get; set; }

        public Product Product { get; set; }
        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double UnitPrice { get; set; }

        public double Discount { get; set; }
    }
}