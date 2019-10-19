using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shop.DAL.Entitys
{
    [Table("GroupProduct")]
    public class GroupProduct
    {
        public GroupProduct()
        {
        }

        public GroupProduct(int id, string name, string content, string image, int order, int status)
        {
            Id = id;
            Name = name;
            Content = content;
            Image = image;
            Order = order;
            Status = status;            
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(120, MinimumLength = 2)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Content { get; set; }

        [StringLength(300)]
        public string Image { get; set; }

        public int Order { get; set; }

        public int Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
