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
        public DbSet<Espion> Espions { get; set; }
        public DbSet<Mission> Missions { get; set; }

        public List<Espion> GetAllEspions()
        {
            return Espions.ToList();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Port=3306;Database=TPFinalCSharp;Uid=root;Pwd=;";
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 34));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}
