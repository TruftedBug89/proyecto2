using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Models
{
    public static class GrupsHasLlistesSkillsOrm
    {
        public static List<grups_has_llistes_skills> Select(int id) 
        {
            List<grups_has_llistes_skills> _grupsLlistes = Orm.bd.grups_has_llistes_skills
                                            .Where(c => c.grups_id == id)
                                            .ToList();
            return _grupsLlistes;
        }

        public static List<grups_has_llistes_skills> SelectGrupsOfLists(int id)
        {
            List<grups_has_llistes_skills> _grupsLlistes = Orm.bd.grups_has_llistes_skills
                                            .Where(c => c.llistes_skills_id == id)
                                            .ToList();
            return _grupsLlistes;
        }


        public static String Insert(grups_has_llistes_skills _grups_llistes_skills)
        {
            Orm.bd.grups_has_llistes_skills.Add(_grups_llistes_skills);
            String missatge = Orm.MySaveChanges();
            return missatge;
        }


    }
}
