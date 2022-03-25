
namespace DesktopApp
{
    partial class FormGestionGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionGrupo));
            this.lblNameGroup = new System.Windows.Forms.Label();
            this.txtNameGroup = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbGroups = new System.Windows.Forms.ListBox();
            this.bindingSourceGroups = new System.Windows.Forms.BindingSource(this.components);
            this.cboActivate = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnBarra = new System.Windows.Forms.Panel();
            this.pcIcono = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pb_minimize = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).BeginInit();
            this.pnBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameGroup
            // 
            this.lblNameGroup.AutoSize = true;
            this.lblNameGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameGroup.Location = new System.Drawing.Point(331, 102);
            this.lblNameGroup.Name = "lblNameGroup";
            this.lblNameGroup.Size = new System.Drawing.Size(79, 24);
            this.lblNameGroup.TabIndex = 1;
            this.lblNameGroup.Text = "Nombre";
            // 
            // txtNameGroup
            // 
            this.txtNameGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameGroup.Location = new System.Drawing.Point(335, 139);
            this.txtNameGroup.Name = "txtNameGroup";
            this.txtNameGroup.Size = new System.Drawing.Size(298, 28);
            this.txtNameGroup.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(395, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 31);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(507, 420);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 31);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbGroups
            // 
            this.lbGroups.DataSource = this.bindingSourceGroups;
            this.lbGroups.DisplayMember = "nom";
            this.lbGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGroups.FormattingEnabled = true;
            this.lbGroups.ItemHeight = 22;
            this.lbGroups.Location = new System.Drawing.Point(26, 139);
            this.lbGroups.Name = "lbGroups";
            this.lbGroups.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbGroups.Size = new System.Drawing.Size(283, 312);
            this.lbGroups.TabIndex = 28;
            this.lbGroups.ValueMember = "id";
            this.lbGroups.SelectedIndexChanged += new System.EventHandler(this.lbGroups_SelectedIndexChanged);
            // 
            // bindingSourceGroups
            // 
            this.bindingSourceGroups.DataSource = typeof(DesktopApp.Models.grups);
            // 
            // cboActivate
            // 
            this.cboActivate.Appearance = System.Windows.Forms.Appearance.Button;
            this.cboActivate.BackColor = System.Drawing.SystemColors.ControlText;
            this.cboActivate.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboActivate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cboActivate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.cboActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActivate.ForeColor = System.Drawing.Color.White;
            this.cboActivate.Location = new System.Drawing.Point(335, 180);
            this.cboActivate.Name = "cboActivate";
            this.cboActivate.Size = new System.Drawing.Size(106, 31);
            this.cboActivate.TabIndex = 31;
            this.cboActivate.Text = "Activar";
            this.cboActivate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboActivate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(190, 96);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 30);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "+";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.pnBarra.Size = new System.Drawing.Size(655, 37);
            this.pnBarra.TabIndex = 33;
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
            this.lbTitulo.Size = new System.Drawing.Size(125, 17);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "Gestion de grupos";
            this.lbTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitulo_MouseDown);
            // 
            // pb_minimize
            // 
            this.pb_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pb_minimize.Image")));
            this.pb_minimize.Location = new System.Drawing.Point(588, 10);
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
            this.pb_close.Location = new System.Drawing.Point(619, 10);
            this.pb_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(25, 25);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_close.TabIndex = 8;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Lista de Grupos";
            // 
            // FormGestionGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 483);
            this.Controls.Add(this.pnBarra);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboActivate);
            this.Controls.Add(this.lbGroups);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNameGroup);
            this.Controls.Add(this.lblNameGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionGrupo";
            this.Text = "FormGestionGrupo";
            this.Load += new System.EventHandler(this.FormGestionGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).EndInit();
            this.pnBarra.ResumeLayout(false);
            this.pnBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNameGroup;
        private System.Windows.Forms.TextBox txtNameGroup;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lbGroups;
        private System.Windows.Forms.CheckBox cboActivate;
        private System.Windows.Forms.BindingSource bindingSourceGroups;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnBarra;
        private System.Windows.Forms.PictureBox pcIcono;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pb_minimize;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.Label label2;
    }
}