using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Rossetto.RG.Dal.Modele
{
    public class Espion
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Nom { get; set; }
        [MaxLength(50)]
        public string NomCode { get; set; }

        public List<Mission> Missions { get; set; }


    }
}
