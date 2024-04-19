using Microsoft.EntityFrameworkCore;
using Rossetto.RG.Dal.Modele;

namespace Rossetto.RG.Dal.DAL
{
    public interface IRossettoDbContext
    {
        DbSet<Espions> Espions { get; set; }
        DbSet<Missions> Missions { get; set; }
        int SaveChanges();
    }
}