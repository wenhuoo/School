namespace School
{
    partial class frmMarks
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbAddMarks = new System.Windows.Forms.TabPage();
            this.txtMarkAdd = new System.Windows.Forms.TextBox();
            this.lblMarksAdd = new System.Windows.Forms.Label();
            this.lblCourseIDAdd = new System.Windows.Forms.Label();
            this.lblStudentIDAdd = new System.Windows.Forms.Label();
            this.cboCIDAdd = new System.Windows.Forms.ComboBox();
            this.cboSIDAdd = new System.Windows.Forms.ComboBox();
            this.btnCancelMarks = new System.Windows.Forms.Button();
            this.btnAddMarks = new System.Windows.Forms.Button();
            this.tbView = new System.Windows.Forms.TabPage();
            this.dGVMarks = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cboCIDEdit = new System.Windows.Forms.ComboBox();
            this.lblMarks = new System.Windows.Forms.Label();
            this.lblCourseIDEdit = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbAddMarks.SuspendLayout();
            this.tbView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbAddMarks);
            this.tabControl1.Controls.Add(this.tbView);
            this.tabControl1.Location = new System.Drawing.Point(20, 23);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(751, 601);
            this.tabControl1.TabIndex = 0;
            // 
            // tbAddMarks
            // 
            this.tbAddMarks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbAddMarks.Controls.Add(this.txtMarkAdd);
            this.tbAddMarks.Controls.Add(this.lblMarksAdd);
            this.tbAddMarks.Controls.Add(this.lblCourseIDAdd);
            this.tbAddMarks.Controls.Add(this.lblStudentIDAdd);
            this.tbAddMarks.Controls.Add(this.cboCIDAdd);
            this.tbAddMarks.Controls.Add(this.cboSIDAdd);
            this.tbAddMarks.Controls.Add(this.btnCancelMarks);
            this.tbAddMarks.Controls.Add(this.btnAddMarks);
            this.tbAddMarks.Location = new System.Drawing.Point(4, 29);
            this.tbAddMarks.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbAddMarks.Name = "tbAddMarks";
            this.tbAddMarks.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbAddMarks.Size = new System.Drawing.Size(743, 568);
            this.tbAddMarks.TabIndex = 0;
            this.tbAddMarks.Text = "Add Marks";
            // 
            // txtMarkAdd
            // 
            this.txtMarkAdd.Location = new System.Drawing.Point(375, 223);
            this.txtMarkAdd.Name = "txtMarkAdd";
            this.txtMarkAdd.Size = new System.Drawing.Size(260, 26);
            this.txtMarkAdd.TabIndex = 8;
            // 
            // lblMarksAdd
            // 
            this.lblMarksAdd.AutoSize = true;
            this.lblMarksAdd.Location = new System.Drawing.Point(104, 226);
            this.lblMarksAdd.Name = "lblMarksAdd";
            this.lblMarksAdd.Size = new System.Drawing.Size(52, 20);
            this.lblMarksAdd.TabIndex = 7;
            this.lblMarksAdd.Text = "Marks";
            // 
            // lblCourseIDAdd
            // 
            this.lblCourseIDAdd.AutoSize = true;
            this.lblCourseIDAdd.Location = new System.Drawing.Point(104, 141);
            this.lblCourseIDAdd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCourseIDAdd.Name = "lblCourseIDAdd";
            this.lblCourseIDAdd.Size = new System.Drawing.Size(81, 20);
            this.lblCourseIDAdd.TabIndex = 5;
            this.lblCourseIDAdd.Text = "Course ID";
            // 
            // lblStudentIDAdd
            // 
            this.lblStudentIDAdd.AutoSize = true;
            this.lblStudentIDAdd.Location = new System.Drawing.Point(104, 63);
            this.lblStudentIDAdd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStudentIDAdd.Name = "lblStudentIDAdd";
            this.lblStudentIDAdd.Size = new System.Drawing.Size(87, 20);
            this.lblStudentIDAdd.TabIndex = 4;
            this.lblStudentIDAdd.Text = "Student ID";
            // 
            // cboCIDAdd
            // 
            this.cboCIDAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCIDAdd.FormattingEnabled = true;
            this.cboCIDAdd.Location = new System.Drawing.Point(375, 138);
            this.cboCIDAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboCIDAdd.Name = "cboCIDAdd";
            this.cboCIDAdd.Size = new System.Drawing.Size(260, 28);
            this.cboCIDAdd.TabIndex = 3;
            // 
            // cboSIDAdd
            // 
            this.cboSIDAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSIDAdd.FormattingEnabled = true;
            this.cboSIDAdd.Location = new System.Drawing.Point(375, 60);
            this.cboSIDAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboSIDAdd.Name = "cboSIDAdd";
            this.cboSIDAdd.Size = new System.Drawing.Size(260, 28);
            this.cboSIDAdd.TabIndex = 2;
            // 
            // btnCancelMarks
            // 
            this.btnCancelMarks.Location = new System.Drawing.Point(447, 428);
            this.btnCancelMarks.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancelMarks.Name = "btnCancelMarks";
            this.btnCancelMarks.Size = new System.Drawing.Size(188, 71);
            this.btnCancelMarks.TabIndex = 1;
            this.btnCancelMarks.Text = "&Cancel";
            this.btnCancelMarks.UseVisualStyleBackColor = true;
            this.btnCancelMarks.Click += new System.EventHandler(this.btnCancelMarks_Click);
            // 
            // btnAddMarks
            // 
            this.btnAddMarks.Location = new System.Drawing.Point(109, 428);
            this.btnAddMarks.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddMarks.Name = "btnAddMarks";
            this.btnAddMarks.Size = new System.Drawing.Size(188, 71);
            this.btnAddMarks.TabIndex = 0;
            this.btnAddMarks.Text = "&Add";
            this.btnAddMarks.UseVisualStyleBackColor = true;
            this.btnAddMarks.Click += new System.EventHandler(this.btnAddMarks_Click);
            // 
            // tbView
            // 
            this.tbView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbView.Controls.Add(this.dGVMarks);
            this.tbView.Controls.Add(this.btnExit);
            this.tbView.Controls.Add(this.btnEdit);
            this.tbView.Controls.Add(this.cboCIDEdit);
            this.tbView.Controls.Add(this.lblMarks);
            this.tbView.Controls.Add(this.lblCourseIDEdit);
            this.tbView.Location = new System.Drawing.Point(4, 29);
            this.tbView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbView.Name = "tbView";
            this.tbView.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbView.Size = new System.Drawing.Size(743, 568);
            this.tbView.TabIndex = 1;
            this.tbView.Text = "Edit Marks";
            // 
            // dGVMarks
            // 
            this.dGVMarks.AllowUserToDeleteRows = false;
            this.dGVMarks.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dGVMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMarks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dGVMarks.Location = new System.Drawing.Point(320, 201);
            this.dGVMarks.Name = "dGVMarks";
            this.dGVMarks.RowTemplate.Height = 28;
            this.dGVMarks.Size = new System.Drawing.Size(307, 151);
            this.dGVMarks.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(510, 435);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 54);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(101, 435);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 54);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cboCIDEdit
            // 
            this.cboCIDEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCIDEdit.FormattingEnabled = true;
            this.cboCIDEdit.Location = new System.Drawing.Point(320, 77);
            this.cboCIDEdit.Name = "cboCIDEdit";
            this.cboCIDEdit.Size = new System.Drawing.Size(307, 28);
            this.cboCIDEdit.TabIndex = 3;
            this.cboCIDEdit.SelectedIndexChanged += new System.EventHandler(this.cboCIDEdit_SelectedIndexChanged);
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(97, 201);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(149, 20);
            this.lblMarks.TabIndex = 1;
            this.lblMarks.Text = "Student ID && Marks";
            // 
            // lblCourseIDEdit
            // 
            this.lblCourseIDEdit.AutoSize = true;
            this.lblCourseIDEdit.Location = new System.Drawing.Point(97, 80);
            this.lblCourseIDEdit.Name = "lblCourseIDEdit";
            this.lblCourseIDEdit.Size = new System.Drawing.Size(81, 20);
            this.lblCourseIDEdit.TabIndex = 0;
            this.lblCourseIDEdit.Text = "Course ID";
            // 
            // frmMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 637);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMarks";
            this.Text = "Marks";
            this.Load += new System.EventHandler(this.frmMarks_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbAddMarks.ResumeLayout(false);
            this.tbAddMarks.PerformLayout();
            this.tbView.ResumeLayout(false);
            this.tbView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMarks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbAddMarks;
        private System.Windows.Forms.TabPage tbView;
        private System.Windows.Forms.ComboBox cboCIDAdd;
        private System.Windows.Forms.Button btnCancelMarks;
        private System.Windows.Forms.Button btnAddMarks;
        private System.Windows.Forms.Label lblCourseIDAdd;
        private System.Windows.Forms.Label lblMarksAdd;
        private System.Windows.Forms.ComboBox cboCIDEdit;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.Label lblCourseIDEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtMarkAdd;
        private System.Windows.Forms.DataGridView dGVMarks;
        private System.Windows.Forms.Label lblStudentIDAdd;
        private System.Windows.Forms.ComboBox cboSIDAdd;
    }
}