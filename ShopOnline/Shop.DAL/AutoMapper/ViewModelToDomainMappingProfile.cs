using AutoMapper;
using Shop.DAL.Entitys;
using Shop.DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DAL.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductViewModel, Product>().ConstructUsing(p => new Product(p.Id, p.Name, p.Detail, p.Price, p.Image, p.PriceNew, p.Date, p.Order, p.Status, p.GroupProductId));

            CreateMap<AdvertiseViewModel, Advertise>().ConstructUsing(a => new Advertise(a.Id, a.Name, a.Url, a.Width, a.Height, a.Link, a.Target, a.Postion, a.Order, a.Status));

            CreateMap<CustomerViewModel, Customer>().ConstructUsing(c => new Customer(c.Id, c.Name, c.ProvinceId, c.BirthDay, c.Address, c.Tel, c.Email));

            CreateMap<GroupProductViewModel, GroupProduct>().ConstructUsing(g => new GroupProduct(g.Id, g.Name, g.Content, g.Image, g.Order, g.Status));

            CreateMap<OrderDetailViewModel, OrderDetail>().ConstructUsing(o => new OrderDetail(o.Id, o.OrderId, o.ProductId, o.Quantity));

            CreateMap<OrderViewModel, Order>().ConstructUsing(o => new Order(o.Id, o.CustomerId, o.TotalMoney, o.Date, o.Status));

            CreateMap<ProvinceViewModel, Province>().ConstructUsing(p => new Province(p.Id, p.Name));

            CreateMap<ShopViewModel, Entitys.Shop>().ConstructUsing(s => new Entitys.Shop(s.Id, s.Name, s.Address, s.Tel, s.ProvinceId));

            CreateMap<SupportViewModel, Support>().ConstructUsing(s => new Support(s.Id, s.Name, s.Tel, s.Nick, s.Status));
        }
    }
}
