
namespace DesktopApp
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxContrasenya = new System.Windows.Forms.TextBox();
            this.buttonIniciarSesion = new System.Windows.Forms.Button();
            this.linkForgetPassword = new System.Windows.Forms.LinkLabel();
            this.pnBarra = new System.Windows.Forms.Panel();
            this.pcIcono = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pb_minimize = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.ckbLookPass = new System.Windows.Forms.CheckBox();
            this.txtError = new System.Windows.Forms.Label();
            this.pbError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbError)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 98);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(346, 107);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(86, 20);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(346, 186);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(83, 20);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsername.Location = new System.Drawing.Point(349, 131);
            this.txtBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(276, 26);
            this.txtBoxUsername.TabIndex = 3;
            // 
            // txtBoxContrasenya
            // 
            this.txtBoxContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxContrasenya.Location = new System.Drawing.Point(350, 210);
            this.txtBoxContrasenya.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxContrasenya.Name = "txtBoxContrasenya";
            this.txtBoxContrasenya.Size = new System.Drawing.Size(276, 26);
            this.txtBoxContrasenya.TabIndex = 4;
            this.txtBoxContrasenya.UseSystemPasswordChar = true;
            // 
            // buttonIniciarSesion
            // 
            this.buttonIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.buttonIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIniciarSesion.Location = new System.Drawing.Point(535, 355);
            this.buttonIniciarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIniciarSesion.Name = "buttonIniciarSesion";
            this.buttonIniciarSesion.Size = new System.Drawing.Size(115, 28);
            this.buttonIniciarSesion.TabIndex = 5;
            this.buttonIniciarSesion.Text = "Iniciar Sesion";
            this.buttonIniciarSesion.UseVisualStyleBackColor = false;
            this.buttonIniciarSesion.Click += new System.EventHandler(this.buttonIniciarSesion_Click);
            // 
            // linkForgetPassword
            // 
            this.linkForgetPassword.AutoSize = true;
            this.linkForgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkForgetPassword.Location = new System.Drawing.Point(347, 320);
            this.linkForgetPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkForgetPassword.Name = "linkForgetPassword";
            this.linkForgetPassword.Size = new System.Drawing.Size(196, 17);
            this.linkForgetPassword.TabIndex = 6;
            this.linkForgetPassword.TabStop = true;
            this.linkForgetPassword.Text = "¿Has olvidado la contraseña?";
            this.linkForgetPassword.Visible = false;
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
            this.pnBarra.Size = new System.Drawing.Size(694, 37);
            this.pnBarra.TabIndex = 7;
            this.pnBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnBarra_MouseDown);
            // 
            // pcIcono
            // 
            this.pcIcono.Image = ((System.Drawing.Image)(resources.GetObject("pcIcono.Image")));
            this.pcIcono.Location = new System.Drawing.Point(12, 10);
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
            this.lbTitulo.Size = new System.Drawing.Size(92, 17);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "Iniciar Sesion";
            this.lbTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitulo_MouseDown);
            // 
            // pb_minimize
            // 
            this.pb_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pb_minimize.Image")));
            this.pb_minimize.Location = new System.Drawing.Point(625, 10);
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
            this.pb_close.Image = ((System.Drawing.Image)(resources.GetObject("pb_close.Image")));
            this.pb_close.Location = new System.Drawing.Point(656, 10);
            this.pb_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(25, 25);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_close.TabIndex = 8;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            // 
            // ckbLookPass
            // 
            this.ckbLookPass.AutoSize = true;
            this.ckbLookPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbLookPass.Location = new System.Drawing.Point(350, 243);
            this.ckbLookPass.Name = "ckbLookPass";
            this.ckbLookPass.Size = new System.Drawing.Size(162, 21);
            this.ckbLookPass.TabIndex = 8;
            this.ckbLookPass.Text = "Mostrar Contrasenya";
            this.ckbLookPass.UseVisualStyleBackColor = true;
            this.ckbLookPass.CheckedChanged += new System.EventHandler(this.ckbLookPass_CheckedChanged);
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.ForeColor = System.Drawing.Color.Red;
            this.txtError.Location = new System.Drawing.Point(392, 285);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(223, 17);
            this.txtError.TabIndex = 9;
            this.txtError.Text = "Usuario y/o contrasenya erroneas";
            this.txtError.Visible = false;
            // 
            // pbError
            // 
            this.pbError.Image = ((System.Drawing.Image)(resources.GetObject("pbError.Image")));
            this.pbError.Location = new System.Drawing.Point(350, 278);
            this.pbError.Name = "pbError";
            this.pbError.Size = new System.Drawing.Size(31, 29);
            this.pbError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbError.TabIndex = 10;
            this.pbError.TabStop = false;
            this.pbError.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 406);
            this.Controls.Add(this.pbError);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.ckbLookPass);
            this.Controls.Add(this.pnBarra);
            this.Controls.Add(this.linkForgetPassword);
            this.Controls.Add(this.buttonIniciarSesion);
            this.Controls.Add(this.txtBoxContrasenya);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnBarra.ResumeLayout(false);
            this.pnBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxContrasenya;
        private System.Windows.Forms.Button buttonIniciarSesion;
        private System.Windows.Forms.LinkLabel linkForgetPassword;
        private System.Windows.Forms.Panel pnBarra;
        private System.Windows.Forms.PictureBox pb_minimize;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.CheckBox ckbLookPass;
        private System.Windows.Forms.PictureBox pcIcono;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label txtError;
        private System.Windows.Forms.PictureBox pbError;
    }
}