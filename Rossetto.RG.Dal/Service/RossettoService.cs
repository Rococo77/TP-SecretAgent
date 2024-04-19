using Rossetto.RG.Dal.DAL;
using Rossetto.RG.Dal.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rossetto.RG.Dal.Service
{
    public class RossettoService : IRossettoService
    {
        private IRossettoDbContext _rossettoDbContext;

        public RossettoService(IRossettoDbContext rossettoDbContext)
        {
            _rossettoDbContext = rossettoDbContext;
        }

        public void AddEspion(string nom, string nomCode)
        {
            var espion = new Espions { Nom = nom, NomCode = nomCode };
            _rossettoDbContext.Espions.Add(espion);
            _rossettoDbContext.SaveChanges();
        }

        public void EditEspion(int id, string nom, string nomCode)
        {
            var espion = _rossettoDbContext.Espions.Find(id);
            espion.Nom = nom;
            espion.NomCode = nomCode;
            _rossettoDbContext.SaveChanges();
        }
        public void DeleteEspion(int id)
        {
            var espion = _rossettoDbContext.Espions.Find(id);
            _rossettoDbContext.Espions.Remove(espion);
            _rossettoDbContext.SaveChanges();
        }

        public void AddMission(string lieu, int annee)
        {
            var mission = new Missions { Lieu = lieu, Annee = annee };
            _rossettoDbContext.Missions.Add(mission);
            _rossettoDbContext.SaveChanges();
        }
        public void EditMission(int id, string lieu, int annee)
        {
            var mission = _rossettoDbContext.Missions.Find(id);
            mission.Lieu = lieu;
            mission.Annee = annee;
            _rossettoDbContext.SaveChanges();
        }
        public void DeleteMission(int id)
        {
            var mission = _rossettoDbContext.Missions.Find(id);
            _rossettoDbContext.Missions.Remove(mission);
            _rossettoDbContext.SaveChanges();
        }

        public void AddMissionToEspion(int missionId, int espionId)
        {
            var espion = _rossettoDbContext.Espions.Find(espionId);
            var mission = _rossettoDbContext.Missions.FirstOrDefault(m => m.Id == missionId && m.EspionId == null);

            if (espion != null && mission != null)
            {
                mission.EspionId = espionId;
                _rossettoDbContext.SaveChanges();
            }
        }
        public void ImportEspionsFromFichier(string url)
        {
            var lignes = File.ReadAllLines(url);
            foreach (var ligne in lignes)
            {
                var donnees = ligne.Split(';');
                if (donnees.Length == 2)
                {
                    AddEspion(donnees[0].Trim(), donnees[1].Trim());
                }
            }
        }







    }
}
