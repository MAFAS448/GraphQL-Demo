using GraphQL_Demo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_Demo.Data
{
    public class GraphQlDbcontext: DbContext
    {
        public GraphQlDbcontext(DbContextOptions<GraphQlDbcontext> options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }
        
    }
}
