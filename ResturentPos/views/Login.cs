using ResturentPos.controllers;
using ResturentPos.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturentPos
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        //auth controller instance
        authController verify = new authController();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text == "" || tbPassword.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Enter User Name and Password..!" , "Invalid Data" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else
            {
                //get password and user type
                string[] user = (string[]) verify.AuthanticateUser(tbUserName.Text, tbPassword.Text);

                String pass = user[0];
                String type = user[1];

                if (tbPassword.Text == pass)
                {
                    if (type == "cashier")
                    {
                        //show cashier interface
                        Console.WriteLine("you will go to cashier menu");

                        CashierForm cashier = new CashierForm();
                        cashier.ShowDialog();
                    }
                    else if (type == "kitchen")
                    {
                        //show kitchen interface
                        Console.WriteLine("you will go to kitchen menu");
                    }

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Invalid User Name or Password..!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
