namespace DesktopApp
{
    partial class FormListaSkills
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.lblNameListSkills = new System.Windows.Forms.Label();
            this.txtNombreSkill = new System.Windows.Forms.TextBox();
            this.btnBuildTabla = new System.Windows.Forms.Button();
            this.pnlListSkills = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvListSkills = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTeams = new System.Windows.Forms.Label();
            this.cbxTeams = new System.Windows.Forms.ComboBox();
            this.btnManagementGrupos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlListSkills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSkills)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnCerrarSesión);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 51);
            this.panel1.TabIndex = 2;
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.BackColor = System.Drawing.Color.Tomato;
            this.btnCerrarSesión.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCerrarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesión.Location = new System.Drawing.Point(1491, 11);
            this.btnCerrarSesión.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(223, 43);
            this.btnCerrarSesión.TabIndex = 0;
            this.btnCerrarSesión.Text = "Cerar Sesión";
            this.btnCerrarSesión.UseVisualStyleBackColor = false;
            // 
            // lblNameListSkills
            // 
            this.lblNameListSkills.AutoSize = true;
            this.lblNameListSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameListSkills.Location = new System.Drawing.Point(51, 204);
            this.lblNameListSkills.Name = "lblNameListSkills";
            this.lblNameListSkills.Size = new System.Drawing.Size(212, 24);
            this.lblNameListSkills.TabIndex = 3;
            this.lblNameListSkills.Text = "Lista de Skills(Siglas):";
            // 
            // txtNombreSkill
            // 
            this.txtNombreSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSkill.Location = new System.Drawing.Point(282, 192);
            this.txtNombreSkill.Name = "txtNombreSkill";
            this.txtNombreSkill.Size = new System.Drawing.Size(673, 45);
            this.txtNombreSkill.TabIndex = 4;
            // 
            // btnBuildTabla
            // 
            this.btnBuildTabla.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBuildTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuildTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildTabla.ForeColor = System.Drawing.Color.White;
            this.btnBuildTabla.Location = new System.Drawing.Point(976, 195);
            this.btnBuildTabla.Name = "btnBuildTabla";
            this.btnBuildTabla.Size = new System.Drawing.Size(258, 42);
            this.btnBuildTabla.TabIndex = 5;
            this.btnBuildTabla.Text = "Aceptar y construir tabla";
            this.btnBuildTabla.UseVisualStyleBackColor = false;
            // 
            // pnlListSkills
            // 
            this.pnlListSkills.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlListSkills.Controls.Add(this.btnAdd);
            this.pnlListSkills.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListSkills.Location = new System.Drawing.Point(0, 51);
            this.pnlListSkills.Margin = new System.Windows.Forms.Padding(4);
            this.pnlListSkills.Name = "pnlListSkills";
            this.pnlListSkills.Size = new System.Drawing.Size(1445, 111);
            this.pnlListSkills.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(35, 19);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 66);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnGestionListaSkills_Click);
            // 
            // dgvListSkills
            // 
            this.dgvListSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSkills.Location = new System.Drawing.Point(215, 266);
            this.dgvListSkills.Name = "dgvListSkills";
            this.dgvListSkills.RowHeadersWidth = 51;
            this.dgvListSkills.RowTemplate.Height = 24;
            this.dgvListSkills.Size = new System.Drawing.Size(918, 366);
            this.dgvListSkills.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(1306, 194);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 45);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(602, 677);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 42);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(742, 677);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 42);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeams.Location = new System.Drawing.Point(1150, 310);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(84, 24);
            this.lblTeams.TabIndex = 16;
            this.lblTeams.Text = "Grupos:";
            // 
            // cbxTeams
            // 
            this.cbxTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTeams.FormattingEnabled = true;
            this.cbxTeams.Location = new System.Drawing.Point(1240, 310);
            this.cbxTeams.Name = "cbxTeams";
            this.cbxTeams.Size = new System.Drawing.Size(179, 30);
            this.cbxTeams.TabIndex = 17;
            // 
            // btnManagementGrupos
            // 
            this.btnManagementGrupos.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnManagementGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagementGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagementGrupos.ForeColor = System.Drawing.Color.White;
            this.btnManagementGrupos.Location = new System.Drawing.Point(1154, 379);
            this.btnManagementGrupos.Name = "btnManagementGrupos";
            this.btnManagementGrupos.Size = new System.Drawing.Size(182, 42);
            this.btnManagementGrupos.TabIndex = 18;
            this.btnManagementGrupos.Text = "Gestionar Grupos";
            this.btnManagementGrupos.UseVisualStyleBackColor = false;
            // 
            // FormListaSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1445, 731);
            this.Controls.Add(this.btnManagementGrupos);
            this.Controls.Add(this.cbxTeams);
            this.Controls.Add(this.lblTeams);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvListSkills);
            this.Controls.Add(this.pnlListSkills);
            this.Controls.Add(this.btnBuildTabla);
            this.Controls.Add(this.txtNombreSkill);
            this.Controls.Add(this.lblNameListSkills);
            this.Controls.Add(this.panel1);
            this.Name = "FormListaSkills";
            this.Text = "FormListaSkills";
            this.panel1.ResumeLayout(false);
            this.pnlListSkills.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSkills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.Label lblNameListSkills;
        private System.Windows.Forms.TextBox txtNombreSkill;
        private System.Windows.Forms.Button btnBuildTabla;
        private System.Windows.Forms.Panel pnlListSkills;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvListSkills;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.ComboBox cbxTeams;
        private System.Windows.Forms.Button btnManagementGrupos;
    }
}