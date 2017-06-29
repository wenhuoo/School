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
    public partial class frmStudents : Form
    {
        Validate val = new Validate();
        public frmStudents()
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
        }

        public void refreshForm()
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                var students = (from c in db.Students select c).ToList();

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
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            this.refreshForm();
            this.updateStudent();
        }

        public void updateStudent()
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                var students = (from c in db.Students select c).ToList();

                cboSIDUp.DisplayMember = "SID";
                cboSIDUp.ValueMember = "SID";
                cboSIDUp.DataSource = students;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string msgFName = val.valFName(txtFName.Text);
            string msgLName = val.valLName(txtLName.Text);
            string msgDate = val.validDateStart(dateSD.Value);
            string msgDateDOB = val.validDateDOB(dateS.Value);
            string msgPhone = val.valPhone(txtPhone.Text);
            string msgAdd1 = val.valAdd1(txtAddressLine1.Text);
            string msgAdd2 = val.valAdd2(txtAddressLine2.Text);
            string msgSuburb = val.valSub(txtSuburb.Text);
            string msgPost = val.valPostcode(txtPostcode.Text);

            if (msgFName == "" && msgLName == "" && msgDate == "" && msgDateDOB == "" && msgPhone == "" && msgAdd1 == "" && msgAdd2 == "" && msgSuburb == "" && msgPost == "")
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    Student students = new Student();

                    students.FName = txtFName.Text;
                    students.LName = txtLName.Text;
                    students.DOB = dateS.Value;
                    students.Phone = txtPhone.Text;
                    students.Add1 = txtAddressLine1.Text;
                    students.Add2 = txtAddressLine2.Text;
                    students.Suburb = txtSuburb.Text;
                    students.State = cboState.Text;
                    students.Postcode = txtPostcode.Text;
                    students.SDate = dateSD.Value;

                    db.Students.Add(students);
                    db.SaveChanges();
                    MessageBox.Show("New Student Added! ID:" + students.SID);
                }
            }
            else
            {
                MessageBox.Show(msgFName + "\r\n" + msgLName + "\r\n" + msgPhone + "\r\n" + msgDate + "\r\n" + msgAdd1 + "\r\n" + msgDateDOB + "\r\n" + msgAdd2 + "\r\n" + msgSuburb + "\r\n" + msgPost);
            }
            this.refreshForm();  
            this.updateStudent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string msgFName = val.valFName(txtFNameUp.Text);
            string msgLName = val.valLName(txtLNameUp.Text);
            string msgDate = val.validDateStart(dateSDUp.Value);
            string msgDateDOB = val.validDateDOB(dateSUp.Value);
            string msgPhone = val.valPhone(txtPhoneUp.Text);
            string msgAdd1 = val.valAdd1(txtAddressLine1Up.Text);
            string msgAdd2 = val.valAdd2(txtAddressLine2Up.Text);
            string msgSuburb = val.valSub(txtSuburbUp.Text);
            string msgPost = val.valPostcode(txtPostcodeUp.Text);
            

            if (msgFName == "" && msgLName == "" && msgDate == "" && msgDateDOB == "" && msgPhone == "" && msgAdd1 == "" && msgAdd2 == "" && msgSuburb == "" && msgPost == "")
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    int sno = Convert.ToInt32(cboSIDUp.Text);
                    Student students = (from c in db.Students where c.SID == sno select c).First();

                    students.FName = txtFNameUp.Text;
                    students.LName = txtLNameUp.Text;
                    students.SDate = dateSDUp.Value;
                    students.DOB = dateSUp.Value;
                    students.Phone = txtPhoneUp.Text;
                    students.Add1 = txtAddressLine1Up.Text;
                    students.Add2 = txtAddressLine2Up.Text;
                    students.Suburb = txtSuburbUp.Text;
                    students.State = cboStateUp.Text;
                    students.Postcode = txtPostcodeUp.Text;
                    

                    db.SaveChanges();
                    MessageBox.Show("Student Updated!");
                }
            }
            else
            {
                MessageBox.Show(msgFName + "\r\n" + msgLName + "\r\n" + msgPhone + "\r\n" + msgAdd1 + "\r\n" + msgAdd2 + "\r\n" + msgSuburb + "\r\n" + msgPost);
            }

            this.updateStudent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                int sno = Convert.ToInt32(cboSIDUp.Text);
                Student stud = (from c in db.Students where c.SID == sno select c).First();
                db.Students.Remove(stud);

                db.SaveChanges();
                MessageBox.Show("Student Deleted!");
            }

            this.updateStudent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboSIDUp_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                int sno = Convert.ToInt32(cboSIDUp.Text);
                Student students = (from c in db.Students where c.SID == sno select c).First();

                txtFNameUp.Text = students.FName;
                txtLNameUp.Text = students.LName;
                dateSUp.Value = students.DOB;
                txtPhoneUp.Text = students.Phone;
                txtAddressLine1Up.Text = students.Add1;
                txtAddressLine2Up.Text = students.Add2;
                txtSuburbUp.Text = students.Suburb;
                cboStateUp.Text = students.State;
                txtPostcodeUp.Text = students.Postcode;
                dateSDUp.Value = students.SDate;
            }
        }
    }
}
