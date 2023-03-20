
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineRetailManagementSystem.Models
{
    public class Orders
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int OrderId { get; set; }
        [Required]
        [ForeignKey("cart")]
        public int CartId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public long totalprice { get; set; }
        public Cart cart { get; set; }

    
    }
}
