using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using BlackFiance.Service.DigitalAssets.Models;

namespace BlackFiance.Service.DigitalAssets.Data
{
    public interface IDigitalAssetsDbContext
    {
        DbSet<DigitalAsset> DigitalAssets { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
