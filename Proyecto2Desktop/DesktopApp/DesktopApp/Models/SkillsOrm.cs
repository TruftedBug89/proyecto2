using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Models
{
    public static class SkillsOrm
    {

        public static List<skills> Select() 
        {
            List<skills> _skills = Orm.bd.skills.ToList();

            return _skills;
        }

        public static List<skills> SelectActivate()
        {
            List<skills> _skills = Orm.bd.skills
                            .Where(c => c.actiu == true)
                            .ToList();

            return _skills;
        }


        public static String Insert(skills _skills)
        {
            Orm.bd.skills.Add(_skills);
            String missatge = Orm.MySaveChanges();
            return missatge;
        }



        public static String Update(skills _skills, String nombre, Boolean actiu,int colorFondo, int colortexto)
        {

            _skills.nom = nombre;
            _skills.actiu = actiu;
            _skills.colorFondo = colorFondo;
            _skills.colorTexto = colortexto;
            String missatge = Orm.MySaveChanges();
            return missatge;

        }

        


    }
}
