using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionDette.ism.enums;

namespace gestionDette.ism.entities
{
    public class Dette : AbstractEntity
    {
        public double Montant { get; set; }
        public double MontantVerser { get; set; }
        public double MontantRestant { get; set; }
        public EtatDette Etat { get; set; }
        public Client Client { get; set; }
        public List<Detail> Details { get; } = new List<Detail>();
        public List<Paiement> Paiements { get; } = new List<Paiement>();
        public static int NbreD { get; set; }


        public Dette()
        {
            Id = ++NbreD;
        }



        public void AddDetails(Detail detail)
        {
            Details.Add(detail);
        }

        public void AddPaiement(Paiement paiement)
        {
            Paiements.Add(paiement);
        }


    }
}
