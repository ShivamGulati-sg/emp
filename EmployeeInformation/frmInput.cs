using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformation
{
   
    public partial class frmInput : Form
    { 
        private Employee employee = null;

        private StreamReader empployeeStreamReader;
        private StreamWriter employeeStreamWrite;
        private bool isDirty;

        public frmInput()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close form
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear text fields
            txtEmployeeName.Clear();
            txtEmployeeNum.Clear();
            txtHoursWorked.Clear();

            //Focus back to employee name text field
            txtEmployeeName.Focus();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            frmOutput newOutputForm = new frmOutput();
            newOutputForm.Show();

            this.Hide();
        }

        private void frmInput_Load(object sender, EventArgs e)
        {
            //show a open file dialog prompts the user to select the file 
            DialogResult response;
            saveFileDialog1.ShowDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.FileName = "Employee Information";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.Filter = "Text Files(*.txt)|.*txt|All files(*.*)|*.*";


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //save the file data
            if (IsValidData())
            {
                employee = new EmployeeInformation.Employee(txtEmployeeName.Text,
                    Convert.ToInt16(txtEmployeeNum.Text), Convert.ToDecimal(txtHoursWorked.Text));
                this.Close();
            }
            //setting the properties of show file dialog box 
            


        }

            private bool IsValidData()
        {
            return Validator.IsPresent(txtEmployeeName) &&
                Validator.IsPresent(txtEmployeeNum) &&
                Validator.IsPresent(txtHoursWorked) &&
                Validator.IsInteger(txtEmployeeNum) &&
                Validator.IsWithinRange(txtHoursWorked, 0, 40);
        }

        }
    }

