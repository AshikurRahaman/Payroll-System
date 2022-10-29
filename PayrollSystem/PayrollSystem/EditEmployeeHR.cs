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
    public partial class EditEmployeeHR : Form
    {
        public EditEmployeeHR()
        {
            InitializeComponent();
        }

        private async void edit_btn_continue_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Edit This Employee ??",
                                     "!!Confirmation!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Employee ep = new Employee();
                string id = edit_txt_box_id.Text;
                ep.name = edit_textBox_name.Text;
                ep.grade = edit_gadeCombo.Text;
                ep.phn = edit_textBox_phone.Text;
                ep.email = edit_textBox_email.Text;
                ep.nid = edit_textBox_nid.Text;
                ep.address = edit_textBox_address.Text;
                ep.joindate = edit_joinDate.Text;
                ep.IsActive = edit_activeCombo.Text;
                ///
                ep.basicSalary = workingEmployeeDemo.basicSalary;
                ep.houseRent = workingEmployeeDemo.houseRent;
                ep.medical = workingEmployeeDemo.medical;
                ep.convenience = workingEmployeeDemo.convenience;
                ep.otherAllowence = workingEmployeeDemo.otherAllowence;
                ep.savedFund = workingEmployeeDemo.savedFund;
                ep.advanceIncomeTax = workingEmployeeDemo.advanceIncomeTax;
                ep.providendFund = workingEmployeeDemo.providendFund;
                ep.privateUseofVehicle = workingEmployeeDemo.privateUseofVehicle;

                ep.hasLoan = workingEmployeeDemo.hasLoan;
                ep.loanAmount = workingEmployeeDemo.loanAmount;
                ep.loanPerMonthPay = workingEmployeeDemo.loanPerMonthPay;
                ep.debt = workingEmployeeDemo.debt;


                try
                {
                    IFirebaseConfig config = new FirebaseConfig()
                    {
                        AuthSecret = "M0sYEthHoMtU0QkuB9grGbyYUhJeOQP11hl9Px8t",
                        BasePath = "https://payrollpoject-default-rtdb.firebaseio.com/"
                    };

                    IFirebaseClient client = new FirebaseClient(config);

                    //var msssage = await client.UpdateAsync("User/Book/" + loginClass.path, book);
                    var message = await client.UpdateAsync("Employee/Info/" + id, ep);
                    if (message.Body != null)
                    {
                        MessageBox.Show("Edited and Updated Successfully");
                        showAllEmployee();
                        emptyFields();

                    }
                    else
                    {
                        MessageBox.Show("Failed");
                        emptyFields();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                // If 'No', do something here.

                showAllEmployee();
                emptyFields();
            }

            
        }

        private void emptyFields()
        {
            edit_txt_box_id.Text = "";
            edit_textBox_name.Text = "";
            edit_gadeCombo.Text = "";
            edit_textBox_phone.Text = "";
            edit_textBox_email.Text = "";
            edit_textBox_nid.Text = "";
            edit_textBox_address.Text = "";
            edit_joinDate.Text = "";
            edit_activeCombo.Text = "";
        }

        private async void showAllEmployee()
        {
            edit_activeCombo.Items.Clear();
            edit_activeCombo.Items.Add("Yes");
            edit_activeCombo.Items.Add("No");
            edit_btn_continue.Hide();

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
                    employeeList.Rows.Clear();

                    foreach (var employee in employees)
                    {
                        employeeList.Rows.Add(employee.Key, employee.Value.name, employee.Value.grade, employee.Value.phn,
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HR f = new HR();
            f.Show();
            this.Hide();
        }

        private void EditEmployeeHR_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Employee er sob elements dhorte hobe, grade eikhane rakha jabe na");

            showAllEmployee();
            ///


        }

        private void employeeList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                workingEmployeeDemo.privateUseofVehicle = employeeList.SelectedCells[17].Value.ToString();

                workingEmployeeDemo.hasLoan = employeeList.SelectedCells[18].Value.ToString();
                workingEmployeeDemo.loanAmount = employeeList.SelectedCells[19].Value.ToString();
                workingEmployeeDemo.loanPerMonthPay = employeeList.SelectedCells[20].Value.ToString();
                workingEmployeeDemo.debt = employeeList.SelectedCells[21].Value.ToString();

                //edit_activeCombo.Text = employeeList.SelectedCells[8].Value.ToString();
                edit_txt_box_id.Text = employeeList.SelectedCells[0].Value.ToString();
                edit_textBox_name.Text = employeeList.SelectedCells[1].Value.ToString();
                edit_gadeCombo.Text = employeeList.SelectedCells[2].Value.ToString();
                edit_textBox_phone.Text = employeeList.SelectedCells[3].Value.ToString();
                edit_textBox_email.Text = employeeList.SelectedCells[4].Value.ToString();
                edit_textBox_nid.Text = employeeList.SelectedCells[5].Value.ToString();
                edit_textBox_address.Text = employeeList.SelectedCells[6].Value.ToString();
                edit_joinDate.Text = employeeList.SelectedCells[7].Value.ToString();
                edit_activeCombo.Text = employeeList.SelectedCells[8].Value.ToString();
                ///
                workingEmployeeDemo.basicSalary = employeeList.SelectedCells[9].Value.ToString();
                workingEmployeeDemo.houseRent = employeeList.SelectedCells[10].Value.ToString();
                workingEmployeeDemo.medical = employeeList.SelectedCells[11].Value.ToString();
                workingEmployeeDemo.convenience = employeeList.SelectedCells[12].Value.ToString();
                workingEmployeeDemo.otherAllowence = employeeList.SelectedCells[13].Value.ToString();
                workingEmployeeDemo.savedFund = employeeList.SelectedCells[14].Value.ToString();
                workingEmployeeDemo.advanceIncomeTax = employeeList.SelectedCells[15].Value.ToString();
                workingEmployeeDemo.providendFund = employeeList.SelectedCells[16].Value.ToString();
                

                edit_btn_continue.Show();


            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
