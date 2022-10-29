namespace PayrollSystem
{
    partial class FinalViewACC
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
            this.view_year_combobox = new System.Windows.Forms.ComboBox();
            this.view_month_combobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Search_btn = new System.Windows.Forms.Button();
            this.salary_gridview = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasicSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Convenience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherAllowence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SavedFund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdvIncTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvidendFund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrivateUseVahicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerMonthPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBy_combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.viewSalarY_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.salary_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSalarY_back)).BeginInit();
            this.SuspendLayout();
            // 
            // view_year_combobox
            // 
            this.view_year_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_year_combobox.FormattingEnabled = true;
            this.view_year_combobox.Location = new System.Drawing.Point(702, 26);
            this.view_year_combobox.Name = "view_year_combobox";
            this.view_year_combobox.Size = new System.Drawing.Size(129, 26);
            this.view_year_combobox.TabIndex = 10;
            // 
            // view_month_combobox
            // 
            this.view_month_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_month_combobox.FormattingEnabled = true;
            this.view_month_combobox.Location = new System.Drawing.Point(520, 26);
            this.view_month_combobox.Name = "view_month_combobox";
            this.view_month_combobox.Size = new System.Drawing.Size(129, 26);
            this.view_month_combobox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(649, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Year :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Month :";
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.Search_btn.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.Location = new System.Drawing.Point(842, 16);
            this.Search_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(155, 43);
            this.Search_btn.TabIndex = 6;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // salary_gridview
            // 
            this.salary_gridview.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.salary_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salary_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Name,
            this.Grade,
            this.Email,
            this.BasicSalary,
            this.HouseRent,
            this.Medical,
            this.Convenience,
            this.OtherAllowence,
            this.SavedFund,
            this.AdvIncTax,
            this.ProvidendFund,
            this.PrivateUseVahicle,
            this.hasLoan,
            this.LoanAmount,
            this.PerMonthPay,
            this.Debt,
            this.Bonus,
            this.TotalSalary});
            this.salary_gridview.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.salary_gridview.Location = new System.Drawing.Point(17, 81);
            this.salary_gridview.Name = "salary_gridview";
            this.salary_gridview.Size = new System.Drawing.Size(980, 296);
            this.salary_gridview.TabIndex = 11;
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
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // BasicSalary
            // 
            this.BasicSalary.HeaderText = "Basic Salary";
            this.BasicSalary.Name = "BasicSalary";
            // 
            // HouseRent
            // 
            this.HouseRent.HeaderText = "House Rent";
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
            this.SavedFund.HeaderText = "Saved Fund";
            this.SavedFund.Name = "SavedFund";
            // 
            // AdvIncTax
            // 
            this.AdvIncTax.HeaderText = "Adv Inc Tax";
            this.AdvIncTax.Name = "AdvIncTax";
            // 
            // ProvidendFund
            // 
            this.ProvidendFund.HeaderText = "Providend Fund";
            this.ProvidendFund.Name = "ProvidendFund";
            // 
            // PrivateUseVahicle
            // 
            this.PrivateUseVahicle.HeaderText = "Private Use Vahicle";
            this.PrivateUseVahicle.Name = "PrivateUseVahicle";
            // 
            // hasLoan
            // 
            this.hasLoan.HeaderText = "Has Loan";
            this.hasLoan.Name = "hasLoan";
            // 
            // LoanAmount
            // 
            this.LoanAmount.HeaderText = "Loan Amount";
            this.LoanAmount.Name = "LoanAmount";
            // 
            // PerMonthPay
            // 
            this.PerMonthPay.HeaderText = "Per Month Pay";
            this.PerMonthPay.Name = "PerMonthPay";
            // 
            // Debt
            // 
            this.Debt.HeaderText = "Debt";
            this.Debt.Name = "Debt";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Search By :";
            this.label3.Visible = false;
            // 
            // searchBy_combo
            // 
            this.searchBy_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBy_combo.FormattingEnabled = true;
            this.searchBy_combo.Location = new System.Drawing.Point(123, 29);
            this.searchBy_combo.Name = "searchBy_combo";
            this.searchBy_combo.Size = new System.Drawing.Size(129, 26);
            this.searchBy_combo.TabIndex = 13;
            this.searchBy_combo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name :";
            this.label4.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Visible = false;
            this.textBox1.WordWrap = false;
            // 
            // viewSalarY_back
            // 
            this.viewSalarY_back.BackColor = System.Drawing.Color.Teal;
            this.viewSalarY_back.Image = global::PayrollSystem.Properties.Resources.back2_gif;
            this.viewSalarY_back.Location = new System.Drawing.Point(12, 407);
            this.viewSalarY_back.Name = "viewSalarY_back";
            this.viewSalarY_back.Size = new System.Drawing.Size(137, 50);
            this.viewSalarY_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewSalarY_back.TabIndex = 46;
            this.viewSalarY_back.TabStop = false;
            this.viewSalarY_back.Click += new System.EventHandler(this.viewSalarY_back_Click);
            // 
            // FinalViewACC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1040, 469);
            this.Controls.Add(this.viewSalarY_back);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchBy_combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salary_gridview);
            this.Controls.Add(this.view_year_combobox);
            this.Controls.Add(this.view_month_combobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            //this.Name = "FinalViewACC";
            this.Text = "FinalViewACC";
            this.Load += new System.EventHandler(this.FinalViewACC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salary_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSalarY_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox view_year_combobox;
        private System.Windows.Forms.ComboBox view_month_combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.DataGridView salary_gridview;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox searchBy_combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasicSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medical;
        private System.Windows.Forms.DataGridViewTextBoxColumn Convenience;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherAllowence;
        private System.Windows.Forms.DataGridViewTextBoxColumn SavedFund;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdvIncTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvidendFund;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrivateUseVahicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerMonthPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSalary;
        private System.Windows.Forms.PictureBox viewSalarY_back;
    }
}