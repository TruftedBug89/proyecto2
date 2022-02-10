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
            this.btnCloseSession = new System.Windows.Forms.Button();
            this.pnlListSkills = new System.Windows.Forms.Panel();
            this.btnManagementListaSkills = new System.Windows.Forms.Button();
            this.pnlWorldsSkills = new System.Windows.Forms.Panel();
            this.btnManagementSkill = new System.Windows.Forms.Button();
            this.btnManagementKPI = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnManagementUsuarios = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvSkill = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnlListSkills.SuspendLayout();
            this.pnlWorldsSkills.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnCloseSession);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1751, 66);
            this.panel1.TabIndex = 0;
            // 
            // btnCloseSession
            // 
            this.btnCloseSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseSession.BackColor = System.Drawing.Color.Tomato;
            this.btnCloseSession.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCloseSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSession.ForeColor = System.Drawing.Color.White;
            this.btnCloseSession.Location = new System.Drawing.Point(1491, 11);
            this.btnCloseSession.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseSession.Name = "btnCloseSession";
            this.btnCloseSession.Size = new System.Drawing.Size(223, 43);
            this.btnCloseSession.TabIndex = 0;
            this.btnCloseSession.Text = "Cerrar Sesión";
            this.btnCloseSession.UseVisualStyleBackColor = false;
            this.btnCloseSession.Click += new System.EventHandler(this.btnCerrarSesión_Click);
            // 
            // pnlListSkills
            // 
            this.pnlListSkills.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlListSkills.Controls.Add(this.btnManagementListaSkills);
            this.pnlListSkills.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListSkills.Location = new System.Drawing.Point(0, 66);
            this.pnlListSkills.Margin = new System.Windows.Forms.Padding(4);
            this.pnlListSkills.Name = "pnlListSkills";
            this.pnlListSkills.Size = new System.Drawing.Size(1751, 110);
            this.pnlListSkills.TabIndex = 1;
            // 
            // btnManagementListaSkills
            // 
            this.btnManagementListaSkills.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnManagementListaSkills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagementListaSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagementListaSkills.ForeColor = System.Drawing.Color.White;
            this.btnManagementListaSkills.Location = new System.Drawing.Point(35, 20);
            this.btnManagementListaSkills.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagementListaSkills.Name = "btnManagementListaSkills";
            this.btnManagementListaSkills.Size = new System.Drawing.Size(147, 66);
            this.btnManagementListaSkills.TabIndex = 3;
            this.btnManagementListaSkills.Text = "Gestion Lista de Skils";
            this.btnManagementListaSkills.UseVisualStyleBackColor = false;
            this.btnManagementListaSkills.Click += new System.EventHandler(this.btnGestionListaSkills_Click);
            // 
            // pnlWorldsSkills
            // 
            this.pnlWorldsSkills.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlWorldsSkills.Controls.Add(this.btnManagementSkill);
            this.pnlWorldsSkills.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlWorldsSkills.Location = new System.Drawing.Point(0, 846);
            this.pnlWorldsSkills.Margin = new System.Windows.Forms.Padding(4);
            this.pnlWorldsSkills.Name = "pnlWorldsSkills";
            this.pnlWorldsSkills.Size = new System.Drawing.Size(1751, 110);
            this.pnlWorldsSkills.TabIndex = 2;
            // 
            // btnManagementSkill
            // 
            this.btnManagementSkill.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnManagementSkill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagementSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagementSkill.ForeColor = System.Drawing.Color.White;
            this.btnManagementSkill.Location = new System.Drawing.Point(35, 25);
            this.btnManagementSkill.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagementSkill.Name = "btnManagementSkill";
            this.btnManagementSkill.Size = new System.Drawing.Size(171, 59);
            this.btnManagementSkill.TabIndex = 4;
            this.btnManagementSkill.Text = "Gestion Skils";
            this.btnManagementSkill.UseVisualStyleBackColor = false;
            this.btnManagementSkill.Click += new System.EventHandler(this.btnGestionSkill_Click);
            // 
            // btnManagementKPI
            // 
            this.btnManagementKPI.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnManagementKPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagementKPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagementKPI.ForeColor = System.Drawing.Color.White;
            this.btnManagementKPI.Location = new System.Drawing.Point(74, 55);
            this.btnManagementKPI.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagementKPI.Name = "btnManagementKPI";
            this.btnManagementKPI.Size = new System.Drawing.Size(155, 59);
            this.btnManagementKPI.TabIndex = 5;
            this.btnManagementKPI.Text = "Gestion KPI";
            this.btnManagementKPI.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 176);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1751, 35);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 811);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1751, 35);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnManagementUsuarios);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 211);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(259, 600);
            this.panel6.TabIndex = 13;
            // 
            // btnManagementUsuarios
            // 
            this.btnManagementUsuarios.BackColor = System.Drawing.Color.Black;
            this.btnManagementUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagementUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagementUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnManagementUsuarios.Location = new System.Drawing.Point(49, 267);
            this.btnManagementUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagementUsuarios.Name = "btnManagementUsuarios";
            this.btnManagementUsuarios.Size = new System.Drawing.Size(133, 81);
            this.btnManagementUsuarios.TabIndex = 7;
            this.btnManagementUsuarios.Text = "Gestion Usuarios";
            this.btnManagementUsuarios.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnManagementKPI);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1491, 211);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(260, 600);
            this.panel7.TabIndex = 14;
            // 
            // dgvSkill
            // 
            this.dgvSkill.ColumnHeadersHeight = 29;
            this.dgvSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSkill.Location = new System.Drawing.Point(259, 211);
            this.dgvSkill.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSkill.Name = "dgvSkill";
            this.dgvSkill.RowHeadersWidth = 51;
            this.dgvSkill.Size = new System.Drawing.Size(1232, 600);
            this.dgvSkill.TabIndex = 16;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1751, 956);
            this.Controls.Add(this.dgvSkill);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlWorldsSkills);
            this.Controls.Add(this.pnlListSkills);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.pnlListSkills.ResumeLayout(false);
            this.pnlWorldsSkills.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseSession;
        private System.Windows.Forms.Panel pnlListSkills;
        private System.Windows.Forms.Panel pnlWorldsSkills;
        private System.Windows.Forms.Button btnManagementListaSkills;
        private System.Windows.Forms.Button btnManagementSkill;
        private System.Windows.Forms.Button btnManagementKPI;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnManagementUsuarios;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvSkill;
    }
}