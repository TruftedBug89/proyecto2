using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Models
{
    public static class KpisOrm
    {
        public static void Insert(kpis kpi)
        {
            Orm.bd.kpis.Add(kpi);
            Orm.bd.SaveChanges();
        }
        public static List<kpis> Select(bool actiu, int skillid)
        {
            List<kpis> _kpis = (from k in Orm.bd.kpis where k.actiu == actiu && k.skills_id == skillid select k).ToList();
            return _kpis;
        }
        public static void Delete(kpis kpi)
        {
            Orm.bd.kpis.Remove(kpi);
            Orm.bd.SaveChanges();
        }
    }
}
