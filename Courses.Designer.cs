namespace School
{
    partial class frmCourses
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ckAT = new System.Windows.Forms.CheckBox();
            this.cboAlloTeacher = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSem = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblAlloTeacher = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCoureseName = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ckAdT = new System.Windows.Forms.CheckBox();
            this.txtSemUp = new System.Windows.Forms.TextBox();
            this.txtYearUp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAllodTeacher = new System.Windows.Forms.Label();
            this.lblCourseNameUp = new System.Windows.Forms.Label();
            this.lblCourseIDUp = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCourseNameUp = new System.Windows.Forms.TextBox();
            this.cboAllodTeacher = new System.Windows.Forms.ComboBox();
            this.cboCourseID = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 8);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(436, 300);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ckAT);
            this.tabPage1.Controls.Add(this.cboAlloTeacher);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.txtSem);
            this.tabPage1.Controls.Add(this.txtYear);
            this.tabPage1.Controls.Add(this.txtCourseName);
            this.tabPage1.Controls.Add(this.lblAlloTeacher);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblCoureseName);
            this.tabPage1.Controls.Add(this.txtCourseID);
            this.tabPage1.Controls.Add(this.lblCourseID);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(428, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Courses";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ckAT
            // 
            this.ckAT.AutoSize = true;
            this.ckAT.Location = new System.Drawing.Point(324, 177);
            this.ckAT.Name = "ckAT";
            this.ckAT.Size = new System.Drawing.Size(107, 17);
            this.ckAT.TabIndex = 5;
            this.ckAT.Text = "Allocate Teacher";
            this.ckAT.UseVisualStyleBackColor = true;
            // 
            // cboAlloTeacher
            // 
            this.cboAlloTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlloTeacher.FormattingEnabled = true;
            this.cboAlloTeacher.Location = new System.Drawing.Point(229, 174);
            this.cboAlloTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.cboAlloTeacher.Name = "cboAlloTeacher";
            this.cboAlloTeacher.Size = new System.Drawing.Size(89, 21);
            this.cboAlloTeacher.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(259, 220);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(83, 220);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSem
            // 
            this.txtSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSem.Location = new System.Drawing.Point(229, 136);
            this.txtSem.Margin = new System.Windows.Forms.Padding(2);
            this.txtSem.Name = "txtSem";
            this.txtSem.Size = new System.Drawing.Size(89, 21);
            this.txtSem.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(229, 101);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(89, 21);
            this.txtYear.TabIndex = 1;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(228, 70);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(89, 21);
            this.txtCourseName.TabIndex = 1;
            // 
            // lblAlloTeacher
            // 
            this.lblAlloTeacher.AutoSize = true;
            this.lblAlloTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlloTeacher.Location = new System.Drawing.Point(81, 174);
            this.lblAlloTeacher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlloTeacher.Name = "lblAlloTeacher";
            this.lblAlloTeacher.Size = new System.Drawing.Size(98, 15);
            this.lblAlloTeacher.TabIndex = 0;
            this.lblAlloTeacher.Text = "Allocate Teacher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year";
            // 
            // lblCoureseName
            // 
            this.lblCoureseName.AutoSize = true;
            this.lblCoureseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoureseName.Location = new System.Drawing.Point(80, 75);
            this.lblCoureseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoureseName.Name = "lblCoureseName";
            this.lblCoureseName.Size = new System.Drawing.Size(83, 15);
            this.lblCoureseName.TabIndex = 0;
            this.lblCoureseName.Text = "Course Name";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseID.Location = new System.Drawing.Point(228, 30);
            this.txtCourseID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(89, 21);
            this.txtCourseID.TabIndex = 1;
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.Location = new System.Drawing.Point(80, 34);
            this.lblCourseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(61, 15);
            this.lblCourseID.TabIndex = 0;
            this.lblCourseID.Text = "Course ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ckAdT);
            this.tabPage2.Controls.Add(this.txtSemUp);
            this.tabPage2.Controls.Add(this.txtYearUp);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lblAllodTeacher);
            this.tabPage2.Controls.Add(this.lblCourseNameUp);
            this.tabPage2.Controls.Add(this.lblCourseIDUp);
            this.tabPage2.Controls.Add(this.btnExit);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.txtCourseNameUp);
            this.tabPage2.Controls.Add(this.cboAllodTeacher);
            this.tabPage2.Controls.Add(this.cboCourseID);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(428, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update/Delete Courses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ckAdT
            // 
            this.ckAdT.AutoSize = true;
            this.ckAdT.Location = new System.Drawing.Point(320, 166);
            this.ckAdT.Name = "ckAdT";
            this.ckAdT.Size = new System.Drawing.Size(107, 17);
            this.ckAdT.TabIndex = 8;
            this.ckAdT.Text = "Allocate Teacher";
            this.ckAdT.UseVisualStyleBackColor = true;
            // 
            // txtSemUp
            // 
            this.txtSemUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemUp.Location = new System.Drawing.Point(213, 120);
            this.txtSemUp.Margin = new System.Windows.Forms.Padding(2);
            this.txtSemUp.Name = "txtSemUp";
            this.txtSemUp.Size = new System.Drawing.Size(102, 21);
            this.txtSemUp.TabIndex = 6;
            // 
            // txtYearUp
            // 
            this.txtYearUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearUp.Location = new System.Drawing.Point(213, 86);
            this.txtYearUp.Margin = new System.Windows.Forms.Padding(2);
            this.txtYearUp.Name = "txtYearUp";
            this.txtYearUp.Size = new System.Drawing.Size(102, 21);
            this.txtYearUp.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Semester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Year";
            // 
            // lblAllodTeacher
            // 
            this.lblAllodTeacher.AutoSize = true;
            this.lblAllodTeacher.Location = new System.Drawing.Point(61, 166);
            this.lblAllodTeacher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllodTeacher.Name = "lblAllodTeacher";
            this.lblAllodTeacher.Size = new System.Drawing.Size(94, 13);
            this.lblAllodTeacher.TabIndex = 3;
            this.lblAllodTeacher.Text = "Allocated Teacher";
            // 
            // lblCourseNameUp
            // 
            this.lblCourseNameUp.AutoSize = true;
            this.lblCourseNameUp.Location = new System.Drawing.Point(61, 56);
            this.lblCourseNameUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseNameUp.Name = "lblCourseNameUp";
            this.lblCourseNameUp.Size = new System.Drawing.Size(71, 13);
            this.lblCourseNameUp.TabIndex = 3;
            this.lblCourseNameUp.Text = "Course Name";
            // 
            // lblCourseIDUp
            // 
            this.lblCourseIDUp.AutoSize = true;
            this.lblCourseIDUp.Location = new System.Drawing.Point(61, 24);
            this.lblCourseIDUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseIDUp.Name = "lblCourseIDUp";
            this.lblCourseIDUp.Size = new System.Drawing.Size(51, 13);
            this.lblCourseIDUp.TabIndex = 3;
            this.lblCourseIDUp.Text = "CourseID";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(268, 222);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 27);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(165, 222);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 27);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(64, 222);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(53, 27);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCourseNameUp
            // 
            this.txtCourseNameUp.Location = new System.Drawing.Point(213, 54);
            this.txtCourseNameUp.Margin = new System.Windows.Forms.Padding(2);
            this.txtCourseNameUp.Name = "txtCourseNameUp";
            this.txtCourseNameUp.Size = new System.Drawing.Size(102, 20);
            this.txtCourseNameUp.TabIndex = 1;
            // 
            // cboAllodTeacher
            // 
            this.cboAllodTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAllodTeacher.FormattingEnabled = true;
            this.cboAllodTeacher.Location = new System.Drawing.Point(213, 164);
            this.cboAllodTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.cboAllodTeacher.Name = "cboAllodTeacher";
            this.cboAllodTeacher.Size = new System.Drawing.Size(102, 21);
            this.cboAllodTeacher.TabIndex = 0;
            // 
            // cboCourseID
            // 
            this.cboCourseID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourseID.FormattingEnabled = true;
            this.cboCourseID.Location = new System.Drawing.Point(213, 22);
            this.cboCourseID.Margin = new System.Windows.Forms.Padding(2);
            this.cboCourseID.Name = "cboCourseID";
            this.cboCourseID.Size = new System.Drawing.Size(102, 21);
            this.cboCourseID.TabIndex = 0;
            this.cboCourseID.SelectedIndexChanged += new System.EventHandler(this.cboCourseID_SelectedIndexChanged);
            // 
            // frmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 317);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCourses";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.frmCourses_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblAlloTeacher;
        private System.Windows.Forms.Label lblCoureseName;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.ComboBox cboAlloTeacher;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAllodTeacher;
        private System.Windows.Forms.Label lblCourseNameUp;
        private System.Windows.Forms.Label lblCourseIDUp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCourseNameUp;
        private System.Windows.Forms.ComboBox cboAllodTeacher;
        private System.Windows.Forms.ComboBox cboCourseID;
        private System.Windows.Forms.TextBox txtSem;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSemUp;
        private System.Windows.Forms.TextBox txtYearUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckAdT;
        private System.Windows.Forms.CheckBox ckAT;
    }
}