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

        MainForm mainForm;




        public UserRegister()
        {
            mainForm = new MainForm();
            userModel = new User_ModelCS();
            userOperation = new User_OperaitonsController();


            InitializeComponent();
        }

        public void getValueTextBox() {

            userModel.Ad = txt_adi.Text.ToLower();
            userModel.Soyad = txt_soyadi.Text.ToLower();
            userModel.Email = txt_email.Text;
            userModel.Sifre = txt_sifre.Text.ToLower();

            userOperation.setController(userModel);


        }
             
          public void ValueClearTextBox()
        {
            txt_adi.Clear();
            txt_soyadi.Clear();
            txt_email.Clear();
            txt_sifre.Clear();
        }
    

        private void UserRegister_Load(object sender, EventArgs e)
        {

        }

        private void kaydet_btn_Click(object sender, EventArgs e)
        {
            getValueTextBox();
            foreach (Control ctrl in this.Controls)
            {

                if (ctrl is TextBox)
                {

                    if (ctrl.Text == String.Empty)
                    {

                        MessageBox.Show(Convert.ToString(((TextBox)ctrl).Name + " Veritabanına boş değer girilmez, lütfen kontrol ediniz!!!"));
                        goto Outer;
                    }

                    else
                    {


                        MessageBox.Show("İşlem Başarılı", "İşlem Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        userOperation.saveUserDatabase(userModel);

                        openMainForm();
                        mainForm.userNameLabel.Text = txt_adi.Text + " " + txt_soyadi.Text ;//Kullanıcı adı ve soyadını yeni açılan forma gönderiyor.
                    
                        break;

                    }

                    Outer:
                    continue;
                }
            }
            }

        public void openMainForm()
        {
            mainForm.Show();
            this.Hide();
        }


        private void returnForm_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Hide();
        }

        private void temizle_btn_Click(object sender, EventArgs e)
        {
            ValueClearTextBox();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
