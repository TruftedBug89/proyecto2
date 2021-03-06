using System;
using DesktopApp.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DesktopApp
{
    public partial class FormGestionUsuarios : Form
    {
        public FormGestionUsuarios()
        {
            InitializeComponent();
            bindingSource1.DataSource = Models.UsuarisOrm.Select();
        }
        //Mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int Iparam);
        private void pnBarra_MouseDown(object sender, MouseEventArgs e)//Para poder mover la ventana des de la TitleBar
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lbTitulo_MouseDown(object sender, MouseEventArgs e)//Para poder mover la ventana des de la TitleBar
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pcIcono_MouseDown(object sender, MouseEventArgs e)//Para poder mover la ventana des de la TitleBar
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }//
        private void btnGroups_Click(object sender, EventArgs e)
        {
            FormRelacionesGrupo gr = new FormRelacionesGrupo("");
            gr.ShowDialog();
            bindingSource1.DataSource = Models.UsuarisOrm.Select();
            dataGridView1.DataSource = bindingSource1;
        }
        private void btnRoles_Click(object sender, EventArgs e)
        {
            FormGestionPerfil gr = new FormGestionPerfil();
            gr.ShowDialog();
            bindingSource1.DataSource = Models.UsuarisOrm.Select();
            dataGridView1.DataSource = bindingSource1;
        }
        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            FormCrearUsuarios fcu = new FormCrearUsuarios();
            fcu.ShowDialog();
            bindingSource1.DataSource = Models.UsuarisOrm.Select();
            dataGridView1.DataSource = bindingSource1;
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            List<Models.usuaris> usersToDownload = Models.UsuarisOrm.Select();

                StringBuilder sb = new StringBuilder();
                foreach (var data in usersToDownload)
                {
                    sb.AppendLine(data.id + "," + data.nom + "," + data.rols_id + "," + data.correo + "," + data.contrasenya + "," + data.actiu);
                }
            SaveFileDialog fileDialog = new SaveFileDialog();
            string filter = "CSV file (*.csv)|*.csv";
            fileDialog.Filter = filter;
            fileDialog.ShowDialog();
            File.WriteAllText(fileDialog.FileName, sb.ToString());
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPick_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            MessageBox.Show("Recuerda de introducir un archivo compatible con la formatación correcta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ofd.Filter = "CSV file (*.csv)|*.csv";
            
            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                int addedUsers = 0;
                bool failedAdd = false;
                foreach (string line in System.IO.File.ReadLines(ofd.FileName))
                {
                    String[] lines = line.Split(',');
                    Console.WriteLine(lines[0]);
                    List<Models.usuaris> _usuaris = Models.Orm.bd.usuaris.ToList();
                    foreach (Models.usuaris u in _usuaris)
                    {
                        if (u.correo == lines[3])
                        {
                            failedAdd = true;
                            break;
                        }
                    }
                    if (!failedAdd)
                    {
                        try
                        {
                            Models.UsuarisOrm.InsertValues(lines[1], lines[2], lines[3], lines[4]);
                            addedUsers++;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se puede procesar el archivo selecionado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                MessageBox.Show(!failedAdd ? "Añadidos " + addedUsers + " usuarios" : "Añadidos " + addedUsers + " usuarios, error al añadir usuarios con correos ya existentes");
                bindingSource1.DataSource = Models.UsuarisOrm.Select();
            }
            
        }
        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Models.UsuarisOrm.SelectByName(textBox1.Text);
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 8)
            {
                Models.usuaris u = (Models.usuaris)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                e.Value = u.rols.nom;
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int rowIndex = e.RowIndex;
            DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
            Models.usuaris usuarioAEditar = r.DataBoundItem as Models.usuaris;
            FormCrearUsuarios fenc = new FormCrearUsuarios(usuarioAEditar);
            fenc.ShowDialog();
            bindingSource1.DataSource = Models.UsuarisOrm.Select();
            dataGridView1.DataSource = bindingSource1;
        }
        private void FormGestionUsuarios_Load(object sender, EventArgs e)
        {
            ControlPermisosUsuario();
        }
        private void ControlPermisosUsuario()
        {
            if (UsuarioLogin.UsuariLogin.rols.gestionarPerfiles == false)
            {
                this.Controls.Remove(btnRoles);
            }
            if (UsuarioLogin.UsuariLogin.rols.gestionarRelacionesGrupos == false)
            {
                this.Controls.Remove(btnGroups);
            }
        }

        private void pb_minimize_Click(object sender, EventArgs e)
        {

        }
    }
}