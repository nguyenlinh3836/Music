﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MusicWorld.Data;

[assembly: HostingStartup(typeof(MusicWorld.Areas.Identity.IdentityHostingStartup))]
namespace MusicWorld.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IndetityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("IndetityContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options =>
                {
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireDigit = false;
                    options.SignIn.RequireConfirmedAccount = false;
                }).AddRoles<IdentityRole>()             
                  .AddEntityFrameworkStores<IndetityContext>();
            });
        }
    }
}