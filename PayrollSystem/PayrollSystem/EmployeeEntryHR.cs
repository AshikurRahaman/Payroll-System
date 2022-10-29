using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class EmployeeEntryHR : Form
    {
        Employee em;

        public EmployeeEntryHR()
        {
            InitializeComponent();
        }

        private async void btn_continue_Click(object sender, EventArgs e)
        {
            /*EmployeeEntryContinued f = new EmployeeEntryContinued();
            f.Show();
            this.Hide();*/

            var confirmResult = MessageBox.Show("Add This Employee ??",
                                     "!!Confirmation!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                
                em = new Employee();

                string name = textBox_name.Text;
                string phone = textBox_phone.Text;
                string nid = textBox_nid.Text;
                string address = textBox_address.Text;
                string mail = textBox_email.Text;
                string date = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                string isActice = activeCombo.Text;
                string grade = gadeCombo.Text;
                //MessageBox.Show(date+"  "+isActice+"  "+grade);
                em.name = name;
                em.phn = phone;
                em.nid = nid;
                em.address = address;
                em.email = mail;
                em.joindate = date;
                em.IsActive = isActice;
                em.grade = grade;

                string basicSalary = lb_salary.Text;

                em.basicSalary = basicSalary;
                em.houseRent = lb_rent.Text;
                em.medical = lb_medical.Text;
                em.convenience = lb_convenience.Text;
                em.otherAllowence = lb_others.Text;
                em.savedFund = lb_saved_fund.Text;
                em.advanceIncomeTax = lb_tax.Text;
                em.providendFund = lb_fund.Text;
                em.privateUseofVehicle = lb_vehicle.Text;

                em.hasLoan = "No";
                em.loanAmount = "0";
                em.loanPerMonthPay = "0";
                em.debt = "0";

                /// mail a validation add kora abe

                if (name.Length > 0 && phone.Length > 0 && nid.Length > 0 && address.Length > 0 && mail.Length > 0 && basicSalary.Length > 0)
                {

                    try
                    {
                        IFirebaseConfig config = new FirebaseConfig()
                        {
                            AuthSecret = "M0sYEthHoMtU0QkuB9grGbyYUhJeOQP11hl9Px8t",
                            BasePath = "https://payrollpoject-default-rtdb.firebaseio.com/"
                        };

                        IFirebaseClient client = new FirebaseClient(config);

                        PushResponse msssage = await client.PushAsync("Employee/Info", em);
                        if (msssage.Body != null)
                        {
                            MessageBox.Show("Inserted Successfully");

                            textBox_address.Text = "";
                            textBox_email.Text = "";
                            textBox_name.Text = "";
                            textBox_nid.Text = "";
                            textBox_phone.Text = "";

                            loan_lbl.Hide();
                            basicSalay_lbl.Hide();
                            houseRent_lbl.Hide();
                            Medical_lbl.Hide();
                            convenience_lbl.Hide();
                            other_allowence_lbl.Hide();
                            saved_fund_lbl.Hide();
                            divider_btn.Hide();
                            advance_incomeTax_lbl.Hide();
                            provident_fund_lbl.Hide();
                            private_use_vechicle_lbl.Hide();
                            btn_continue.Hide();

                            lb_hasLoan.Hide();
                            lb_salary.Hide();
                            lb_rent.Hide();
                            lb_medical.Hide();
                            lb_convenience.Hide();
                            lb_others.Hide();
                            lb_saved_fund.Hide();
                            lb_tax.Hide();
                            lb_fund.Hide();
                            lb_vehicle.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Failed");
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Give All Infos of an Employee");

                }
            }
            else
            {
                // If 'No', do something here.
                
                textBox_address.Text = "";
                textBox_email.Text = "";
                textBox_name.Text = "";
                textBox_nid.Text = "";
                textBox_phone.Text = "";

                loan_lbl.Hide();
                basicSalay_lbl.Hide();
                houseRent_lbl.Hide();
                Medical_lbl.Hide();
                convenience_lbl.Hide();
                other_allowence_lbl.Hide();
                saved_fund_lbl.Hide();
                divider_btn.Hide();
                advance_incomeTax_lbl.Hide();
                provident_fund_lbl.Hide();
                private_use_vechicle_lbl.Hide();
                btn_continue.Hide();

                lb_hasLoan.Hide();
                lb_salary.Hide();
                lb_rent.Hide();
                lb_medical.Hide();
                lb_convenience.Hide();
                lb_others.Hide();
                lb_saved_fund.Hide();
                lb_tax.Hide();
                lb_fund.Hide();
                lb_vehicle.Hide();
            }

            
            
        }

        private void EmployeeEntryHR_Load(object sender, EventArgs e)
        {
            lb_salary.Hide();
            lb_rent.Hide();
            lb_medical.Hide();
            lb_convenience.Hide();
            lb_others.Hide();
            lb_saved_fund.Hide();
            lb_tax.Hide();
            lb_fund.Hide();
            lb_vehicle.Hide();
            lb_hasLoan.Hide();

            activeCombo.Items.Clear();
            activeCombo.Items.Add("Yes");
            activeCombo.Items.Add("No");
            activeCombo.Text = "Yes";

            gadeCombo.Text = "1";
        }

        private void pictureBox_5_Click(object sender, EventArgs e)
        {
            HR f = new HR();
            f.Show();
            this.Hide();
        }

        private void rightArrow_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string phone = textBox_phone.Text;
            string nid = textBox_nid.Text;
            string address = textBox_address.Text;
            string mail = textBox_email.Text;
            string date = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string isActice = activeCombo.Text;
            string grade = gadeCombo.Text;

            if (name.Length > 0 && phone.Length > 0 && nid.Length > 0 && address.Length > 0 && mail.Length > 0)
            {
                generateSalary();
                show();
            }
            else
            {
                MessageBox.Show("Give All Infos of an Employee");

            }


        }

        private void show()
        {
            loan_lbl.Show();
            basicSalay_lbl.Show();
            houseRent_lbl.Show();
            Medical_lbl.Show();
            convenience_lbl.Show();
            other_allowence_lbl.Show();
            saved_fund_lbl.Show();
            divider_btn.Show();
            advance_incomeTax_lbl.Show();
            provident_fund_lbl.Show();
            private_use_vechicle_lbl.Show();
            btn_continue.Show();

            lb_hasLoan.Show();
            lb_salary.Show();
            lb_rent.Show();
            lb_medical.Show();
            lb_convenience.Show();
            lb_others.Show();
            lb_saved_fund.Show();
            lb_tax.Show();
            lb_fund.Show();
            lb_vehicle.Show();
        }

        public int Generate(int basicS, int percent)
        {
            
            int x = percent * basicS;
            
            x = x / 100;
            

            return x;
        }

        private void generateSalary()
        {
            string grade = gadeCombo.Text.ToString() ;

            int myGrade = int.Parse(grade);

            int basicSalary = 0;
            int convenience = 0;
            int advanceincomeTax = 0;
            //int houseRent = 0;
            int medical = 0;
            int otherAllow = 0;
            int providentFund = 0;
            int savedFund = 0;
            int privateVechileUse = 0;

            


            if (grade == "5")
            {
                basicSalary = 50000;
                convenience = 0;
                advanceincomeTax = Generate(basicSalary, 2);

            }else if(grade == "4")
            {
                basicSalary = 40000;
                convenience = 0;
                advanceincomeTax = Generate(basicSalary, 2);
            }
            else if (grade == "3")
            {
                basicSalary = 30000;
                convenience = 0;
                advanceincomeTax = Generate(basicSalary, 2);
            }
            else if (grade == "2")
            {
                basicSalary = 25000;
                convenience = 5000;
                advanceincomeTax = Generate(basicSalary, 1);
            }
            else if (grade == "1")
            {
                basicSalary = 20000;
                convenience = 5000;
                advanceincomeTax = Generate(basicSalary, 1);
            }

            int houseRent = Generate(basicSalary, 50);
            //MessageBox.Show(houseRent+"");

            medical = 3000;
            otherAllow = Generate(basicSalary, 10);
            providentFund = Generate(basicSalary, 25);
            savedFund = 0;
            privateVechileUse = Generate(basicSalary, 7);

            lb_salary.Text = basicSalary + "";
            lb_rent.Text = houseRent + "";
            lb_medical.Text = medical + "";
            lb_convenience.Text = convenience + "";
            lb_others.Text = otherAllow + "";
            lb_saved_fund.Text = savedFund + "";
            lb_tax.Text = advanceincomeTax + "";
            lb_fund.Text = providentFund + "";
            lb_vehicle.Text = privateVechileUse + "";
            lb_hasLoan.Text = "No";
        }

        private void gadeCombo_TextChanged(object sender, EventArgs e)
        {
            generateSalary();
        }
    }
}
