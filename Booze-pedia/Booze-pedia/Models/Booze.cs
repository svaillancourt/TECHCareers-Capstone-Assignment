//Models class for liquor databse schema 
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Booze_pedia.Models
{
    public class Booze
    {   //id
        public int Id { get; set; }

        // Name
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        // Category
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Category { get; set; }

        // Description
        [StringLength(250, MinimumLength = 3)]
        public string Description { get; set; }

        //Quantity
        [Required]
        [Range(0, 100)]
        public int Quantity { get; set; }

        // Price
        [Required]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        // In-Stock
        [Required]
        [DisplayName("In Stock")]
        public bool InStock { get; set; }

        // Picture Name
        [DisplayName("Picture Name")]
        public string PictureName { get; set; }

        // Picture File Path
        [NotMapped]
        [DisplayName("")]
        public IFormFile PictureFile { get; set; }
    }
}
