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

        public static String Insert(llistes_skills _llistes_Skills) 
        {
            Orm.bd.llistes_skills.Add(_llistes_Skills);
            String missatge = Orm.MySaveChanges();
            return missatge;
        }

    }
}
