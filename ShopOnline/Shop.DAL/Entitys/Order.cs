using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.DAL.Entitys
{
    [Table("Order")]
    public class Order
    {
        public Order()
        {
        }

        public Order(int id, int customerId, double totalMoney, DateTime date, int status)
        {
            Id = id;
            CustomerId = customerId;
            TotalMoney = totalMoney;
            Date = date;
            Status = status;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        [Range(1, 999999999)]
        public double TotalMoney { get; set; }

        public DateTime Date { get; set; }

        public int Status { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
