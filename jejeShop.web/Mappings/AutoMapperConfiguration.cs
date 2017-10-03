using AutoMapper;
using jejeShop.Model.Models;

using jejeShop.Web.Models;

namespace jejeShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<PostCategory, PostCategoryViewModel>().MaxDepth(2);
                cfg.CreateMap<Post, PostViewModel>().MaxDepth(2);
                cfg.CreateMap<Tag, TagViewModel>().MaxDepth(2);

                cfg.CreateMap<ProductCategory, ProductCategoryViewModel>().MaxDepth(2);
                cfg.CreateMap<Product, ProductViewModel>().MaxDepth(2);
                cfg.CreateMap<ProductTag, ProductTagViewModel>().MaxDepth(2);

                cfg.CreateMap<Footer, FooterViewModel>().MaxDepth(2);

                cfg.CreateMap<Slide, SlideViewModel>().MaxDepth(2);


                cfg.CreateMap<ContactDetail, ContactDetailViewModel>().MaxDepth(2);
            });
        }
    }
}