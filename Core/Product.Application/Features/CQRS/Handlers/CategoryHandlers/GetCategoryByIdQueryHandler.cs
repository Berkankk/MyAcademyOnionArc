﻿using Product.Application.Features.CQRS.Queries.CategoryQueries;
using Product.Application.Features.CQRS.Results.CategoryResults;
using Product.Application.Interfaces;
using Product.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryByIdQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.ID);

            var category = new GetCategoryByIdQueryResult   //tek değer döndüğümüz için select işlemi yapmadık diğeri listeleme işlemi 
            {
                CategoryID = value.CategoryID,
                CategoryName = value.CategoryName
            };
            return category;
        }
    }
}
