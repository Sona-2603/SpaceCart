using System;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace SpaceCart.Data
{
    public static class SpaceCartDbContextFactory
    {
        public static SpaceCartDbContext Create()
        {
            var basePath = AppContext.BaseDirectory;

            var builder = new ConfigurationBuilder().SetBasePath(basePath).AddJsonFile("appsettings.json");

            var configuration = builder.Build();

            var build = new DbContextOptionsBuilder<SpaceCartDbContext>();
            build.UseMySQL(configuration.GetConnectionString("Default"));
            return new SpaceCartDbContext(build.Options);

        }
    }
}


