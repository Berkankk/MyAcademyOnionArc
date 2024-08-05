using AutoMapper;
using Product.Application.Features.CQRS.Commands.CategoryCommands;
using Product.Application.Features.CQRS.Commands.ProductCommand;
using Product.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateProductCommand command)  //Geriye veri dönmediği için task yazdık
        {
            var product = _mapper.Map<Domain.Entities.Product>(command);
            await _repository.UpdateAsync(product);

        }
    }
}
