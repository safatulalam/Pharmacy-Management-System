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
    public partial class PharmacistDashboard : UserControl
    {
        internal PharmacistsClass phc;
        internal PharmacistDashboard(PharmacistsClass phc)
        {

            InitializeComponent();
            this.phc = phc;
            this.lblPhamacistsName.Text = this.phc.PharmacistsFirstName;
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            AddMedicineUserControl addMed = new AddMedicineUserControl();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(addMed);
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            ViewMedicineUserControl viewMed = new ViewMedicineUserControl();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(viewMed);
        }

        private void btnUpdateMedicine_Click(object sender, EventArgs e)
        {
            UpdateMedicineUserControl updateMed= new UpdateMedicineUserControl(); 
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(updateMed);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.Show();
        }
    }
}
