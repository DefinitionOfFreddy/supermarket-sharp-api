using AutoMapper;
using supermarket.sharp.api.Domain.Models;
using supermarket.sharp.api.Extensions;
using supermarket.sharp.api.Resources;

namespace supermarket.sharp.api.Mapping
{
    public class ModelToRessourceProfile : Profile
    {
        public ModelToRessourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<Product, ProductResource>()
                .ForMember(
                    src => src.UnitOfMeasurement,
                    opt => opt.MapFrom(src => src.UnitOfMesurement.ToDescriptionString())
                );
        }
    }
}