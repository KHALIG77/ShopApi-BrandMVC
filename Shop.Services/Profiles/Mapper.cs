using AutoMapper;
using Shop.Services.DTOs.BrandDTOs;
using Shop.Services.DTOs.ProductDTOs;
using Shop.Core.Entities;

namespace Shop.Services.Profiles
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Product, ProductGetDTO>();
            CreateMap<ProductPostDTO, Product>();
            CreateMap<BrandPostDTO, Brand>();
            //Productdan ProoductgetAllItem yaradanda icindeki spesifik bir propa menimsetme elemek ucun member islenir.
            //Birinci hissesinde yaranacah obyektin hansi propertisi secilir o gosderilir, sorada ikinci hissede hansi obyetkden yaradilirsa o obyetktin propunun sertine uygun beraberlesir
            CreateMap<Product,ProductGetAllItemDTO>().ForMember(dest=>dest.HasDiscount,m=>m.MapFrom(s=>s.DiscountPercent>0));

            CreateMap<Brand, BrandGetDTO>();
            CreateMap<Brand, BrandGetAllItemDTO>();
            CreateMap<Brand,BrandInProductGetDTO>();
        }
    }
}
