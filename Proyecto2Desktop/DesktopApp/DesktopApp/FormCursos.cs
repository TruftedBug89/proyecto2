using DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class FormCursos : Form
    {
        private cursos _curs;
        //private List<cursos> _cursos;
        public String gruposStatus;
        public FormCursos(String status)
        {
            InitializeComponent();
            this.gruposStatus = status;
        }

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

        private void FormCursos_Load(object sender, EventArgs e)
        {
            cargarCursos();
            cargarAños();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            String missatge = "";
            if (_curs != null)
            {
                String nom = cbxYears.SelectedItem.ToString() + " - " + txtFinishCourse.Text;
                missatge = CursosOrm.Update(_curs, Convert.ToInt32(cbxYears.SelectedItem), Convert.ToInt32(txtFinishCourse.Text), cboActivate.Checked, nom);

                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Curso actualizado");
                    cargarCursos();
                }
            }
            else
            {
                if (cbxYears.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona un año");
                }
                else
                {
                    cursos _curs = new cursos();
                    _curs.curs_inici = Convert.ToInt32(cbxYears.SelectedItem);
                    _curs.curs_fi = Convert.ToInt32(txtFinishCourse.Text);
                    _curs.actiu = cboActivate.Checked;
                    _curs.nom = cbxYears.SelectedItem.ToString() + " - " + txtFinishCourse.Text;

                    missatge = CursosOrm.Insert(_curs);

                    if (missatge != "")
                    {
                        MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Curso añadido");
                        cargarCursos();
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cargarCursos() 
        {
            bindingSourceCourses.DataSource = null;
            bindingSourceCourses.DataSource = CursosOrm.Select();
        }
        private void cargarAños() 
        {
            string currentYear = DateTime.Now.Year.ToString();
            int añoActual = Convert.ToInt32(currentYear);

            for (int i = añoActual; i < 2122; i++)
            {
                cbxYears.Items.Add(i);
            }
        }
        private void cbxYears_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int CursFi = Convert.ToInt32(cbxYears.SelectedItem) + 1;
            txtFinishCourse.Text = CursFi.ToString();
        }
        private void lbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            _curs = (cursos)lbCourses.SelectedItem;

            if (_curs != null)
            {
                cbxYears.SelectedItem = _curs.curs_inici;
                txtFinishCourse.Text = _curs.curs_fi.ToString();
                cboActivate.Checked = (bool)_curs.actiu;
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            VaciarCampos();
        }
        private void VaciarCampos()
        {
            _curs = null;
            cbxYears.SelectedItem = null;
            txtFinishCourse.Text = "";
            cboActivate.Checked = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
