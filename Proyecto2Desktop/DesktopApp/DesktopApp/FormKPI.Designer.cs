namespace DesktopApp
{
    partial class FormKPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKPI));
            this.lblNewKPI = new System.Windows.Forms.Label();
            this.txtNewKPI = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddKpi = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillsidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actiuDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.valoracionsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSourceKPI = new System.Windows.Forms.BindingSource(this.components);
            this.pnBarra = new System.Windows.Forms.Panel();
            this.pcIcono = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pb_minimize = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.lblKPIName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceKPI)).BeginInit();
            this.pnBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            this.SuspendLayout();
            //
            // lblNewKPI
            //
            this.lblNewKPI.AutoSize = true;
            this.lblNewKPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNewKPI.Location = new System.Drawing.Point(103, 470);
            this.lblNewKPI.Name = "lblNewKPI";
            this.lblNewKPI.Size = new System.Drawing.Size(238, 24);
            this.lblNewKPI.TabIndex = 4;
            this.lblNewKPI.Text = "Descipción nueva SubSkill:";
            //
            // txtNewKPI
            //
            this.txtNewKPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNewKPI.Location = new System.Drawing.Point(368, 468);
            this.txtNewKPI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewKPI.Name = "txtNewKPI";
            this.txtNewKPI.Size = new System.Drawing.Size(774, 28);
            this.txtNewKPI.TabIndex = 5;
            //
            // btnSave
            //
            this.btnSave.Location = new System.Drawing.Point(1139, 553);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 38);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //
            // btnCancel
            //
            this.btnCancel.Location = new System.Drawing.Point(1282, 553);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 38);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            //
            // btnAddKpi
            //
            this.btnAddKpi.Location = new System.Drawing.Point(1156, 465);
            this.btnAddKpi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddKpi.Name = "btnAddKpi";
            this.btnAddKpi.Size = new System.Drawing.Size(167, 36);
            this.btnAddKpi.TabIndex = 9;
            this.btnAddKpi.Text = "Añadir SubSkill";
            this.btnAddKpi.UseVisualStyleBackColor = true;
            this.btnAddKpi.Click += new System.EventHandler(this.btnAddKpi_Click);
            //
            // dataGridView1
            //
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nomDataGridViewTextBoxColumn1,
            this.skillsidDataGridViewTextBoxColumn1,
            this.actiuDataGridViewCheckBoxColumn1,
            this.valoracionsDataGridViewTextBoxColumn1,
            this.skillsDataGridViewTextBoxColumn1,
            this.activo});
            this.dataGridView1.DataSource = this.bindingSourceKPI;
            this.dataGridView1.Location = new System.Drawing.Point(110, 172);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1133, 249);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow_1);
            //
            // idDataGridViewTextBoxColumn1
            //
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Visible = false;
            //
            // nomDataGridViewTextBoxColumn1
            //
            this.nomDataGridViewTextBoxColumn1.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn1.HeaderText = "Descripcion del KPI";
            this.nomDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.nomDataGridViewTextBoxColumn1.Name = "nomDataGridViewTextBoxColumn1";
            //
            // skillsidDataGridViewTextBoxColumn1
            //
            this.skillsidDataGridViewTextBoxColumn1.DataPropertyName = "skills_id";
            this.skillsidDataGridViewTextBoxColumn1.HeaderText = "skills_id";
            this.skillsidDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.skillsidDataGridViewTextBoxColumn1.Name = "skillsidDataGridViewTextBoxColumn1";
            this.skillsidDataGridViewTextBoxColumn1.Visible = false;
            //
            // actiuDataGridViewCheckBoxColumn1
            //
            this.actiuDataGridViewCheckBoxColumn1.DataPropertyName = "actiu";
            this.actiuDataGridViewCheckBoxColumn1.HeaderText = "actiu";
            this.actiuDataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.actiuDataGridViewCheckBoxColumn1.Name = "actiuDataGridViewCheckBoxColumn1";
            this.actiuDataGridViewCheckBoxColumn1.Visible = false;
            //
            // valoracionsDataGridViewTextBoxColumn1
            //
            this.valoracionsDataGridViewTextBoxColumn1.DataPropertyName = "valoracions";
            this.valoracionsDataGridViewTextBoxColumn1.HeaderText = "valoracions";
            this.valoracionsDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.valoracionsDataGridViewTextBoxColumn1.Name = "valoracionsDataGridViewTextBoxColumn1";
            this.valoracionsDataGridViewTextBoxColumn1.Visible = false;
            //
            // skillsDataGridViewTextBoxColumn1
            //
            this.skillsDataGridViewTextBoxColumn1.DataPropertyName = "skills";
            this.skillsDataGridViewTextBoxColumn1.HeaderText = "skills";
            this.skillsDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.skillsDataGridViewTextBoxColumn1.Name = "skillsDataGridViewTextBoxColumn1";
            this.skillsDataGridViewTextBoxColumn1.Visible = false;
            //
            // activo
            //
            this.activo.FillWeight = 20F;
            this.activo.HeaderText = "Activo";
            this.activo.MinimumWidth = 8;
            this.activo.Name = "activo";
            //
            // bindingSourceKPI
            //
            this.bindingSourceKPI.DataSource = typeof(DesktopApp.Models.kpis);
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
            this.pnBarra.Size = new System.Drawing.Size(1445, 37);
            this.pnBarra.TabIndex = 28;
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
            this.lbTitulo.Size = new System.Drawing.Size(40, 17);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "Skills";
            this.lbTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitulo_MouseDown);
            //
            // pb_minimize
            //
            this.pb_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pb_minimize.Image")));
            this.pb_minimize.Location = new System.Drawing.Point(1377, 10);
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
            this.pb_close.Location = new System.Drawing.Point(1408, 10);
            this.pb_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(25, 25);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_close.TabIndex = 8;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            //
            // lblKPIName
            //
            this.lblKPIName.AutoSize = true;
            this.lblKPIName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblKPIName.Location = new System.Drawing.Point(553, 80);
            this.lblKPIName.Name = "lblKPIName";
            this.lblKPIName.Size = new System.Drawing.Size(211, 39);
            this.lblKPIName.TabIndex = 6;
            this.lblKPIName.Text = "Nombre Skill";
            //
            // FormKPI
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 637);
            this.Controls.Add(this.pnBarra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddKpi);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblKPIName);
            this.Controls.Add(this.txtNewKPI);
            this.Controls.Add(this.lblNewKPI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormKPI";
            this.Text = "Skills";
            this.Load += new System.EventHandler(this.FormKPI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceKPI)).EndInit();
            this.pnBarra.ResumeLayout(false);
            this.pnBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNewKPI;
        private System.Windows.Forms.TextBox txtNewKPI;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bindingSourceKPI;
        private System.Windows.Forms.Button btnAddKpi;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillsidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn actiuDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoracionsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activo;
        private System.Windows.Forms.Panel pnBarra;
        private System.Windows.Forms.PictureBox pcIcono;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pb_minimize;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.Label lblKPIName;
    }
}
