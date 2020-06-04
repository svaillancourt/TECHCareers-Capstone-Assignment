using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booze_pedia.Models
{
    public class BoozeCategoryViewModel
    {
        public List<Booze> Boozes { get; set; }
        public SelectList Category { get; set; }
        public string BoozeCategory { get; set; }
        public string SearchString { get; set; }
    }
}
