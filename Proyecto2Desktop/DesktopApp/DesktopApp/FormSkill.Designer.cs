namespace DesktopApp
{
    partial class FormSkill
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
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreSkill = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLetraSkill = new System.Windows.Forms.Label();
            this.lblBColor = new System.Windows.Forms.Label();
            this.lblTcolor = new System.Windows.Forms.Label();
            this.cbxBcolors = new System.Windows.Forms.ComboBox();
            this.cbxTcolors = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlLetrasSkills = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtNombreSkill = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlLetrasSkills.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnCerrarSesión);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 51);
            this.panel1.TabIndex = 1;
            // 
            // lblNombreSkill
            // 
            this.lblNombreSkill.AutoSize = true;
            this.lblNombreSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSkill.Location = new System.Drawing.Point(73, 121);
            this.lblNombreSkill.Name = "lblNombreSkill";
            this.lblNombreSkill.Size = new System.Drawing.Size(135, 24);
            this.lblNombreSkill.TabIndex = 2;
            this.lblNombreSkill.Text = "Nombre Skill:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(225, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 158);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLetraSkill
            // 
            this.lblLetraSkill.AutoSize = true;
            this.lblLetraSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetraSkill.Location = new System.Drawing.Point(101, 274);
            this.lblLetraSkill.Name = "lblLetraSkill";
            this.lblLetraSkill.Size = new System.Drawing.Size(106, 24);
            this.lblLetraSkill.TabIndex = 5;
            this.lblLetraSkill.Text = "Letra Skill:";
            // 
            // lblBColor
            // 
            this.lblBColor.AutoSize = true;
            this.lblBColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBColor.Location = new System.Drawing.Point(564, 230);
            this.lblBColor.Name = "lblBColor";
            this.lblBColor.Size = new System.Drawing.Size(184, 24);
            this.lblBColor.TabIndex = 6;
            this.lblBColor.Text = "Background Color:";
            // 
            // lblTcolor
            // 
            this.lblTcolor.AutoSize = true;
            this.lblTcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTcolor.Location = new System.Drawing.Point(635, 333);
            this.lblTcolor.Name = "lblTcolor";
            this.lblTcolor.Size = new System.Drawing.Size(113, 24);
            this.lblTcolor.TabIndex = 7;
            this.lblTcolor.Text = "Text Color:";
            // 
            // cbxBcolors
            // 
            this.cbxBcolors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBcolors.FormattingEnabled = true;
            this.cbxBcolors.Location = new System.Drawing.Point(781, 227);
            this.cbxBcolors.Name = "cbxBcolors";
            this.cbxBcolors.Size = new System.Drawing.Size(233, 30);
            this.cbxBcolors.TabIndex = 8;
            // 
            // cbxTcolors
            // 
            this.cbxTcolors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTcolors.FormattingEnabled = true;
            this.cbxTcolors.Location = new System.Drawing.Point(781, 327);
            this.cbxTcolors.Name = "cbxTcolors";
            this.cbxTcolors.Size = new System.Drawing.Size(233, 30);
            this.cbxTcolors.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 562);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1192, 78);
            this.panel2.TabIndex = 10;
            // 
            // pnlLetrasSkills
            // 
            this.pnlLetrasSkills.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLetrasSkills.Controls.Add(this.btnAñadir);
            this.pnlLetrasSkills.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLetrasSkills.Location = new System.Drawing.Point(0, 431);
            this.pnlLetrasSkills.Name = "pnlLetrasSkills";
            this.pnlLetrasSkills.Size = new System.Drawing.Size(1192, 131);
            this.pnlLetrasSkills.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(488, 18);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 42);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(1043, 114);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 45);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // txtNombreSkill
            // 
            this.txtNombreSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSkill.Location = new System.Drawing.Point(225, 114);
            this.txtNombreSkill.Name = "txtNombreSkill";
            this.txtNombreSkill.Size = new System.Drawing.Size(789, 45);
            this.txtNombreSkill.TabIndex = 3;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.Location = new System.Drawing.Point(47, 18);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(101, 92);
            this.btnAñadir.TabIndex = 0;
            this.btnAñadir.Text = "+";
            this.btnAñadir.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(639, 18);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 42);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1192, 640);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pnlLetrasSkills);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbxTcolors);
            this.Controls.Add(this.cbxBcolors);
            this.Controls.Add(this.lblTcolor);
            this.Controls.Add(this.lblBColor);
            this.Controls.Add(this.lblLetraSkill);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNombreSkill);
            this.Controls.Add(this.lblNombreSkill);
            this.Controls.Add(this.panel1);
            this.Name = "FormSkill";
            this.Text = "FormSkill";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlLetrasSkills.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombreSkill;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLetraSkill;
        private System.Windows.Forms.Label lblBColor;
        private System.Windows.Forms.Label lblTcolor;
        private System.Windows.Forms.ComboBox cbxBcolors;
        private System.Windows.Forms.ComboBox cbxTcolors;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlLetrasSkills;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNombreSkill;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnSalir;
    }
}