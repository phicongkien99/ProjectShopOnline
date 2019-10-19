using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.DAL.Entitys
{
    public class Advertise
    {
        public Advertise()
        {
        }

        public Advertise(int id, string name, string url, float width, float height, string link, int target, int postion, int order, int status)
        {
            Id = id;
            Name = name;
            Url = url;
            Width = width;
            Height = height;
            Link = link;
            Target = target;
            Postion = postion;
            Order = order;
            Status = status;
        }

        [Key]
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
