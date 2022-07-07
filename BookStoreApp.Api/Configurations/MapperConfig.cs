using AutoMapper;
using BookStoreApp.Api.Data;
using BookStoreApp.Api.Dtos;

namespace BookStoreApp.Api.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorDto, Author>().ReverseMap();
        }
    }
}
