using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Booze_pedia.Models
{
    public class Booze
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Minimum of 3 characters or max  of 30", MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Minimum of 3 characters or max  of 20", MinimumLength = 3)]
        public string Category { get; set; }
        [StringLength(250, ErrorMessage = "Minimum of 3 characters or max  of 250", MinimumLength = 3)]
        public string Description { get; set; }
        [Required]
        [Range(0, 100)]
        public int Quantity { get; set; }
        [Required]
        [Range(0, 999.99)]
        public decimal Price { get; set; }
        [Required]
        public bool InStock { get; set; }
    }
}
