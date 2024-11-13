using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDette.ism.entities
{
    public class Paiement : AbstractEntity
    {
        private double Montant { get; set; }
        private Dette Dette { get; set; }
        private static int NbreP { get; set; }

        public Paiement()
        {
            Id = ++NbreP;
        }
    }
}
