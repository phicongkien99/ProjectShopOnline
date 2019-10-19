using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shop.DAL.Entitys
{
    [Table("Product")]
    public class Product
    {
        public Product()
        {
        }

        public Product(int id, string name, string detail, double price, string image, double priceNew, DateTime date, int order, int status, int groupProductId)
        {
            Id = id;
            Name = name;
            Detail = detail;
            Price = price;
            Image = image;
            PriceNew = priceNew;
            Date = date;
            Order = order;
            Status = status;
            GroupProductId = groupProductId;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(120, MinimumLength = 2)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Detail { get; set; }

        [Range(500, 999999999)]
        public double Price { get; set; }

        [StringLength(300)]
        public string Image { get; set; }

        [Range(500, 999999999)]
        public double PriceNew { get; set; }

        public DateTime Date { get; set; }

        public int Order { get; set; }

        public int Status { get; set; }

        [Required]
        public int GroupProductId { get; set; }

        [ForeignKey("GroupProductId")]
        public virtual GroupProduct GroupPrd { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
