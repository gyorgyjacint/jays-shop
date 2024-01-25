using AutoMapper;
using Jaysbe.Contracts;
using Jaysbe.Dtos;
using Jaysbe.Models;
using Microsoft.AspNetCore.Identity;

namespace Jaysbe;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ProductRequest, Product>().ReverseMap();
        CreateMap<Product, ProductResponse>();
        CreateMap<IdentityUser, User<Guid>>();
    }
}