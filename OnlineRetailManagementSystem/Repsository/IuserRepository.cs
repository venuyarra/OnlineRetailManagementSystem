using OnlineRetailManagementSystem.Models;

namespace OnlineRetailManagementSystem.Repsository
{
    interface IuserRepository
    {
        List<Product> GetAllProductsByName(string ProductName);
        Boolean AddProducttoCart(Product product);
        Boolean AddProductstoOrders(Orders orders);
        Boolean DeleteProductFromCart(ProductsInCart productincart);

    }
}
