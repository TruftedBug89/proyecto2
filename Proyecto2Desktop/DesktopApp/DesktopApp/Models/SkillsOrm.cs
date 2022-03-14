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



        public static List<skills> SelectIdLlista(int id_llistaSkills)
        {
            List<skills> _skills = Orm.bd.skills                           
                            .Where(c => c.llistes_skills_id == id_llistaSkills)
                            .ToList();

            return _skills;
        }

        public static List<skills> SelectActivate(int id_llista)
        {
            List<skills> _skills = Orm.bd.skills
                            .Where(c => c.actiu == true)   
                            .Where(c => c.llistes_skills_id == id_llista)
                            .ToList();

            return _skills;
        }


        public static String Insert(skills _skills)
        {
            Orm.bd.skills.Add(_skills);
            String missatge = Orm.MySaveChanges();
            return missatge;
        }



        public static String Update(skills _skills, String nombre, Boolean actiu, int colorFondo, int colortexto)
        {

            _skills.nom = nombre;
            _skills.actiu = actiu;
            _skills.colorFondo = colorFondo;
            _skills.colorTexto = colortexto;
            String missatge = Orm.MySaveChanges();
            return missatge;

        }

        public static String Update(skills _skills)
        {
                       
            String missatge = Orm.MySaveChanges();
            return missatge;

        }



    }
}
