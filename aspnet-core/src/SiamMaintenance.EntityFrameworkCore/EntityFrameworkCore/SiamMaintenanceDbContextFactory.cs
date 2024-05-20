using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SiamMaintenance.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class SiamMaintenanceDbContextFactory : IDesignTimeDbContextFactory<SiamMaintenanceDbContext>
{
    public SiamMaintenanceDbContext CreateDbContext(string[] args)
    {
        SiamMaintenanceEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<SiamMaintenanceDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new SiamMaintenanceDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SiamMaintenance.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
