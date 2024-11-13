using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDette.ism.entities
{
    public class AbstractEntity
    {
        public int Id { get; set; }
        protected DateTime DateCreate { get; set; }
        protected DateTime DateUpdate { get; set; }
        protected int Usercreate { get; set; }
        protected int Userupdate { get; set; }

        public int GetUsercreate()
        {
            return Usercreate;
        }

        public void SetDateUpdate(DateTime dateUpdate)
        {
            this.DateUpdate = dateUpdate;
        }

        public void SetDateCreate(DateTime dateCreate)
        {
            this.DateCreate = dateCreate;
        }

        public int GetUserupdate()
        {
            return Userupdate;
        }
    }
}
