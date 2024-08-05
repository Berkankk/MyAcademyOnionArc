using Product.Application.Features.CQRS.Commands.CategoryCommands;
using Product.Application.Interfaces;
using Product.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;

        public CreateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCategoryCommand categoryCommand)
        {
            var category = new Category
            {
                CategoryName = categoryCommand.CategoryName
            };
            await _repository.CreateAsync(category);
        }
    }
}
