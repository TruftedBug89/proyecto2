
namespace DesktopApp
{
    partial class FormGestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_minimize = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPick = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actiuDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupshasalumnesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupshasdocentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoracionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoracions1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnGroups = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pcIcono = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.pcIcono);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.pb_minimize);
            this.panel1.Controls.Add(this.pb_close);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 37);
            this.panel1.TabIndex = 1;
            // 
            // pb_minimize
            // 
            this.pb_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pb_minimize.Image")));
            this.pb_minimize.Location = new System.Drawing.Point(912, 3);
            this.pb_minimize.Name = "pb_minimize";
            this.pb_minimize.Size = new System.Drawing.Size(25, 25);
            this.pb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_minimize.TabIndex = 1;
            this.pb_minimize.TabStop = false;
            // 
            // pb_close
            // 
            this.pb_close.Image = ((System.Drawing.Image)(resources.GetObject("pb_close.Image")));
            this.pb_close.Location = new System.Drawing.Point(943, 4);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(25, 25);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_close.TabIndex = 0;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Importar Usuarios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar Usuario:";
            // 
            // btnPick
            // 
            this.btnPick.Location = new System.Drawing.Point(221, 67);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(75, 23);
            this.btnPick.TabIndex = 5;
            this.btnPick.Text = "Examinar";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = ".csv";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.rolsidDataGridViewTextBoxColumn,
            this.actiuDataGridViewCheckBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.contrasenyaDataGridViewTextBoxColumn,
            this.grupshasalumnesDataGridViewTextBoxColumn,
            this.grupshasdocentsDataGridViewTextBoxColumn,
            this.rolsDataGridViewTextBoxColumn,
            this.valoracionsDataGridViewTextBoxColumn,
            this.valoracions1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(94, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(819, 198);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rolsidDataGridViewTextBoxColumn
            // 
            this.rolsidDataGridViewTextBoxColumn.DataPropertyName = "rols_id";
            this.rolsidDataGridViewTextBoxColumn.HeaderText = "rols_id";
            this.rolsidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rolsidDataGridViewTextBoxColumn.Name = "rolsidDataGridViewTextBoxColumn";
            this.rolsidDataGridViewTextBoxColumn.ReadOnly = true;
            this.rolsidDataGridViewTextBoxColumn.Visible = false;
            // 
            // actiuDataGridViewCheckBoxColumn
            // 
            this.actiuDataGridViewCheckBoxColumn.DataPropertyName = "actiu";
            this.actiuDataGridViewCheckBoxColumn.HeaderText = "actiu";
            this.actiuDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.actiuDataGridViewCheckBoxColumn.Name = "actiuDataGridViewCheckBoxColumn";
            this.actiuDataGridViewCheckBoxColumn.ReadOnly = true;
            this.actiuDataGridViewCheckBoxColumn.Visible = false;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contrasenyaDataGridViewTextBoxColumn
            // 
            this.contrasenyaDataGridViewTextBoxColumn.DataPropertyName = "contrasenya";
            this.contrasenyaDataGridViewTextBoxColumn.HeaderText = "contrasenya";
            this.contrasenyaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contrasenyaDataGridViewTextBoxColumn.Name = "contrasenyaDataGridViewTextBoxColumn";
            this.contrasenyaDataGridViewTextBoxColumn.ReadOnly = true;
            this.contrasenyaDataGridViewTextBoxColumn.Visible = false;
            // 
            // grupshasalumnesDataGridViewTextBoxColumn
            // 
            this.grupshasalumnesDataGridViewTextBoxColumn.DataPropertyName = "grups_has_alumnes";
            this.grupshasalumnesDataGridViewTextBoxColumn.HeaderText = "grups_has_alumnes";
            this.grupshasalumnesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.grupshasalumnesDataGridViewTextBoxColumn.Name = "grupshasalumnesDataGridViewTextBoxColumn";
            this.grupshasalumnesDataGridViewTextBoxColumn.ReadOnly = true;
            this.grupshasalumnesDataGridViewTextBoxColumn.Visible = false;
            // 
            // grupshasdocentsDataGridViewTextBoxColumn
            // 
            this.grupshasdocentsDataGridViewTextBoxColumn.DataPropertyName = "grups_has_docents";
            this.grupshasdocentsDataGridViewTextBoxColumn.HeaderText = "grups_has_docents";
            this.grupshasdocentsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.grupshasdocentsDataGridViewTextBoxColumn.Name = "grupshasdocentsDataGridViewTextBoxColumn";
            this.grupshasdocentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.grupshasdocentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // rolsDataGridViewTextBoxColumn
            // 
            this.rolsDataGridViewTextBoxColumn.DataPropertyName = "rols";
            this.rolsDataGridViewTextBoxColumn.HeaderText = "Rols";
            this.rolsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rolsDataGridViewTextBoxColumn.Name = "rolsDataGridViewTextBoxColumn";
            this.rolsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valoracionsDataGridViewTextBoxColumn
            // 
            this.valoracionsDataGridViewTextBoxColumn.DataPropertyName = "valoracions";
            this.valoracionsDataGridViewTextBoxColumn.HeaderText = "valoracions";
            this.valoracionsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.valoracionsDataGridViewTextBoxColumn.Name = "valoracionsDataGridViewTextBoxColumn";
            this.valoracionsDataGridViewTextBoxColumn.ReadOnly = true;
            this.valoracionsDataGridViewTextBoxColumn.Visible = false;
            // 
            // valoracions1DataGridViewTextBoxColumn
            // 
            this.valoracions1DataGridViewTextBoxColumn.DataPropertyName = "valoracions1";
            this.valoracions1DataGridViewTextBoxColumn.HeaderText = "valoracions1";
            this.valoracions1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.valoracions1DataGridViewTextBoxColumn.Name = "valoracions1DataGridViewTextBoxColumn";
            this.valoracions1DataGridViewTextBoxColumn.ReadOnly = true;
            this.valoracions1DataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DesktopApp.Models.usuaris);
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.Location = new System.Drawing.Point(87, 398);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(113, 32);
            this.btnAddUsers.TabIndex = 10;
            this.btnAddUsers.Text = "Añadir Usuario";
            this.btnAddUsers.UseVisualStyleBackColor = true;
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUsers_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Location = new System.Drawing.Point(240, 397);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(143, 33);
            this.btnRoles.TabIndex = 11;
            this.btnRoles.Text = "Gestionar Perfiles";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnGroups
            // 
            this.btnGroups.Location = new System.Drawing.Point(417, 399);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Size = new System.Drawing.Size(164, 32);
            this.btnGroups.TabIndex = 12;
            this.btnGroups.Text = "Gestionar Grupos";
            this.btnGroups.UseVisualStyleBackColor = true;
            this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(817, 399);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(96, 32);
            this.btnDownload.TabIndex = 13;
            this.btnDownload.Text = "Descargar";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(447, 481);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pcIcono
            // 
            this.pcIcono.Image = ((System.Drawing.Image)(resources.GetObject("pcIcono.Image")));
            this.pcIcono.Location = new System.Drawing.Point(12, 9);
            this.pcIcono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcIcono.Name = "pcIcono";
            this.pcIcono.Size = new System.Drawing.Size(25, 25);
            this.pcIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcIcono.TabIndex = 13;
            this.pcIcono.TabStop = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(43, 12);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(92, 17);
            this.lbTitulo.TabIndex = 12;
            this.lbTitulo.Text = "Iniciar Sesion";
            // 
            // FormGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 534);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnGroups);
            this.Controls.Add(this.btnRoles);
            this.Controls.Add(this.btnAddUsers);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormGestionUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_minimize;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddUsers;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnGroups;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn actiuDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupshasalumnesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupshasdocentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoracionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoracions1DataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pcIcono;
        private System.Windows.Forms.Label lbTitulo;
    }
}