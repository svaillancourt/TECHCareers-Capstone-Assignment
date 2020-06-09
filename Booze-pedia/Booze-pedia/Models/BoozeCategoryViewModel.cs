//Model for filtering liquor list through category of liquor.
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booze_pedia.Models
{
    public class BoozeCategoryViewModel
    {   // List for liquor which we need to pass through category
        public List<Booze> Boozes { get; set; }
        // Select list of categories.
        public SelectList Category { get; set; }
        // Comparizon string for Liquor category
        public string BoozeCategory { get; set; }
        // String variable for Search String by name and description
        public string SearchString { get; set; }
        // Boolean variable for instock filtering.
        public bool InStockSearchString { get; set; }
    }
}
