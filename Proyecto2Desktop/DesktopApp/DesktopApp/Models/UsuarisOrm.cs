using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopApp.Models;

namespace DesktopApp.Models
{
    public static class UsuarisOrm
    {

        public static List<usuaris> Select()
        {
            List<usuaris> _usuaris = Orm.bd.usuaris.ToList();

            return _usuaris;
        }


        internal static object SelectByName(string text)
        {
            List<usuaris> _usuaris = Orm.bd.usuaris
                            .Where(c => c.nom.Contains(text))
                            .ToList();

            return _usuaris;
        }

        internal static String InsertValues(string nom, string rol, string correo, string contra)

        {
            usuaris user = new usuaris();
            user.nom = nom;
            user.rols_id = int.Parse(rol);
            user.correo = correo;
            user.contrasenya = contra;
            user.actiu = true;


            Orm.bd.usuaris.Add(user);
            String missatge = Orm.MySaveChanges();
            return missatge;
        }

        public static String Insert(usuaris _usuaris)
        {
            Orm.bd.usuaris.Add(_usuaris);
            String missatge = Orm.MySaveChanges();
            return missatge;

        }
    


        public static Boolean SelectLogin(string correu, string contrasenya)
        {
            Boolean acceptar;
            if(String.IsNullOrWhiteSpace(correu))
            {
               
                return false;
            }

            List<usuaris> users = UsuarisOrm.Select();
            usuaris usuarioALoguear = null;

            foreach (usuaris user in users)
            {
                if (user.correo.Equals(correu))
                {
                    usuarioALoguear = user;
                }
            }

            if (usuarioALoguear == null) return false;


            Boolean passcorrecto = BCrypt.Net.BCrypt.EnhancedVerify(contrasenya, usuarioALoguear.contrasenya, BCrypt.Net.HashType.SHA512);

            if (passcorrecto)
            {
                System.Windows.Forms.MessageBox.Show("El usuario o la contraseña són correctos!");
                acceptar = true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("El usuario o la contraseña són incorrectos!");
                acceptar = false;
            }

            return acceptar;
         }


        }

}
