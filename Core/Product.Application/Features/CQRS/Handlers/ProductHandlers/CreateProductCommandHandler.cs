using AutoMapper;
using Product.Application.Features.CQRS.Commands.ProductCommand;
using Product.Application.Features.CQRS.Commands.ProductCommands;
using Product.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Handle(CreateProductCommand command)
        {
            var product = _mapper.Map<Domain.Entities.Product>(command);
            await _repository.CreateAsync(product);
        }
    }
}
