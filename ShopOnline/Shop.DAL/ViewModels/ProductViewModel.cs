using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.DAL.ViewModels
{
    public class ProductViewModel
    {

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

    }
}
