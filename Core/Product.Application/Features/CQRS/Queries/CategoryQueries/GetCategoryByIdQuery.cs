using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Features.CQRS.Queries.CategoryQueries
{
    public class GetCategoryByIdQuery
    {
        public int ID { get; set; }

        public GetCategoryByIdQuery(int iD)
        {
            ID = iD;
        }
    }
}
