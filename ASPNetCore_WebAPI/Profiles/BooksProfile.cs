using ASPNetCoreWebAPI.API.Helpers;
using ASPNetCoreWebAPI.API.Models;
using ASPNetCoreWebAPI.API.Persistence.Entities;
using AutoMapper;

namespace ASPNetCoreWebAPI.API.Profiles
{
    public class BooksProfile : Profile
    {
        public BooksProfile()
        {
            CreateMap<Book, BookDto>()
                .ForMember(
                    dest => dest.PublishedAge,
                    opt => opt.MapFrom(src => src.FirstPublished.GetPublishedAge()));
        }
    }
}
