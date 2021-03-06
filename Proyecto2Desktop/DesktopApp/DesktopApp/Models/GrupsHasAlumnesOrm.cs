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

        public static List<grups_has_alumnes> SelectGroupOfUser(int id)
        {
            List<grups_has_alumnes> _GrupsAlumne = Orm.bd.grups_has_alumnes
                                    .Where(c => c.usuaris_id == id)
                                    .ToList();
            return _GrupsAlumne;
        }


        public static grups_has_alumnes SelectOne(int idGrup, int idUsuari)
        {
            grups_has_alumnes _grupAlumne = Orm.bd.grups_has_alumnes
                                        .Where(c => c.grups_id == idGrup)
                                        .Where(d => d.usuaris_id == idUsuari)
                                        .FirstOrDefault();
            return _grupAlumne;

        }




        public static String Insert(grups_has_alumnes _grups_alumnes)
        {
            Orm.bd.grups_has_alumnes.Add(_grups_alumnes);
            String missatge = Orm.MySaveChanges();
            return missatge;
        }


        public static String Delete(grups_has_alumnes _grups_alumnes)
        {
            Orm.bd.grups_has_alumnes.Remove(_grups_alumnes);
            String missatge = Orm.MySaveChanges();
            return missatge;
        }


    }
}
