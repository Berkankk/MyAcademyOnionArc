using AutoMapper;
using MediatR;
using Product.Application.Features.Mediator.Queries.CustomerQueries;
using Product.Application.Features.Mediator.Results.CustomerResults;
using Product.Application.Interfaces;
using Product.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Features.Mediator.Handlers.CustomerHandlers
{
    public class GetCustormerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, GetCustomerByIdQueryResult>
    {
        private readonly IRepository<Customer> _repository;
        private readonly IMapper _mapper;
        public GetCustormerByIdQueryHandler(IRepository<Customer> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetCustomerByIdQueryResult> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            return _mapper.Map<GetCustomerByIdQueryResult>(value);
        }
    }
}
