using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booze_pedia.Models;

namespace Booze_pedia.Data
{
    public class BoozeContext :DbContext
    {
        public BoozeContext(DbContextOptions<BoozeContext> options)
           : base(options)
        {
        }

        // liquor context DB booze context which extends DBContext 
        public DbSet<Booze> Booze { get; set; }
    }
}
