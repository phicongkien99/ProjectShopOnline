using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.DAL.ViewModels
{
    public class CustomerViewModel
    {
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
    }
}
