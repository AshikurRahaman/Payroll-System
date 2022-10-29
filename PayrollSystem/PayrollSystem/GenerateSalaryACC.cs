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
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class GenerateSalaryACC : Form
    {
        public GenerateSalaryACC()
        {
            InitializeComponent();
        }

        private void GenerateSalaryACC_Load(object sender, EventArgs e)
        {
            addBonus_btn.Hide();
            SaveSalary_btn.Hide();

            month_combobox.Items.Clear();
            month_combobox.Items.Add("January");
            month_combobox.Items.Add("February");
            month_combobox.Items.Add("March");
            month_combobox.Items.Add("April");
            month_combobox.Items.Add("May");
            month_combobox.Items.Add("June");
            month_combobox.Items.Add("July");
            month_combobox.Items.Add("August");
            month_combobox.Items.Add("September");
            month_combobox.Items.Add("October");
            month_combobox.Items.Add("November");
            month_combobox.Items.Add("December");
            month_combobox.Text = "January";


            year_combobox.Items.Clear();
            for(int i=2020; i<=2050; i++)
            {
                year_combobox.Items.Add(i+"");
            }
            year_combobox.Text = "2021";


        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            

            string month = month_combobox.Text;
            string year = year_combobox.Text;

            salaryEligibleEmployees();
            addBonus_btn.Show();
            SaveSalary_btn.Show();
        }

        private async void salaryEligibleEmployees()
        {
            try
            {
                IFirebaseConfig config = new FirebaseConfig()
                {
                    AuthSecret = "M0sYEthHoMtU0QkuB9grGbyYUhJeOQP11hl9Px8t",
                    BasePath = "https://payrollpoject-default-rtdb.firebaseio.com/"
                };

                IFirebaseClient client = new FirebaseClient(config);

                var data = await client.GetAsync("Employee/Info");


                Dictionary<string, Employee> employees = data.ResultAs<Dictionary<string, Employee>>();

                if (employees != null)
                {
                    EemployeeList.Rows.Clear();

                    foreach (var employee in employees)
                    {
                        if (employee.Value.IsActive == "Yes")
                        {
                            int totalSalary = CalculateTotalSalary(employee.Value.basicSalary, employee.Value.houseRent, employee.Value.medical, employee.Value.convenience,
                             employee.Value.otherAllowence, employee.Value.savedFund, employee.Value.advanceIncomeTax,
                             employee.Value.providendFund, employee.Value.privateUseofVehicle, employee.Value.loanPerMonthPay);


                            if (employee.Value.hasLoan == "Yes")
                            {
                                int debt = int.Parse(employee.Value.debt) - int.Parse(employee.Value.loanPerMonthPay);

                                int perMonthPay = int.Parse(employee.Value.loanPerMonthPay);

                                if (debt<perMonthPay) {
                                    employee.Value.hasLoan = "No";
                                    debt = 0;
                                    employee.Value.loanPerMonthPay = "0";
                                    employee.Value.loanAmount = "0";
                                }
                                employee.Value.debt = debt + "";
                            }

                            int savedFund = int.Parse(employee.Value.savedFund) + int.Parse(employee.Value.providendFund);
                            employee.Value.savedFund = savedFund + "";

                            string bonus = "0";

                            EemployeeList.Rows.Add(employee.Key, employee.Value.name, employee.Value.grade, employee.Value.phn,
                             employee.Value.email, employee.Value.nid, employee.Value.address, employee.Value.joindate, employee.Value.IsActive,
                             employee.Value.basicSalary, employee.Value.houseRent, employee.Value.medical, employee.Value.convenience,
                             employee.Value.otherAllowence, employee.Value.savedFund, employee.Value.advanceIncomeTax,
                             employee.Value.providendFund, employee.Value.privateUseofVehicle, employee.Value.hasLoan,
                             employee.Value.loanAmount, employee.Value.loanPerMonthPay, employee.Value.debt, bonus, totalSalary+"");
                        }
                    }
                }
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }

        }

        private int CalculateTotalSalary(string bs, string hr, string m, string c, string oa, string sf, string ai,
            string pf, string pv, string pmp)
        {
            int total = int.Parse(bs) + int.Parse(hr) + int.Parse(m) + int.Parse(c) + int.Parse(oa) - int.Parse(ai) - int.Parse(pf) - int.Parse(pv) - int.Parse(pmp);

            return total;
        }

        private async void saveSalary()
        {

            try
            {
                
                //PushResponse msssage = await client.PushAsync("Employee/Info", em);

                string month = month_combobox.Text;
                string year = year_combobox.Text;

                string path = year + "-" + month;

                string myPath = year + "-" + month;

                path = "Employee/Salary/" + path;

                List<Salary> salaryList = new List<Salary>();

                List<string> allSalaryString = new List<string>(); 

                

                IFirebaseConfig config = new FirebaseConfig()
                {
                    AuthSecret = "M0sYEthHoMtU0QkuB9grGbyYUhJeOQP11hl9Px8t",
                    BasePath = "https://payrollpoject-default-rtdb.firebaseio.com/"
                };

                IFirebaseClient client = new FirebaseClient(config);

                int i;

                

                

                if (EemployeeList.Rows.Count > 1)
                {
                    for (i = 0; i < EemployeeList.Rows.Count - 1; i++)
                    {
                 
                        Salary s = new Salary();

                        string salaryString="";

                        s.id = EemployeeList.Rows[i].Cells[0].Value.ToString();
                        salaryString = salaryString + "Id : " + s.id + "\n";

                        s.name = EemployeeList.Rows[i].Cells[1].Value.ToString();
                        salaryString = salaryString + "Name : " + s.name + "\n";

                        s.grade = EemployeeList.Rows[i].Cells[2].Value.ToString();
                        salaryString = salaryString + "Grade : " + s.grade + "\n";

                        s.email = EemployeeList.Rows[i].Cells[4].Value.ToString();
                        salaryString = salaryString + "Email : " + s.email + "\n";

                        s.basicSalary = EemployeeList.Rows[i].Cells[9].Value.ToString();
                        salaryString = salaryString + "Basic Salary : " + s.basicSalary + "\n";

                        s.houseRent = EemployeeList.Rows[i].Cells[10].Value.ToString();
                        salaryString = salaryString + "House Rent : " + s.houseRent + "\n";

                        s.medical = EemployeeList.Rows[i].Cells[11].Value.ToString();
                        salaryString = salaryString + "Medical : " + s.medical + "\n";

                        s.convenience = EemployeeList.Rows[i].Cells[12].Value.ToString();
                        salaryString = salaryString + "Convenience : " + s.convenience + "\n";

                        s.otherAllowence = EemployeeList.Rows[i].Cells[13].Value.ToString();
                        salaryString = salaryString + "Other Allowence : " + s.otherAllowence + "\n";

                        s.savedFund = EemployeeList.Rows[i].Cells[14].Value.ToString();
                        salaryString = salaryString + "Saved Fund : " + s.savedFund + "\n";

                        salaryString = salaryString + "     _________ \n";


                        s.advanceIncomeTax = EemployeeList.Rows[i].Cells[15].Value.ToString();
                        salaryString = salaryString + "     Advance Income Tax : " + s.advanceIncomeTax + "\n";

                        s.providendFund = EemployeeList.Rows[i].Cells[16].Value.ToString();
                        salaryString = salaryString + "     Provident Fund : " + s.providendFund + "\n";

                        s.privateUseofVehicle = EemployeeList.Rows[i].Cells[17].Value.ToString();
                        salaryString = salaryString + "     Private Use of Vehicle : " + s.privateUseofVehicle + "\n";


                        s.hasLoan = EemployeeList.Rows[i].Cells[18].Value.ToString();
                        salaryString = salaryString + "     Has a Loan : " + s.hasLoan + "\n";

                        s.loanAmount = EemployeeList.Rows[i].Cells[19].Value.ToString();
                        salaryString = salaryString + "     Loan Amount : " + s.loanAmount + "\n";

                        s.loanPerMonthPay = EemployeeList.Rows[i].Cells[20].Value.ToString();
                        salaryString = salaryString + "     Per Month Payable : " + s.loanPerMonthPay + "\n";

                        s.debt = EemployeeList.Rows[i].Cells[21].Value.ToString();
                        salaryString = salaryString + "     Debt : " + s.debt + "\n";

                        s.bonus = EemployeeList.Rows[i].Cells[22].Value.ToString();
                        salaryString = salaryString + "Bonus : " + s.bonus + "\n";

                        salaryString = salaryString + "_______________________________________________________ \n";

                        s.totalSalary = EemployeeList.Rows[i].Cells[23].Value.ToString();
                        salaryString = salaryString + "Total Salary : " + s.totalSalary + " BDT\n";


                        salaryList.Add(s);
                        allSalaryString.Add(salaryString);

                    }

                    PushResponse msssage = await client.PushAsync(path, salaryList);
                    if (msssage.Body != null)
                    {
                        MessageBox.Show("Save Successful");

                        try
                        {
                            using (SmtpClient client1 = new SmtpClient("smtp.gmail.com", 587))
                            {
                                client1.EnableSsl = true;
                                client1.DeliveryMethod = SmtpDeliveryMethod.Network;
                                client1.UseDefaultCredentials = false;

                                client1.Credentials = new NetworkCredential("systemPayroll92@gmail.com", "c#systemPayroll92");

                                for (i = 0; i < salaryList.Count; i++)
                                {

                                    try
                                    {
                                        string sendTo = salaryList[i].email;
                                        string mySalary = allSalaryString[i];

                                        MailMessage message = new MailMessage();
                                        message.To.Add(sendTo);
                                        message.From = new MailAddress("systemPayroll92@gmail.com");
                                        message.Subject = "Salary/" + myPath;
                                        message.Body = mySalary;
                                        client1.Send(message);
                                        MessageBox.Show("Send to : " + sendTo);
                                    }catch(Exception e)
                                    {
                                        MessageBox.Show("!!!ERROR!!! Send Failed to : " + salaryList[i].email);
                                    }
                                    
                                }

                                

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        EemployeeList.Rows.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Save Error");
                    }

                }

            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private async void updateInfo()
        {
            try
            {
                IFirebaseConfig config = new FirebaseConfig()
                {
                    AuthSecret = "M0sYEthHoMtU0QkuB9grGbyYUhJeOQP11hl9Px8t",
                    BasePath = "https://payrollpoject-default-rtdb.firebaseio.com/"
                };

                IFirebaseClient client = new FirebaseClient(config);



                Employee s = new Employee();

                if (EemployeeList.Rows.Count > 1)
                {
                    for (int i = 0; i < EemployeeList.Rows.Count - 1; i++)
                    {

                        string id = EemployeeList.Rows[i].Cells[0].Value.ToString();
                        s.name = EemployeeList.Rows[i].Cells[1].Value.ToString();
                        s.grade = EemployeeList.Rows[i].Cells[2].Value.ToString();

                        s.phn = EemployeeList.Rows[i].Cells[3].Value.ToString();
                        s.email = EemployeeList.Rows[i].Cells[4].Value.ToString();

                        s.nid = EemployeeList.Rows[i].Cells[5].Value.ToString();

                        s.address = EemployeeList.Rows[i].Cells[6].Value.ToString();

                        s.joindate = EemployeeList.Rows[i].Cells[7].Value.ToString();

                        s.IsActive = EemployeeList.Rows[i].Cells[8].Value.ToString();



                        s.basicSalary = EemployeeList.Rows[i].Cells[9].Value.ToString();
                        s.houseRent = EemployeeList.Rows[i].Cells[10].Value.ToString();
                        s.medical = EemployeeList.Rows[i].Cells[11].Value.ToString();
                        s.convenience = EemployeeList.Rows[i].Cells[12].Value.ToString();
                        s.otherAllowence = EemployeeList.Rows[i].Cells[13].Value.ToString();
                        s.savedFund = EemployeeList.Rows[i].Cells[14].Value.ToString();
                        s.advanceIncomeTax = EemployeeList.Rows[i].Cells[15].Value.ToString();
                        s.providendFund = EemployeeList.Rows[i].Cells[16].Value.ToString();
                        s.privateUseofVehicle = EemployeeList.Rows[i].Cells[17].Value.ToString();


                        s.hasLoan = EemployeeList.Rows[i].Cells[18].Value.ToString();
                        s.loanAmount = EemployeeList.Rows[i].Cells[19].Value.ToString();
                        s.loanPerMonthPay = EemployeeList.Rows[i].Cells[20].Value.ToString();
                        s.debt = EemployeeList.Rows[i].Cells[21].Value.ToString();

                        var message = await client.UpdateAsync("Employee/Info/" + id, s);
                        //MessageBox.Show(message.Body);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void SaveSalary_btn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Save and Send Salary ??",
                                     "Confirmation!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                updateInfo();
                saveSalary();

                addBonus_btn.Hide();
                //EemployeeList.Rows.Clear();
                SaveSalary_btn.Hide();
            }
            else
            {
                // If 'No', do something here.
                addBonus_btn.Hide();
                EemployeeList.Rows.Clear();
                SaveSalary_btn.Hide();
            }

            
        }

        private void addBonus_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EemployeeList.Rows.Count > 1)
                {
                    for (int i = 0; i < EemployeeList.Rows.Count - 1; i++)
                    {
                       

                        int basicSalary = int.Parse(EemployeeList.Rows[i].Cells[9].Value.ToString());
                        int totalSalary = int.Parse(EemployeeList.Rows[i].Cells[23].Value.ToString());

                        int bonus = (basicSalary * 40) / 100;
                        totalSalary += bonus;

                        EemployeeList.Rows[i].Cells[22].Value = bonus + "";

                        EemployeeList.Rows[i].Cells[23].Value = totalSalary + "";
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            addBonus_btn.Hide();
        }

        private void generateSalary_back_Click(object sender, EventArgs e)
        {
            Accountant f = new Accountant();
            f.Show();
            this.Hide();
        }
    }
}
