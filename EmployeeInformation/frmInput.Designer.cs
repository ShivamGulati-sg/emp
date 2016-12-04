namespace EmployeeInformation
{
    partial class frmInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.txtEmployeeNum = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblEmployeeNum = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeInfo = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.grpEmployeeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmployeeInfo
            // 
            this.grpEmployeeInfo.Controls.Add(this.txtHoursWorked);
            this.grpEmployeeInfo.Controls.Add(this.txtEmployeeNum);
            this.grpEmployeeInfo.Controls.Add(this.txtEmployeeName);
            this.grpEmployeeInfo.Controls.Add(this.lblHoursWorked);
            this.grpEmployeeInfo.Controls.Add(this.lblEmployeeNum);
            this.grpEmployeeInfo.Controls.Add(this.lblEmployeeName);
            this.grpEmployeeInfo.Location = new System.Drawing.Point(42, 63);
            this.grpEmployeeInfo.Name = "grpEmployeeInfo";
            this.grpEmployeeInfo.Size = new System.Drawing.Size(400, 159);
            this.grpEmployeeInfo.TabIndex = 0;
            this.grpEmployeeInfo.TabStop = false;
            this.grpEmployeeInfo.Text = "Please provide the employee\'s information";
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(169, 110);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.txtHoursWorked.TabIndex = 5;
            // 
            // txtEmployeeNum
            // 
            this.txtEmployeeNum.Location = new System.Drawing.Point(169, 70);
            this.txtEmployeeNum.Name = "txtEmployeeNum";
            this.txtEmployeeNum.Size = new System.Drawing.Size(121, 20);
            this.txtEmployeeNum.TabIndex = 4;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(169, 28);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(216, 20);
            this.txtEmployeeName.TabIndex = 3;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(27, 113);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(76, 13);
            this.lblHoursWorked.TabIndex = 2;
            this.lblHoursWorked.Text = "&Hours Worked";
            // 
            // lblEmployeeNum
            // 
            this.lblEmployeeNum.AutoSize = true;
            this.lblEmployeeNum.Location = new System.Drawing.Point(27, 73);
            this.lblEmployeeNum.Name = "lblEmployeeNum";
            this.lblEmployeeNum.Size = new System.Drawing.Size(93, 13);
            this.lblEmployeeNum.TabIndex = 1;
            this.lblEmployeeNum.Text = "Employee N&umber";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(27, 31);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(84, 13);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Employee &Name";
            // 
            // lblEmployeeInfo
            // 
            this.lblEmployeeInfo.AutoSize = true;
            this.lblEmployeeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeInfo.Location = new System.Drawing.Point(154, 23);
            this.lblEmployeeInfo.Name = "lblEmployeeInfo";
            this.lblEmployeeInfo.Size = new System.Drawing.Size(172, 18);
            this.lblEmployeeInfo.TabIndex = 1;
            this.lblEmployeeInfo.Text = "Employee Information";
            this.lblEmployeeInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(42, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(147, 247);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(257, 247);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "&Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(367, 247);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 321);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEmployeeInfo);
            this.Controls.Add(this.grpEmployeeInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Form";
            this.Load += new System.EventHandler(this.frmInput_Load);
            this.grpEmployeeInfo.ResumeLayout(false);
            this.grpEmployeeInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmployeeInfo;
        private System.Windows.Forms.Label lblEmployeeInfo;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.TextBox txtEmployeeNum;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblEmployeeNum;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

