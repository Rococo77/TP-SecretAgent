using Microsoft.EntityFrameworkCore;
using Rossetto.RG.Dal.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rossetto.RG.Dal.DAL
{
    public class RossettoDbContext : DbContext, IRossettoDbContext
    {
        public DbSet<Espions> Espions { get; set; }
        public DbSet<Missions> Missions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Port=3306;Database=TPFinalCSharp;Uid=root;Pwd=;";
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 34));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}
