using AutoMapper;
using RestaurantOrderProject.DtoLayer.FeatureDtos;
using RestaurantOrderProject.EntityLayer.Entities;

namespace RestaurantOrder_Api.Mapping
{
    public class FeatureMapping: Profile
    {
        public FeatureMapping() {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
        }
    }
}
