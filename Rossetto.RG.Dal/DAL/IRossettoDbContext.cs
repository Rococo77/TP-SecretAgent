using Microsoft.EntityFrameworkCore;
using Rossetto.RG.Dal.Modele;

namespace Rossetto.RG.Dal.DAL
{
    public interface IRossettoDbContext
    {
        DbSet<Espion> Espions { get; set; }
        DbSet<Mission> Missions { get; set; }

        List<Espion> GetAllEspions();


        int SaveChanges();
    }
}