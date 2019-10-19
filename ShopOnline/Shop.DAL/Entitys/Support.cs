using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.DAL.Entitys
{
    [Table("Support")]
    public class Support
    {
        public Support()
        {
        }

        public Support(int id, string name, string tel, string nick, int status)
        {
            Id = id;
            Name = name;
            Tel = tel;
            Nick = nick;
            Status = status;
        }

        [Key]
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
