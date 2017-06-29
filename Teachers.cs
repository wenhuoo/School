using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class frmTeachers : Form
    {
        Validate val = new Validate();
        public frmTeachers()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtPhone.Text = "";
            txtAddressLine1.Text = "";
            txtAddressLine2.Text = "";
            txtSuburb.Text = "";
            txtPostcode.Text = "";
            txtRegNo.Text = "";
            txtPassword.Text = "";
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStartDateUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmTeachers_Load(object sender, EventArgs e)
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                var teachers = (from c in db.Teachers select c).ToList();

                cboState.DisplayMember = "state";
                cboState.ValueMember = "state";
                cboStateUp.DisplayMember = "state";
                cboStateUp.ValueMember = "state";

                var states = new[]
                {
                    new {state = "VIC"},
                    new {state = "QLD"},
                    new {state = "SA"},
                    new {state = "TAS"},
                    new {state = "WA"},
                    new {state = "NSW"},
                    new {state = "NT"},
                    new {state = "ACT"},
                };

                cboState.DataSource = states;
                cboStateUp.DataSource = states;
            }

            this.updateTeacher();
            Clear();
        }

        private void updateTeacher()
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                var teachers = (from c in db.Teachers select c).ToList();

                cboTIDUp.DisplayMember = "TID";
                cboTIDUp.ValueMember = "TID";
                cboTIDUp.DataSource = teachers;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string msgFName = val.valFName(txtFName.Text);
            string msgLName = val.valLName(txtLName.Text);
            string msgDate = val.validDateDOB(dateT.Value);
            string msgPhone = val.valPhone(txtPhone.Text);
            string msgAdd1 = val.valAdd1(txtAddressLine1.Text);
            string msgAdd2 = val.valAdd2(txtAddressLine2.Text);
            string msgSuburb = val.valSub(txtSuburb.Text);
            string msgPost = val.valPostcode(txtPostcode.Text);
            string msgRego = val.valRegoNo(txtRegNo.Text);
            string msgPass = val.valPassword(txtPassword.Text);

            if (msgFName == "" && msgLName == "" && msgDate == "" && msgPhone == "" && msgAdd1 == "" && msgAdd2 == "" && msgSuburb == "" && msgPost == "" && msgRego == "" && msgPass == "")
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    Teacher teachers = new Teacher();

                    teachers.FName = txtFName.Text;
                    teachers.LName = txtLName.Text;
                    teachers.DOB = dateT.Value;
                    teachers.Phone = txtPhone.Text;
                    teachers.Add1 = txtAddressLine1.Text;
                    teachers.Add2 = txtAddressLine2.Text;
                    teachers.Suburb = txtSuburb.Text;
                    teachers.State = cboState.Text;
                    teachers.Postcode = txtPostcode.Text;
                    teachers.RegNo = txtRegNo.Text;
                    teachers.Password = txtPassword.Text;

                    db.Teachers.Add(teachers);
                    db.SaveChanges();
                    MessageBox.Show("New Teacher Added! ID:" + teachers.TID);
                }
            }
            else
            {
                MessageBox.Show(msgFName + "\r\n" + msgLName + "\r\n" + msgPhone + "\r\n" + msgAdd1 + "\r\n" + msgAdd2 + "\r\n" + msgSuburb + "\r\n" + msgPost + "\r\n" + msgRego + "\r\n" + msgPass);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string msgFName = val.valFName(txtFNameUp.Text);
            string msgLName = val.valLName(txtLNameUp.Text);
            string msgDate = val.validDateDOB(dateTUp.Value);
            string msgPhone = val.valPhone(txtPhoneUp.Text);
            string msgAdd1 = val.valAdd1(txtAddressLine1Up.Text);
            string msgAdd2 = val.valAdd2(txtAddressLine2Up.Text);
            string msgSuburb = val.valSub(txtSuburbUp.Text);
            string msgPost = val.valPostcode(txtPostcodeUp.Text);
            string msgRego = val.valRegoNo(txtRegNoUp.Text);
            string msgPass = val.valPassword(txtPasswordUp.Text);

            if (msgFName == "" && msgLName == "" && msgDate == "" && msgPhone == "" && msgAdd1 == "" && msgAdd2 == "" && msgSuburb == "" && msgPost == "" && msgRego == "" && msgPass == "")
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    int tno = Convert.ToInt32(cboTIDUp.Text);
                    Teacher teachers = (from c in db.Teachers where c.TID == tno select c).First();

                    teachers.FName = txtFNameUp.Text;
                    teachers.LName = txtLNameUp.Text;
                    teachers.DOB = dateTUp.Value;
                    teachers.Phone = txtPhoneUp.Text;
                    teachers.Add1 = txtAddressLine1Up.Text;
                    teachers.Add2 = txtAddressLine2Up.Text;
                    teachers.Suburb = txtSuburbUp.Text;
                    teachers.State = cboStateUp.Text;
                    teachers.Postcode = txtPostcodeUp.Text;
                    teachers.RegNo = txtRegNoUp.Text;
                    teachers.Password = txtPasswordUp.Text;

                    db.SaveChanges();
                    MessageBox.Show("Teacher Updated!");
                }

                this.updateTeacher();

            }
            else
            {
                MessageBox.Show(msgFName + "\r\n" + msgLName + "\r\n" + msgPhone + "\r\n" + msgAdd1 + "\r\n" + msgAdd2 + "\r\n" + msgSuburb + "\r\n" + msgPost + "\r\n" + msgRego + "\r\n" + msgPass);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                int tno = Convert.ToInt32(cboTIDUp.Text);
                Teacher teach = (from c in db.Teachers where c.TID == tno select c).First();
                db.Teachers.Remove(teach);
                db.SaveChanges();
                MessageBox.Show("Teacher Deleted!");
            }

            this.updateTeacher();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboTIDUp_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                int tno = Convert.ToInt32(cboTIDUp.Text);
                Teacher teachers = (from c in db.Teachers where c.TID == tno select c).First();

                txtFNameUp.Text = teachers.FName;
                txtLNameUp.Text = teachers.LName;
                dateTUp.Value = teachers.DOB;
                txtPhoneUp.Text = teachers.Phone;
                txtAddressLine1Up.Text = teachers.Add1;
                txtAddressLine2Up.Text = teachers.Add2;
                txtSuburbUp.Text = teachers.Suburb;
                cboStateUp.Text = teachers.State;
                txtPostcodeUp.Text = teachers.Postcode;
                txtRegNoUp.Text = teachers.RegNo;
                txtPasswordUp.Text = teachers.Password;
            }
        }
    }
}
