using AutoMapper;
using MediatR;
using Product.Application.Features.Mediator.Commands.CustomerCommands;
using Product.Application.Interfaces;
using Product.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Features.Mediator.Handlers.CustomerHandlers
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Customer> _repository;

        public UpdateCustomerCommandHandler(IMapper mapper, IRepository<Customer> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var mappedvalue = _mapper.Map<Customer>(request);
            await _repository.UpdateAsync(mappedvalue);
          
            
        }
    }
}
