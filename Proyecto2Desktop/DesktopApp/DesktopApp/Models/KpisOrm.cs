using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Models
{
    public static class KpisOrm
    {
        public static String Insert(kpis kpi)
        {
            Orm.bd.kpis.Add(kpi);
            return Orm.MySaveChanges();
        }

        public static List<kpis> Select(bool actiu, int skillid)
        {
            List<kpis> _kpis = (from k in Orm.bd.kpis where k.actiu == actiu where k.skills_id == skillid select k).ToList();
            return _kpis;
        }
        // public static String Delete(kpis kpi)
        // {
        //     Orm.bd.kpis.Remove(kpi);
        //     return Orm.MySaveChanges();
        // }
    }
}
