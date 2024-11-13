using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace gestionDette.ism.entities
{
    public class Client : AbstractEntity
    {
        public string Nom { get; set; }
        public string Tel { get; set; }
        public string Adresse { get; set; }
        public User User { get; set; }
        public List<Dette> Dettes { get; } = new List<Dette>();
        public List<Demande> Demandes { get; } = new List<Demande>();
        public static int NbreC { get; set; }

        public Client()
        {
            Id = ++NbreC;
        }


        public void AddDette(Dette dette)
        {
            Dettes.Add(dette);
        }

        public void AddDemande(Demande demande)
        {
            Demandes.Add(demande);
        }
    }
}
