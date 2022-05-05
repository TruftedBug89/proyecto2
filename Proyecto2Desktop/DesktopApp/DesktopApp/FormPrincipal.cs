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
    public partial class FormPrincipal : Form
    {
        private List<llistes_skills> _llistes_Skills;
        private List<skills> _skills;
        private llistes_skills _llistesSkills;
        private skills _skill;
        private List<kpis> _kpis;
        private Boolean checkGestionKPI = true;
        public FormPrincipal()
        {
            InitializeComponent();
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
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            _llistes_Skills = Llistes_SkillsOrm.SelectActivate();
            foreach (llistes_skills lSkills in _llistes_Skills)
            {
                CrearBotonListaSkill(lSkills);
            }
            ControlPermisosUsuario();
        }
        private void ControlPermisosUsuario()
        {
            if (UsuarioLogin.UsuariLogin.rols.gestionarKPIs == false)
            {
                btnManagmentKPI.Visible = false;
                checkGestionKPI = false;
            }
            if (UsuarioLogin.UsuariLogin.rols.gestionarListaSkills == false)
            {
                btnManagmentListSkills.Visible = false;
            }
            if (UsuarioLogin.UsuariLogin.rols.gestionarSkills == false)
            {
                flpSkills.Controls.Remove(btnManagmentSkills);
            }
            if (UsuarioLogin.UsuariLogin.rols.gestionarUsuarios == false)
            {
                btnGestionUsuarios.Visible = false;
            }
            if (UsuarioLogin.UsuariLogin.rols.gestionarPerfiles == false)
            {
                btnManagmentRoles.Visible = false;
            }
            if (UsuarioLogin.UsuariLogin.rols.gestionarGrupos == false)
            {
                btnManagmentGroups.Visible = false;
            }
            if (UsuarioLogin.UsuariLogin.rols.gestionarCursos == false)
            {
                btnManagmentCourses.Visible = false;
            }
        }
        private void SeleccionarLista_Click(object sender, EventArgs e, RadioButton btnListSkill, llistes_skills llistesS)
        {
            limpiarPanelSkills();
            dgvSkill.Columns.Clear();
            btnManagmentKPI.Visible = false;
            _llistesSkills = llistesS;
            _skills = SkillsOrm.SelectActivate(_llistesSkills.id);
            foreach (skills skill in _skills)
            {
                flpSkills.Visible = true;
                btnManagmentSkills.Visible = true;
                CrearBotonSkills(skill);

            }
        }
        private void SeleccionarSkill_Click(object sender, EventArgs e, RadioButton btnSkill, skills S)
        {
            _skill = S;
            if (checkGestionKPI == true) {
                btnManagmentKPI.Visible = true;
            }
            dgvSkill.Columns.Clear();
            dgvSkill.DataSource = null;
            dgvSkill.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15);
            dgvSkill.Columns.Add(S.nom, S.nom);
            dgvSkill.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);


            dgvSkill.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(S.colorFondo);
            dgvSkill.EnableHeadersVisualStyles = false;

            dgvSkill.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(S.colorTexto);
            dgvSkill.EnableHeadersVisualStyles = false;

            _kpis = KpisOrm.Select(true, _skill.id);
            foreach (kpis kpi in _kpis)
            {
                dgvSkill.Rows.Add(kpi.nom);
                
                
            }
            dgvSkill.ClearSelection();
        }
        private void CrearBotonListaSkill(llistes_skills ls)
        {
            RadioButton btnListSkill = new RadioButton();
            btnListSkill.Appearance = Appearance.Button;
            btnListSkill.Text = ls.nom;
            String nombre = btnListSkill.Text;
            btnListSkill.FlatStyle = FlatStyle.Flat;
            btnListSkill.TextAlign = ContentAlignment.MiddleCenter;
            btnListSkill.Font = new Font(new FontFamily("Microsoft Sans Serif"), 20, FontStyle.Bold);
            btnListSkill.BackColor = Color.Black;
            btnListSkill.ForeColor = Color.White;
            btnListSkill.Size = new Size(200, 55);
            btnListSkill.FlatAppearance.CheckedBackColor = Color.Blue;
            btnListSkill.Margin = new Padding(24, 8, 4, 4);
            flpListSkills.Controls.Add(btnListSkill);
            btnListSkill.Click += (sender2, e2) => SeleccionarLista_Click(sender2, e2, btnListSkill, ls);
        }
        private void CrearBotonSkills(skills _skills)
        {
            RadioButton btnSkill = new RadioButton();
            btnSkill.Appearance = Appearance.Button;
            char[] letra = _skills.nom.ToCharArray();
            btnSkill.Text = letra[0].ToString();
            String nombre = btnSkill.Text;
            btnSkill.FlatStyle = FlatStyle.Flat;
            btnSkill.FlatAppearance.BorderSize = 0;
            btnSkill.TextAlign = ContentAlignment.MiddleCenter;
            btnSkill.Font = new Font(new FontFamily("Microsoft Sans Serif"), 30, FontStyle.Bold);
            btnSkill.BackColor = Color.FromArgb(_skills.colorFondo);
            btnSkill.ForeColor = Color.FromArgb(_skills.colorTexto);
            btnSkill.Size = new Size(85, 75);
            btnSkill.FlatAppearance.CheckedBackColor = Color.FromArgb(100, Color.FromArgb(_skills.colorFondo));
            btnSkill.Margin = new Padding(120, 15, 4, 4);
            flpSkills.Controls.Add(btnSkill);
            btnSkill.Click += (sender2, e2) => SeleccionarSkill_Click(sender2, e2, btnSkill, _skills);
        }
        private void ActualizarDatos()
        {
            ActualizarPanelListasSkills();
            limpiarPanelSkills();
            _llistesSkills = null;
            dgvSkill.Columns.Clear();
            flpSkills.Visible = false;
            btnManagmentSkills.Visible = false;
        }
        private void ActualizarPanelListasSkills()
        {
            if (UsuarioLogin.UsuariLogin.rols.gestionarListaSkills == false)
            {
                flpListSkills.Controls.Clear();
            }
            else
            {
                //Elimino todos los Controles menos el primero
                while (flpListSkills.Controls.Count > 1)
                {
                    flpListSkills.Controls.RemoveAt(1);
                }
            }
            List<llistes_skills> _llistes_Skills = Llistes_SkillsOrm.SelectActivate();
            foreach (llistes_skills lSkills in _llistes_Skills)
            {
                CrearBotonListaSkill(lSkills);
            }
        }
        private void limpiarPanelSkills()
        {
            if (UsuarioLogin.UsuariLogin.rols.gestionarSkills == false)
            {
                flpSkills.Controls.Clear();
            }
            else
            {
                //Elimino todos los Controles menos el primero
                while (flpSkills.Controls.Count > 1)
                {
                    flpSkills.Controls.RemoveAt(1);
                }
            }
        }
        private void btnManagmentSkills_Click(object sender, EventArgs e)
        {
            if (_llistesSkills != null)
            {
                FormSkill formSkill = new FormSkill(_llistesSkills);
                formSkill.ShowDialog();
                ActualizarDatos();
            }
            else
            {
                MessageBox.Show("Selecciona una lista de Skills");
            }
        }
        private void btnManagmentKPI_Click(object sender, EventArgs e)
        {
            FormKPI FormKPI = new FormKPI(_skill);
            FormKPI.ShowDialog();
            ActualizarDatos();
        }
        private void btnManagmentRoles_Click(object sender, EventArgs e)
        {
            FormGestionPerfil formGestionPerfil = new FormGestionPerfil();
            formGestionPerfil.ShowDialog();
            ActualizarDatos();
        }
        private void btnManagmentCourses_Click(object sender, EventArgs e)
        {
            FormCursos formCursos = new FormCursos("");
            formCursos.ShowDialog();
            ActualizarDatos();
        }
        private void btnManagmentGroups_Click(object sender, EventArgs e)
        {
            FormGestionGrupo formGestionGrupo = new FormGestionGrupo("");
            formGestionGrupo.ShowDialog();
            ActualizarDatos();
        }
        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            FormGestionUsuarios fgu = new FormGestionUsuarios();
            fgu.ShowDialog();
        }
        private void pb_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pb_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnManagmentListSkills_Click_1(object sender, EventArgs e)
        {
            FormListaSkills formListaSkills = new FormListaSkills();
            formListaSkills.ShowDialog();
            ActualizarPanelListasSkills();
            limpiarPanelSkills();
            _llistesSkills = null;
            dgvSkill.Columns.Clear();
        }
        private void msCloseSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
    }
}
