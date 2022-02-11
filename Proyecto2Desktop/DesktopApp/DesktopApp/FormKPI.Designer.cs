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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNewKPI = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1552, 64);
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
            this.btnCerrarSesión.Size = new System.Drawing.Size(251, 54);
            this.btnCerrarSesión.TabIndex = 0;
            this.btnCerrarSesión.Text = "Cerar Sesión";
            this.btnCerrarSesión.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Descripción});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(56, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1432, 281);
            this.dataGridView1.TabIndex = 3;
            // 
            // id
            // 
            this.id.HeaderText = "Column1";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Column1";
            this.Descripción.MinimumWidth = 8;
            this.Descripción.Name = "Descripción";
            // 
            // lblNewKPI
            // 
            this.lblNewKPI.AutoSize = true;
            this.lblNewKPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNewKPI.Location = new System.Drawing.Point(115, 588);
            this.lblNewKPI.Name = "lblNewKPI";
            this.lblNewKPI.Size = new System.Drawing.Size(276, 26);
            this.lblNewKPI.TabIndex = 4;
            this.lblNewKPI.Text = "Descipción nueva SubSkill:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox1.Location = new System.Drawing.Point(414, 585);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(869, 32);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(676, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre Skill";
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(608, 705);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(117, 48);
            this.C.TabIndex = 7;
            this.C.Text = "Guardar";
            this.C.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(768, 705);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 48);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormKPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 852);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.C);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNewKPI);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormKPI";
            this.Text = "FormKPI";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.Label lblNewKPI;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button btnCancel;
    }
}