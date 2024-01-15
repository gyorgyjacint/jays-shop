using AutoMapper;
using Jaysbe.Contracts;
using Jaysbe.Models;

namespace Jaysbe;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ProductRequest, Product>().ReverseMap();
    }
}