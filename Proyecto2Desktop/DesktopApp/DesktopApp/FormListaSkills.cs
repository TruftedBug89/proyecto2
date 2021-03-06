using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Models;

namespace DesktopApp
{
    public partial class FormListaSkills : Form
    {
        private llistes_skills _llistesSkills;
        private List<llistes_skills> _llistesS;
        public FormListaSkills()
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
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _llistesSkills = null;
            dgvListaSkills.DataSource = null;
            CrearBotonListaSkill(_llistesSkills);
            txtNameListSkill.Visible = true;
            txtNameListSkill.ReadOnly = false;
            lblplus.Visible = false;
            txtAddNewSkills.Visible = false;
            lblPlus2.Visible = false;
            dgvListaNewSkills.Visible = false;
        }
        private void SeleccionarLista_Click(object sender, EventArgs e, RadioButton btnListSkill, llistes_skills llistesS)
        {
            _llistesSkills = llistesS;
            if (_llistesSkills != null)
            {
                CargarGruposRelacionados();
                txtNameListSkill.Text = _llistesSkills.nom;
                cboActivate.Checked = llistesS.actiu;
                txtNameListSkill.ReadOnly = true;
                txtNameListSkill.Visible = true;
                lblplus.Visible = true;
                txtAddNewSkills.Visible = true;
                lblPlus2.Visible = true;
                dgvListaNewSkills.Visible = true;
                if (_llistesSkills.skills.Count() != 0 || _llistesSkills.skills != null)
                {
                    dgvListaSkills.Rows.Clear();
                    //ConstruirEncabezadosTabla();
                    int i = 0;
                    foreach (skills skill in _llistesSkills.skills)
                    {
                        char[] letras = skill.nom.ToCharArray();
                        dgvListaSkills.Rows.Add(letras[0], skill.nom);
                        dgvListaSkills.Rows[i].Cells[0].Style.BackColor = Color.FromArgb(skill.colorFondo);
                        dgvListaSkills.Rows[i].Cells[0].Style.ForeColor = Color.FromArgb(skill.colorTexto);
                        var cellBtnBackColor = ((DataGridViewButtonCell)dgvListaSkills.Rows[i].Cells[2]);
                        cellBtnBackColor.FlatStyle = FlatStyle.Flat;
                        dgvListaSkills.Rows[i].Cells[2].Style.BackColor = Color.FromArgb(skill.colorFondo);
                        var cellBtnTextColor = ((DataGridViewButtonCell)dgvListaSkills.Rows[i].Cells[3]);
                        cellBtnTextColor.FlatStyle = FlatStyle.Flat;
                        dgvListaSkills.Rows[i].Cells[3].Style.BackColor = Color.FromArgb(skill.colorTexto);
                        dgvListaSkills.Rows[i].Cells[4].Value = skill.actiu;
                        i++;
                    }
                }
                else
                {
                    dgvListaSkills.Rows.Clear();
                }
            }
            else
            {
                txtNameListSkill.Text = "";
                txtNameListSkill.ReadOnly = false;
                dgvListaSkills.Rows.Clear();
                lblplus.Visible = false;
                txtAddNewSkills.Visible = false;
                lblPlus2.Visible = false;
                dgvListaNewSkills.Visible = false;
            }
        }
        private void FormListaSkills_Load(object sender, EventArgs e)
        {
            _llistesS = Llistes_SkillsOrm.Select();
            if (_llistesS.Count() >= 1)
            {
                foreach (llistes_skills lSkills in _llistesS)
                {
                    CrearBotonListaSkill(lSkills);
                }
            }
            ControlPermisosUsuario();
            bdCurs.DataSource = GrupsOrm.Select();
        }
        private void ControlPermisosUsuario()
        {
            if (UsuarioLogin.UsuariLogin.rols.gestionarSkills == false)
            {
                this.Controls.Remove(dgvListaSkills);
                this.Controls.Remove(dgvListaNewSkills);
                this.Controls.Remove(btnBuildTable);
                this.Controls.Remove(lblPlus2);
            }
            if (UsuarioLogin.UsuariLogin.rols.gestionarRelacionesGrupos == false)
            {
                this.Controls.Remove(gbGroupsSkill);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            String missatge = "";
            if (_llistesSkills != null)
            {
                _llistesSkills.actiu = cboActivate.Checked;
                missatge = Llistes_SkillsOrm.Update(_llistesSkills, txtNameListSkill.Text.ToUpper(), _llistesSkills.actiu);
                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int i = 0;
                    foreach (skills skill in _llistesSkills.skills)
                    {
                        skill.nom = dgvListaSkills.Rows[i].Cells[1].Value.ToString();
                        DataGridViewCheckBoxCell chk = dgvListaSkills.Rows[i].Cells[4] as DataGridViewCheckBoxCell;
                        skill.actiu = Convert.ToBoolean(chk.Value);
                        skill.colorFondo = dgvListaSkills.Rows[i].Cells[2].Style.BackColor.ToArgb();
                        skill.colorTexto = dgvListaSkills.Rows[i].Cells[3].Style.BackColor.ToArgb();
                        missatge = SkillsOrm.Update(skill);
                        if (missatge != "")
                        {
                            MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        i++;
                    }
                    _llistesSkills.nom = ActualizarNombreSkillActivadas(_llistesSkills.id);
                    missatge = Llistes_SkillsOrm.Update(_llistesSkills);
                    if (missatge != "")
                    {
                        MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //si el texto del addNewSkill no esta vacio añademe x skills como caracteres tenga el texto
                    if (!txtAddNewSkills.Text.Equals(""))
                    {
                        if (dgvListaNewSkills.Rows.Count >= 1)
                        {
                            foreach (DataGridViewRow row in dgvListaNewSkills.Rows)
                            {
                                skills _skill = new skills();
                                if (!row.Cells[1].Value.Equals(""))
                                {
                                    char[] letrasS = row.Cells[1].Value.ToString().ToCharArray();
                                    var regex = new Regex(Regex.Escape(letrasS[0].ToString()));
                                    String nombreSkill = regex.Replace(row.Cells[1].Value.ToString(), letrasS[0].ToString().ToUpper(), 1);
                                    _skill.nom = nombreSkill;
                                }
                                else
                                {
                                    _skill.nom = row.Cells[0].Value.ToString().ToUpper();
                                }
                                _skill.llistes_skills_id = _llistesSkills.id;
                                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[4];
                                _skill.actiu = Convert.ToBoolean(chk.Value);
                                _skill.colorFondo = row.Cells[2].Style.BackColor.ToArgb();
                                _skill.colorTexto = row.Cells[3].Style.BackColor.ToArgb();
                                missatge = SkillsOrm.Insert(_skill);
                                if (missatge != "")
                                {
                                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            List<skills> skillsLlistaSkills = SkillsOrm.SelectActivate(_llistesSkills.id);
                            char[] LetrasActivadas = new char[skillsLlistaSkills.Count];
                            int j = 0;
                            foreach (skills skill in skillsLlistaSkills)
                            {
                                char[] letraSkill = skill.nom.ToCharArray();
                                LetrasActivadas[j] = letraSkill[0];
                                j++;
                            }
                            String nuevoNombre = new String(LetrasActivadas);
                            _llistesSkills.nom = nuevoNombre.ToUpper();
                            missatge = Llistes_SkillsOrm.Update(_llistesSkills);
                            if (missatge != "")
                            {
                                MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            char[] letras = txtAddNewSkills.Text.ToCharArray();
                            for (int j = 0; j < letras.Length; j++)
                            {
                                skills _skill = new skills();
                                _skill.llistes_skills_id = _llistesSkills.id;
                                _skill.nom = letras[j].ToString().ToUpper();
                                _skill.actiu = true;
                                _skill.colorFondo = Color.Black.ToArgb();
                                _skill.colorTexto = Color.White.ToArgb();
                                missatge = SkillsOrm.Insert(_skill);
                                if (missatge != "")
                                {
                                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        _llistesSkills.nom = ActualizarNombreSkillActivadas(_llistesSkills.id);
                        missatge = Llistes_SkillsOrm.Update(_llistesSkills);
                        if (missatge != "")
                        {
                            MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    MessageBox.Show("Lista de skills actualizada");
                }
            }
            else
            {
                if (!txtNameListSkill.Text.Equals(""))
                {
                    llistes_skills _llistes_Skills = new llistes_skills();
                    _llistes_Skills.nom = txtNameListSkill.Text.ToUpper();
                    _llistes_Skills.actiu = cboActivate.Checked;
                    missatge = Llistes_SkillsOrm.Insert(_llistes_Skills);
                    if (missatge != "")
                    {
                        MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (dgvListaSkills.Rows.Count >= 1)
                        {
                            foreach (DataGridViewRow row in dgvListaSkills.Rows)
                            {
                                skills _skill = new skills();
                                if (!row.Cells[1].Value.Equals(""))
                                {
                                    char[] letrasS = row.Cells[1].Value.ToString().ToCharArray();
                                    var regex = new Regex(Regex.Escape(letrasS[0].ToString()));
                                    String nombreSkill = regex.Replace(row.Cells[1].Value.ToString(), letrasS[0].ToString().ToUpper(), 1);
                                    _skill.nom = nombreSkill;
                                }
                                else
                                {
                                    _skill.nom = row.Cells[0].Value.ToString().ToUpper();
                                }
                                _skill.llistes_skills_id = _llistes_Skills.id;
                                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[4];
                                _skill.actiu = Convert.ToBoolean(chk.Value);
                                _skill.colorFondo = row.Cells[2].Style.BackColor.ToArgb();
                                _skill.colorTexto = row.Cells[3].Style.BackColor.ToArgb();
                                missatge = SkillsOrm.Insert(_skill);
                                if (missatge != "")
                                {
                                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            _llistes_Skills.nom = ActualizarNombreSkillActivadas(_llistes_Skills.id);
                            missatge = Llistes_SkillsOrm.Update(_llistes_Skills);
                            if (missatge != "")
                            {
                                MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            char[] letras = txtNameListSkill.Text.ToCharArray();
                            for (int i = 0; i < letras.Length; i++)
                            {
                                skills _skill = new skills();
                                _skill.llistes_skills_id = _llistes_Skills.id;
                                _skill.nom = letras[i].ToString().ToUpper();
                                _skill.actiu = true;
                                _skill.colorFondo = Color.Black.ToArgb();
                                _skill.colorTexto = Color.White.ToArgb();
                                missatge = SkillsOrm.Insert(_skill);
                                if (missatge != "")
                                {
                                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        MessageBox.Show("Lista de skills añadida");
                    }
                }
                else
                {
                    MessageBox.Show("Listas vacias");
                }
            }
            ActualizarPanelListaSkills();
            dgvListaSkills.Rows.Clear();
            dgvListaNewSkills.Rows.Clear();
            dgvListaNewSkills.Visible = false;
            txtNameListSkill.Text = "";
            txtAddNewSkills.Text = "";
            lblplus.Visible = false;
            lblPlus2.Visible = false;
            txtAddNewSkills.Visible = false;
            txtNameListSkill.ReadOnly = false;
            txtNameListSkill.Visible = false;
        }
        private String ActualizarNombreSkillActivadas(int idLista)
        {
            //Una vez añadidas las skills mirar las que esten activadas y actualizar el nombre de la lista de skills
            //concatenando las letras de skills activadas.
            //Ej: FRASE la R y la S estan desactivadas --> FAE
            List<skills> skillsLlistaSkills = SkillsOrm.SelectActivate(idLista);
            char[] LetrasActivadas = new char[skillsLlistaSkills.Count];
            int i = 0;
            foreach (skills skill in skillsLlistaSkills)
            {
                char[] letraSkill = skill.nom.ToCharArray();
                LetrasActivadas[i] = letraSkill[0];
                i++;
            }
            String nuevoNombre = new String(LetrasActivadas);
            return nuevoNombre.ToUpper();
        }
        private void ActualizarPanelListaSkills()
        {
            //Elimino todos los Controles menos el primero
            while (flpListSkills.Controls.Count > 1)
            {
                flpListSkills.Controls.RemoveAt(1);
            }
            List<llistes_skills> _llistesSkills = Llistes_SkillsOrm.Select();
            foreach (llistes_skills LS in _llistesSkills)
            {
                CrearBotonListaSkill(LS);
            }
        }
        private void CrearBotonListaSkill(llistes_skills ls)
        {
            RadioButton btnListSkill = new RadioButton();
            btnListSkill.Appearance = Appearance.Button;
            if (ls == null)
            {
                btnListSkill.Text = "Nueva Lista";
                txtNameListSkill.Text = "";
                dgvListaSkills.Rows.Clear();
            }
            else
            {
                btnListSkill.Text = ls.nom;
            }
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
        private void CargarGruposRelacionados()
        {
            cbxGroups.Items.Clear();
            if (_llistesSkills != null)
            {
                List<grups_has_llistes_skills> GrupsDeSkill = GrupsHasLlistesSkillsOrm.SelectGrupsOfLists(_llistesSkills.id);
                foreach (grups_has_llistes_skills item in GrupsDeSkill)
                {
                    grups _grup = GrupsOrm.SelectGrup(item.grups_id);
                    cbxGroups.Items.Add(_grup.nom);
                }
            }
        }
        private void btnManagmentGroups_Click(object sender, EventArgs e)
        {
            FormRelacionesGrupo formRelacionesGrupo = new FormRelacionesGrupo("GuposListasSkills");
            formRelacionesGrupo.ShowDialog();
        }
        private void btnBuildTable_Click(object sender, EventArgs e)
        {
            if (_llistesSkills != null)
            {
                ConstruirTabla(dgvListaNewSkills, txtAddNewSkills.Text);
                dgvListaSkills.ClearSelection();
            }
            else
            {
                ConstruirTabla(dgvListaSkills, txtNameListSkill.Text);
            }
        }
        public void ConstruirTabla(DataGridView dataGridView, String Text)
        {
            //limpiar rows si hay alguna fila
            if (dataGridView.Rows.Count >= 1)
            {
                dataGridView.Rows.Clear();
            }
            //añadir rows en la otra datagridview como caracteres haya en la txtaddNewSkills
            Char[] letras = Text.ToCharArray();
            for (int i = 0; i < letras.Length; i++)
            {
                dataGridView.Rows.Add(letras[i].ToString().ToUpper());
                dataGridView.Rows[i].Cells[1].Value = "";
                var cellBtnBackColor = ((DataGridViewButtonCell)dataGridView.Rows[i].Cells[2]);
                cellBtnBackColor.FlatStyle = FlatStyle.Flat;
                dataGridView.Rows[i].Cells[2].Style.BackColor = Color.Black;
                var cellBtnTextColor = ((DataGridViewButtonCell)dataGridView.Rows[i].Cells[3]);
                cellBtnTextColor.FlatStyle = FlatStyle.Flat;
                dataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                dataGridView.Rows[i].Cells[4].Value = true;
            }
        }
        private void dgvListaSkills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 2)
                {
                    cambiarColorBotonCelda(e.RowIndex, 2);
                }
                else if (e.ColumnIndex == 3)
                {
                    cambiarColorBotonCelda(e.RowIndex, 3);
                }
            }
        }
        private void cambiarColorBotonCelda(int indexRow, int celda)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog.Color;
                var cell = ((DataGridViewButtonCell)dgvListaSkills.Rows[indexRow].Cells[celda]);
                cell.FlatStyle = FlatStyle.Flat;
                dgvListaSkills.Rows[indexRow].Cells[celda].Style.BackColor = color;
            }
            dgvListaSkills.ClearSelection();
        }
        private void cambiarColorBotonCelda2(int indexRow, int celda)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog.Color;
                var cell = ((DataGridViewButtonCell)dgvListaNewSkills.Rows[indexRow].Cells[celda]);
                cell.FlatStyle = FlatStyle.Flat;
                dgvListaNewSkills.Rows[indexRow].Cells[celda].Style.BackColor = color;
            }
            dgvListaNewSkills.ClearSelection();
        }
        private void dgvListaNewSkills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 2)
                {
                    cambiarColorBotonCelda2(e.RowIndex, 2);
                }
                else if (e.ColumnIndex == 3)
                {
                    cambiarColorBotonCelda2(e.RowIndex, 3);
                }
            }
        }
        private void dgvListaSkills_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!dgvListaSkills.Rows[e.RowIndex].Cells[1].Value.Equals(""))
                {
                    char[] letras = dgvListaSkills.Rows[e.RowIndex].Cells[1].Value.ToString().ToCharArray();
                    String letraMayuscula = letras[0].ToString().ToUpper();

                    dgvListaSkills.Rows[e.RowIndex].Cells[0].Value = letraMayuscula;
                }
            }
        }
        private void pb_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}