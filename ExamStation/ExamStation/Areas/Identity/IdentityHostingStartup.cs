﻿using System;
using ExamStation.Areas.Identity.Data;
using ExamStation.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(ExamStation.Areas.Identity.IdentityHostingStartup))]
namespace ExamStation.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ExamStationDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ExamStationDbContextConnection")));

                services.AddDefaultIdentity<ExamStationUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                })
                    .AddEntityFrameworkStores<ExamStationDbContext>();
            });
        }
    }
}