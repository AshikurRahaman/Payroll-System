namespace PayrollSystem
{
    partial class GenerateSalaryACC
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
            this.btn_generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.month_combobox = new System.Windows.Forms.ComboBox();
            this.year_combobox = new System.Windows.Forms.ComboBox();
            this.EemployeeList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasicSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Convenience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherAllowence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SavedFund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdvanceIncomeTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvidendFund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrivateUseVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMonthPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveSalary_btn = new System.Windows.Forms.Button();
            this.addBonus_btn = new System.Windows.Forms.Button();
            this.generateSalary_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EemployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateSalary_back)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_generate
            // 
            this.btn_generate.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_generate.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.Location = new System.Drawing.Point(500, 29);
            this.btn_generate.Margin = new System.Windows.Forms.Padding(2);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(171, 43);
            this.btn_generate.TabIndex = 1;
            this.btn_generate.Text = "Generate Salary";
            this.btn_generate.UseVisualStyleBackColor = false;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Month :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Year :";
            // 
            // month_combobox
            // 
            this.month_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_combobox.FormattingEnabled = true;
            this.month_combobox.Location = new System.Drawing.Point(83, 39);
            this.month_combobox.Name = "month_combobox";
            this.month_combobox.Size = new System.Drawing.Size(129, 26);
            this.month_combobox.TabIndex = 4;
            // 
            // year_combobox
            // 
            this.year_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_combobox.FormattingEnabled = true;
            this.year_combobox.Location = new System.Drawing.Point(310, 39);
            this.year_combobox.Name = "year_combobox";
            this.year_combobox.Size = new System.Drawing.Size(129, 26);
            this.year_combobox.TabIndex = 5;
            // 
            // EemployeeList
            // 
            this.EemployeeList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.EemployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EemployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Name,
            this.Grade,
            this.Phn,
            this.Email,
            this.Nid,
            this.Address,
            this.joinDate,
            this.IsActive,
            this.BasicSalary,
            this.HouseRent,
            this.Medical,
            this.Convenience,
            this.OtherAllowence,
            this.SavedFund,
            this.AdvanceIncomeTax,
            this.ProvidendFund,
            this.PrivateUseVehicle,
            this.hasLoan,
            this.LoanAmount,
            this.perMonthPay,
            this.debt,
            this.Bonus,
            this.TotalSalary});
            this.EemployeeList.Location = new System.Drawing.Point(16, 89);
            this.EemployeeList.Name = "EemployeeList";
            this.EemployeeList.Size = new System.Drawing.Size(638, 334);
            this.EemployeeList.TabIndex = 51;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            // 
            // Phn
            // 
            this.Phn.HeaderText = "Phn No";
            this.Phn.Name = "Phn";
            this.Phn.Visible = false;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Nid
            // 
            this.Nid.HeaderText = "Nid";
            this.Nid.Name = "Nid";
            this.Nid.Visible = false;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.Visible = false;
            // 
            // joinDate
            // 
            this.joinDate.HeaderText = "joinDate";
            this.joinDate.Name = "joinDate";
            this.joinDate.Visible = false;
            // 
            // IsActive
            // 
            this.IsActive.HeaderText = "Active Status";
            this.IsActive.Name = "IsActive";
            this.IsActive.Visible = false;
            // 
            // BasicSalary
            // 
            this.BasicSalary.HeaderText = "BasicSalary";
            this.BasicSalary.Name = "BasicSalary";
            // 
            // HouseRent
            // 
            this.HouseRent.HeaderText = "HouseRent";
            this.HouseRent.Name = "HouseRent";
            // 
            // Medical
            // 
            this.Medical.HeaderText = "Medical";
            this.Medical.Name = "Medical";
            // 
            // Convenience
            // 
            this.Convenience.HeaderText = "Convenience";
            this.Convenience.Name = "Convenience";
            // 
            // OtherAllowence
            // 
            this.OtherAllowence.HeaderText = "OtherAllowence";
            this.OtherAllowence.Name = "OtherAllowence";
            // 
            // SavedFund
            // 
            this.SavedFund.HeaderText = "SavedFund";
            this.SavedFund.Name = "SavedFund";
            // 
            // AdvanceIncomeTax
            // 
            this.AdvanceIncomeTax.HeaderText = "AdvanceIncomeTax";
            this.AdvanceIncomeTax.Name = "AdvanceIncomeTax";
            // 
            // ProvidendFund
            // 
            this.ProvidendFund.HeaderText = "ProvidendFund";
            this.ProvidendFund.Name = "ProvidendFund";
            // 
            // PrivateUseVehicle
            // 
            this.PrivateUseVehicle.HeaderText = "PrivateUseVehicle";
            this.PrivateUseVehicle.Name = "PrivateUseVehicle";
            // 
            // hasLoan
            // 
            this.hasLoan.HeaderText = "hasLoan";
            this.hasLoan.Name = "hasLoan";
            // 
            // LoanAmount
            // 
            this.LoanAmount.HeaderText = "LoanAmount";
            this.LoanAmount.Name = "LoanAmount";
            // 
            // perMonthPay
            // 
            this.perMonthPay.HeaderText = "perMonthPay";
            this.perMonthPay.Name = "perMonthPay";
            // 
            // debt
            // 
            this.debt.HeaderText = "debt";
            this.debt.Name = "debt";
            // 
            // Bonus
            // 
            this.Bonus.HeaderText = "Bonus";
            this.Bonus.Name = "Bonus";
            // 
            // TotalSalary
            // 
            this.TotalSalary.HeaderText = "Total Salary";
            this.TotalSalary.Name = "TotalSalary";
            // 
            // SaveSalary_btn
            // 
            this.SaveSalary_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.SaveSalary_btn.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSalary_btn.Location = new System.Drawing.Point(387, 441);
            this.SaveSalary_btn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveSalary_btn.Name = "SaveSalary_btn";
            this.SaveSalary_btn.Size = new System.Drawing.Size(267, 43);
            this.SaveSalary_btn.TabIndex = 52;
            this.SaveSalary_btn.Text = "Save Salary and Send Mail";
            this.SaveSalary_btn.UseVisualStyleBackColor = false;
            this.SaveSalary_btn.Click += new System.EventHandler(this.SaveSalary_btn_Click);
            // 
            // addBonus_btn
            // 
            this.addBonus_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.addBonus_btn.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBonus_btn.Location = new System.Drawing.Point(189, 441);
            this.addBonus_btn.Margin = new System.Windows.Forms.Padding(2);
            this.addBonus_btn.Name = "addBonus_btn";
            this.addBonus_btn.Size = new System.Drawing.Size(155, 43);
            this.addBonus_btn.TabIndex = 53;
            this.addBonus_btn.Text = "Add Bonus";
            this.addBonus_btn.UseVisualStyleBackColor = false;
            this.addBonus_btn.Click += new System.EventHandler(this.addBonus_btn_Click);
            // 
            // generateSalary_back
            // 
            this.generateSalary_back.BackColor = System.Drawing.Color.Teal;
            this.generateSalary_back.Image = global::PayrollSystem.Properties.Resources.back2_gif;
            this.generateSalary_back.Location = new System.Drawing.Point(16, 441);
            this.generateSalary_back.Name = "generateSalary_back";
            this.generateSalary_back.Size = new System.Drawing.Size(137, 50);
            this.generateSalary_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.generateSalary_back.TabIndex = 54;
            this.generateSalary_back.TabStop = false;
            this.generateSalary_back.Click += new System.EventHandler(this.generateSalary_back_Click);
            // 
            // GenerateSalaryACC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(682, 495);
            this.Controls.Add(this.generateSalary_back);
            this.Controls.Add(this.addBonus_btn);
            this.Controls.Add(this.SaveSalary_btn);
            this.Controls.Add(this.EemployeeList);
            this.Controls.Add(this.year_combobox);
            this.Controls.Add(this.month_combobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_generate);
            this.Margin = new System.Windows.Forms.Padding(2);
            //this.Name = "GenerateSalaryACC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Salary";
            this.Load += new System.EventHandler(this.GenerateSalaryACC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EemployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateSalary_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox month_combobox;
        private System.Windows.Forms.ComboBox year_combobox;
        private System.Windows.Forms.DataGridView EemployeeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasicSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medical;
        private System.Windows.Forms.DataGridViewTextBoxColumn Convenience;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherAllowence;
        private System.Windows.Forms.DataGridViewTextBoxColumn SavedFund;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdvanceIncomeTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvidendFund;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrivateUseVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMonthPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn debt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSalary;
        private System.Windows.Forms.Button SaveSalary_btn;
        private System.Windows.Forms.Button addBonus_btn;
        private System.Windows.Forms.PictureBox generateSalary_back;
    }
}