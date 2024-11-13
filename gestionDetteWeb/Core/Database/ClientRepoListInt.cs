using gestionDette.ism.entities;
using gestionDetteWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDetteWeb.Core.Database
{
    public interface ClientRepoListInt : Repository<Client>
    {
        Client? SelectByPhone(string phone);
        Client? SelectBySurname(string val);
    }
}
