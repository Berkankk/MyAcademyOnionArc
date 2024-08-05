using AutoMapper;
using Product.Application.Features.CQRS.Commands.ProductCommand;
using Product.Application.Features.CQRS.Commands.ProductCommands;
using Product.Application.Features.CQRS.Results.CategoryResults;
using Product.Application.Features.CQRS.Results.ProductResults;
using Product.Application.Features.Mediator.Commands.CustomerCommands;
using Product.Application.Features.Mediator.Results.CustomerResults;
using Product.Domain.Entities;

namespace Product.WebUI.Mappings
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<GetProductQueryResult, Domain.Entities.Product>().ReverseMap();
            CreateMap<GetProductByIdQueryResult, Domain.Entities.Product>().ReverseMap();
            CreateMap<UpdateProductCommand, Domain.Entities.Product>().ReverseMap();
            CreateMap<CreateProductCommand, Domain.Entities.Product>().ReverseMap();
            CreateMap<RemoveProductCommand, Domain.Entities.Product>().ReverseMap();

            CreateMap<Category, GetCategoryQueryResult>().ReverseMap();

            CreateMap<Customer, GetCustomerQueryResult>().ReverseMap();
            CreateMap<Customer, CreateCustomerCommand>().ReverseMap();
            CreateMap<Customer, GetCustomerByIdQueryResult>().ReverseMap();
            CreateMap<Customer, UpdateCustomerCommand>().ReverseMap();


        }
    }
}
