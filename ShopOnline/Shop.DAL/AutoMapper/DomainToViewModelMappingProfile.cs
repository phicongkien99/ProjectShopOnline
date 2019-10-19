using AutoMapper;
using Shop.DAL.Entitys;
using Shop.DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DAL.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Product, ProductViewModel>();
            CreateMap<Advertise, AdvertiseViewModel>();
            CreateMap<Customer, CustomerViewModel>();
            CreateMap<GroupProduct, GroupProductViewModel>();
            CreateMap<Order, OrderViewModel>();
            CreateMap<OrderDetail, OrderDetailViewModel>();
            CreateMap<Province, ProvinceViewModel>();
            CreateMap<Entitys.Shop, ShopViewModel>();
            CreateMap<Support, SupportViewModel>();
        }
    }
}
