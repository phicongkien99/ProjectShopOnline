using System.ComponentModel.DataAnnotations;

namespace Shop.DAL.ViewModels
{
    public class AdvertiseViewModel
    {
        public int Id { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        [StringLength(600)]
        public string Url { get; set; }

        public float Width { get; set; }

        public float Height { get; set; }

        public string Link { get; set; }

        public int Target { get; set; }

        public int Postion { get; set; }

        public int Order { get; set; }

        public int Status { get; set; }
    }
}
