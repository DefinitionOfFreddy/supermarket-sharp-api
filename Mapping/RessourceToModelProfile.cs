using AutoMapper;
using supermarket.sharp.api.Domain.Models;
using supermarket.sharp.api.Resources;

namespace supermarket.sharp.api.Mapping
{
    public class RessourceToModelProfile : Profile
    {
        public RessourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}