using System.ComponentModel.DataAnnotations;

namespace Shop.DAL.ViewModels
{
    public class ShopViewModel
    {
        public int Id { get; set; }

        [StringLength(40, MinimumLength = 2)]
        public string Name { get; set; }

        [StringLength(200, MinimumLength = 2)]
        public string Address { get; set; }

        [StringLength(20, MinimumLength = 10)]
        public string Tel { get; set; }

        [Required]
        public int ProvinceId { get; set; }
    }
}
