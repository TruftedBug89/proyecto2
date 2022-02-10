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
            this.lblNombreListaSkill = new System.Windows.Forms.Label();
            this.txtNombreSkill = new System.Windows.Forms.TextBox();
            this.btnConstruirTabla = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGestionListaSkills = new System.Windows.Forms.Button();
            this.dgvListaSkills = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxBcolors = new System.Windows.Forms.ComboBox();
            this.btnGestionarGrupos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSkills)).BeginInit();
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
            // lblNombreListaSkill
            // 
            this.lblNombreListaSkill.AutoSize = true;
            this.lblNombreListaSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreListaSkill.Location = new System.Drawing.Point(51, 204);
            this.lblNombreListaSkill.Name = "lblNombreListaSkill";
            this.lblNombreListaSkill.Size = new System.Drawing.Size(212, 24);
            this.lblNombreListaSkill.TabIndex = 3;
            this.lblNombreListaSkill.Text = "Lista de Skills(Siglas):";
            // 
            // txtNombreSkill
            // 
            this.txtNombreSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSkill.Location = new System.Drawing.Point(282, 192);
            this.txtNombreSkill.Name = "txtNombreSkill";
            this.txtNombreSkill.Size = new System.Drawing.Size(673, 45);
            this.txtNombreSkill.TabIndex = 4;
            // 
            // btnConstruirTabla
            // 
            this.btnConstruirTabla.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnConstruirTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConstruirTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConstruirTabla.ForeColor = System.Drawing.Color.White;
            this.btnConstruirTabla.Location = new System.Drawing.Point(976, 195);
            this.btnConstruirTabla.Name = "btnConstruirTabla";
            this.btnConstruirTabla.Size = new System.Drawing.Size(258, 42);
            this.btnConstruirTabla.TabIndex = 5;
            this.btnConstruirTabla.Text = "Aceptar y construir tabla";
            this.btnConstruirTabla.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnGestionListaSkills);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1445, 111);
            this.panel2.TabIndex = 6;
            // 
            // btnGestionListaSkills
            // 
            this.btnGestionListaSkills.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGestionListaSkills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionListaSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionListaSkills.ForeColor = System.Drawing.Color.White;
            this.btnGestionListaSkills.Location = new System.Drawing.Point(35, 20);
            this.btnGestionListaSkills.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestionListaSkills.Name = "btnGestionListaSkills";
            this.btnGestionListaSkills.Size = new System.Drawing.Size(176, 66);
            this.btnGestionListaSkills.TabIndex = 3;
            this.btnGestionListaSkills.Text = "+";
            this.btnGestionListaSkills.UseVisualStyleBackColor = false;
            // 
            // dgvListaSkills
            // 
            this.dgvListaSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSkills.Location = new System.Drawing.Point(215, 266);
            this.dgvListaSkills.Name = "dgvListaSkills";
            this.dgvListaSkills.RowHeadersWidth = 51;
            this.dgvListaSkills.RowTemplate.Height = 24;
            this.dgvListaSkills.Size = new System.Drawing.Size(918, 366);
            this.dgvListaSkills.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(1306, 194);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 45);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(602, 677);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 42);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(742, 677);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 42);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1150, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Grupos:";
            // 
            // cbxBcolors
            // 
            this.cbxBcolors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBcolors.FormattingEnabled = true;
            this.cbxBcolors.Location = new System.Drawing.Point(1240, 310);
            this.cbxBcolors.Name = "cbxBcolors";
            this.cbxBcolors.Size = new System.Drawing.Size(179, 30);
            this.cbxBcolors.TabIndex = 17;
            // 
            // btnGestionarGrupos
            // 
            this.btnGestionarGrupos.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGestionarGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarGrupos.ForeColor = System.Drawing.Color.White;
            this.btnGestionarGrupos.Location = new System.Drawing.Point(1154, 379);
            this.btnGestionarGrupos.Name = "btnGestionarGrupos";
            this.btnGestionarGrupos.Size = new System.Drawing.Size(182, 42);
            this.btnGestionarGrupos.TabIndex = 18;
            this.btnGestionarGrupos.Text = "Gestionar Grupos";
            this.btnGestionarGrupos.UseVisualStyleBackColor = false;
            // 
            // FormListaSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 731);
            this.Controls.Add(this.btnGestionarGrupos);
            this.Controls.Add(this.cbxBcolors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvListaSkills);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnConstruirTabla);
            this.Controls.Add(this.txtNombreSkill);
            this.Controls.Add(this.lblNombreListaSkill);
            this.Controls.Add(this.panel1);
            this.Name = "FormListaSkills";
            this.Text = "FormListaSkills";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSkills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.Label lblNombreListaSkill;
        private System.Windows.Forms.TextBox txtNombreSkill;
        private System.Windows.Forms.Button btnConstruirTabla;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGestionListaSkills;
        private System.Windows.Forms.DataGridView dgvListaSkills;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxBcolors;
        private System.Windows.Forms.Button btnGestionarGrupos;
    }
}