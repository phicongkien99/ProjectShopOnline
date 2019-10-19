using System.ComponentModel.DataAnnotations;

namespace Shop.DAL.ViewModels
{
    public class OrderDetailViewModel
    {
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
