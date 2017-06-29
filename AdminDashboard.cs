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
    public partial class frmAdminDash : Form
    {
        public frmAdminDash()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            new frmStudents().ShowDialog();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            new frmTeachers().ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new frmAdmin().ShowDialog();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            new frmCourses().ShowDialog();
        }

        private void frmAdminDash_Load(object sender, EventArgs e)
        {

        }
    }
}
