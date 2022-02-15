namespace DesktopApp
{
    partial class FormPrincipal
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
            this.pnlListaSkills = new System.Windows.Forms.Panel();
            this.btnGestionListaSkills = new System.Windows.Forms.Button();
            this.pnlLetrasSkills = new System.Windows.Forms.Panel();
            this.btnGestionSkill = new System.Windows.Forms.Button();
            this.btnGestionKPI = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvSkill = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnlListaSkills.SuspendLayout();
            this.pnlLetrasSkills.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnCerrarSesión);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1970, 82);
            this.panel1.TabIndex = 0;
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesión.BackColor = System.Drawing.Color.Tomato;
            this.btnCerrarSesión.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCerrarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesión.Location = new System.Drawing.Point(1677, 14);
            this.btnCerrarSesión.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(251, 54);
            this.btnCerrarSesión.TabIndex = 0;
            this.btnCerrarSesión.Text = "Cerar Sesión";
            this.btnCerrarSesión.UseVisualStyleBackColor = false;
            this.btnCerrarSesión.Click += new System.EventHandler(this.btnCerrarSesión_Click);
            // 
            // pnlListaSkills
            // 
            this.pnlListaSkills.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlListaSkills.Controls.Add(this.btnGestionListaSkills);
            this.pnlListaSkills.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListaSkills.Location = new System.Drawing.Point(0, 82);
            this.pnlListaSkills.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlListaSkills.Name = "pnlListaSkills";
            this.pnlListaSkills.Size = new System.Drawing.Size(1970, 138);
            this.pnlListaSkills.TabIndex = 1;
            // 
            // btnGestionListaSkills
            // 
            this.btnGestionListaSkills.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGestionListaSkills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionListaSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionListaSkills.ForeColor = System.Drawing.Color.White;
            this.btnGestionListaSkills.Location = new System.Drawing.Point(39, 25);
            this.btnGestionListaSkills.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGestionListaSkills.Name = "btnGestionListaSkills";
            this.btnGestionListaSkills.Size = new System.Drawing.Size(165, 82);
            this.btnGestionListaSkills.TabIndex = 3;
            this.btnGestionListaSkills.Text = "Gestion Lista de Skils";
            this.btnGestionListaSkills.UseVisualStyleBackColor = false;
            this.btnGestionListaSkills.Click += new System.EventHandler(this.btnGestionListaSkills_Click);
            // 
            // pnlLetrasSkills
            // 
            this.pnlLetrasSkills.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLetrasSkills.Controls.Add(this.btnGestionSkill);
            this.pnlLetrasSkills.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLetrasSkills.Location = new System.Drawing.Point(0, 1057);
            this.pnlLetrasSkills.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLetrasSkills.Name = "pnlLetrasSkills";
            this.pnlLetrasSkills.Size = new System.Drawing.Size(1970, 138);
            this.pnlLetrasSkills.TabIndex = 2;
            // 
            // btnGestionSkill
            // 
            this.btnGestionSkill.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGestionSkill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionSkill.ForeColor = System.Drawing.Color.White;
            this.btnGestionSkill.Location = new System.Drawing.Point(39, 31);
            this.btnGestionSkill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGestionSkill.Name = "btnGestionSkill";
            this.btnGestionSkill.Size = new System.Drawing.Size(192, 74);
            this.btnGestionSkill.TabIndex = 4;
            this.btnGestionSkill.Text = "Gestion Skils";
            this.btnGestionSkill.UseVisualStyleBackColor = false;
            this.btnGestionSkill.Click += new System.EventHandler(this.btnGestionSkill_Click);
            // 
            // btnGestionKPI
            // 
            this.btnGestionKPI.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGestionKPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionKPI.ForeColor = System.Drawing.Color.White;
            this.btnGestionKPI.Location = new System.Drawing.Point(66, 347);
            this.btnGestionKPI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGestionKPI.Name = "btnGestionKPI";
            this.btnGestionKPI.Size = new System.Drawing.Size(174, 74);
            this.btnGestionKPI.TabIndex = 5;
            this.btnGestionKPI.Text = "Gestion KPI";
            this.btnGestionKPI.UseVisualStyleBackColor = false;
            this.btnGestionKPI.Click += new System.EventHandler(this.btnGestionKPI_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 220);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1970, 44);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 1013);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1970, 44);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnGestionUsuarios);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 264);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(291, 749);
            this.panel6.TabIndex = 13;
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.BackColor = System.Drawing.Color.Black;
            this.btnGestionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnGestionUsuarios.Location = new System.Drawing.Point(55, 334);
            this.btnGestionUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(150, 101);
            this.btnGestionUsuarios.TabIndex = 7;
            this.btnGestionUsuarios.Text = "Gestion Usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnGestionKPI);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1678, 264);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(292, 749);
            this.panel7.TabIndex = 14;
            // 
            // dgvSkill
            // 
            this.dgvSkill.ColumnHeadersHeight = 29;
            this.dgvSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSkill.Location = new System.Drawing.Point(291, 264);
            this.dgvSkill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSkill.Name = "dgvSkill";
            this.dgvSkill.RowHeadersWidth = 51;
            this.dgvSkill.Size = new System.Drawing.Size(1387, 749);
            this.dgvSkill.TabIndex = 16;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1970, 1195);
            this.Controls.Add(this.dgvSkill);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlLetrasSkills);
            this.Controls.Add(this.pnlListaSkills);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.pnlListaSkills.ResumeLayout(false);
            this.pnlLetrasSkills.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.Panel pnlListaSkills;
        private System.Windows.Forms.Panel pnlLetrasSkills;
        private System.Windows.Forms.Button btnGestionListaSkills;
        private System.Windows.Forms.Button btnGestionSkill;
        private System.Windows.Forms.Button btnGestionKPI;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvSkill;
    }
}