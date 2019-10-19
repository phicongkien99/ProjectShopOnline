using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.DAL.ViewModels
{
    public class GroupProductViewModel
    {
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
    }
}
