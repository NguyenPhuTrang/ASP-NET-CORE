using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MobilePhone.Areas.Identity.Data;
using MobilePhone.Data;

[assembly: HostingStartup(typeof(MobilePhone.Areas.Identity.IdentityHostingStartup))]
namespace MobilePhone.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MobilePhoneContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MobilePhoneContextConnection")));

                services.AddDefaultIdentity<MobilePhoneUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MobilePhoneContext>();
            });
        }
    }
}