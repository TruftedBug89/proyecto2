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
            _cursos = CursosOrm.Select();

            foreach (cursos curs in _cursos)
            {
                lbCourses.Items.Add(curs.curs_inici + " - " + curs.curs_fi);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            String missatge = "";

            if (_curs != null)
            {
                missatge = CursosOrm.Update(_curs, Convert.ToInt32(dtpStartCourse.Text),Convert.ToInt32(dtpFinishCourse.Text),cboActivate.Checked);

                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Curso actualizado");
                }
            }
            else
            {
               

                cursos _curs = new cursos();
                _curs.curs_inici = Convert.ToInt32(dtpStartCourse.Text);
                _curs.curs_fi = Convert.ToInt32(dtpFinishCourse.Text);
                _curs.actiu = cboActivate.Checked;

                missatge = CursosOrm.Insert(_curs);

                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Curso añadido");
                }

            }



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        

    }
}
