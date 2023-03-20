﻿

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineRetailManagementSystem.Models
{
    public class ProductsInCart
    {
     
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductInCartId { get; set; }
        [Required]
        [ForeignKey("cart")]
        public int CartId { get; set; }
        [Required]
        [ForeignKey("product")]
        public int ProductId { get; set; }
        [Required]
        public long TotalPrice { get; set; }
        public Cart cart { get; set; }
        public Product product { get; set; }


    }
}
