using GraphQL_Demo.Data;
using GraphQL_Demo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_Demo.GqlTypes
{
    public class QueryType
    {
        public async Task<List<Product>> AllProductsAsync([Service] GraphQlDbcontext context)
        {
            return await context.Product.ToListAsync();
        }

        
    }
}
