using MediatR;
using Product.Application.Features.Mediator.Results.CustomerResults;
using Product.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Features.Mediator.Queries.CustomerQueries
{
    public class GetCustomerByIdQuery :IRequest<GetCustomerByIdQueryResult>
    {
        public int ID { get; set; }

        public GetCustomerByIdQuery(int iD)
        {
            ID = iD;
        }
    }
}
