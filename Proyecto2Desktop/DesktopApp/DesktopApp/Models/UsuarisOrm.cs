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

        internal static object SelectByName(string text)
        {
            List<usuaris> _usuaris = Orm.bd.usuaris
                            .Where(c => c.nom.Contains(text))
                            .ToList();
            //List<usuaris> _usuaris = (from u in Orm.bd.usuaris
                                      //join r in Orm.bd.rols on u.rols_id equals r.id
                                     // select u).ToList();
            return _usuaris;
        }
    }
}
