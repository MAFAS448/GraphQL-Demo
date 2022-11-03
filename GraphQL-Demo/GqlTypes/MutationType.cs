using GraphQL_Demo.Data;
using GraphQL_Demo.Data.Entities;

namespace GraphQL_Demo.GqlTypes
{
    public class MutationType
    {
        public async Task<Product> SaveProductAsync([Service] GraphQlDbcontext context,Product newProduct)
        {
            context.Product.Add(newProduct);
            await context.SaveChangesAsync();
            return newProduct;
        }

        public async Task<Product> UpdateProductAsync([Service] GraphQlDbcontext context, Product updateProduct)
        {
            context.Product.Update(updateProduct);
            await context.SaveChangesAsync();
            return updateProduct;
        }

        public async Task<string> DeleteProductAsync([Service] GraphQlDbcontext context, int id)
        {
            var deleteProduct = await context.Product.FindAsync(id);
            if(deleteProduct == null)
            {
                return "invalid Operation";
            }
            context.Product.Remove(deleteProduct);
            await context.SaveChangesAsync();
            return "Deleted!";
        }
    }
}
