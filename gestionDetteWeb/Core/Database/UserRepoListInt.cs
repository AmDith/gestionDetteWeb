using gestionDette.ism.entities;
using gestionDetteWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDetteWeb.Core.Database
{
    public interface UserRepoListInt : Repository<User>
    {
        string Login(string val);
        User SelectByLogin(string val);
        User SelectByPassord(string val);
        User SelectByEmail(string val);
    }
}
