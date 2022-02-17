using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Models
{
    public static class SkillsOrm
    {
        public static String Insert(skills skills)
        {
            Orm.bd.skills.Add(skills);
            String missatge = Orm.MySaveChanges();
            return missatge;
        }
    }
}
