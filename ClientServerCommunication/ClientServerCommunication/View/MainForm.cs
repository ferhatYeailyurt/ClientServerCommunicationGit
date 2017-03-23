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
using ClientServerCommunication.Controller;
using ClientServerCommunication.Model;
using ClientServerCommunication.db_objects;

namespace ClientServerCommunication.View
{
    public partial class MainForm : Form
    {
        User_OperaitonsController user_OperaitonsController;
        public MainForm()
        {
            user_OperaitonsController = new User_OperaitonsController();

            InitializeComponent();
        }

        private void btn_userList_Click(object sender, EventArgs e)
        {
            user_OperaitonsController.listUser();
           
        }

        private void lstView_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }

        private void btn_userSelect_Click(object sender, EventArgs e)
        {
            if (lstView_User.SelectedItems.Count > 0)
            {
                MessageBox.Show("Kullanıcı " + lstView_User.SelectedItems[0].Text + "seçildi.");
            }
            else
            {
                MessageBox.Show("Lütfen ilk önce kullanıcıyı seçiniz...");
            }
        }
    }
}
