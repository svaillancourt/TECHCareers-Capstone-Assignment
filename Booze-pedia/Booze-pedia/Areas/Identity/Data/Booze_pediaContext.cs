using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booze_pedia.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

/*
 * Identity Implication:
 * https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-3.1&tabs=visual-studio#pw
 * https://www.youtube.com/watch?v=CzRM-hOe35o
 */

namespace Booze_pedia.Data
{
    public class Booze_pediaContext : IdentityDbContext<Booze_pediaUser>
    {
        public Booze_pediaContext(DbContextOptions<Booze_pediaContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
