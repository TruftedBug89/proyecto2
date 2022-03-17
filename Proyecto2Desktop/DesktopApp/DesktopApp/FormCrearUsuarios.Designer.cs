namespace DesktopApp
{
    partial class FormCrearUsuarios
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGroupManagment = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.cbxSelectionPerfil = new System.Windows.Forms.ComboBox();
            this.bsRols = new System.Windows.Forms.BindingSource(this.components);
            this.tbRepeatPassword = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.cbActiu = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbLookPassword = new System.Windows.Forms.CheckBox();
            this.cbRepeatPassword = new System.Windows.Forms.CheckBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsRols)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(338, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repetir Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(855, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seleccionar Perfil:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(596, 692);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 44);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(731, 692);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 44);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnGroupManagment
            // 
            this.btnGroupManagment.Location = new System.Drawing.Point(740, 557);
            this.btnGroupManagment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGroupManagment.Name = "btnGroupManagment";
            this.btnGroupManagment.Size = new System.Drawing.Size(202, 35);
            this.btnGroupManagment.TabIndex = 7;
            this.btnGroupManagment.Text = "Gestión de Grupos";
            this.btnGroupManagment.UseVisualStyleBackColor = true;
            this.btnGroupManagment.Click += new System.EventHandler(this.btnGroupManagment_Click);
            // 
            // tbUser
            // 
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.Location = new System.Drawing.Point(555, 180);
            this.tbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(179, 32);
            this.tbUser.TabIndex = 10;
            // 
            // cbxSelectionPerfil
            // 
            this.cbxSelectionPerfil.DataSource = this.bsRols;
            this.cbxSelectionPerfil.DisplayMember = "nom";
            this.cbxSelectionPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectionPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbxSelectionPerfil.FormattingEnabled = true;
            this.cbxSelectionPerfil.Location = new System.Drawing.Point(1113, 174);
            this.cbxSelectionPerfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxSelectionPerfil.Name = "cbxSelectionPerfil";
            this.cbxSelectionPerfil.Size = new System.Drawing.Size(195, 34);
            this.cbxSelectionPerfil.TabIndex = 13;
            this.cbxSelectionPerfil.ValueMember = "id";
            // 
            // bsRols
            // 
            this.bsRols.DataSource = typeof(DesktopApp.Models.rols);
            // 
            // tbRepeatPassword
            // 
            this.tbRepeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRepeatPassword.Location = new System.Drawing.Point(596, 384);
            this.tbRepeatPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRepeatPassword.Name = "tbRepeatPassword";
            this.tbRepeatPassword.Size = new System.Drawing.Size(346, 32);
            this.tbRepeatPassword.TabIndex = 15;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(596, 291);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(346, 32);
            this.tbPassword.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCerrarSesión);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1635, 64);
            this.panel1.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.ForeColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(660, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Creación de usuarios";
            // 
            // btnCerrarSesión
            // 
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
            // 
            // cbActiu
            // 
            this.cbActiu.AutoSize = true;
            this.cbActiu.Location = new System.Drawing.Point(587, 557);
            this.cbActiu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbActiu.Name = "cbActiu";
            this.cbActiu.Size = new System.Drawing.Size(78, 24);
            this.cbActiu.TabIndex = 2;
            this.cbActiu.Text = "Activo";
            this.cbActiu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(338, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Correo:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbEmail.Location = new System.Drawing.Point(596, 480);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(513, 32);
            this.tbEmail.TabIndex = 20;
            // 
            // cbLookPassword
            // 
            this.cbLookPassword.AutoSize = true;
            this.cbLookPassword.Location = new System.Drawing.Point(965, 295);
            this.cbLookPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLookPassword.Name = "cbLookPassword";
            this.cbLookPassword.Size = new System.Drawing.Size(144, 24);
            this.cbLookPassword.TabIndex = 21;
            this.cbLookPassword.Text = "Mostrar/Ocultar";
            this.cbLookPassword.UseVisualStyleBackColor = true;
            this.cbLookPassword.CheckedChanged += new System.EventHandler(this.cbLookPassword_CheckedChanged);
            // 
            // cbRepeatPassword
            // 
            this.cbRepeatPassword.AutoSize = true;
            this.cbRepeatPassword.Location = new System.Drawing.Point(965, 384);
            this.cbRepeatPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbRepeatPassword.Name = "cbRepeatPassword";
            this.cbRepeatPassword.Size = new System.Drawing.Size(144, 24);
            this.cbRepeatPassword.TabIndex = 22;
            this.cbRepeatPassword.Text = "Mostrar/Ocultar";
            this.cbRepeatPassword.UseVisualStyleBackColor = true;
            this.cbRepeatPassword.CheckedChanged += new System.EventHandler(this.cbRepeatPassword_CheckedChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbName.Location = new System.Drawing.Point(297, 97);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(96, 26);
            this.lbName.TabIndex = 23;
            this.lbName.Text = "Nombre:";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbLastName.Location = new System.Drawing.Point(647, 99);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(107, 26);
            this.lbLastName.TabIndex = 24;
            this.lbLastName.Text = "Apellidos:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbName.Location = new System.Drawing.Point(417, 99);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(207, 32);
            this.tbName.TabIndex = 25;
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbLastName.Location = new System.Drawing.Point(773, 99);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(535, 32);
            this.tbLastName.TabIndex = 26;
            // 
            // FormCrearUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 759);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.cbRepeatPassword);
            this.Controls.Add(this.cbLookPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbActiu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbRepeatPassword);
            this.Controls.Add(this.cbxSelectionPerfil);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.btnGroupManagment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCrearUsuarios";
            this.Text = "FormCrearUsuarios";
            this.Load += new System.EventHandler(this.FormCrearUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRols)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGroupManagment;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.ComboBox cbxSelectionPerfil;
        private System.Windows.Forms.TextBox tbRepeatPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bsRols;
        private System.Windows.Forms.CheckBox cbActiu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.CheckBox cbLookPassword;
        private System.Windows.Forms.CheckBox cbRepeatPassword;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLastName;
    }
}