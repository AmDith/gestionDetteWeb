using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDette.ism.entities
{
    public class Article : AbstractEntity
    {
        public string Reference { get; set; }
        public string Libelle { get; set; }
        public double Prix { get; set; }
        public int QteStock { get; set; }
        public List<Detail> Details { get; } = new List<Detail>();
        public static int NbreA { get; set; }
        public List<Demande> Demandes { get; } = new List<Demande>();

        public Article()
        {
            Id = ++NbreA;
        }

        public void AddDetails(Detail detail)
        {
            Details.Add(detail);
        }

        public void AddDemande(Demande demande)
        {
            Demandes.Add(demande);
        }

        // Getters et Setters
        //public string Reference
        //{
        //    get { return Reference; }
        //    set { Reference = value; }
        //}

        //public string Libelle
        //{
        //    get { return Libelle; }
        //    set { Libelle = value; }
        //}

        //public double Prix
        //{
        //    get { return Prix; }
        //    set { Prix = value; }
        //}

        //public int QteStock
        //{
        //    get { return QteStock; }
        //    set { QteStock = value; }
        //}

        //public List<Detail> Details
        //{
        //    get { return Details; }
        //    set { Details = value; }
        //}

        //public List<Demande> Demandes
        //{
        //    get { return Demandes; }
        //    set { Demandes = value; }
        //}

        // Méthode ToString
        public override string ToString()
        {
            return $"Article[Reference={Reference}, Libelle={Libelle}, Prix={Prix}, QteStock={QteStock}]";
        }

        // Méthode Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Article other = (Article)obj;
            return Reference == other.Reference && Libelle == other.Libelle &&
                   Prix == other.Prix && QteStock == other.QteStock;
        }




    }
}
