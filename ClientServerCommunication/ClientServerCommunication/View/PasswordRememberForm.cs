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
using System.Net.Mail;
using System.Net;

namespace ClientServerCommunication.View
{
    public partial class PasswordRememberForm : Form
    {

        User_ModelCS userModel;
        User_OperaitonsController userController;

        public PasswordRememberForm()
        {
            userModel = new User_ModelCS();
            userController = new User_OperaitonsController();

            InitializeComponent();
        }

        private void btn_gonder_mail_Click(object sender, EventArgs e)
        {
            userModel.Email = txt_email.Text;
            userController.setController(userModel);
            userController.sendPasswordMail();


        }

        
  
    }
}
