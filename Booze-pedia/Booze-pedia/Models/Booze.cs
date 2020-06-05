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
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Category { get; set; }

        [StringLength(250, MinimumLength = 3)]
        public string Description { get; set; }

        [Required]
        [Range(0, 100)]
        public int Quantity { get; set; }

        [Required]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Required]
        [DisplayName("In Stock")]
        public bool InStock { get; set; }

        [DisplayName("Picture Name")]
        public string PictureName { get; set; }

        [NotMapped]
        [DisplayName("")]
        public IFormFile PictureFile { get; set; }
    }
}
