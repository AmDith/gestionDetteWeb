using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionDette.ism.enums;

namespace gestionDette.ism.entities
{
    public class Demande : AbstractEntity
    {
        private EtatDeDemande EtatDeDemande { get; set; }
        private Client Client { get; set; }
        private static int NbreDEM { get; set; }
        private List<Article> Articles { get; set; } = new List<Article>();

        public Demande()
        {
            Id = ++NbreDEM;
        }
    }
}
