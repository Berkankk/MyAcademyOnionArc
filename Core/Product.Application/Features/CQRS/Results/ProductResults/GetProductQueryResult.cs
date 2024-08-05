using Product.Application.Features.CQRS.Results.CategoryResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Features.CQRS.Results.ProductResults
{
    public class GetProductQueryResult
    {

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public int CategoryID { get; set; }
        public GetCategoryQueryResult Category { get; set; }
    }
}
