using System.ComponentModel.DataAnnotations;

namespace Shop.DAL.ViewModels
{
    public class ProvinceViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }
    }
}
