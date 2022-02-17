using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Models
{
    public static class SkillsOrm
    {
        public static void Insert(skills _skills) {
            Orm.bd.skills.Add(_skills);
            Orm.bd.SaveChanges();
        }
    }
}
