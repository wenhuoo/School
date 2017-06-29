namespace School
{
    partial class frmStudents
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
            this.tabStudent = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateSD = new System.Windows.Forms.DateTimePicker();
            this.dateS = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
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
            this.dateSDUp = new System.Windows.Forms.DateTimePicker();
            this.dateSUp = new System.Windows.Forms.DateTimePicker();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboStateUp = new System.Windows.Forms.ComboBox();
            this.txtPostcodeUp = new System.Windows.Forms.TextBox();
            this.txtSuburbUp = new System.Windows.Forms.TextBox();
            this.txtAddressLine2Up = new System.Windows.Forms.TextBox();
            this.txtAddressLine1Up = new System.Windows.Forms.TextBox();
            this.txtPhoneUp = new System.Windows.Forms.TextBox();
            this.txtLNameUp = new System.Windows.Forms.TextBox();
            this.txtFNameUp = new System.Windows.Forms.TextBox();
            this.lblStartDateUp = new System.Windows.Forms.Label();
            this.lblPostcodeUp = new System.Windows.Forms.Label();
            this.lblStateUp = new System.Windows.Forms.Label();
            this.lblSuburbUp = new System.Windows.Forms.Label();
            this.lblAddressLine2Up = new System.Windows.Forms.Label();
            this.lblAddressLine1Up = new System.Windows.Forms.Label();
            this.lblPhoneUp = new System.Windows.Forms.Label();
            this.lblDOBUp = new System.Windows.Forms.Label();
            this.lblLNameUp = new System.Windows.Forms.Label();
            this.lblFNameUp = new System.Windows.Forms.Label();
            this.lblSIDUp = new System.Windows.Forms.Label();
            this.cboSIDUp = new System.Windows.Forms.ComboBox();
            this.errorProviderFName = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabStudent.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFName)).BeginInit();
            this.SuspendLayout();
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.tabPage1);
            this.tabStudent.Controls.Add(this.tabPage2);
            this.tabStudent.Location = new System.Drawing.Point(-1, -1);
            this.tabStudent.Margin = new System.Windows.Forms.Padding(2);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.SelectedIndex = 0;
            this.tabStudent.Size = new System.Drawing.Size(425, 531);
            this.tabStudent.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateSD);
            this.tabPage1.Controls.Add(this.dateS);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.cboState);
            this.tabPage1.Controls.Add(this.txtPostcode);
            this.tabPage1.Controls.Add(this.txtSuburb);
            this.tabPage1.Controls.Add(this.txtAddressLine2);
            this.tabPage1.Controls.Add(this.txtAddressLine1);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.txtLName);
            this.tabPage1.Controls.Add(this.txtFName);
            this.tabPage1.Controls.Add(this.lblStartDate);
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
            this.tabPage1.Size = new System.Drawing.Size(417, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Students";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateSD
            // 
            this.dateSD.Location = new System.Drawing.Point(208, 383);
            this.dateSD.Name = "dateSD";
            this.dateSD.Size = new System.Drawing.Size(137, 20);
            this.dateSD.TabIndex = 7;
            // 
            // dateS
            // 
            this.dateS.Location = new System.Drawing.Point(207, 108);
            this.dateS.Name = "dateS";
            this.dateS.Size = new System.Drawing.Size(137, 20);
            this.dateS.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(289, 434);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(61, 434);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(208, 308);
            this.cboState.Margin = new System.Windows.Forms.Padding(2);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(137, 21);
            this.cboState.TabIndex = 3;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(208, 350);
            this.txtPostcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(137, 20);
            this.txtPostcode.TabIndex = 2;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(208, 275);
            this.txtSuburb.Margin = new System.Windows.Forms.Padding(2);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(137, 20);
            this.txtSuburb.TabIndex = 2;
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(208, 236);
            this.txtAddressLine2.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(137, 20);
            this.txtAddressLine2.TabIndex = 2;
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(208, 194);
            this.txtAddressLine1.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(137, 20);
            this.txtAddressLine1.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(208, 155);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(137, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(208, 70);
            this.txtLName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(137, 20);
            this.txtLName.TabIndex = 2;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(208, 38);
            this.txtFName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(137, 20);
            this.txtFName.TabIndex = 2;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(58, 389);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(91, 13);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Course Start Date";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(57, 353);
            this.lblPostcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(52, 13);
            this.lblPostcode.TabIndex = 1;
            this.lblPostcode.Text = "Postcode";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(58, 314);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 1;
            this.lblState.Text = "State";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(57, 279);
            this.lblSuburb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(41, 13);
            this.lblSuburb.TabIndex = 1;
            this.lblSuburb.Text = "Suburb";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(57, 240);
            this.lblAddressLine2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine2.TabIndex = 1;
            this.lblAddressLine2.Text = "Address Line 2";
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(57, 199);
            this.lblAddressLine1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine1.TabIndex = 1;
            this.lblAddressLine1.Text = "Address Line 1";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(57, 158);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 13);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(58, 114);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(66, 13);
            this.lblDOB.TabIndex = 1;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(57, 73);
            this.lblLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 13);
            this.lblLName.TabIndex = 1;
            this.lblLName.Text = "Last Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(57, 32);
            this.lblFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(57, 13);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "First Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dateSDUp);
            this.tabPage2.Controls.Add(this.dateSUp);
            this.tabPage2.Controls.Add(this.btnExit);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.cboStateUp);
            this.tabPage2.Controls.Add(this.txtPostcodeUp);
            this.tabPage2.Controls.Add(this.txtSuburbUp);
            this.tabPage2.Controls.Add(this.txtAddressLine2Up);
            this.tabPage2.Controls.Add(this.txtAddressLine1Up);
            this.tabPage2.Controls.Add(this.txtPhoneUp);
            this.tabPage2.Controls.Add(this.txtLNameUp);
            this.tabPage2.Controls.Add(this.txtFNameUp);
            this.tabPage2.Controls.Add(this.lblStartDateUp);
            this.tabPage2.Controls.Add(this.lblPostcodeUp);
            this.tabPage2.Controls.Add(this.lblStateUp);
            this.tabPage2.Controls.Add(this.lblSuburbUp);
            this.tabPage2.Controls.Add(this.lblAddressLine2Up);
            this.tabPage2.Controls.Add(this.lblAddressLine1Up);
            this.tabPage2.Controls.Add(this.lblPhoneUp);
            this.tabPage2.Controls.Add(this.lblDOBUp);
            this.tabPage2.Controls.Add(this.lblLNameUp);
            this.tabPage2.Controls.Add(this.lblFNameUp);
            this.tabPage2.Controls.Add(this.lblSIDUp);
            this.tabPage2.Controls.Add(this.cboSIDUp);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(417, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update/Delete Students";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateSDUp
            // 
            this.dateSDUp.Location = new System.Drawing.Point(214, 418);
            this.dateSDUp.Name = "dateSDUp";
            this.dateSDUp.Size = new System.Drawing.Size(137, 20);
            this.dateSDUp.TabIndex = 28;
            // 
            // dateSUp
            // 
            this.dateSUp.Location = new System.Drawing.Point(212, 142);
            this.dateSUp.Name = "dateSUp";
            this.dateSUp.Size = new System.Drawing.Size(139, 20);
            this.dateSUp.TabIndex = 27;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(296, 466);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 26);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(167, 466);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 26);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(59, 466);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(53, 26);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboStateUp
            // 
            this.cboStateUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStateUp.FormattingEnabled = true;
            this.cboStateUp.Location = new System.Drawing.Point(214, 343);
            this.cboStateUp.Margin = new System.Windows.Forms.Padding(2);
            this.cboStateUp.Name = "cboStateUp";
            this.cboStateUp.Size = new System.Drawing.Size(137, 21);
            this.cboStateUp.TabIndex = 25;
            // 
            // txtPostcodeUp
            // 
            this.txtPostcodeUp.Location = new System.Drawing.Point(214, 385);
            this.txtPostcodeUp.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostcodeUp.Name = "txtPostcodeUp";
            this.txtPostcodeUp.Size = new System.Drawing.Size(137, 20);
            this.txtPostcodeUp.TabIndex = 23;
            // 
            // txtSuburbUp
            // 
            this.txtSuburbUp.Location = new System.Drawing.Point(214, 310);
            this.txtSuburbUp.Margin = new System.Windows.Forms.Padding(2);
            this.txtSuburbUp.Name = "txtSuburbUp";
            this.txtSuburbUp.Size = new System.Drawing.Size(137, 20);
            this.txtSuburbUp.TabIndex = 22;
            // 
            // txtAddressLine2Up
            // 
            this.txtAddressLine2Up.Location = new System.Drawing.Point(214, 271);
            this.txtAddressLine2Up.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressLine2Up.Name = "txtAddressLine2Up";
            this.txtAddressLine2Up.Size = new System.Drawing.Size(137, 20);
            this.txtAddressLine2Up.TabIndex = 21;
            // 
            // txtAddressLine1Up
            // 
            this.txtAddressLine1Up.Location = new System.Drawing.Point(214, 229);
            this.txtAddressLine1Up.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressLine1Up.Name = "txtAddressLine1Up";
            this.txtAddressLine1Up.Size = new System.Drawing.Size(137, 20);
            this.txtAddressLine1Up.TabIndex = 20;
            // 
            // txtPhoneUp
            // 
            this.txtPhoneUp.Location = new System.Drawing.Point(214, 190);
            this.txtPhoneUp.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneUp.Name = "txtPhoneUp";
            this.txtPhoneUp.Size = new System.Drawing.Size(137, 20);
            this.txtPhoneUp.TabIndex = 19;
            // 
            // txtLNameUp
            // 
            this.txtLNameUp.Location = new System.Drawing.Point(214, 104);
            this.txtLNameUp.Margin = new System.Windows.Forms.Padding(2);
            this.txtLNameUp.Name = "txtLNameUp";
            this.txtLNameUp.Size = new System.Drawing.Size(137, 20);
            this.txtLNameUp.TabIndex = 17;
            // 
            // txtFNameUp
            // 
            this.txtFNameUp.Location = new System.Drawing.Point(214, 73);
            this.txtFNameUp.Margin = new System.Windows.Forms.Padding(2);
            this.txtFNameUp.Name = "txtFNameUp";
            this.txtFNameUp.Size = new System.Drawing.Size(137, 20);
            this.txtFNameUp.TabIndex = 16;
            // 
            // lblStartDateUp
            // 
            this.lblStartDateUp.AutoSize = true;
            this.lblStartDateUp.Location = new System.Drawing.Point(64, 424);
            this.lblStartDateUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDateUp.Name = "lblStartDateUp";
            this.lblStartDateUp.Size = new System.Drawing.Size(91, 13);
            this.lblStartDateUp.TabIndex = 14;
            this.lblStartDateUp.Text = "Course Start Date";
            // 
            // lblPostcodeUp
            // 
            this.lblPostcodeUp.AutoSize = true;
            this.lblPostcodeUp.Location = new System.Drawing.Point(63, 388);
            this.lblPostcodeUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostcodeUp.Name = "lblPostcodeUp";
            this.lblPostcodeUp.Size = new System.Drawing.Size(52, 13);
            this.lblPostcodeUp.TabIndex = 13;
            this.lblPostcodeUp.Text = "Postcode";
            // 
            // lblStateUp
            // 
            this.lblStateUp.AutoSize = true;
            this.lblStateUp.Location = new System.Drawing.Point(64, 349);
            this.lblStateUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStateUp.Name = "lblStateUp";
            this.lblStateUp.Size = new System.Drawing.Size(32, 13);
            this.lblStateUp.TabIndex = 12;
            this.lblStateUp.Text = "State";
            // 
            // lblSuburbUp
            // 
            this.lblSuburbUp.AutoSize = true;
            this.lblSuburbUp.Location = new System.Drawing.Point(63, 314);
            this.lblSuburbUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuburbUp.Name = "lblSuburbUp";
            this.lblSuburbUp.Size = new System.Drawing.Size(41, 13);
            this.lblSuburbUp.TabIndex = 11;
            this.lblSuburbUp.Text = "Suburb";
            // 
            // lblAddressLine2Up
            // 
            this.lblAddressLine2Up.AutoSize = true;
            this.lblAddressLine2Up.Location = new System.Drawing.Point(63, 275);
            this.lblAddressLine2Up.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressLine2Up.Name = "lblAddressLine2Up";
            this.lblAddressLine2Up.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine2Up.TabIndex = 10;
            this.lblAddressLine2Up.Text = "Address Line 2";
            // 
            // lblAddressLine1Up
            // 
            this.lblAddressLine1Up.AutoSize = true;
            this.lblAddressLine1Up.Location = new System.Drawing.Point(63, 233);
            this.lblAddressLine1Up.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressLine1Up.Name = "lblAddressLine1Up";
            this.lblAddressLine1Up.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine1Up.TabIndex = 9;
            this.lblAddressLine1Up.Text = "Address Line 1";
            // 
            // lblPhoneUp
            // 
            this.lblPhoneUp.AutoSize = true;
            this.lblPhoneUp.Location = new System.Drawing.Point(63, 194);
            this.lblPhoneUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneUp.Name = "lblPhoneUp";
            this.lblPhoneUp.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneUp.TabIndex = 8;
            this.lblPhoneUp.Text = "Phone Number";
            // 
            // lblDOBUp
            // 
            this.lblDOBUp.AutoSize = true;
            this.lblDOBUp.Location = new System.Drawing.Point(64, 148);
            this.lblDOBUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDOBUp.Name = "lblDOBUp";
            this.lblDOBUp.Size = new System.Drawing.Size(66, 13);
            this.lblDOBUp.TabIndex = 7;
            this.lblDOBUp.Text = "Date of Birth";
            // 
            // lblLNameUp
            // 
            this.lblLNameUp.AutoSize = true;
            this.lblLNameUp.Location = new System.Drawing.Point(63, 109);
            this.lblLNameUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLNameUp.Name = "lblLNameUp";
            this.lblLNameUp.Size = new System.Drawing.Size(58, 13);
            this.lblLNameUp.TabIndex = 6;
            this.lblLNameUp.Text = "Last Name";
            // 
            // lblFNameUp
            // 
            this.lblFNameUp.AutoSize = true;
            this.lblFNameUp.Location = new System.Drawing.Point(63, 67);
            this.lblFNameUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFNameUp.Name = "lblFNameUp";
            this.lblFNameUp.Size = new System.Drawing.Size(57, 13);
            this.lblFNameUp.TabIndex = 5;
            this.lblFNameUp.Text = "First Name";
            // 
            // lblSIDUp
            // 
            this.lblSIDUp.AutoSize = true;
            this.lblSIDUp.Location = new System.Drawing.Point(63, 23);
            this.lblSIDUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSIDUp.Name = "lblSIDUp";
            this.lblSIDUp.Size = new System.Drawing.Size(58, 13);
            this.lblSIDUp.TabIndex = 15;
            this.lblSIDUp.Text = "Student ID";
            // 
            // cboSIDUp
            // 
            this.cboSIDUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSIDUp.FormattingEnabled = true;
            this.cboSIDUp.Location = new System.Drawing.Point(214, 23);
            this.cboSIDUp.Margin = new System.Windows.Forms.Padding(2);
            this.cboSIDUp.Name = "cboSIDUp";
            this.cboSIDUp.Size = new System.Drawing.Size(82, 21);
            this.cboSIDUp.TabIndex = 4;
            this.cboSIDUp.SelectedIndexChanged += new System.EventHandler(this.cboSIDUp_SelectedIndexChanged);
            // 
            // errorProviderFName
            // 
            this.errorProviderFName.ContainerControl = this;
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 525);
            this.Controls.Add(this.tabStudent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStudents";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.frmStudents_Load);
            this.tabStudent.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabStudent;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cboStateUp;
        private System.Windows.Forms.TextBox txtPostcodeUp;
        private System.Windows.Forms.TextBox txtSuburbUp;
        private System.Windows.Forms.TextBox txtAddressLine2Up;
        private System.Windows.Forms.TextBox txtAddressLine1Up;
        private System.Windows.Forms.TextBox txtPhoneUp;
        private System.Windows.Forms.TextBox txtLNameUp;
        private System.Windows.Forms.TextBox txtFNameUp;
        private System.Windows.Forms.Label lblStartDateUp;
        private System.Windows.Forms.Label lblPostcodeUp;
        private System.Windows.Forms.Label lblStateUp;
        private System.Windows.Forms.Label lblSuburbUp;
        private System.Windows.Forms.Label lblAddressLine2Up;
        private System.Windows.Forms.Label lblAddressLine1Up;
        private System.Windows.Forms.Label lblPhoneUp;
        private System.Windows.Forms.Label lblDOBUp;
        private System.Windows.Forms.Label lblLNameUp;
        private System.Windows.Forms.Label lblFNameUp;
        private System.Windows.Forms.Label lblSIDUp;
        private System.Windows.Forms.ComboBox cboSIDUp;
        private System.Windows.Forms.DateTimePicker dateS;
        private System.Windows.Forms.DateTimePicker dateSUp;
        private System.Windows.Forms.DateTimePicker dateSD;
        private System.Windows.Forms.DateTimePicker dateSDUp;
        private System.Windows.Forms.ErrorProvider errorProviderFName;
    }
}