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
    public partial class frmTeacherDash : Form
    {
        public frmTeacherDash()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            new frmCourses().ShowDialog();
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            new frmMarks().ShowDialog();
        }

        private void frmTeacherDash_Load(object sender, EventArgs e)
        {

        }
    }
}
