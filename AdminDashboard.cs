using PharmacyManagementSystem.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class AdminDashboard : UserControl
    {
        public AdminDashboard()
        {
            InitializeComponent();         
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            ViewUserUserControl viewUserUserControl = new ViewUserUserControl();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(viewUserUserControl);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            EditUserUserControl patientsListUC = new EditUserUserControl();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(patientsListUC);
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser adduser=new AddUser();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(adduser);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
