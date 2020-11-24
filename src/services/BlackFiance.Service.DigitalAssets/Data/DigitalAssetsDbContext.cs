using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using BlackFiance.Service.DigitalAssets.Models;

namespace BlackFiance.Service.DigitalAssets.Data
{
    public class DigitalAssetsDbContext: DbContext, IDigitalAssetsDbContext
    {
        public DigitalAssetsDbContext(DbContextOptions options)
            :base(options) { }

        public static readonly ILoggerFactory ConsoleLoggerFactory
            = LoggerFactory.Create(builder => { builder.AddConsole(); });

        public DbSet<DigitalAsset> DigitalAssets { get; private set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
