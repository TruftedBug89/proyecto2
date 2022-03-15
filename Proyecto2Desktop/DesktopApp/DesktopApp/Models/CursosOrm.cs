using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Models
{
    public static class CursosOrm
    {
        public static List<cursos> Select() 
        {
            List<cursos> _cursos = Orm.bd.cursos
                            .OrderBy(c => c.nom)
                            .ToList();

            return _cursos;
        
        }

        public static List<cursos> SelectActius() 
        {
            List<cursos> _cursos = Orm.bd.cursos
                            .Where(c => c.actiu == true)
                            .OrderBy(c => c.nom)
                            .ToList();
            return _cursos;
        }

        public static String Insert(cursos _curs)
        {
            Orm.bd.cursos.Add(_curs);
            String missatge = Orm.MySaveChanges();
            return missatge;
        }

        public static String Update(cursos _curs, int CursInici, int CursFinal, bool actiu, String nom)
        {
            _curs.curs_inici = CursInici;
            _curs.curs_fi = CursFinal;
            _curs.actiu = actiu;
            _curs.nom = nom;
            String missatge = Orm.MySaveChanges();
            return missatge;
        }


    }
}
