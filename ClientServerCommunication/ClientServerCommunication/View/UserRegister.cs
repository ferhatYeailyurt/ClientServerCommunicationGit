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
using ClientServerCommunication.Controller;
using ClientServerCommunication.db_objects;

namespace ClientServerCommunication.View    
{
    public partial class UserRegister : Form
    {
        User_ModelCS userModel;
        User_OperaitonsController userOperation;


        public UserRegister()
        {

            userModel = new User_ModelCS();
            userOperation = new User_OperaitonsController();


            InitializeComponent();
        }

        public void getValueTextBox()
        {
            userModel.Ad = txt_adi.Text;
            userModel.Soyad = txt_soyadi.Text;
            userModel.Email = txt_email.Text;
            userModel.Sifre = txt_sifre.Text;
            userOperation.setController(userModel);
        }
    

        private void UserRegister_Load(object sender, EventArgs e)
        {

        }

        private void kaydet_btn_Click(object sender, EventArgs e)
        {
            getValueTextBox();
            userOperation.saveUserDatabase(userModel);
        }


        private void returnForm_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Hide();
        }
    }
}
