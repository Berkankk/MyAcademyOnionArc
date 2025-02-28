﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Features.Mediator.Commands.CustomerCommands
{
    public class CreateCustomerCommand : IRequest  //Request işlemi ancak dönüş tipi yok
    {
        public string NameSurname { get; set; }
        public string Email { get; set; }
    }
}
