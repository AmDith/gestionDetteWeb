using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionDette.ism.enums;

namespace gestionDette.ism.entities
{
    public class User : AbstractEntity
    {
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Etat Etat { get; set; }
        public Role Role { get; set; }
        public Client Client { get; set; }
        public static int NbreU { get; set; }


        public User()
        {
            Id = ++NbreU;
        }
    }
}
