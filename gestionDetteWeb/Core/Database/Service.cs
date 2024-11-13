using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace gestionDetteWeb.Core.Database
{
    public interface Service<T, A>
    {
        bool SaveList(T objet);
        List<T> Show();
        A FindData();
    }
}

