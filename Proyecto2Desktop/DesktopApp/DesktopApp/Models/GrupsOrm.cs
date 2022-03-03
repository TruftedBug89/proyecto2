using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Models
{
    public static class GrupsOrm
    {

        public static List<grups> Select() 
        {
            List<grups> _grups = Orm.bd.grups.ToList();

            return _grups;
        }
        
        public static String Insert(grups _grups)
        {
            Orm.bd.grups.Add(_grups);
            String missatge = Orm.MySaveChanges();
            return missatge;
        }

        public static String InsertDocents(grups_has_docents _grups_docents)
        {
            Orm.bd.grups_has_docents.Add(_grups_docents);
            String missatge = Orm.MySaveChanges();
            return missatge;
        }

        public static String InsertAlumn(grups_has_alumnes _grups_alumnes)
        {
            Orm.bd.grups_has_alumnes.Add(_grups_alumnes);
            String missatge = Orm.MySaveChanges();
            return missatge;
        }

        public static String InsertSkils(grups_has_llistes_skills _grups_llistes_skills)
        {
            Orm.bd.grups_has_llistes_skills.Add(_grups_llistes_skills);
            String missatge = Orm.MySaveChanges();
            return missatge;
        }


        public static String Update(grups _grups, String nom, bool actiu) 
        {
            _grups.nom = nom;
            _grups.actiu = actiu;
            String missatge = Orm.MySaveChanges();
            return missatge;
        }



    }
}
