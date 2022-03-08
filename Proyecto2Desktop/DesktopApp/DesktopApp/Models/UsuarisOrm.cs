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

        public static String Insert(usuaris _usuaris)
        {
            Orm.bd.usuaris.Add(_usuaris);
            String missatge = Orm.MySaveChanges();
            return missatge;
        }
    }
}
