namespace Eco.Products.Repositories;

public class ProductsRepository : IProductsRepository
{
    public ProductsResponse GetProducts()
    {
        ProductsResponse? productsResponse = JsonHelper<ProductsResponse>.DecodeJsonData("src/data/products.json");
        
        if (productsResponse == null) throw new Exception("Nullable");

        return productsResponse;
    }
}