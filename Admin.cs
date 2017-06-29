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
    public partial class frmAdmin : Form
    {
        Validate val = new Validate();
        public frmAdmin()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtPassword.Text = "";
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            this.updateAdmin();
        }

        public void updateAdmin()
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                var admins = (from c in db.Administrators select c).ToList();

                cboAIDUp.DisplayMember = "AID";
                cboAIDUp.ValueMember = "AID";
                cboAIDUp.DataSource = admins;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string msgFN = val.valFName(txtFName.Text);
            string msgLN = val.valLName(txtLName.Text);
            string msgP = val.valPassword(txtPassword.Text);

            if (msgFN == "" && msgLN == "" && msgP == "")
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    Administrator admins = new Administrator();

                    admins.FName = txtFName.Text;
                    admins.LName = txtLName.Text;
                    admins.Password = txtPassword.Text;

                    db.Administrators.Add(admins);
                    db.SaveChanges();
                    MessageBox.Show("New Admin Added! ID:" + admins.AID);
                }

                this.updateAdmin();
            }
            else
            {
                MessageBox.Show(msgFN + "\r\n" + msgLN + "\r\n" + msgP);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string msgFN = val.valFName(txtFNameUp.Text);
            string msgLN = val.valLName(txtLNameUp.Text);
            string msgP = val.valPassword(txtPasswordUp.Text);

            if (msgFN == "" && msgLN == "" && msgP == "")
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    int ano = Convert.ToInt32(cboAIDUp.Text);
                    Administrator admins = (from c in db.Administrators where c.AID == ano select c).First();

                    admins.FName = txtFNameUp.Text;
                    admins.LName = txtLNameUp.Text;
                    admins.Password = txtPasswordUp.Text;

                    db.SaveChanges();
                    MessageBox.Show("Admin Updated!");
                }

                this.updateAdmin();
            }
            else
            {
                MessageBox.Show(msgFN + "\r\n" + msgLN + "\r\n" + msgP);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                int ano = Convert.ToInt32(cboAIDUp.Text);
                Administrator admins = (from c in db.Administrators where c.AID == ano select c).First();

                db.Administrators.Remove(admins);

                db.SaveChanges();
                MessageBox.Show("Admin Deleted!");
            }

            this.updateAdmin();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboAIDUp_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                int ano = Convert.ToInt32(cboAIDUp.Text);
                Administrator admins = (from c in db.Administrators where c.AID == ano select c).First();

                txtFNameUp.Text = admins.FName;
                txtLNameUp.Text = admins.LName;
                txtPasswordUp.Text = admins.Password;
            }
        }
    }
}
