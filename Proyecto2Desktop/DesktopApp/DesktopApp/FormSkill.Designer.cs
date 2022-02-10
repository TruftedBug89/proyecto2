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
            this.txtWordSkill = new System.Windows.Forms.TextBox();
            this.lblLetraSkill = new System.Windows.Forms.Label();
            this.lblBColor = new System.Windows.Forms.Label();
            this.lblTcolor = new System.Windows.Forms.Label();
            this.cbxBcolors = new System.Windows.Forms.ComboBox();
            this.cbxTcolors = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlWordsSkills = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtNameSkill = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlWordsSkills.SuspendLayout();
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
            // txtWordSkill
            // 
            this.txtWordSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordSkill.Location = new System.Drawing.Point(225, 224);
            this.txtWordSkill.Name = "txtWordSkill";
            this.txtWordSkill.Size = new System.Drawing.Size(184, 158);
            this.txtWordSkill.TabIndex = 4;
            this.txtWordSkill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 562);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1192, 78);
            this.panel2.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(639, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 42);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(488, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 42);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // pnlWordsSkills
            // 
            this.pnlWordsSkills.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlWordsSkills.Controls.Add(this.btnAdd);
            this.pnlWordsSkills.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlWordsSkills.Location = new System.Drawing.Point(0, 431);
            this.pnlWordsSkills.Name = "pnlWordsSkills";
            this.pnlWordsSkills.Size = new System.Drawing.Size(1192, 131);
            this.pnlWordsSkills.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(47, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 92);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(1043, 114);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 45);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // txtNameSkill
            // 
            this.txtNameSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSkill.Location = new System.Drawing.Point(225, 114);
            this.txtNameSkill.Name = "txtNameSkill";
            this.txtNameSkill.Size = new System.Drawing.Size(789, 45);
            this.txtNameSkill.TabIndex = 3;
            // 
            // FormSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1192, 640);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlWordsSkills);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbxTcolors);
            this.Controls.Add(this.cbxBcolors);
            this.Controls.Add(this.lblTcolor);
            this.Controls.Add(this.lblBColor);
            this.Controls.Add(this.lblLetraSkill);
            this.Controls.Add(this.txtWordSkill);
            this.Controls.Add(this.txtNameSkill);
            this.Controls.Add(this.lblNombreSkill);
            this.Controls.Add(this.panel1);
            this.Name = "FormSkill";
            this.Text = "FormSkill";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlWordsSkills.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombreSkill;
        private System.Windows.Forms.TextBox txtWordSkill;
        private System.Windows.Forms.Label lblLetraSkill;
        private System.Windows.Forms.Label lblBColor;
        private System.Windows.Forms.Label lblTcolor;
        private System.Windows.Forms.ComboBox cbxBcolors;
        private System.Windows.Forms.ComboBox cbxTcolors;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlWordsSkills;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtNameSkill;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}