namespace DesktopApp
{
    partial class FormCursos
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
            this.lblCourses = new System.Windows.Forms.Label();
            this.lbCourses = new System.Windows.Forms.ListBox();
            this.bindingSourceCourses = new System.Windows.Forms.BindingSource(this.components);
            this.gbStartCourse = new System.Windows.Forms.GroupBox();
            this.cbxYears = new System.Windows.Forms.ComboBox();
            this.gbFinishCourse = new System.Windows.Forms.GroupBox();
            this.txtFinishCourse = new System.Windows.Forms.TextBox();
            this.cboActivate = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCourses)).BeginInit();
            this.gbStartCourse.SuspendLayout();
            this.gbFinishCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourses.Location = new System.Drawing.Point(278, 19);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(75, 24);
            this.lblCourses.TabIndex = 4;
            this.lblCourses.Text = "Cursos";
            // 
            // lbCourses
            // 
            this.lbCourses.DataSource = this.bindingSourceCourses;
            this.lbCourses.DisplayMember = "nom";
            this.lbCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourses.FormattingEnabled = true;
            this.lbCourses.ItemHeight = 22;
            this.lbCourses.Location = new System.Drawing.Point(12, 105);
            this.lbCourses.Name = "lbCourses";
            this.lbCourses.Size = new System.Drawing.Size(159, 224);
            this.lbCourses.TabIndex = 6;
            this.lbCourses.ValueMember = "id";
            this.lbCourses.SelectedIndexChanged += new System.EventHandler(this.lbCourses_SelectedIndexChanged);
            // 
            // bindingSourceCourses
            // 
            this.bindingSourceCourses.DataSource = typeof(DesktopApp.Models.cursos);
            // 
            // gbStartCourse
            // 
            this.gbStartCourse.Controls.Add(this.cbxYears);
            this.gbStartCourse.Location = new System.Drawing.Point(194, 57);
            this.gbStartCourse.Name = "gbStartCourse";
            this.gbStartCourse.Size = new System.Drawing.Size(181, 112);
            this.gbStartCourse.TabIndex = 7;
            this.gbStartCourse.TabStop = false;
            this.gbStartCourse.Text = "Curs Inici";
            // 
            // cbxYears
            // 
            this.cbxYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxYears.FormattingEnabled = true;
            this.cbxYears.Location = new System.Drawing.Point(6, 37);
            this.cbxYears.Name = "cbxYears";
            this.cbxYears.Size = new System.Drawing.Size(100, 30);
            this.cbxYears.TabIndex = 34;
            this.cbxYears.SelectionChangeCommitted += new System.EventHandler(this.cbxYears_SelectionChangeCommitted);
            // 
            // gbFinishCourse
            // 
            this.gbFinishCourse.Controls.Add(this.txtFinishCourse);
            this.gbFinishCourse.Location = new System.Drawing.Point(385, 57);
            this.gbFinishCourse.Name = "gbFinishCourse";
            this.gbFinishCourse.Size = new System.Drawing.Size(183, 112);
            this.gbFinishCourse.TabIndex = 8;
            this.gbFinishCourse.TabStop = false;
            this.gbFinishCourse.Text = "Curs Final";
            // 
            // txtFinishCourse
            // 
            this.txtFinishCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinishCourse.Location = new System.Drawing.Point(6, 37);
            this.txtFinishCourse.Name = "txtFinishCourse";
            this.txtFinishCourse.ReadOnly = true;
            this.txtFinishCourse.Size = new System.Drawing.Size(100, 28);
            this.txtFinishCourse.TabIndex = 24;
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
            this.cboActivate.Location = new System.Drawing.Point(214, 197);
            this.cboActivate.Name = "cboActivate";
            this.cboActivate.Size = new System.Drawing.Size(106, 41);
            this.cboActivate.TabIndex = 21;
            this.cboActivate.Text = "Activar";
            this.cboActivate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboActivate.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(174, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 42);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(304, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 42);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(12, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 42);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 445);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboActivate);
            this.Controls.Add(this.gbFinishCourse);
            this.Controls.Add(this.gbStartCourse);
            this.Controls.Add(this.lbCourses);
            this.Controls.Add(this.lblCourses);
            this.Name = "FormCursos";
            this.Text = "FormCursos";
            this.Load += new System.EventHandler(this.FormCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCourses)).EndInit();
            this.gbStartCourse.ResumeLayout(false);
            this.gbFinishCourse.ResumeLayout(false);
            this.gbFinishCourse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.ListBox lbCourses;
        private System.Windows.Forms.GroupBox gbStartCourse;
        private System.Windows.Forms.GroupBox gbFinishCourse;
        private System.Windows.Forms.CheckBox cboActivate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource bindingSourceCourses;
        private System.Windows.Forms.TextBox txtFinishCourse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxYears;
    }
}