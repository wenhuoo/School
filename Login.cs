using System;
using System.Linq;
using System.Windows.Forms;

namespace School
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cboUser.Items.Add("Teachers");
            cboUser.Items.Add("Administrators");
            cboUser.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                int uname;
                string inputUname = txtUsername.Text;
                bool isInt = int.TryParse(inputUname, out uname); 
                string pass = txtPassword.Text;

                if(string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please type username and password.");
                    return;
                }
                if(!isInt)
                {
                    MessageBox.Show("Please type integer for username.");
                    return;
                }

                if (cboUser.Text == "Teachers")
                {
                    Teacher teacher = (from c in db.Teachers where c.TID == uname select c).FirstOrDefault();
                    if (teacher == null)
                    {
                        MessageBox.Show("Username cannot be found in the Teacher Table.");
                        return;
                    }
                    if (teacher.TID == uname && teacher.Password == pass)
                    {
                        new frmTeacherDash().ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password for Teachers!");
                        return;
                    }
                }
                else
                {
                    Administrator admin = (from c in db.Administrators where c.AID == uname select c).FirstOrDefault();
                    if (admin == null)
                    {
                        MessageBox.Show("Username cannot be found in the Admin Table.");
                        return;
                    }
                    if (admin.AID == uname && admin.Password == pass)
                    {
                        new frmAdminDash().ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password for Admins!");
                        return;
                    }
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
