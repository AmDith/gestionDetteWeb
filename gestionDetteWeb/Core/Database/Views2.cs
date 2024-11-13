using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDetteWeb.Core.Database
{
    public interface Views2<T>
    {
        T Created();
        void Affiche(List<T> datas);
    }
}
