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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            loginAs_combo.Text = "Accountant";
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            string userType = loginAs_combo.Text;
            string name = textBox_username.Text;
            string pass = textBox_password.Text;

            try
            {
                IFirebaseConfig config = new FirebaseConfig()
                {
                    AuthSecret = "M0sYEthHoMtU0QkuB9grGbyYUhJeOQP11hl9Px8t",
                    BasePath = "https://payrollpoject-default-rtdb.firebaseio.com/"
                };

                IFirebaseClient client = new FirebaseClient(config);

                var data = await client.GetAsync("User/Accountant");

                if (userType == "HR")
                {
                    data = await client.GetAsync("User/HR");
                }
               

                
                Dictionary<string, User> users = data.ResultAs<Dictionary<string, User>>();

                foreach (var user in users)
                {
                    if(user.Value.name==name && user.Value.pass == pass)
                    {
                        if (userType == "Accountant")
                        {
                            /// Accountant Fom
                            Accountant f = new Accountant();
                            f.Show();
                            this.Hide();
                        }else if (userType == "HR")
                        {
                            HR f1 = new HR();
                            f1.Show();
                            this.Hide();
                            
                        }
                        return;
                    }
                }

                MessageBox.Show("Login Failed");
                loginAs_combo.Text = "Accountant";
                textBox_password.Text = "";
                textBox_username.Text = "";
                return ;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            
        }
    }
}
