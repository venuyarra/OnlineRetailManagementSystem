
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineRetailManagementSystem.Models
{
    public class Product
    {
        [Required]
        public string productname { get; set; }
        [Required]
        public string productdescription { get; set; }
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
      
        public int productid { get; set; }
        [Required]
        public double productprice { get; set; }
        [Required]
        public string url { get; set; }
        [Required]
        public bool status { get; set; }
        public ICollection<ProductsInCart> productincart { get; set; }
        
    }
}
