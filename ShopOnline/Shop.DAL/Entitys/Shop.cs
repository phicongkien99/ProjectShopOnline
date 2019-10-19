using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.DAL.Entitys
{
    [Table("Shop")]
    public class Shop
    {
        public Shop()
        {
        }

        public Shop(int id, string name, string address, string tel, int provinceId)
        {
            Id = id;
            Name = name;
            Address = address;
            Tel = tel;
            ProvinceId = provinceId;
        }

        [Key]
        public int Id { get; set; }

        [StringLength(40, MinimumLength = 2)]
        public string Name { get; set; }

        [StringLength(200, MinimumLength = 2)]
        public string Address { get; set; }

        [StringLength(20, MinimumLength = 10)]
        public string Tel { get; set; }

        [Required]
        public int ProvinceId { get; set; }

        [ForeignKey("ProvinceId")]
        public virtual Province Province { get; set; }
    }
}
