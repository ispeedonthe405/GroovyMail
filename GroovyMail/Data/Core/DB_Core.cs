using Microsoft.EntityFrameworkCore;

namespace GroovyMail.Data.Core
{
    internal class DB_Core_Context : DbContext
    {
        public string DbFullPath { get; set; } = string.Empty;
        public DbSet<DB_Core> Data { get; set; }

        public DB_Core_Context(string dbFullPath)
        {
            DbFullPath = dbFullPath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbFullPath}");
        }
    }

    internal class DB_Core
    {
        
    }
}
