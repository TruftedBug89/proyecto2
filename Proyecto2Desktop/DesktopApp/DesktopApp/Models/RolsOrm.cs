using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Models
{
    public static class RolsOrm
    {
        public static List<rols> Select()
        {
            List<rols> listaRols = Orm.bd.rols.ToList();

            return listaRols;
        }

        public static String Insert(rols _rol) {
            Orm.bd.rols.Add(_rol);
            String missatge = Orm.MySaveChanges();
            return missatge;
        }

        public static String Delete(rols _rols) { 
            
                String missatge = "";
                Orm.bd.rols.Remove(_rols);
                missatge = Orm.MySaveChanges();
                return missatge;
            
        }


    }
}
