using KLWalks.API.Data;
using KLWalks.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace KLWalks.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly KLWalksDbContext kLWalksDbContext;

        public RegionRepository(KLWalksDbContext kLWalksDbContext)
        {
            this.kLWalksDbContext = kLWalksDbContext;
        }
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
           return await kLWalksDbContext.Regions.ToListAsync();
        }
    }
}
