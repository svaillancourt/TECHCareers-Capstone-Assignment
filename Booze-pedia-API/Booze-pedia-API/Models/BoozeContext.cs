using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Booze_pedia_API.Models
{
    public class BoozeContext : DbContext
    {
        public BoozeContext(DbContextOptions<BoozeContext> options) : base(options)
        {
        }
        public DbSet<BoozeItem> BoozeItems { get; set; }
    }
}
