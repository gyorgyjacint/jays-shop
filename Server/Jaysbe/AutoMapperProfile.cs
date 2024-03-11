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
        CreateMap<ProductRequestDto, Product>().ReverseMap();
        CreateMap<Product, ProductResponseDto>();
        CreateMap<IdentityUser, UserDto<Guid>>();
        CreateMap<Category, CategoryResponse>().ReverseMap();
        CreateMap<Category, CategoryParentInfo>();
    }
}