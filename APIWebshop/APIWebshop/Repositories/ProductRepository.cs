namespace APIWebshop.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProducts();
        Task<Product?> FindProductById(int productId);
        Task<Product?> CreateProduct(Product product);
        Task<Product?> DeleteProductById(int productId);
        Task<Product?> UpdateProductById(int productId, Product product);
    }
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext _context;

        public ProductRepository(DatabaseContext context)
        {
            _context = context;
        }

        // READ!
        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Product.ToListAsync(); // use include for foreign key connections here
        }

        public async Task<Product?> FindProductById(int productId)
        {
            return await _context.Product.FirstOrDefaultAsync(i => i.Id == productId); // use include for foreign key connections here
        }

        // Create
        public async Task<Product> CreateProduct(Product newProduct)
        {
            _context.Product.Add(newProduct);
            await _context.SaveChangesAsync();
            return newProduct;
        }

        // Delete
        public async Task<Product?> DeleteProductById(int productId)
        {
            var product = await FindProductById(productId);

            if (product != null)
            {
                _context.Remove(product);
                await _context.SaveChangesAsync();
            }

            return product;
        }

        // Update
        public async Task<Product?> UpdateProductById(int productId, Product updateProduct)
        {
            var product = await FindProductById(productId);

            if (product != null)
            {
                product.Name = updateProduct.Name;
                product.Price = updateProduct.Price;
                product.Type = updateProduct.Type;

                await _context.SaveChangesAsync();
            }
            return product;
        }
        //test
    }
}
