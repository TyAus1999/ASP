using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlAltPC.Models
{
    public partial class Product
    {
        public Product()
        {
            Cart = new HashSet<Cart>();
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(255)]
        [Display(Name="Product Name")]
        public string Name { get; set; }
        [StringLength(8000)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        [Range(0,999999,ErrorMessage = "Price must be between 0 and 999,999")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }
        [StringLength(255)]
        public string Photo { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [InverseProperty("Product")]
        public Category Category { get; set; }
        [InverseProperty("Product")]
        public ICollection<Cart> Cart { get; set; }
        [InverseProperty("Product")]
        public ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
