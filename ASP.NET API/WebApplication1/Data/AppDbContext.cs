using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<RAM> RAMs { get; set; }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Models.Monitor> Monitors { get; set; }
        public DbSet<Mouse> Mouses { get; set; }
        public DbSet<Keyboard> Keyboards { get; set; }

        public DbSet<Types> Types { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<CPUsocket> CPUsockets { get; set; }
        public DbSet<DDRtype> DDRtypes { get; set; }
        public DbSet<GDDRtype> GDDRtypes { get; set; }
        public DbSet<PeriferialConnectionType> PeriferialConnectionTypes { get; set; }
        public DbSet<KeyboardType> KeyboardTypes { get; set; }
        public DbSet<KeyboardLayout> KeyboardLayouts { get; set; }
        public DbSet<KeyboardSize> KeyboardSizes { get; set; }
        public DbSet<ScreenSync> ScreenSyncs { get; set; }
        public DbSet<ScreenSyncType> ScreenSyncTypes { get; set; }
        public DbSet<StorageConnectionType> StorageConnectionTypes { get; set; }
        public DbSet<StorageType> StorageTypes { get; set; }
        public DbSet<CoreNumber> CoreNumbers { get; set; }
        public DbSet<ThreadNumber> ThreadNumbers { get; set; }
        public DbSet<OverclockPreset> OverclockPresets { get; set; }
        public DbSet<RAMkit> RamKits { get; set; }
        public DbSet<MonitorType> MonitorTypes { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
