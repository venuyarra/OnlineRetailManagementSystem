using OnlineRetailManagementSystem.Models;

namespace OnlineRetailManagementSystem.Repsository
{
    interface IadminRepository
    {
        Boolean AddProductId(Product product);
        Boolean DeleteProductId(Product product);
        Boolean UpdateProductId(Product product);
        List<Product> GetAllProducts();
        List<Orders> GetAllOrders();
       
    }
}
