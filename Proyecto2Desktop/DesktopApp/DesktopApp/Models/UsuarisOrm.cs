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
        
        public static Boolean SelectLogin(string correu, string contrasenya)
        {
            Boolean acceptar;

            usuaris user =  Orm.bd.usuaris
                .Where (u => u.correo == correu )
                .First();

            Boolean passcorrecto = BCrypt.Net.BCrypt.EnhancedVerify(contrasenya, user.contrasenya, BCrypt.Net.HashType.SHA512);

            if (passcorrecto)
            {
                System.Windows.Forms.MessageBox.Show("El usuario o la contrasenya són correctos!");
                acceptar = true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("El usuario o la contrasenya són incorrectos!");
                acceptar = false;
            }

            return acceptar;
         }






            /* public static Boolean SelectCorreuContra(String correu, String contrasenya)
             {

                 String missatge = "Error";
                 String missatge1 = "Correcte";
                 String contraencrypt;
                 Boolean comprovar = false;
                 SqlCommand sentencia = new SqlCommand();


                 try
                 {
                     Orm.bd.Open();
                     SqlDataReader dades;
                     DataTable taula = new DataTable();

                     sentencia.Connection = BDaluSQLConnection.conexio;
                     sentencia.CommandText = "select correu,contrasenya FROM usuaris WHERE correu = @correu ";

                     sentencia.Parameters.Clear();
                     sentencia.Parameters.AddWithValue("@correu", correu);


                     dades = sentencia.ExecuteReader();

                     if (dades.Read())
                     {


                         contraencrypt = dades["contrasenya"].ToString();
                         Boolean passcorrecto = BCrypt.Net.BCrypt.EnhancedVerify(contrasenya, contraencrypt, BCrypt.Net.HashType.SHA512);
                         if (passcorrecto)
                         {
                             comprovar = true;
                             System.Windows.Forms.MessageBox.Show(missatge1);

                         }

                     }





                 }
                 catch (SqlException ex)
                 {
                     System.Windows.Forms.MessageBox.Show(missatge);
                     throw;
                 }

                 BDaluSQLConnection.conexio.Close();
                 return comprovar;

             }*/
        }
}
