using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace GroovyMail.Data
{
    internal class DB_Base(string dbFileName, string dbSubfolder) : 
        DbContext
    {
        public string DbFileName { get; set; } = dbFileName;
        public string DbSubFolder { get; set; } = dbSubfolder;
        public string DbFullPath { get; set; } = string.Empty;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DbFullPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                DbSubFolder,
                DbFileName );
            optionsBuilder.UseSqlite($"Data Source={DbFullPath}");
        }
    }
}
