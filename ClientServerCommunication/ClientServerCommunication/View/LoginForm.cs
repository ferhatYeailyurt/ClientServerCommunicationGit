using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClientServerCommunication;
using ClientServerCommunication.Model;
using ClientServerCommunication.db_objects;
using ClientServerCommunication.Controller;
using ClientServerCommunication.View;

namespace ClientServerCommunication
{
    public partial class LoginForm : Form
    {

        User_ModelCS userModel;
        User_Data_Table usDataTable;
        User_OperaitonsController userOperation;

        public LoginForm()
        {
            userModel = new User_ModelCS();
            usDataTable = new User_Data_Table();
            userOperation = new User_OperaitonsController();

            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Hide();
        }

        public void getValueDb()
        {
            userModel.Ad = txt_username.Text.ToLower();
            userModel.Sifre = txt_password.Text.ToLower();

            userOperation.setController(userModel);
        }

        private void giris_yap_btn_Click(object sender, EventArgs e)
        {
            getValueDb();

            if (txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Lütfen kullanıcı adı ve parolasını giriniz...");
                return;
            }

            userOperation.loginUser();
            userOperation.sendPasswordMail();

            if(userOperation.kapat=="kapat")
            {
                this.Hide();
            }



        }

        private void SifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordRememberForm passForm = new PasswordRememberForm();
            passForm.Show();
            
        }
    }
}
