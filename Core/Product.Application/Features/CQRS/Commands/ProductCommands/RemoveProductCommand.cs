﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Features.CQRS.Commands.ProductCommands
{
    public class RemoveProductCommand(int id)
    {
        public int ID { get; set; } = id;

      
    }
}
