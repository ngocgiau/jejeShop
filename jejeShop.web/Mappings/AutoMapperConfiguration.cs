using System;
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


            });


        }
    }
}