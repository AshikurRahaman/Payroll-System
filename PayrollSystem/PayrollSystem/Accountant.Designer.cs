
namespace PayrollSystem
{
    partial class Accountant
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
            this.view_salary_btn = new System.Windows.Forms.Button();
            this.generate_salary_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.account_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.account_back)).BeginInit();
            this.SuspendLayout();
            // 
            // view_salary_btn
            // 
            this.view_salary_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.view_salary_btn.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_salary_btn.Location = new System.Drawing.Point(34, 357);
            this.view_salary_btn.Name = "view_salary_btn";
            this.view_salary_btn.Size = new System.Drawing.Size(166, 45);
            this.view_salary_btn.TabIndex = 52;
            this.view_salary_btn.Text = "View Salary";
            this.view_salary_btn.UseVisualStyleBackColor = false;
            this.view_salary_btn.Click += new System.EventHandler(this.view_salary_btn_Click);
            // 
            // generate_salary_btn
            // 
            this.generate_salary_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.generate_salary_btn.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_salary_btn.Location = new System.Drawing.Point(528, 357);
            this.generate_salary_btn.Name = "generate_salary_btn";
            this.generate_salary_btn.Size = new System.Drawing.Size(230, 45);
            this.generate_salary_btn.TabIndex = 53;
            this.generate_salary_btn.Text = "Generate Salary";
            this.generate_salary_btn.UseVisualStyleBackColor = false;
            this.generate_salary_btn.Click += new System.EventHandler(this.generate_salary_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PayrollSystem.Properties.Resources.mr_Accountant_gif;
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(724, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // account_back
            // 
            this.account_back.BackColor = System.Drawing.Color.Teal;
            this.account_back.Image = global::PayrollSystem.Properties.Resources.back2_gif;
            this.account_back.Location = new System.Drawing.Point(282, 407);
            this.account_back.Name = "account_back";
            this.account_back.Size = new System.Drawing.Size(137, 50);
            this.account_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.account_back.TabIndex = 50;
            this.account_back.TabStop = false;
            this.account_back.Click += new System.EventHandler(this.account_back_Click);
            // 
            // Accountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.generate_salary_btn);
            this.Controls.Add(this.view_salary_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.account_back);
            this.Name = "Accountant";
            this.Text = "Accountant";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.account_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox account_back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button view_salary_btn;
        private System.Windows.Forms.Button generate_salary_btn;
    }
}