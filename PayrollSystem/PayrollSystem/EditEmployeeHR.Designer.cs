
namespace PayrollSystem
{
    partial class EditEmployeeHR
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
            this.edit_activeCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edit_btn_continue = new System.Windows.Forms.Button();
            this.edit_gadeCombo = new System.Windows.Forms.ComboBox();
            this.edit_textBox_email = new System.Windows.Forms.TextBox();
            this.edit_textBox_address = new System.Windows.Forms.TextBox();
            this.edit_textBox_nid = new System.Windows.Forms.TextBox();
            this.edit_textBox_phone = new System.Windows.Forms.TextBox();
            this.edit_textBox_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_joinDate = new System.Windows.Forms.TextBox();
            this.employeeList = new System.Windows.Forms.DataGridView();
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
            this.loanAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMonthPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.edit_txt_box_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // edit_activeCombo
            // 
            this.edit_activeCombo.FormattingEnabled = true;
            this.edit_activeCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.edit_activeCombo.Location = new System.Drawing.Point(733, 383);
            this.edit_activeCombo.Margin = new System.Windows.Forms.Padding(2);
            this.edit_activeCombo.Name = "edit_activeCombo";
            this.edit_activeCombo.Size = new System.Drawing.Size(50, 21);
            this.edit_activeCombo.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(677, 384);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Active";
            // 
            // edit_btn_continue
            // 
            this.edit_btn_continue.BackColor = System.Drawing.Color.DarkCyan;
            this.edit_btn_continue.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn_continue.Location = new System.Drawing.Point(708, 432);
            this.edit_btn_continue.Margin = new System.Windows.Forms.Padding(2);
            this.edit_btn_continue.Name = "edit_btn_continue";
            this.edit_btn_continue.Size = new System.Drawing.Size(251, 43);
            this.edit_btn_continue.TabIndex = 38;
            this.edit_btn_continue.Text = "Edit This Employee";
            this.edit_btn_continue.UseVisualStyleBackColor = false;
            this.edit_btn_continue.Click += new System.EventHandler(this.edit_btn_continue_Click);
            // 
            // edit_gadeCombo
            // 
            this.edit_gadeCombo.FormattingEnabled = true;
            this.edit_gadeCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.edit_gadeCombo.Location = new System.Drawing.Point(909, 383);
            this.edit_gadeCombo.Margin = new System.Windows.Forms.Padding(2);
            this.edit_gadeCombo.Name = "edit_gadeCombo";
            this.edit_gadeCombo.Size = new System.Drawing.Size(51, 21);
            this.edit_gadeCombo.TabIndex = 36;
            this.edit_gadeCombo.Visible = false;
            // 
            // edit_textBox_email
            // 
            this.edit_textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_textBox_email.Location = new System.Drawing.Point(781, 290);
            this.edit_textBox_email.Margin = new System.Windows.Forms.Padding(2);
            this.edit_textBox_email.Name = "edit_textBox_email";
            this.edit_textBox_email.Size = new System.Drawing.Size(179, 23);
            this.edit_textBox_email.TabIndex = 35;
            // 
            // edit_textBox_address
            // 
            this.edit_textBox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_textBox_address.Location = new System.Drawing.Point(781, 252);
            this.edit_textBox_address.Margin = new System.Windows.Forms.Padding(2);
            this.edit_textBox_address.Name = "edit_textBox_address";
            this.edit_textBox_address.Size = new System.Drawing.Size(179, 23);
            this.edit_textBox_address.TabIndex = 34;
            // 
            // edit_textBox_nid
            // 
            this.edit_textBox_nid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_textBox_nid.Location = new System.Drawing.Point(781, 214);
            this.edit_textBox_nid.Margin = new System.Windows.Forms.Padding(2);
            this.edit_textBox_nid.Name = "edit_textBox_nid";
            this.edit_textBox_nid.Size = new System.Drawing.Size(179, 23);
            this.edit_textBox_nid.TabIndex = 33;
            // 
            // edit_textBox_phone
            // 
            this.edit_textBox_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_textBox_phone.Location = new System.Drawing.Point(781, 176);
            this.edit_textBox_phone.Margin = new System.Windows.Forms.Padding(2);
            this.edit_textBox_phone.Name = "edit_textBox_phone";
            this.edit_textBox_phone.Size = new System.Drawing.Size(179, 23);
            this.edit_textBox_phone.TabIndex = 32;
            // 
            // edit_textBox_name
            // 
            this.edit_textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_textBox_name.Location = new System.Drawing.Point(781, 136);
            this.edit_textBox_name.Margin = new System.Windows.Forms.Padding(2);
            this.edit_textBox_name.Name = "edit_textBox_name";
            this.edit_textBox_name.Size = new System.Drawing.Size(179, 23);
            this.edit_textBox_name.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(677, 294);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 19);
            this.label11.TabIndex = 30;
            this.label11.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(677, 217);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 19);
            this.label10.TabIndex = 29;
            this.label10.Text = "NID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(677, 255);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(848, 385);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Grade";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(677, 334);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Joining Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(677, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Phone No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(677, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(716, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Edit Employee ";
            // 
            // edit_joinDate
            // 
            this.edit_joinDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_joinDate.Location = new System.Drawing.Point(780, 330);
            this.edit_joinDate.Margin = new System.Windows.Forms.Padding(2);
            this.edit_joinDate.Name = "edit_joinDate";
            this.edit_joinDate.Size = new System.Drawing.Size(179, 23);
            this.edit_joinDate.TabIndex = 41;
            // 
            // employeeList
            // 
            this.employeeList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.employeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.loanAmount,
            this.perMonthPay,
            this.debt});
            this.employeeList.Location = new System.Drawing.Point(12, 90);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(647, 313);
            this.employeeList.TabIndex = 42;
            this.employeeList.DoubleClick += new System.EventHandler(this.employeeList_DoubleClick);
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
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // joinDate
            // 
            this.joinDate.HeaderText = "joinDate";
            this.joinDate.Name = "joinDate";
            // 
            // IsActive
            // 
            this.IsActive.HeaderText = "Active Status";
            this.IsActive.Name = "IsActive";
            // 
            // BasicSalary
            // 
            this.BasicSalary.HeaderText = "BasicSalary";
            this.BasicSalary.Name = "BasicSalary";
            this.BasicSalary.Visible = false;
            // 
            // HouseRent
            // 
            this.HouseRent.HeaderText = "HouseRent";
            this.HouseRent.Name = "HouseRent";
            this.HouseRent.Visible = false;
            // 
            // Medical
            // 
            this.Medical.HeaderText = "Medical";
            this.Medical.Name = "Medical";
            this.Medical.Visible = false;
            // 
            // Convenience
            // 
            this.Convenience.HeaderText = "Convenience";
            this.Convenience.Name = "Convenience";
            this.Convenience.Visible = false;
            // 
            // OtherAllowence
            // 
            this.OtherAllowence.HeaderText = "OtherAllowence";
            this.OtherAllowence.Name = "OtherAllowence";
            this.OtherAllowence.Visible = false;
            // 
            // SavedFund
            // 
            this.SavedFund.HeaderText = "SavedFund";
            this.SavedFund.Name = "SavedFund";
            this.SavedFund.Visible = false;
            // 
            // AdvanceIncomeTax
            // 
            this.AdvanceIncomeTax.HeaderText = "AdvanceIncomeTax";
            this.AdvanceIncomeTax.Name = "AdvanceIncomeTax";
            this.AdvanceIncomeTax.Visible = false;
            // 
            // ProvidendFund
            // 
            this.ProvidendFund.HeaderText = "ProvidendFund";
            this.ProvidendFund.Name = "ProvidendFund";
            this.ProvidendFund.Visible = false;
            // 
            // PrivateUseVehicle
            // 
            this.PrivateUseVehicle.HeaderText = "PrivateUseVehicle";
            this.PrivateUseVehicle.Name = "PrivateUseVehicle";
            this.PrivateUseVehicle.Visible = false;
            // 
            // hasLoan
            // 
            this.hasLoan.HeaderText = "hasLoan";
            this.hasLoan.Name = "hasLoan";
            this.hasLoan.Visible = false;
            // 
            // loanAmount
            // 
            this.loanAmount.HeaderText = "loanAmount";
            this.loanAmount.Name = "loanAmount";
            this.loanAmount.Visible = false;
            // 
            // perMonthPay
            // 
            this.perMonthPay.HeaderText = "perMonthPay";
            this.perMonthPay.Name = "perMonthPay";
            this.perMonthPay.Visible = false;
            // 
            // debt
            // 
            this.debt.HeaderText = "debt";
            this.debt.Name = "debt";
            this.debt.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(226, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 25);
            this.label8.TabIndex = 43;
            this.label8.Text = "All Employees ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Image = global::PayrollSystem.Properties.Resources.back2_gif;
            this.pictureBox1.Location = new System.Drawing.Point(12, 425);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(677, 105);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 19);
            this.label9.TabIndex = 45;
            this.label9.Text = "Id :";
            // 
            // edit_txt_box_id
            // 
            this.edit_txt_box_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_txt_box_id.Location = new System.Drawing.Point(780, 101);
            this.edit_txt_box_id.Margin = new System.Windows.Forms.Padding(2);
            this.edit_txt_box_id.Name = "edit_txt_box_id";
            this.edit_txt_box_id.Size = new System.Drawing.Size(179, 23);
            this.edit_txt_box_id.TabIndex = 46;
            // 
            // EditEmployeeHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(992, 504);
            this.Controls.Add(this.edit_txt_box_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.employeeList);
            this.Controls.Add(this.edit_joinDate);
            this.Controls.Add(this.edit_activeCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edit_btn_continue);
            this.Controls.Add(this.edit_gadeCombo);
            this.Controls.Add(this.edit_textBox_email);
            this.Controls.Add(this.edit_textBox_address);
            this.Controls.Add(this.edit_textBox_nid);
            this.Controls.Add(this.edit_textBox_phone);
            this.Controls.Add(this.edit_textBox_name);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            //this.Name = "EditEmployeeHR";
            this.Text = "EditEmployeeHR";
            this.Load += new System.EventHandler(this.EditEmployeeHR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox edit_activeCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button edit_btn_continue;
        private System.Windows.Forms.ComboBox edit_gadeCombo;
        private System.Windows.Forms.TextBox edit_textBox_email;
        private System.Windows.Forms.TextBox edit_textBox_address;
        private System.Windows.Forms.TextBox edit_textBox_nid;
        private System.Windows.Forms.TextBox edit_textBox_phone;
        private System.Windows.Forms.TextBox edit_textBox_name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edit_joinDate;
        private System.Windows.Forms.DataGridView employeeList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edit_txt_box_id;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn loanAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMonthPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn debt;
    }
}