using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Features.Mediator.Commands.CustomerCommands
{
    public class RemoveCustomerCommand : IRequest
    {
        public int ID { get; set; }

        public RemoveCustomerCommand(int iD)
        {
            ID = iD;
        }
    }
}
