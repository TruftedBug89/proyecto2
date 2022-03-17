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
            List<kpis> _kpis = new List<kpis>();
            if (actiu)
            {
                _kpis = (from k in Orm.bd.kpis where k.actiu == true where k.skills_id == skillid select k).ToList();

            }
            else
            {
                _kpis = (from k in Orm.bd.kpis where k.skills_id == skillid select k).ToList();

            }
            return _kpis;
        }
        public static kpis SelectSingleId(int id)
        {
            return (from k in Orm.bd.kpis where k.id == id select k).Single();
        }
        public static String Update(kpis old,String nouNom, int novaSkill,Boolean actiu)

        {
            old.nom = nouNom;
            old.skills_id = novaSkill;
            old.actiu = actiu;
            return Orm.MySaveChanges();
        }
        // public static String Delete(kpis kpi)
        // {
        //     Orm.bd.kpis.Remove(kpi);
        //     return Orm.MySaveChanges();
        // }
    }
}
