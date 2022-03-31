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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearUsuarios));
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
            this.cbActiu = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbLookPassword = new System.Windows.Forms.CheckBox();
            this.cbRepeatPassword = new System.Windows.Forms.CheckBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.pb_minimize = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.pnBarra = new System.Windows.Forms.Panel();
            this.pcIcono = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsRols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            this.pnBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcono)).BeginInit();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario:";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(54, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repetir Contraseña:";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seleccionar Perfil:";
            //
            // btnSave
            //
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(588, 555);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //
            // btnCancel
            //
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(709, 555);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            //
            // btnGroupManagment
            //
            this.btnGroupManagment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnGroupManagment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupManagment.Location = new System.Drawing.Point(480, 486);
            this.btnGroupManagment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGroupManagment.Name = "btnGroupManagment";
            this.btnGroupManagment.Size = new System.Drawing.Size(180, 36);
            this.btnGroupManagment.TabIndex = 7;
            this.btnGroupManagment.Text = "Gestión de Grupos";
            this.btnGroupManagment.UseVisualStyleBackColor = false;
            //
            // tbUser
            //
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.Location = new System.Drawing.Point(241, 209);
            this.tbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(419, 28);
            this.tbUser.TabIndex = 10;
            //
            // cbxSelectionPerfil
            //
            this.cbxSelectionPerfil.DataSource = this.bsRols;
            this.cbxSelectionPerfil.DisplayMember = "nom";
            this.cbxSelectionPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectionPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectionPerfil.FormattingEnabled = true;
            this.cbxSelectionPerfil.Location = new System.Drawing.Point(241, 432);
            this.cbxSelectionPerfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxSelectionPerfil.Name = "cbxSelectionPerfil";
            this.cbxSelectionPerfil.Size = new System.Drawing.Size(419, 30);
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
            this.tbRepeatPassword.Location = new System.Drawing.Point(241, 379);
            this.tbRepeatPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRepeatPassword.Name = "tbRepeatPassword";
            this.tbRepeatPassword.Size = new System.Drawing.Size(419, 28);
            this.tbRepeatPassword.TabIndex = 15;
            //
            // tbPassword
            //
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(241, 318);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(419, 28);
            this.tbPassword.TabIndex = 16;
            //
            // cbActiu
            //
            this.cbActiu.AutoSize = true;
            this.cbActiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActiu.Location = new System.Drawing.Point(241, 497);
            this.cbActiu.Name = "cbActiu";
            this.cbActiu.Size = new System.Drawing.Size(83, 28);
            this.cbActiu.TabIndex = 2;
            this.cbActiu.Text = "Activo";
            this.cbActiu.UseVisualStyleBackColor = true;
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Correo:";
            //
            // tbEmail
            //
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(241, 264);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(419, 28);
            this.tbEmail.TabIndex = 20;
            //
            // cbLookPassword
            //
            this.cbLookPassword.AutoSize = true;
            this.cbLookPassword.Location = new System.Drawing.Point(669, 325);
            this.cbLookPassword.Name = "cbLookPassword";
            this.cbLookPassword.Size = new System.Drawing.Size(128, 21);
            this.cbLookPassword.TabIndex = 21;
            this.cbLookPassword.Text = "Mostrar/Ocultar";
            this.cbLookPassword.UseVisualStyleBackColor = true;
            this.cbLookPassword.CheckedChanged += new System.EventHandler(this.cbLookPassword_CheckedChanged);
            //
            // cbRepeatPassword
            //
            this.cbRepeatPassword.AutoSize = true;
            this.cbRepeatPassword.Location = new System.Drawing.Point(669, 385);
            this.cbRepeatPassword.Name = "cbRepeatPassword";
            this.cbRepeatPassword.Size = new System.Drawing.Size(128, 21);
            this.cbRepeatPassword.TabIndex = 22;
            this.cbRepeatPassword.Text = "Mostrar/Ocultar";
            this.cbRepeatPassword.UseVisualStyleBackColor = true;
            this.cbRepeatPassword.CheckedChanged += new System.EventHandler(this.cbRepeatPassword_CheckedChanged);
            //
            // lbName
            //
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(54, 88);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(79, 24);
            this.lbName.TabIndex = 23;
            this.lbName.Text = "Nombre:";
            //
            // lbLastName
            //
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.Location = new System.Drawing.Point(55, 148);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(92, 24);
            this.lbLastName.TabIndex = 24;
            this.lbLastName.Text = "Apellidos:";
            //
            // tbName
            //
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(241, 85);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(419, 28);
            this.tbName.TabIndex = 25;
            //
            // tbLastName
            //
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(241, 145);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(419, 28);
            this.tbLastName.TabIndex = 26;
            //
            // pb_minimize
            //
            this.pb_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pb_minimize.Image")));
            this.pb_minimize.Location = new System.Drawing.Point(772, 10);
            this.pb_minimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_minimize.Name = "pb_minimize";
            this.pb_minimize.Size = new System.Drawing.Size(25, 25);
            this.pb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_minimize.TabIndex = 9;
            this.pb_minimize.TabStop = false;
            this.pb_minimize.Click += new System.EventHandler(this.pb_minimize_Click);
            //
            // pb_close
            //
            this.pb_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_close.Image = ((System.Drawing.Image)(resources.GetObject("pb_close.Image")));
            this.pb_close.Location = new System.Drawing.Point(803, 10);
            this.pb_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(25, 25);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_close.TabIndex = 8;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            //
            // pnBarra
            //
            this.pnBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.pnBarra.Controls.Add(this.pcIcono);
            this.pnBarra.Controls.Add(this.lbTitulo);
            this.pnBarra.Controls.Add(this.pb_minimize);
            this.pnBarra.Controls.Add(this.pb_close);
            this.pnBarra.Location = new System.Drawing.Point(0, 0);
            this.pnBarra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnBarra.Name = "pnBarra";
            this.pnBarra.Size = new System.Drawing.Size(841, 37);
            this.pnBarra.TabIndex = 27;
            this.pnBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnBarra_MouseDown);
            //
            // pcIcono
            //
            this.pcIcono.Image = ((System.Drawing.Image)(resources.GetObject("pcIcono.Image")));
            this.pcIcono.Location = new System.Drawing.Point(24, 11);
            this.pcIcono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcIcono.Name = "pcIcono";
            this.pcIcono.Size = new System.Drawing.Size(25, 25);
            this.pcIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcIcono.TabIndex = 11;
            this.pcIcono.TabStop = false;
            this.pcIcono.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcIcono_MouseDown);
            //
            // lbTitulo
            //
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(55, 10);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(96, 17);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "Crear Usuario";
            this.lbTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitulo_MouseDown);
            //
            // FormCrearUsuarios
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 627);
            this.Controls.Add(this.pnBarra);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.cbRepeatPassword);
            this.Controls.Add(this.cbLookPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbActiu);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCrearUsuarios";
            this.Text = "FormCrearUsuarios";
            this.Load += new System.EventHandler(this.FormCrearUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            this.pnBarra.ResumeLayout(false);
            this.pnBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcono)).EndInit();
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
        private System.Windows.Forms.PictureBox pb_minimize;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.Panel pnBarra;
        private System.Windows.Forms.PictureBox pcIcono;
        private System.Windows.Forms.Label lbTitulo;
    }
}
