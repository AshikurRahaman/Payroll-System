using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class Accountant : Form
    {
        public Accountant()
        {
            InitializeComponent();
        }

        private void account_back_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Hide();
        }

        private void generate_salary_btn_Click(object sender, EventArgs e)
        {
            GenerateSalaryACC f1 = new GenerateSalaryACC();
            f1.Show();
            this.Hide();
        }

        private void view_salary_btn_Click(object sender, EventArgs e)
        {
            FinalViewACC f = new FinalViewACC();
            f.Show();
            this.Hide();
        }

        
    }
}
