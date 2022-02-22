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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNewKPI = new System.Windows.Forms.Label();
            this.txtNewKPI = new System.Windows.Forms.TextBox();
            this.lblKPIName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddKpi = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actiuDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.skillsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoracionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceKPI = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceKPI)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnCerrarSesión);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1626, 63);
            this.panel1.TabIndex = 2;
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.BackColor = System.Drawing.Color.Tomato;
            this.btnCerrarSesión.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCerrarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesión.Location = new System.Drawing.Point(1677, 14);
            this.btnCerrarSesión.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(250, 54);
            this.btnCerrarSesión.TabIndex = 0;
            this.btnCerrarSesión.Text = "Cerar Sesión";
            this.btnCerrarSesión.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.skillsidDataGridViewTextBoxColumn,
            this.actiuDataGridViewCheckBoxColumn,
            this.skillsDataGridViewTextBoxColumn,
            this.valoracionsDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.bindingSourceKPI;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(56, 171);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1432, 282);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // lblNewKPI
            // 
            this.lblNewKPI.AutoSize = true;
            this.lblNewKPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNewKPI.Location = new System.Drawing.Point(116, 588);
            this.lblNewKPI.Name = "lblNewKPI";
            this.lblNewKPI.Size = new System.Drawing.Size(276, 26);
            this.lblNewKPI.TabIndex = 4;
            this.lblNewKPI.Text = "Descipción nueva SubSkill:";
            // 
            // txtNewKPI
            // 
            this.txtNewKPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNewKPI.Location = new System.Drawing.Point(414, 585);
            this.txtNewKPI.Name = "txtNewKPI";
            this.txtNewKPI.Size = new System.Drawing.Size(870, 32);
            this.txtNewKPI.TabIndex = 5;
            // 
            // lblKPIName
            // 
            this.lblKPIName.AutoSize = true;
            this.lblKPIName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblKPIName.Location = new System.Drawing.Point(711, 108);
            this.lblKPIName.Name = "lblKPIName";
            this.lblKPIName.Size = new System.Drawing.Size(137, 26);
            this.lblKPIName.TabIndex = 6;
            this.lblKPIName.Text = "Nombre Skill";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(608, 705);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 48);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(768, 705);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 48);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddKpi
            // 
            this.btnAddKpi.Location = new System.Drawing.Point(1300, 581);
            this.btnAddKpi.Name = "btnAddKpi";
            this.btnAddKpi.Size = new System.Drawing.Size(188, 45);
            this.btnAddKpi.TabIndex = 9;
            this.btnAddKpi.Text = "Añadir SubSkill";
            this.btnAddKpi.UseVisualStyleBackColor = true;
            this.btnAddKpi.Click += new System.EventHandler(this.btnAddKpi_Click);
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
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // skillsidDataGridViewTextBoxColumn
            // 
            this.skillsidDataGridViewTextBoxColumn.DataPropertyName = "skills_id";
            this.skillsidDataGridViewTextBoxColumn.HeaderText = "skills_id";
            this.skillsidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.skillsidDataGridViewTextBoxColumn.Name = "skillsidDataGridViewTextBoxColumn";
            this.skillsidDataGridViewTextBoxColumn.ReadOnly = true;
            this.skillsidDataGridViewTextBoxColumn.Visible = false;
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
            // skillsDataGridViewTextBoxColumn
            // 
            this.skillsDataGridViewTextBoxColumn.DataPropertyName = "skills";
            this.skillsDataGridViewTextBoxColumn.HeaderText = "Numero de skill";
            this.skillsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.skillsDataGridViewTextBoxColumn.Name = "skillsDataGridViewTextBoxColumn";
            this.skillsDataGridViewTextBoxColumn.ReadOnly = true;
            this.skillsDataGridViewTextBoxColumn.Visible = false;
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
            // bindingSourceKPI
            // 
            this.bindingSourceKPI.DataSource = typeof(DesktopApp.Models.kpis);
            // 
            // FormKPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 842);
            this.Controls.Add(this.btnAddKpi);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblKPIName);
            this.Controls.Add(this.txtNewKPI);
            this.Controls.Add(this.lblNewKPI);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormKPI";
            this.Text = "FormKPI";
            this.Load += new System.EventHandler(this.FormKPI_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceKPI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNewKPI;
        private System.Windows.Forms.TextBox txtNewKPI;
        private System.Windows.Forms.Label lblKPIName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bindingSourceKPI;
        private System.Windows.Forms.Button btnAddKpi;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn actiuDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoracionsDataGridViewTextBoxColumn;
    }
}