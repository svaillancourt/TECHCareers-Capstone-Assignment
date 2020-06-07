using System;
using Booze_pedia.Areas.Identity.Data;
using Booze_pedia.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Booze_pedia.Areas.Identity.IdentityHostingStartup))]
namespace Booze_pedia.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Booze_pediaContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Booze_pediaContextConnection")));

                services.AddDefaultIdentity<Booze_pediaUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<Booze_pediaContext>();
            });
        }
    }
}