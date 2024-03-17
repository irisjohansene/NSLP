using AutoMapper;
using NSLPWebApi.Dto;
using NSLPWebApi.Models;
using System.Drawing;
using System.Reflection.Metadata;

namespace NSLPWebApi.EFConfigurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Ingredient, IngredientDto>().ReverseMap();
            CreateMap<Measurement, MeasurementDto>().ReverseMap();
            CreateMap<MenuType, MenuTypeDto>().ReverseMap();
            CreateMap<IngredientType, IngredientTypeDto>().ReverseMap();
            CreateMap<Menu, MenuDto>().ReverseMap();
            CreateMap<Recipe, RecipeDto>().ReverseMap();
            CreateMap<RecipeToIngredient, RecipeToIngredientDto>().ReverseMap();
            CreateMap<MenuToIngredientOrRecipe, MenuToIngredientOrRecipeDto>().ReverseMap();
            CreateMap<Vendor, VendorDto>().ReverseMap();
            CreateMap<Models.Document, DocumentDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailDto>().ReverseMap();
            CreateMap<Setting, SettingDto>().ReverseMap();
            CreateMap<ProductCategory, ProductCategoryDto>().ReverseMap();
        }
    }
}
