using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Models
{
    public static class UsuarisOrm
    {
        public static List<usuaris> Select()
        {
            List<usuaris> _usuaris = Orm.bd.usuaris.ToList();

            return _usuaris;
        }

        public static usuaris SelectUsuari(int idUser)
        {
            usuaris _usuari = Orm.bd.usuaris
                            .Where(c => c.id == idUser)
                            .FirstOrDefault();
            return _usuari;
        }


    }
}
