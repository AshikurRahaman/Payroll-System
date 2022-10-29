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
    public partial class FinalViewACC : Form
    {
        public FinalViewACC()
        {
            InitializeComponent();
        }

        private void FinalViewACC_Load(object sender, EventArgs e)
        {

            searchBy_combo.Items.Clear();
            searchBy_combo.Items.Add("Name");
            searchBy_combo.Items.Add("Date");
            searchBy_combo.Text = "Date";

            view_month_combobox.Items.Clear();
            view_month_combobox.Items.Add("January");
            view_month_combobox.Items.Add("February");
            view_month_combobox.Items.Add("March");
            view_month_combobox.Items.Add("April");
            view_month_combobox.Items.Add("May");
            view_month_combobox.Items.Add("June");
            view_month_combobox.Items.Add("July");
            view_month_combobox.Items.Add("August");
            view_month_combobox.Items.Add("September");
            view_month_combobox.Items.Add("October");
            view_month_combobox.Items.Add("November");
            view_month_combobox.Items.Add("December");
            view_month_combobox.Text = "January";


            view_year_combobox.Items.Clear();
            for (int i = 2020; i <= 2050; i++)
            {
                view_year_combobox.Items.Add(i + "");
            }
            view_year_combobox.Text = "2021";

            
        }

        private async void Search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string month = view_month_combobox.Text;
                string year = view_year_combobox.Text;

                IFirebaseConfig config = new FirebaseConfig()
                {
                    AuthSecret = "M0sYEthHoMtU0QkuB9grGbyYUhJeOQP11hl9Px8t",
                    BasePath = "https://payrollpoject-default-rtdb.firebaseio.com/"
                };
                IFirebaseClient client = new FirebaseClient(config);

                string path;

                if (searchBy_combo.Text == "Name")
                {
                    path = "";
                }
                else if (searchBy_combo.Text == "Date")
                {
                    path = year + "-" + month;


                    var data = await client.GetAsync("Employee/Salary/"+path);
                    

                    Dictionary<string, List<Salary>> salaries = data.ResultAs<Dictionary<string, List<Salary>>>();

                    salary_gridview.Rows.Clear();

                    if (salaries != null)
                    {
                        //salary_gridview.Rows.Add(year + "-" + month);
                        foreach (var item in salaries)
                        {
                            //salary_gridview.Rows.Add(year + "-" + month);

                            foreach (var value in item.Value)
                            {

                                salary_gridview.Rows.Add(value.id, value.name, value.grade , value.email, value.basicSalary, value.houseRent, value.medical,
                                    value.convenience, value.otherAllowence, value.savedFund, value.advanceIncomeTax, value.providendFund, value.privateUseofVehicle,
                                    value.hasLoan, value.loanAmount, value.loanPerMonthPay, value.debt, value.bonus, value.totalSalary);

                            }

                            salary_gridview.Rows.Add();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Salaries Found");
                    }
                }
            }catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

            
        }

        private void viewSalarY_back_Click(object sender, EventArgs e)
        {
            Accountant ff = new Accountant();
            ff.Show();
            this.Hide();
        }
    }
}
