using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Models
{
    public static class GrupsHasAlumnesOrm
    {
        public static List<grups_has_alumnes> Select(int id)
        {
            List<grups_has_alumnes> _GrupsAlumnes = Orm.bd.grups_has_alumnes
                                    .Where(c => c.grups_id == id)
                                    .ToList();
            return _GrupsAlumnes;
        }

        public static String Insert(grups_has_alumnes _grups_alumnes)
        {
            Orm.bd.grups_has_alumnes.Add(_grups_alumnes);
            String missatge = Orm.MySaveChanges();
            return missatge;
        }

    }
}
