using DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class FormCursos : Form
    {
        private cursos _curs;
        private List<cursos> _cursos;
        public FormCursos()
        {
            InitializeComponent();
        }

        private void FormCursos_Load(object sender, EventArgs e)
        {
            cargarCursos();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            String missatge = "";

            if (_curs != null)
            {
                String nom = dtpStartCourse.Text + " - " + txtFinishCourse.Text;
                missatge = CursosOrm.Update(_curs, Convert.ToInt32(dtpStartCourse.Text),Convert.ToInt32(txtFinishCourse.Text),cboActivate.Checked,nom);

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
               

                cursos _curs = new cursos();
                _curs.curs_inici = Convert.ToInt32(dtpStartCourse.Text);
                _curs.curs_fi = Convert.ToInt32(txtFinishCourse.Text);
                _curs.actiu = cboActivate.Checked;
                _curs.nom = dtpStartCourse.Text + " - " + txtFinishCourse.Text;

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarCursos() 
        {
            bindingSourceCourses.DataSource = null;
            bindingSourceCourses.DataSource = CursosOrm.Select();
        }

        private void dtpStartCourse_ValueChanged(object sender, EventArgs e)
        {
            int CursFi = Convert.ToInt32(dtpStartCourse.Text) + 1;
            txtFinishCourse.Text = CursFi.ToString();

        }
    }
}
