using System;
using System.ComponentModel.DataAnnotations;

namespace Shop.DAL.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        [Range(1, 999999999)]
        public double TotalMoney { get; set; }

        public DateTime Date { get; set; }

        public int Status { get; set; }
    }
}
