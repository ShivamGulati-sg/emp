using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformation
{
  
        public static class Validator
        {
            private static string title = "Entry Error";

            public static string Title { get; set; }

            //this method checks if a text box is empty
            public static Boolean IsPresent(TextBox textBox)
            {
                if (textBox.Text == String.Empty)
                {
                    MessageBox.Show(textBox.Tag + " is a required field",
                        Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }

            public static Boolean IsInteger(TextBox textBox)
            {
                int number = 0;
                if (int.TryParse(textBox.Text, out number))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(textBox.Tag + " must be a INTEGER value", Title,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.SelectAll();
                    textBox.Focus();
                    return false;
                }
            }//IsDecimal

            public static Boolean IsWithinRange(TextBox textBox, decimal min, decimal max)
            {
                decimal number = Convert.ToDecimal(textBox.Text);
                if (number < min || number > max)
                {
                    MessageBox.Show(textBox.Tag + " must be between " + min + " and " + max,
                        Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.SelectAll();
                    textBox.Focus();

                    return false;

                }
                return true;
            }


        }
    }

}
}
