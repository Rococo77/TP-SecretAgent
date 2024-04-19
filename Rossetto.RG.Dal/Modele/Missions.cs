using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rossetto.RG.Dal.Modele
{
    public class Missions
    {
        public int Id { get; set; }
        public string Lieu { get; set; }
        public int Annee { get; set; }
        public int? EspionId { get; set; }
        public Espions Espion { get; set; }

    }
}
