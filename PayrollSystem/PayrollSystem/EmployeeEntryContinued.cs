using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
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
    public partial class PaymentInfo : Form
    {
        //private object employeeList;

        public PaymentInfo()
        {
            InitializeComponent();
        }

        

        

        private void PaymentInfo_Load(object sender, EventArgs e)
        {
            changeGradeCombobox.Items.Clear();
            changeGradeCombobox.Items.Add("1");
            changeGradeCombobox.Items.Add("2");
            changeGradeCombobox.Items.Add("3");
            changeGradeCombobox.Items.Add("4");
            changeGradeCombobox.Items.Add("5");
            changeGradeCombobox.Show();

            search_category_combo.Items.Clear();
            search_category_combo.Items.Add("Employee Name");
            search_category_combo.Items.Add("Employee Grade");
            search_category_combo.Text = "Employee Name";

            ShowEmployeees();
            hide();
            loanDetailsHide();
        }

        private async void ShowEmployeees()
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

                //List<Salary> salaryList = new List<Salary>(); 

                Dictionary<string, Employee> employees = data.ResultAs<Dictionary<string, Employee>>();

                if (employees != null)
                {
                    EemployeeList.Rows.Clear();

                    foreach (var employee in employees)
                    {
                        EemployeeList.Rows.Add(employee.Key, employee.Value.name, employee.Value.grade, employee.Value.phn,
                             employee.Value.email, employee.Value.nid, employee.Value.address, employee.Value.joindate, employee.Value.IsActive,
                             employee.Value.basicSalary, employee.Value.houseRent, employee.Value.medical, employee.Value.convenience,
                             employee.Value.otherAllowence, employee.Value.savedFund, employee.Value.advanceIncomeTax,
                             employee.Value.providendFund, employee.Value.privateUseofVehicle, employee.Value.hasLoan,
                             employee.Value.loanAmount, employee.Value.loanPerMonthPay, employee.Value.debt);
                    }
                }
                else
                {
                    MessageBox.Show("No Employees Found");
                }
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
        }

    

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HR f = new HR();
            f.Show();
            this.Hide();
        }

        private void EemployeeList_DoubleClick(object sender, EventArgs e)
        {
            grantLoan_btn.Hide();
            
            try
            {

                lb_vehicle.Text = EemployeeList.SelectedCells[17].Value.ToString();

                lb_IsLoan.Text = EemployeeList.SelectedCells[18].Value.ToString();

                
                lb_loanAmount.Text= EemployeeList.SelectedCells[19].Value.ToString();
                lb_perMonthPay.Text= EemployeeList.SelectedCells[20].Value.ToString();
                lb_debt.Text= EemployeeList.SelectedCells[21].Value.ToString();

                /// loan info

                id_label.Text = EemployeeList.SelectedCells[0].Value.ToString();

                workingEmployeeDemo.name = EemployeeList.SelectedCells[1].Value.ToString();
                lb_name.Text = workingEmployeeDemo.name;

                workingEmployeeDemo.grade = EemployeeList.SelectedCells[2].Value.ToString();
                changeGradeCombobox.Text = workingEmployeeDemo.grade;
                workingEmployeeDemo.phn = EemployeeList.SelectedCells[3].Value.ToString();
                workingEmployeeDemo.email = EemployeeList.SelectedCells[4].Value.ToString();
                workingEmployeeDemo.nid = EemployeeList.SelectedCells[5].Value.ToString();
                workingEmployeeDemo.address = EemployeeList.SelectedCells[6].Value.ToString();
                workingEmployeeDemo.joindate = EemployeeList.SelectedCells[7].Value.ToString();
                workingEmployeeDemo.IsActive = EemployeeList.SelectedCells[8].Value.ToString();
                //


                lb_salary.Text = EemployeeList.SelectedCells[9].Value.ToString();
                lb_rent.Text = EemployeeList.SelectedCells[10].Value.ToString();
                lb_medical.Text = EemployeeList.SelectedCells[11].Value.ToString();
                lb_convenience.Text = EemployeeList.SelectedCells[12].Value.ToString();
                lb_others.Text = EemployeeList.SelectedCells[13].Value.ToString();
                lb_saved_fund.Text = EemployeeList.SelectedCells[14].Value.ToString();
                lb_tax.Text = EemployeeList.SelectedCells[15].Value.ToString();
                lb_fund.Text = EemployeeList.SelectedCells[16].Value.ToString();

                if (lb_IsLoan.Text == "No" && workingEmployeeDemo.IsActive=="Yes")
                {
                    grantLoan_btn.Show();
                }
                else if (lb_IsLoan.Text == "Yes")
                {
                    loanDetailsShow();
                }

                changeGradeCombobox.Show();
                show();
                ///
                lb_IsLoan.Show();
                
                
            }
            catch(Exception eee)
            {
                MessageBox.Show(eee.Message);
            }

            
        }

        private void loanDetailsHide()
        {
            loanAmount_lbl.Hide();
            perMonthPay_lbl.Hide();
            debt_lbl.Hide();

            lb_loanAmount.Hide();
            lb_perMonthPay.Hide();
            lb_debt.Hide();

            grantLoan_btn.Hide();
        }

        private void loanDetailsShow()
        {
            loanAmount_lbl.Show();
            perMonthPay_lbl.Show();
            debt_lbl.Show();

            lb_loanAmount.Show();
            lb_perMonthPay.Show();
            lb_debt.Show();
        }

        private void changeGradeCombobox_TextChanged(object sender, EventArgs e)
        {
            string grade = changeGradeCombobox.Text;

            sSalary(grade);

        }

        private int Generate(int basicS, int percent)
        {

            int x = percent * basicS;

            x = x / 100;


            return x;
        }

        private void sSalary(string grade)
        {
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

            }
            else if (grade == "4")
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


        }

        private void hide()
        {
            update_salary_btn.Hide();
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

        private void show()
        {
            update_salary_btn.Show();
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

        private async void update_salary_btn_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Update This Employee ??",
                                     "Confirmation!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Employee emp = new Employee();

                try
                {
                    emp.name = workingEmployeeDemo.name;
                    emp.grade = changeGradeCombobox.Text;
                    emp.phn = workingEmployeeDemo.phn;
                    emp.email = workingEmployeeDemo.email;
                    emp.nid = workingEmployeeDemo.nid;
                    emp.address = workingEmployeeDemo.address;
                    emp.joindate = workingEmployeeDemo.joindate;
                    emp.IsActive = workingEmployeeDemo.IsActive;

                    emp.basicSalary = lb_salary.Text;
                    emp.houseRent = lb_rent.Text;
                    emp.medical = lb_medical.Text;
                    emp.convenience = lb_convenience.Text;
                    emp.otherAllowence = lb_others.Text;
                    emp.savedFund = lb_saved_fund.Text;
                    emp.advanceIncomeTax = lb_tax.Text;
                    emp.providendFund = lb_fund.Text;
                    emp.privateUseofVehicle = lb_vehicle.Text;

                    emp.hasLoan = lb_IsLoan.Text;
                    emp.loanAmount = lb_loanAmount.Text;
                    emp.loanPerMonthPay = lb_perMonthPay.Text;
                    emp.debt = lb_debt.Text;

                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }

                try
                {
                    string id = id_label.Text;

                    IFirebaseConfig config = new FirebaseConfig()
                    {
                        AuthSecret = "M0sYEthHoMtU0QkuB9grGbyYUhJeOQP11hl9Px8t",
                        BasePath = "https://payrollpoject-default-rtdb.firebaseio.com/"
                    };

                    IFirebaseClient client = new FirebaseClient(config);

                    //var msssage = await client.UpdateAsync("User/Book/" + loginClass.path, book);
                    var message = await client.UpdateAsync("Employee/Info/" + id, emp);
                    if (message.Body != null)
                    {
                        MessageBox.Show("Updated Successfully");
                        ShowEmployeees();
                        hide();
                        loanDetailsHide();
                        //changeGradeCombobox.Text = "";
                        changeGradeCombobox.Show();///
                        lb_IsLoan.Hide();
                        search_category_combo.Text = "Employee Name";
                        search_textBox.Text = "";
                        lb_name.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                        
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                ShowEmployeees();
                hide();
                loanDetailsHide();
                //changeGradeCombobox.Text = "";
                changeGradeCombobox.Show();///
                lb_IsLoan.Hide();
                search_category_combo.Text = "Employee Name";
                search_textBox.Text = "";
                lb_name.Text = "";
            }

            

        }

        private void generateLoan()
        {
            string salary = lb_salary.Text;
            int mySalary = int.Parse(salary);

            int loanAmount = mySalary * 10;
            int perMonthPayable = loanAmount / 36;

            lb_loanAmount.Text = loanAmount + "";
            lb_perMonthPay.Text = perMonthPayable + "";
            lb_debt.Text = loanAmount + "";
        }

        private void grantLoan_btn_Click(object sender, EventArgs e)
        {
            /// generate loan

            changeGradeCombobox.Hide();

            lb_IsLoan.Text = "Yes";

            generateLoan();


            loanDetailsShow();
        }

        private async void search_textBox_TextChanged(object sender, EventArgs e)
        {
            EemployeeList.Rows.Clear();

            string searchCategory = search_category_combo.Text;
            string search_value = search_textBox.Text;

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
                        //search_category_combo.Items.Add("Employee Name");
                        //search_category_combo.Items.Add("Employee Grade");

                        if (searchCategory== "Employee Name")
                        {
                            //employee.Value.name == search_value
                            if (employee.Value.name.Contains( search_value))
                            {
                                EemployeeList.Rows.Add(employee.Key, employee.Value.name, employee.Value.grade, employee.Value.phn,
                             employee.Value.email, employee.Value.nid, employee.Value.address, employee.Value.joindate, employee.Value.IsActive,
                             employee.Value.basicSalary, employee.Value.houseRent, employee.Value.medical, employee.Value.convenience,
                             employee.Value.otherAllowence, employee.Value.savedFund, employee.Value.advanceIncomeTax,
                             employee.Value.providendFund, employee.Value.privateUseofVehicle, employee.Value.hasLoan,
                             employee.Value.loanAmount, employee.Value.loanPerMonthPay, employee.Value.debt);
                            }
                        }else if(searchCategory == "Employee Grade")
                        {
                            if (employee.Value.grade == search_value)
                            {
                                EemployeeList.Rows.Add(employee.Key, employee.Value.name, employee.Value.grade, employee.Value.phn,
                             employee.Value.email, employee.Value.nid, employee.Value.address, employee.Value.joindate, employee.Value.IsActive,
                             employee.Value.basicSalary, employee.Value.houseRent, employee.Value.medical, employee.Value.convenience,
                             employee.Value.otherAllowence, employee.Value.savedFund, employee.Value.advanceIncomeTax,
                             employee.Value.providendFund, employee.Value.privateUseofVehicle, employee.Value.hasLoan,
                             employee.Value.loanAmount, employee.Value.loanPerMonthPay, employee.Value.debt);
                            }
                        }

                        
                    }
                }
                else
                {
                    MessageBox.Show("No Employees Found");
                }
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
        }
    }
}
