﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace OnlineRetailManagementSystem.Models
{
    public class Cart
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int CartId { get; set; }
        [Required]
        [ForeignKey("user")]
        public String Email { get; set; }
        [Required]
        bool Status { get; set; }
        public ICollection<ProductsInCart> ProductsInCart { get; set; }
        public ICollection<Orders> orders { get; set; }
        public User user { get; set; }


    }
}
