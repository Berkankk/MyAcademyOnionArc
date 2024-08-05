using Product.Application.Features.CQRS.Commands.ProductCommands;
using Product.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class RemoveProductCommandHandler(IProductRepository _repository)
    {
        public async Task Handle(RemoveProductCommand removeProduct)
        {
            await _repository.DeleteAsync(removeProduct.ID);
        }
    }
}
