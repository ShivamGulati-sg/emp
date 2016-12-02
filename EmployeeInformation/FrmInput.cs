using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformation
{
    public partial class frmInput : Form
    {
        public frmInput()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Close form
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Clear text fields
            txtEmployeeName.Clear();
            txtEmployeeNum.Clear();
            txtHoursWorked.Clear();

            //Focus back to employee name text field
            txtEmployeeName.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmOutput newOutputForm = new frmOutput();
            newOutputForm.Show();

            this.Hide();
        }
    }
}
