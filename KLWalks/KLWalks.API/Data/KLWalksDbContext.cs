using KLWalks.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace KLWalks.API.Data
{
    public class KLWalksDbContext : DbContext
    {
        public KLWalksDbContext(DbContextOptions<KLWalksDbContext> options):base(options)
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
