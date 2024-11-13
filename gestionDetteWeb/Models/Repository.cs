using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDetteWeb.Models
{
    public interface Repository <A>
    {
        int Insert(A amour);
        List<A> SelectAll();
        void Delete(int id);
        void Update(A amour);
        A? SelectById(int id);
    }
}
