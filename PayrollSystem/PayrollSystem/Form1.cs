using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Media;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //EmployeeEntryContinued load = new EmployeeEntryContinued();
            //load.Show();
            //this.Hide();
            /*var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirmation!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("ok");
            }
            else
            {
                // If 'No', do something here.
                MessageBox.Show("Not ok");
            }*/

            LoginForm f = new LoginForm();
            f.Show();
            this.Hide();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            /*SoundPlayer sp = new SoundPlayer(PayrollSystem.Properties.Resources.coins_in_hand_4);
            sp.Play();*/
        }
    }
}
