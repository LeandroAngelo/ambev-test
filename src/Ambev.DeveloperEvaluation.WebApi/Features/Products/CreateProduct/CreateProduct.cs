using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Products.CreateProduct;


namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;

public class CreateProduct : Profile
{
    public CreateProduct()
    {
        CreateMap<CreateProductRequest, CreateProductCommand>()           
         .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating));

        CreateMap<CreateProductResult, CreateProductResponse>();

    }
}
