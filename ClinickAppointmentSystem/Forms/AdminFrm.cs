using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinickAppointmentSystem.Forms
{
    public partial class AdminFrm : Form
    {
        public AdminFrm()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //adminDashboardUCFrm1.BringToFront();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            //manageUserUCFrm1.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
