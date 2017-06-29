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
    public partial class frmMarks : Form
    {
        Validate val = new Validate();
        public const int MarkCol = 2;
        public frmMarks()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txtMarkAdd.Text = "";
        }

        public void updateMarks()
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                var m = (from s in db.Students select new { s.SID }).ToList();
                var n = (from c in db.Courses select new { c.CID }).ToList();

                cboCIDEdit.DisplayMember = "CID";
                cboCIDEdit.ValueMember = "CID";
                cboCIDEdit.DataSource = n;

                int cno = Convert.ToInt32(cboCIDEdit.Text);
                var g = (from d in db.Student_Course where d.CID == cno select d).ToList();

                dGVMarks.DataSource = g;
                dGVMarks.Columns[3].Visible = false;
                dGVMarks.Columns[4].Visible = false;
                dGVMarks.Columns["SID"].ReadOnly = true;
                dGVMarks.Columns["CID"].ReadOnly = true;

                cboCIDAdd.DisplayMember = "CID";
                cboCIDAdd.ValueMember = "CID";
                cboCIDAdd.DataSource = n;
                cboSIDAdd.DisplayMember = "SID";
                cboSIDAdd.ValueMember = "SID";
                cboSIDAdd.DataSource = m;
            }
        }


        private void frmMarks_Load(object sender, EventArgs e)
        {
            this.updateMarks();
        }

        private void cboCIDEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                int cid = Convert.ToInt32(cboCIDEdit.Text);
                var course = (from c in db.Student_Course where c.CID == cid select c).ToList();

                dGVMarks.DataSource = course;
            }
        }

        private void btnAddMarks_Click(object sender, EventArgs e)
        {
            string mark = val.valMark(txtMarkAdd.Text);

            if (!(mark == ""))
            {
                MessageBox.Show(mark);
            }

            using (SchoolEntities db = new SchoolEntities())
            {
                int sno = Convert.ToInt32(cboSIDAdd.Text);
                int cno = Convert.ToInt32(cboCIDAdd.Text);

                Student_Course course = (from c in db.Student_Course where sno == c.SID && cno == c.CID select c).FirstOrDefault();

                if (course != null)
                {
                    MessageBox.Show("Mark Exists Already. Cannot Add Marks.");
                }
                else
                {
                    course = new Student_Course();
                    course.SID = sno;
                    course.CID = cno;
                    course.Mark = Convert.ToInt32(txtMarkAdd.Text);
                    db.Student_Course.Add(course);
                    db.SaveChanges();
                    MessageBox.Show("Mark Added.");
                }

                updateMarks();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                int cno = Convert.ToInt32(cboCIDEdit.Text);
                int[] sid = (from c in db.Student_Course where c.CID == cno select c.SID).ToArray();
                int sct = sid.Length;
                for (int i = 0; i < sct; i++)
                {
                    int studentid = sid[i];
                    Student_Course cou = (from c in db.Student_Course where c.CID == cno && c.SID == studentid select c).FirstOrDefault();

                    string markInput = dGVMarks.Rows[i].Cells[MarkCol].Value.ToString();
                    string output = val.valMark(markInput);
                    int markEd = Convert.ToInt32(markInput);

                    if (!(output == ""))
                    {
                        MessageBox.Show(output);
                    }
                    cou.Mark = markEd;
                    db.SaveChanges();
                }
            }

            updateMarks();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelMarks_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
