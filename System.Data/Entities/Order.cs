using Stripe;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace System.Data.Entities
{
    public class Order
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        public Customer Customer { get; set; }
        [Required]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }

        [Required]
        public double TotalAmount { get; set; }

        public OrderItem[] OrderItems { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public Status Status { get; set; } = Status.Pending;
    }

    public enum Status
    {
        Pending,
        Succedd,
        Failed
    }
}