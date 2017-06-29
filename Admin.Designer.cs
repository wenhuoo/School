namespace School
{
    partial class frmAdmin
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPasswordUp = new System.Windows.Forms.TextBox();
            this.txtLNameUp = new System.Windows.Forms.TextBox();
            this.txtFNameUp = new System.Windows.Forms.TextBox();
            this.lblPasswordUp = new System.Windows.Forms.Label();
            this.lblLNameUp = new System.Windows.Forms.Label();
            this.lblFNameUp = new System.Windows.Forms.Label();
            this.lblAIDUp = new System.Windows.Forms.Label();
            this.cboAIDUp = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(393, 278);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.txtLName);
            this.tabPage1.Controls.Add(this.txtFName);
            this.tabPage1.Controls.Add(this.lblDOB);
            this.tabPage1.Controls.Add(this.lblLName);
            this.tabPage1.Controls.Add(this.lblFName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(385, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Admins";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(277, 185);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 28);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(49, 185);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 28);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(198, 118);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(137, 20);
            this.txtPassword.TabIndex = 33;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(198, 73);
            this.txtLName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(137, 20);
            this.txtLName.TabIndex = 34;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(198, 41);
            this.txtFName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(137, 20);
            this.txtFName.TabIndex = 32;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(48, 118);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(53, 13);
            this.lblDOB.TabIndex = 30;
            this.lblDOB.Text = "Password";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(47, 76);
            this.lblLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 13);
            this.lblLName.TabIndex = 29;
            this.lblLName.Text = "Last Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(47, 35);
            this.lblFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(57, 13);
            this.lblFName.TabIndex = 28;
            this.lblFName.Text = "First Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExit);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.txtPasswordUp);
            this.tabPage2.Controls.Add(this.txtLNameUp);
            this.tabPage2.Controls.Add(this.txtFNameUp);
            this.tabPage2.Controls.Add(this.lblPasswordUp);
            this.tabPage2.Controls.Add(this.lblLNameUp);
            this.tabPage2.Controls.Add(this.lblFNameUp);
            this.tabPage2.Controls.Add(this.lblAIDUp);
            this.tabPage2.Controls.Add(this.cboAIDUp);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(385, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update/Delete Admins";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(290, 197);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 26);
            this.btnExit.TabIndex = 50;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(168, 197);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 26);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(53, 197);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(53, 26);
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPasswordUp
            // 
            this.txtPasswordUp.Location = new System.Drawing.Point(202, 156);
            this.txtPasswordUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPasswordUp.Name = "txtPasswordUp";
            this.txtPasswordUp.Size = new System.Drawing.Size(137, 20);
            this.txtPasswordUp.TabIndex = 49;
            // 
            // txtLNameUp
            // 
            this.txtLNameUp.Location = new System.Drawing.Point(202, 112);
            this.txtLNameUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLNameUp.Name = "txtLNameUp";
            this.txtLNameUp.Size = new System.Drawing.Size(137, 20);
            this.txtLNameUp.TabIndex = 48;
            // 
            // txtFNameUp
            // 
            this.txtFNameUp.Location = new System.Drawing.Point(202, 80);
            this.txtFNameUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFNameUp.Name = "txtFNameUp";
            this.txtFNameUp.Size = new System.Drawing.Size(137, 20);
            this.txtFNameUp.TabIndex = 47;
            // 
            // lblPasswordUp
            // 
            this.lblPasswordUp.AutoSize = true;
            this.lblPasswordUp.Location = new System.Drawing.Point(52, 156);
            this.lblPasswordUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordUp.Name = "lblPasswordUp";
            this.lblPasswordUp.Size = new System.Drawing.Size(53, 13);
            this.lblPasswordUp.TabIndex = 45;
            this.lblPasswordUp.Text = "Password";
            // 
            // lblLNameUp
            // 
            this.lblLNameUp.AutoSize = true;
            this.lblLNameUp.Location = new System.Drawing.Point(51, 115);
            this.lblLNameUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLNameUp.Name = "lblLNameUp";
            this.lblLNameUp.Size = new System.Drawing.Size(58, 13);
            this.lblLNameUp.TabIndex = 44;
            this.lblLNameUp.Text = "Last Name";
            // 
            // lblFNameUp
            // 
            this.lblFNameUp.AutoSize = true;
            this.lblFNameUp.Location = new System.Drawing.Point(51, 73);
            this.lblFNameUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFNameUp.Name = "lblFNameUp";
            this.lblFNameUp.Size = new System.Drawing.Size(57, 13);
            this.lblFNameUp.TabIndex = 43;
            this.lblFNameUp.Text = "First Name";
            // 
            // lblAIDUp
            // 
            this.lblAIDUp.AutoSize = true;
            this.lblAIDUp.Location = new System.Drawing.Point(51, 31);
            this.lblAIDUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAIDUp.Name = "lblAIDUp";
            this.lblAIDUp.Size = new System.Drawing.Size(79, 13);
            this.lblAIDUp.TabIndex = 46;
            this.lblAIDUp.Text = "Adminstrator ID";
            // 
            // cboAIDUp
            // 
            this.cboAIDUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAIDUp.FormattingEnabled = true;
            this.cboAIDUp.Location = new System.Drawing.Point(202, 31);
            this.cboAIDUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboAIDUp.Name = "cboAIDUp";
            this.cboAIDUp.Size = new System.Drawing.Size(82, 21);
            this.cboAIDUp.TabIndex = 42;
            this.cboAIDUp.SelectedIndexChanged += new System.EventHandler(this.cboAIDUp_SelectedIndexChanged);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 275);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
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
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtPasswordUp;
        private System.Windows.Forms.TextBox txtLNameUp;
        private System.Windows.Forms.TextBox txtFNameUp;
        private System.Windows.Forms.Label lblPasswordUp;
        private System.Windows.Forms.Label lblLNameUp;
        private System.Windows.Forms.Label lblFNameUp;
        private System.Windows.Forms.Label lblAIDUp;
        private System.Windows.Forms.ComboBox cboAIDUp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}