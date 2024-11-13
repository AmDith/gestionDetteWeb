using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDetteWeb.Core.Database
{
    public interface Views <T, A>
    {
        T Created(A michel);
        void Affiche(List<T> datas);
    }
}
