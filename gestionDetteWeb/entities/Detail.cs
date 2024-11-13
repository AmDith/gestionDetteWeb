using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace gestionDette.ism.entities
{
    public class Detail : AbstractEntity
    {
        private double Somme { get; set; }
        private int QteVendu { get; set; }
        private Dette Dette { get; set; }
        private Article Article { get; set; }
        private static int NbreDE { get; set; }

        public Detail()
        {
            Id = ++NbreDE;
        }
    }
}
