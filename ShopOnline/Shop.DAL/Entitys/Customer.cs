using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shop.DAL.Entitys
{
    [Table("Customer")]
    public class Customer
    {
        public Customer()
        {
        }

        public Customer(int id, string name, int provinceId, DateTime birthDay, string address, string tel, string email)
        {
            Id = id;
            Name = name;
            ProvinceId = provinceId;
            BirthDay = birthDay;
            Address = address;
            Tel = tel;
            Email = email;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(24, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        public int ProvinceId { get; set; }

        public DateTime BirthDay { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(20, MinimumLength = 10)]
        public string Tel { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        [ForeignKey("ProvinceId")]
        public virtual Province Province { get; set; }
    }
}
