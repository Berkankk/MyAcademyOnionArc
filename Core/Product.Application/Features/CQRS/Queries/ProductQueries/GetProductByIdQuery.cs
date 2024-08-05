using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Features.CQRS.Queries.ProductQueries
{
    public class GetProductByIdQuery
    {
        public int ID { get; set; }

        public GetProductByIdQuery(int iD)
        {
            ID = iD;
        }
    }
}
