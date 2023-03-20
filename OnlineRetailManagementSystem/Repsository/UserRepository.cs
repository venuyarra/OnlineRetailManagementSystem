using OnlineRetailManagementSystem.Models;

namespace OnlineRetailManagementSystem.Repsository
{
    public class UserRepository : IuserRepository
    {
        public bool AddProductstoOrders(Orders orders)
        {
            throw new NotImplementedException();
        }

        public bool AddProducttoCart(Product product)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProductFromCart(ProductsInCart productincart)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProductsByName(string ProductName)
        {
            throw new NotImplementedException();
        }
    }
}
