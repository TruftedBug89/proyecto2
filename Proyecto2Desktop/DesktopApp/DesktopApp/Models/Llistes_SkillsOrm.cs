using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Models
{
    public static class Llistes_SkillsOrm
    {
        public static List<llistes_skills> Select() 
        {
            List<llistes_skills> _llistes_Skills = Orm.bd.llistes_skills.ToList();

            return _llistes_Skills;
        }

        public static List<llistes_skills> SelectActivate()
        {
            List<llistes_skills> _llistes_Skills = Orm.bd.llistes_skills
                                        .Where(c => c.actiu == true)
                                        .ToList();

            return _llistes_Skills;
        }

        public static String Insert(llistes_skills _llistes_Skills) 
        {
            Orm.bd.llistes_skills.Add(_llistes_Skills);
            String missatge = Orm.MySaveChanges();
            return missatge;
        }

        public static String Update(llistes_skills _llistes, String nombre, Boolean actiu)
        {

            _llistes.nom = nombre;
            _llistes.actiu = actiu;
            String missatge = Orm.MySaveChanges();
            return missatge;

        }

        public static String UpdateName(llistes_skills _llistes, String nombre)
        {

            _llistes.nom = nombre;
            String missatge = Orm.MySaveChanges();
            return missatge;

        }




    }
}
