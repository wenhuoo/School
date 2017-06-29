namespace School
{
    partial class frmTeachers
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
            this.tabTeacher = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateT = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTUp = new System.Windows.Forms.DateTimePicker();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboStateUp = new System.Windows.Forms.ComboBox();
            this.txtPasswordUp = new System.Windows.Forms.TextBox();
            this.txtRegNoUp = new System.Windows.Forms.TextBox();
            this.txtPostcodeUp = new System.Windows.Forms.TextBox();
            this.txtSuburbUp = new System.Windows.Forms.TextBox();
            this.txtAddressLine2Up = new System.Windows.Forms.TextBox();
            this.txtAddressLine1Up = new System.Windows.Forms.TextBox();
            this.txtPhoneUp = new System.Windows.Forms.TextBox();
            this.txtLNameUp = new System.Windows.Forms.TextBox();
            this.txtFNameUp = new System.Windows.Forms.TextBox();
            this.lblPasswordUp = new System.Windows.Forms.Label();
            this.lblRegNoUp = new System.Windows.Forms.Label();
            this.lblPostcodeUp = new System.Windows.Forms.Label();
            this.lblStateUp = new System.Windows.Forms.Label();
            this.lblSuburbUp = new System.Windows.Forms.Label();
            this.lblAddressLine2Up = new System.Windows.Forms.Label();
            this.lblAddressLine1Up = new System.Windows.Forms.Label();
            this.lblPhoneUp = new System.Windows.Forms.Label();
            this.lblDOBUp = new System.Windows.Forms.Label();
            this.lblLNameUp = new System.Windows.Forms.Label();
            this.lblFNameUp = new System.Windows.Forms.Label();
            this.lblTIDUp = new System.Windows.Forms.Label();
            this.cboTIDUp = new System.Windows.Forms.ComboBox();
            this.tabTeacher.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTeacher
            // 
            this.tabTeacher.Controls.Add(this.tabPage1);
            this.tabTeacher.Controls.Add(this.tabPage2);
            this.tabTeacher.Location = new System.Drawing.Point(0, 1);
            this.tabTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.tabTeacher.Name = "tabTeacher";
            this.tabTeacher.SelectedIndex = 0;
            this.tabTeacher.Size = new System.Drawing.Size(478, 582);
            this.tabTeacher.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateT);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.cboState);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.txtRegNo);
            this.tabPage1.Controls.Add(this.txtPostcode);
            this.tabPage1.Controls.Add(this.txtSuburb);
            this.tabPage1.Controls.Add(this.txtAddressLine2);
            this.tabPage1.Controls.Add(this.txtAddressLine1);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.txtLName);
            this.tabPage1.Controls.Add(this.txtFName);
            this.tabPage1.Controls.Add(this.lblPassword);
            this.tabPage1.Controls.Add(this.lblRegNo);
            this.tabPage1.Controls.Add(this.lblPostcode);
            this.tabPage1.Controls.Add(this.lblState);
            this.tabPage1.Controls.Add(this.lblSuburb);
            this.tabPage1.Controls.Add(this.lblAddressLine2);
            this.tabPage1.Controls.Add(this.lblAddressLine1);
            this.tabPage1.Controls.Add(this.lblPhone);
            this.tabPage1.Controls.Add(this.lblDOB);
            this.tabPage1.Controls.Add(this.lblLName);
            this.tabPage1.Controls.Add(this.lblFName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(470, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Teachers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateT
            // 
            this.dateT.Location = new System.Drawing.Point(223, 116);
            this.dateT.Name = "dateT";
            this.dateT.Size = new System.Drawing.Size(138, 20);
            this.dateT.TabIndex = 30;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(304, 469);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 28);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(76, 469);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 28);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(224, 311);
            this.cboState.Margin = new System.Windows.Forms.Padding(2);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(137, 21);
            this.cboState.TabIndex = 27;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(223, 423);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(137, 20);
            this.txtPassword.TabIndex = 25;
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(224, 388);
            this.txtRegNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(137, 20);
            this.txtRegNo.TabIndex = 25;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(224, 352);
            this.txtPostcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(137, 20);
            this.txtPostcode.TabIndex = 24;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(224, 278);
            this.txtSuburb.Margin = new System.Windows.Forms.Padding(2);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(137, 20);
            this.txtSuburb.TabIndex = 23;
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(224, 239);
            this.txtAddressLine2.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(137, 20);
            this.txtAddressLine2.TabIndex = 22;
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(224, 197);
            this.txtAddressLine1.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(137, 20);
            this.txtAddressLine1.TabIndex = 21;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(224, 157);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(137, 20);
            this.txtPhone.TabIndex = 20;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(224, 72);
            this.txtLName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(137, 20);
            this.txtLName.TabIndex = 26;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(224, 40);
            this.txtFName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(137, 20);
            this.txtFName.TabIndex = 18;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(73, 427);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Location = new System.Drawing.Point(74, 391);
            this.lblRegNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(103, 13);
            this.lblRegNo.TabIndex = 16;
            this.lblRegNo.Text = "Registration Number";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(73, 356);
            this.lblPostcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(52, 13);
            this.lblPostcode.TabIndex = 15;
            this.lblPostcode.Text = "Postcode";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(74, 316);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 14;
            this.lblState.Text = "State";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(73, 282);
            this.lblSuburb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(41, 13);
            this.lblSuburb.TabIndex = 13;
            this.lblSuburb.Text = "Suburb";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(73, 243);
            this.lblAddressLine2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine2.TabIndex = 12;
            this.lblAddressLine2.Text = "Address Line 2";
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(73, 201);
            this.lblAddressLine1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine1.TabIndex = 11;
            this.lblAddressLine1.Text = "Address Line 1";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(73, 161);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 13);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(74, 116);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(66, 13);
            this.lblDOB.TabIndex = 9;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(73, 76);
            this.lblLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 13);
            this.lblLName.TabIndex = 8;
            this.lblLName.Text = "Last Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(73, 35);
            this.lblFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(57, 13);
            this.lblFName.TabIndex = 7;
            this.lblFName.Text = "First Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dateTUp);
            this.tabPage2.Controls.Add(this.btnExit);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.cboStateUp);
            this.tabPage2.Controls.Add(this.txtPasswordUp);
            this.tabPage2.Controls.Add(this.txtRegNoUp);
            this.tabPage2.Controls.Add(this.txtPostcodeUp);
            this.tabPage2.Controls.Add(this.txtSuburbUp);
            this.tabPage2.Controls.Add(this.txtAddressLine2Up);
            this.tabPage2.Controls.Add(this.txtAddressLine1Up);
            this.tabPage2.Controls.Add(this.txtPhoneUp);
            this.tabPage2.Controls.Add(this.txtLNameUp);
            this.tabPage2.Controls.Add(this.txtFNameUp);
            this.tabPage2.Controls.Add(this.lblPasswordUp);
            this.tabPage2.Controls.Add(this.lblRegNoUp);
            this.tabPage2.Controls.Add(this.lblPostcodeUp);
            this.tabPage2.Controls.Add(this.lblStateUp);
            this.tabPage2.Controls.Add(this.lblSuburbUp);
            this.tabPage2.Controls.Add(this.lblAddressLine2Up);
            this.tabPage2.Controls.Add(this.lblAddressLine1Up);
            this.tabPage2.Controls.Add(this.lblPhoneUp);
            this.tabPage2.Controls.Add(this.lblDOBUp);
            this.tabPage2.Controls.Add(this.lblLNameUp);
            this.tabPage2.Controls.Add(this.lblFNameUp);
            this.tabPage2.Controls.Add(this.lblTIDUp);
            this.tabPage2.Controls.Add(this.cboTIDUp);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(470, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update/Delete Teachers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTUp
            // 
            this.dateTUp.Location = new System.Drawing.Point(237, 145);
            this.dateTUp.Name = "dateTUp";
            this.dateTUp.Size = new System.Drawing.Size(137, 20);
            this.dateTUp.TabIndex = 52;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(325, 508);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 26);
            this.btnExit.TabIndex = 51;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(196, 508);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 26);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(88, 508);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(53, 26);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboStateUp
            // 
            this.cboStateUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStateUp.FormattingEnabled = true;
            this.cboStateUp.Location = new System.Drawing.Point(237, 346);
            this.cboStateUp.Margin = new System.Windows.Forms.Padding(2);
            this.cboStateUp.Name = "cboStateUp";
            this.cboStateUp.Size = new System.Drawing.Size(137, 21);
            this.cboStateUp.TabIndex = 48;
            // 
            // txtPasswordUp
            // 
            this.txtPasswordUp.Location = new System.Drawing.Point(237, 460);
            this.txtPasswordUp.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswordUp.Name = "txtPasswordUp";
            this.txtPasswordUp.Size = new System.Drawing.Size(137, 20);
            this.txtPasswordUp.TabIndex = 47;
            // 
            // txtRegNoUp
            // 
            this.txtRegNoUp.Location = new System.Drawing.Point(237, 423);
            this.txtRegNoUp.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegNoUp.Name = "txtRegNoUp";
            this.txtRegNoUp.Size = new System.Drawing.Size(137, 20);
            this.txtRegNoUp.TabIndex = 47;
            // 
            // txtPostcodeUp
            // 
            this.txtPostcodeUp.Location = new System.Drawing.Point(237, 387);
            this.txtPostcodeUp.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostcodeUp.Name = "txtPostcodeUp";
            this.txtPostcodeUp.Size = new System.Drawing.Size(137, 20);
            this.txtPostcodeUp.TabIndex = 46;
            // 
            // txtSuburbUp
            // 
            this.txtSuburbUp.Location = new System.Drawing.Point(237, 313);
            this.txtSuburbUp.Margin = new System.Windows.Forms.Padding(2);
            this.txtSuburbUp.Name = "txtSuburbUp";
            this.txtSuburbUp.Size = new System.Drawing.Size(137, 20);
            this.txtSuburbUp.TabIndex = 45;
            // 
            // txtAddressLine2Up
            // 
            this.txtAddressLine2Up.Location = new System.Drawing.Point(237, 274);
            this.txtAddressLine2Up.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressLine2Up.Name = "txtAddressLine2Up";
            this.txtAddressLine2Up.Size = new System.Drawing.Size(137, 20);
            this.txtAddressLine2Up.TabIndex = 44;
            // 
            // txtAddressLine1Up
            // 
            this.txtAddressLine1Up.Location = new System.Drawing.Point(237, 233);
            this.txtAddressLine1Up.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressLine1Up.Name = "txtAddressLine1Up";
            this.txtAddressLine1Up.Size = new System.Drawing.Size(137, 20);
            this.txtAddressLine1Up.TabIndex = 43;
            // 
            // txtPhoneUp
            // 
            this.txtPhoneUp.Location = new System.Drawing.Point(237, 193);
            this.txtPhoneUp.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneUp.Name = "txtPhoneUp";
            this.txtPhoneUp.Size = new System.Drawing.Size(137, 20);
            this.txtPhoneUp.TabIndex = 42;
            // 
            // txtLNameUp
            // 
            this.txtLNameUp.Location = new System.Drawing.Point(237, 107);
            this.txtLNameUp.Margin = new System.Windows.Forms.Padding(2);
            this.txtLNameUp.Name = "txtLNameUp";
            this.txtLNameUp.Size = new System.Drawing.Size(137, 20);
            this.txtLNameUp.TabIndex = 40;
            // 
            // txtFNameUp
            // 
            this.txtFNameUp.Location = new System.Drawing.Point(237, 76);
            this.txtFNameUp.Margin = new System.Windows.Forms.Padding(2);
            this.txtFNameUp.Name = "txtFNameUp";
            this.txtFNameUp.Size = new System.Drawing.Size(137, 20);
            this.txtFNameUp.TabIndex = 39;
            // 
            // lblPasswordUp
            // 
            this.lblPasswordUp.AutoSize = true;
            this.lblPasswordUp.Location = new System.Drawing.Point(87, 464);
            this.lblPasswordUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordUp.Name = "lblPasswordUp";
            this.lblPasswordUp.Size = new System.Drawing.Size(53, 13);
            this.lblPasswordUp.TabIndex = 37;
            this.lblPasswordUp.Text = "Password";
            // 
            // lblRegNoUp
            // 
            this.lblRegNoUp.AutoSize = true;
            this.lblRegNoUp.Location = new System.Drawing.Point(87, 427);
            this.lblRegNoUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegNoUp.Name = "lblRegNoUp";
            this.lblRegNoUp.Size = new System.Drawing.Size(100, 13);
            this.lblRegNoUp.TabIndex = 37;
            this.lblRegNoUp.Text = "RegistrationNumber";
            // 
            // lblPostcodeUp
            // 
            this.lblPostcodeUp.AutoSize = true;
            this.lblPostcodeUp.Location = new System.Drawing.Point(86, 391);
            this.lblPostcodeUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostcodeUp.Name = "lblPostcodeUp";
            this.lblPostcodeUp.Size = new System.Drawing.Size(52, 13);
            this.lblPostcodeUp.TabIndex = 36;
            this.lblPostcodeUp.Text = "Postcode";
            // 
            // lblStateUp
            // 
            this.lblStateUp.AutoSize = true;
            this.lblStateUp.Location = new System.Drawing.Point(87, 352);
            this.lblStateUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStateUp.Name = "lblStateUp";
            this.lblStateUp.Size = new System.Drawing.Size(32, 13);
            this.lblStateUp.TabIndex = 35;
            this.lblStateUp.Text = "State";
            // 
            // lblSuburbUp
            // 
            this.lblSuburbUp.AutoSize = true;
            this.lblSuburbUp.Location = new System.Drawing.Point(86, 317);
            this.lblSuburbUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuburbUp.Name = "lblSuburbUp";
            this.lblSuburbUp.Size = new System.Drawing.Size(41, 13);
            this.lblSuburbUp.TabIndex = 34;
            this.lblSuburbUp.Text = "Suburb";
            // 
            // lblAddressLine2Up
            // 
            this.lblAddressLine2Up.AutoSize = true;
            this.lblAddressLine2Up.Location = new System.Drawing.Point(86, 278);
            this.lblAddressLine2Up.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressLine2Up.Name = "lblAddressLine2Up";
            this.lblAddressLine2Up.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine2Up.TabIndex = 33;
            this.lblAddressLine2Up.Text = "Address Line 2";
            // 
            // lblAddressLine1Up
            // 
            this.lblAddressLine1Up.AutoSize = true;
            this.lblAddressLine1Up.Location = new System.Drawing.Point(86, 237);
            this.lblAddressLine1Up.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressLine1Up.Name = "lblAddressLine1Up";
            this.lblAddressLine1Up.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine1Up.TabIndex = 32;
            this.lblAddressLine1Up.Text = "Address Line 1";
            // 
            // lblPhoneUp
            // 
            this.lblPhoneUp.AutoSize = true;
            this.lblPhoneUp.Location = new System.Drawing.Point(86, 197);
            this.lblPhoneUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneUp.Name = "lblPhoneUp";
            this.lblPhoneUp.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneUp.TabIndex = 31;
            this.lblPhoneUp.Text = "Phone Number";
            // 
            // lblDOBUp
            // 
            this.lblDOBUp.AutoSize = true;
            this.lblDOBUp.Location = new System.Drawing.Point(87, 152);
            this.lblDOBUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDOBUp.Name = "lblDOBUp";
            this.lblDOBUp.Size = new System.Drawing.Size(66, 13);
            this.lblDOBUp.TabIndex = 30;
            this.lblDOBUp.Text = "Date of Birth";
            // 
            // lblLNameUp
            // 
            this.lblLNameUp.AutoSize = true;
            this.lblLNameUp.Location = new System.Drawing.Point(86, 111);
            this.lblLNameUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLNameUp.Name = "lblLNameUp";
            this.lblLNameUp.Size = new System.Drawing.Size(58, 13);
            this.lblLNameUp.TabIndex = 29;
            this.lblLNameUp.Text = "Last Name";
            // 
            // lblFNameUp
            // 
            this.lblFNameUp.AutoSize = true;
            this.lblFNameUp.Location = new System.Drawing.Point(86, 70);
            this.lblFNameUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFNameUp.Name = "lblFNameUp";
            this.lblFNameUp.Size = new System.Drawing.Size(57, 13);
            this.lblFNameUp.TabIndex = 28;
            this.lblFNameUp.Text = "First Name";
            // 
            // lblTIDUp
            // 
            this.lblTIDUp.AutoSize = true;
            this.lblTIDUp.Location = new System.Drawing.Point(86, 26);
            this.lblTIDUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTIDUp.Name = "lblTIDUp";
            this.lblTIDUp.Size = new System.Drawing.Size(61, 13);
            this.lblTIDUp.TabIndex = 38;
            this.lblTIDUp.Text = "Teacher ID";
            // 
            // cboTIDUp
            // 
            this.cboTIDUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTIDUp.FormattingEnabled = true;
            this.cboTIDUp.Location = new System.Drawing.Point(237, 26);
            this.cboTIDUp.Margin = new System.Windows.Forms.Padding(2);
            this.cboTIDUp.Name = "cboTIDUp";
            this.cboTIDUp.Size = new System.Drawing.Size(82, 21);
            this.cboTIDUp.TabIndex = 27;
            this.cboTIDUp.SelectedIndexChanged += new System.EventHandler(this.cboTIDUp_SelectedIndexChanged);
            // 
            // frmTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 579);
            this.Controls.Add(this.tabTeacher);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTeachers";
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.frmTeachers_Load);
            this.tabTeacher.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTeacher;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cboStateUp;
        private System.Windows.Forms.TextBox txtPasswordUp;
        private System.Windows.Forms.TextBox txtRegNoUp;
        private System.Windows.Forms.TextBox txtPostcodeUp;
        private System.Windows.Forms.TextBox txtSuburbUp;
        private System.Windows.Forms.TextBox txtAddressLine2Up;
        private System.Windows.Forms.TextBox txtAddressLine1Up;
        private System.Windows.Forms.TextBox txtPhoneUp;
        private System.Windows.Forms.TextBox txtLNameUp;
        private System.Windows.Forms.TextBox txtFNameUp;
        private System.Windows.Forms.Label lblPasswordUp;
        private System.Windows.Forms.Label lblRegNoUp;
        private System.Windows.Forms.Label lblPostcodeUp;
        private System.Windows.Forms.Label lblStateUp;
        private System.Windows.Forms.Label lblSuburbUp;
        private System.Windows.Forms.Label lblAddressLine2Up;
        private System.Windows.Forms.Label lblAddressLine1Up;
        private System.Windows.Forms.Label lblPhoneUp;
        private System.Windows.Forms.Label lblDOBUp;
        private System.Windows.Forms.Label lblLNameUp;
        private System.Windows.Forms.Label lblFNameUp;
        private System.Windows.Forms.Label lblTIDUp;
        private System.Windows.Forms.ComboBox cboTIDUp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.DateTimePicker dateT;
        private System.Windows.Forms.DateTimePicker dateTUp;
    }
}