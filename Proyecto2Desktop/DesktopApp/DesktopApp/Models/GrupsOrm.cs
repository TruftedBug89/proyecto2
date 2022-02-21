using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Models
{
    public static class GrupsOrm
    {

        public static List<grups> Select() 
        {
            List<grups> _grups = Orm.bd.grups.ToList();

            return _grups;
        }
        
        public static String Insert(grups _grups)
        {
            Orm.bd.grups.Add(_grups);
            String missatge = Orm.MySaveChanges();
            return missatge;
        }



    }
}
