using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Models
{
    public static class GrupsHasDocentsOrm
    {
        public static List<grups_has_docents> Select(int id) 
        {
            List<grups_has_docents> _GrupsDocents = Orm.bd.grups_has_docents
                                    .Where(c => c.grups_id == id)
                                    .ToList();
            return _GrupsDocents;
        }

        public static List<grups_has_docents> SelectGroupOfUser(int id)
        {
            List<grups_has_docents> _GrupsDocents = Orm.bd.grups_has_docents
                                    .Where(c => c.usuaris_id == id)
                                    .ToList();
            return _GrupsDocents;
        }




        public static String Insert(grups_has_docents _grups_docents)
        {
            Orm.bd.grups_has_docents.Add(_grups_docents);
            String missatge = Orm.MySaveChanges();
            return missatge;
        }


        public static String Delete(grups_has_docents _grups_docents) 
        {
            Orm.bd.grups_has_docents.Remove(_grups_docents);
            String missatge = Orm.MySaveChanges();
            return missatge;
        }


    }
}
