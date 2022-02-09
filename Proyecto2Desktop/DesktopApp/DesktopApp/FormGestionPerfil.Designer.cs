
namespace DesktopApp
{
    partial class FormGestionPerfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewPerfiles = new System.Windows.Forms.ListView();
            this.labelNombrePerfil = new System.Windows.Forms.Label();
            this.textBoxNombrePerfil = new System.Windows.Forms.TextBox();
            this.labelPermisos = new System.Windows.Forms.Label();
            this.checkBoxPermisosTodos = new System.Windows.Forms.CheckBox();
            this.checkBoxPermisosVaciar = new System.Windows.Forms.CheckBox();
            this.groupBoxPermisos = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxGestionarKPIs = new System.Windows.Forms.CheckBox();
            this.checkBoxGestionListaSkills = new System.Windows.Forms.CheckBox();
            this.checkBoxGestionSkills = new System.Windows.Forms.CheckBox();
            this.checkBoxGestionarUsuarios = new System.Windows.Forms.CheckBox();
            this.checkBoxGestionPerfiles = new System.Windows.Forms.CheckBox();
            this.checkBoxGestionGrupos = new System.Windows.Forms.CheckBox();
            this.groupBoxPermisos.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewPerfiles
            // 
            this.listViewPerfiles.HideSelection = false;
            this.listViewPerfiles.Location = new System.Drawing.Point(31, 85);
            this.listViewPerfiles.Name = "listViewPerfiles";
            this.listViewPerfiles.Size = new System.Drawing.Size(137, 226);
            this.listViewPerfiles.TabIndex = 0;
            this.listViewPerfiles.UseCompatibleStateImageBehavior = false;
            // 
            // labelNombrePerfil
            // 
            this.labelNombrePerfil.AutoSize = true;
            this.labelNombrePerfil.Location = new System.Drawing.Point(176, 85);
            this.labelNombrePerfil.Name = "labelNombrePerfil";
            this.labelNombrePerfil.Size = new System.Drawing.Size(70, 13);
            this.labelNombrePerfil.TabIndex = 1;
            this.labelNombrePerfil.Text = "Nombre Perfil";
            // 
            // textBoxNombrePerfil
            // 
            this.textBoxNombrePerfil.Location = new System.Drawing.Point(267, 81);
            this.textBoxNombrePerfil.Name = "textBoxNombrePerfil";
            this.textBoxNombrePerfil.Size = new System.Drawing.Size(410, 20);
            this.textBoxNombrePerfil.TabIndex = 2;
            // 
            // labelPermisos
            // 
            this.labelPermisos.AutoSize = true;
            this.labelPermisos.Location = new System.Drawing.Point(178, 141);
            this.labelPermisos.Name = "labelPermisos";
            this.labelPermisos.Size = new System.Drawing.Size(52, 13);
            this.labelPermisos.TabIndex = 3;
            this.labelPermisos.Text = "Permisos:";
            // 
            // checkBoxPermisosTodos
            // 
            this.checkBoxPermisosTodos.AutoSize = true;
            this.checkBoxPermisosTodos.Location = new System.Drawing.Point(267, 139);
            this.checkBoxPermisosTodos.Name = "checkBoxPermisosTodos";
            this.checkBoxPermisosTodos.Size = new System.Drawing.Size(115, 17);
            this.checkBoxPermisosTodos.TabIndex = 4;
            this.checkBoxPermisosTodos.Text = "Seleccionar Todos";
            this.checkBoxPermisosTodos.UseVisualStyleBackColor = true;
            // 
            // checkBoxPermisosVaciar
            // 
            this.checkBoxPermisosVaciar.AutoSize = true;
            this.checkBoxPermisosVaciar.Location = new System.Drawing.Point(464, 139);
            this.checkBoxPermisosVaciar.Name = "checkBoxPermisosVaciar";
            this.checkBoxPermisosVaciar.Size = new System.Drawing.Size(89, 17);
            this.checkBoxPermisosVaciar.TabIndex = 5;
            this.checkBoxPermisosVaciar.Text = "Vaciar Todos";
            this.checkBoxPermisosVaciar.UseVisualStyleBackColor = true;
            // 
            // groupBoxPermisos
            // 
            this.groupBoxPermisos.Controls.Add(this.checkBoxGestionGrupos);
            this.groupBoxPermisos.Controls.Add(this.checkBoxGestionPerfiles);
            this.groupBoxPermisos.Controls.Add(this.checkBoxGestionarUsuarios);
            this.groupBoxPermisos.Controls.Add(this.checkBoxGestionSkills);
            this.groupBoxPermisos.Controls.Add(this.checkBoxGestionListaSkills);
            this.groupBoxPermisos.Controls.Add(this.checkBoxGestionarKPIs);
            this.groupBoxPermisos.Location = new System.Drawing.Point(177, 185);
            this.groupBoxPermisos.Name = "groupBoxPermisos";
            this.groupBoxPermisos.Size = new System.Drawing.Size(500, 126);
            this.groupBoxPermisos.TabIndex = 6;
            this.groupBoxPermisos.TabStop = false;
            this.groupBoxPermisos.Text = "groupBoxPermisos";
            this.groupBoxPermisos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 7;
            // 
            // checkBoxGestionarKPIs
            // 
            this.checkBoxGestionarKPIs.AutoSize = true;
            this.checkBoxGestionarKPIs.Location = new System.Drawing.Point(24, 24);
            this.checkBoxGestionarKPIs.Name = "checkBoxGestionarKPIs";
            this.checkBoxGestionarKPIs.Size = new System.Drawing.Size(96, 17);
            this.checkBoxGestionarKPIs.TabIndex = 0;
            this.checkBoxGestionarKPIs.Text = "Gestionar KPIs";
            this.checkBoxGestionarKPIs.UseVisualStyleBackColor = true;
            // 
            // checkBoxGestionListaSkills
            // 
            this.checkBoxGestionListaSkills.AutoSize = true;
            this.checkBoxGestionListaSkills.Location = new System.Drawing.Point(198, 24);
            this.checkBoxGestionListaSkills.Name = "checkBoxGestionListaSkills";
            this.checkBoxGestionListaSkills.Size = new System.Drawing.Size(123, 17);
            this.checkBoxGestionListaSkills.TabIndex = 1;
            this.checkBoxGestionListaSkills.Text = "Gestionar Lista Skills";
            this.checkBoxGestionListaSkills.UseVisualStyleBackColor = true;
            // 
            // checkBoxGestionSkills
            // 
            this.checkBoxGestionSkills.AutoSize = true;
            this.checkBoxGestionSkills.Location = new System.Drawing.Point(394, 24);
            this.checkBoxGestionSkills.Name = "checkBoxGestionSkills";
            this.checkBoxGestionSkills.Size = new System.Drawing.Size(98, 17);
            this.checkBoxGestionSkills.TabIndex = 2;
            this.checkBoxGestionSkills.Text = "Gestionar Skills";
            this.checkBoxGestionSkills.UseVisualStyleBackColor = true;
            // 
            // checkBoxGestionarUsuarios
            // 
            this.checkBoxGestionarUsuarios.AutoSize = true;
            this.checkBoxGestionarUsuarios.Location = new System.Drawing.Point(24, 79);
            this.checkBoxGestionarUsuarios.Name = "checkBoxGestionarUsuarios";
            this.checkBoxGestionarUsuarios.Size = new System.Drawing.Size(115, 17);
            this.checkBoxGestionarUsuarios.TabIndex = 3;
            this.checkBoxGestionarUsuarios.Text = "Gestionar Usuarios";
            this.checkBoxGestionarUsuarios.UseVisualStyleBackColor = true;
            // 
            // checkBoxGestionPerfiles
            // 
            this.checkBoxGestionPerfiles.AutoSize = true;
            this.checkBoxGestionPerfiles.Location = new System.Drawing.Point(198, 79);
            this.checkBoxGestionPerfiles.Name = "checkBoxGestionPerfiles";
            this.checkBoxGestionPerfiles.Size = new System.Drawing.Size(108, 17);
            this.checkBoxGestionPerfiles.TabIndex = 4;
            this.checkBoxGestionPerfiles.Text = "Gestionar Perfiles";
            this.checkBoxGestionPerfiles.UseVisualStyleBackColor = true;
            // 
            // checkBoxGestionGrupos
            // 
            this.checkBoxGestionGrupos.AutoSize = true;
            this.checkBoxGestionGrupos.Location = new System.Drawing.Point(394, 79);
            this.checkBoxGestionGrupos.Name = "checkBoxGestionGrupos";
            this.checkBoxGestionGrupos.Size = new System.Drawing.Size(108, 17);
            this.checkBoxGestionGrupos.TabIndex = 5;
            this.checkBoxGestionGrupos.Text = "Gestionar Grupos";
            this.checkBoxGestionGrupos.UseVisualStyleBackColor = true;
            // 
            // FormGestionPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxPermisos);
            this.Controls.Add(this.checkBoxPermisosVaciar);
            this.Controls.Add(this.checkBoxPermisosTodos);
            this.Controls.Add(this.labelPermisos);
            this.Controls.Add(this.textBoxNombrePerfil);
            this.Controls.Add(this.labelNombrePerfil);
            this.Controls.Add(this.listViewPerfiles);
            this.Name = "FormGestionPerfil";
            this.Text = "FormGestionPerfil";
            this.groupBoxPermisos.ResumeLayout(false);
            this.groupBoxPermisos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPerfiles;
        private System.Windows.Forms.Label labelNombrePerfil;
        private System.Windows.Forms.TextBox textBoxNombrePerfil;
        private System.Windows.Forms.Label labelPermisos;
        private System.Windows.Forms.CheckBox checkBoxPermisosTodos;
        private System.Windows.Forms.CheckBox checkBoxPermisosVaciar;
        private System.Windows.Forms.GroupBox groupBoxPermisos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxGestionGrupos;
        private System.Windows.Forms.CheckBox checkBoxGestionPerfiles;
        private System.Windows.Forms.CheckBox checkBoxGestionarUsuarios;
        private System.Windows.Forms.CheckBox checkBoxGestionSkills;
        private System.Windows.Forms.CheckBox checkBoxGestionListaSkills;
        private System.Windows.Forms.CheckBox checkBoxGestionarKPIs;
    }
}