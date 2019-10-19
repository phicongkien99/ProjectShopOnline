using System.ComponentModel.DataAnnotations;

namespace Shop.DAL.ViewModels
{
    public class SupportViewModel
    {
        public int Id { get; set; }

        [StringLength(40, MinimumLength = 2)]
        public string Name { get; set; }

        [StringLength(20, MinimumLength = 10)]
        public string Tel { get; set; }

        [StringLength(100, MinimumLength = 2)]
        public string Nick { get; set; }

        public int Status { get; set; }
    }
}
