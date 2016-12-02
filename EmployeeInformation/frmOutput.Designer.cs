namespace EmployeeInformation
{
    partial class frmOutput
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
            this.lblEmployeeInfo = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeNum = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblWeeklyPay = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeNum = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.txtWeeklyPay = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmployeeInfo
            // 
            this.lblEmployeeInfo.AutoSize = true;
            this.lblEmployeeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeInfo.Location = new System.Drawing.Point(154, 23);
            this.lblEmployeeInfo.Name = "lblEmployeeInfo";
            this.lblEmployeeInfo.Size = new System.Drawing.Size(172, 18);
            this.lblEmployeeInfo.TabIndex = 0;
            this.lblEmployeeInfo.Text = "Employee Information";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(88, 70);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(84, 13);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // lblEmployeeNum
            // 
            this.lblEmployeeNum.AutoSize = true;
            this.lblEmployeeNum.Location = new System.Drawing.Point(88, 118);
            this.lblEmployeeNum.Name = "lblEmployeeNum";
            this.lblEmployeeNum.Size = new System.Drawing.Size(93, 13);
            this.lblEmployeeNum.TabIndex = 2;
            this.lblEmployeeNum.Text = "Employee Number";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(88, 166);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(76, 13);
            this.lblHoursWorked.TabIndex = 3;
            this.lblHoursWorked.Text = "Hours Worked";
            // 
            // lblWeeklyPay
            // 
            this.lblWeeklyPay.AutoSize = true;
            this.lblWeeklyPay.Location = new System.Drawing.Point(88, 214);
            this.lblWeeklyPay.Name = "lblWeeklyPay";
            this.lblWeeklyPay.Size = new System.Drawing.Size(64, 13);
            this.lblWeeklyPay.TabIndex = 4;
            this.lblWeeklyPay.Text = "Weekly Pay";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(217, 67);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(184, 20);
            this.txtEmployeeName.TabIndex = 5;
            // 
            // txtEmployeeNum
            // 
            this.txtEmployeeNum.Location = new System.Drawing.Point(217, 115);
            this.txtEmployeeNum.Name = "txtEmployeeNum";
            this.txtEmployeeNum.Size = new System.Drawing.Size(109, 20);
            this.txtEmployeeNum.TabIndex = 6;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(217, 163);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(79, 20);
            this.txtHoursWorked.TabIndex = 7;
            // 
            // txtWeeklyPay
            // 
            this.txtWeeklyPay.Location = new System.Drawing.Point(217, 211);
            this.txtWeeklyPay.Name = "txtWeeklyPay";
            this.txtWeeklyPay.Size = new System.Drawing.Size(79, 20);
            this.txtWeeklyPay.TabIndex = 8;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(136, 261);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(279, 261);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Location = new System.Drawing.Point(324, 166);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(77, 13);
            this.lblPayRate.TabIndex = 11;
            this.lblPayRate.Text = "@$10.50/hour";
            // 
            // frmOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 321);
            this.Controls.Add(this.lblPayRate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtWeeklyPay);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.txtEmployeeNum);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblWeeklyPay);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblEmployeeNum);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblEmployeeInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOutput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Output Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeInfo;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeNum;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblWeeklyPay;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeNum;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.TextBox txtWeeklyPay;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPayRate;
    }
}