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
    public partial class frmCourses : Form
    {

        Validate val = new Validate();
        public frmCourses()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtCourseName.Text = "";
            txtYear.Text = "";
            txtSem.Text = "";
        }

        public void updateTeacher()
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                var courses = (from c in db.Teachers select c).ToList();
                cboAlloTeacher.DisplayMember = "TID";
                cboAlloTeacher.ValueMember = "TID";
                cboAlloTeacher.DataSource = courses;
                cboAllodTeacher.DisplayMember = "TID";
                cboAllodTeacher.ValueMember = "TID";
                cboAllodTeacher.DataSource = courses;
            }
        }
        public void refreshForm()
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                var courses = (from c in db.Courses select c).ToList();

                cboCourseID.DisplayMember = "CID";
                cboCourseID.ValueMember = "CID";
                cboCourseID.DataSource = courses;
            }
        }
        private void frmCourses_Load(object sender, EventArgs e)
        {
            this.refreshForm();
            this.updateTeacher();
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string msgYear = val.valYear(txtYear.Text);
            string msgCName = val.valCName(txtCourseName.Text);
            string msgSem = val.valSem(txtSem.Text);
            string msgCID = val.validCID(txtCourseID.Text);

            if (msgSem == "" && msgYear == "" && msgCName == "" && msgCID == "")
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    Course courses = new Course();
                    courses.Year = Convert.ToInt32(txtYear.Text);
                    courses.CName = txtCourseName.Text;
                    courses.Semester = txtSem.Text;
                    courses.CID = Convert.ToInt32(txtCourseID.Text);
                    if (ckAT.Checked)
                    {
                        courses.TID = Convert.ToInt32(cboAlloTeacher.Text);
                    }
                    db.Courses.Add(courses);
                    db.SaveChanges();

                    MessageBox.Show("Course Added!");
                }
            }
            else
            {
                MessageBox.Show(msgCName + "\r\n" + msgYear + "\r\n" + msgSem + "\r\n" + msgCID);
            }
            this.refreshForm();
            this.updateTeacher();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string msgYear = val.valYear(txtYearUp.Text);
            string msgCName = val.valCName(txtCourseNameUp.Text);
            string msgSem = val.valSem(txtSemUp.Text);

            if (msgSem == "" && msgYear == "" && msgCName == "")
            {
                using (SchoolEntities db = new SchoolEntities())
                {

                    int cno = Convert.ToInt32(cboCourseID.Text);
                    Course courses = (from c in db.Courses where c.CID == cno select c).First();

                    courses.Year = Convert.ToInt32(txtYearUp.Text);
                    courses.CName = txtCourseName.Text;
                    courses.Semester = txtSemUp.Text;
                    courses.CID = Convert.ToInt32(txtCourseID.Text);
                    if (ckAdT.Checked)
                    {
                        courses.TID = Convert.ToInt32(cboAllodTeacher.Text);
                    }

                    db.SaveChanges();
                    MessageBox.Show("Course details updated!");
                }

                this.refreshForm();
                this.updateTeacher();
            }
            else
            {
                MessageBox.Show(msgCName + "\r\n" + msgYear + "\r\n" + msgSem);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                int cno = Convert.ToInt32(cboCourseID.Text);
                Course cor = (from c in db.Courses where c.CID == cno select c).First();
                db.Courses.Remove(cor);
                db.SaveChanges();
                MessageBox.Show("Course Deleted!");
            }
            this.updateTeacher();
            this.refreshForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCourseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                int cno = Convert.ToInt32(cboCourseID.Text);
                Course courses = (from c in db.Courses where c.CID == cno select c).First();

                txtCourseNameUp.Text = courses.CName;
                cboAllodTeacher.Text = courses.TID.ToString();
                txtYearUp.Text = courses.Year.ToString();
                txtSemUp.Text = courses.Semester.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
