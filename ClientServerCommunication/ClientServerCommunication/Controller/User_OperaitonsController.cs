﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientServerCommunication;

using ClientServerCommunication.Model;
using ClientServerCommunication.db_objects;
using ClientServerCommunication.View;


using System.Net.Mail;
using System.Net;

namespace ClientServerCommunication.Controller
{
    class User_OperaitonsController
    {

        UserDBDataClassesDataContext usDataContext;
        User_Data_Table usDataTable;


        LoginForm loginForm;

        User_ModelCS userModel;

        public User_OperaitonsController()
        {
            usDataContext = new UserDBDataClassesDataContext();

            usDataTable = new User_Data_Table();

            userModel = new User_ModelCS();
               
        }
      

            
        public User_OperaitonsController(User_ModelCS us)
        {
            this.userModel = us;
        }

 
        public void setController(User_ModelCS us)
        {
            this.userModel = us;
        }

        public void saveUserDatabase(User_ModelCS us)
        {
            databaseSave();
        }

        private void databaseSave()
        {
            try
            {
                usDataTable.USER_NAME = userModel.Ad;
                usDataTable.USER_SURNAME = userModel.Soyad;
                usDataTable.USER_MAIL = userModel.Email;
                usDataTable.USER_PASSWORD = userModel.Sifre;

                usDataContext.User_Data_Tables.InsertOnSubmit(usDataTable);
                usDataContext.SubmitChanges();
                
            }
            catch(Exception e)
            {
                MessageBox.Show("Veri eklenmedi, bir hata var!!!");
            }

        }

        public String kapat;
        public void loginUser()
        {
           if(checkLogin(userModel.Ad.ToString(),userModel.Sifre.ToString()))
            {
                kapat = "kapat";
            }
        }

        private bool checkLogin(String ad, String sifre)
        {
            var q = from p in usDataContext.User_Data_Tables where p.USER_NAME == ad && p.USER_PASSWORD == sifre select p;

            if (q.Any())
            {
                MessageBox.Show("Başarılı bir şekilde giriş yaptınız...");
                return true;
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı adını ve şifreyi doğru giriniz...");
                return false ;
            }
        }

        public void sendPasswordMail()
        {
            sendPassword(userModel.Email.ToString());
        }

        public string sifre=null;
        private bool sendPassword(String mail)
        {
           
            var q = from p in usDataContext.User_Data_Tables where p.USER_MAIL == mail select p;
          
            if(q.Any())
            {
                
                foreach (var maillist in q)
                {
                    

                    if (maillist.USER_MAIL.Equals(mail))
                    {
                        maillist.USER_PASSWORD=sifre;
                        break;
                    }  
                }

                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    
                    Credentials = new NetworkCredential("clientserver40@gmail.com", "123456asd."),
                    EnableSsl = true

                };

                client.Send("mail@dpu.edu.tr", mail, "Şifre Sıfırlama", sifre);
                MessageBox.Show(mail +" mail adresinize şifre bilgileri gönderilmiştir...");
                return true;

            }
            else
            {
                MessageBox.Show("Kayıtlı e-posta adresi yok, lütfen tekrar deneyiniz!!!");
                return false;
            }

        }


        public void listUser()
        {
            getUserlist(); 
        }

        private void getUserlist()
        {
            var q = from p in usDataContext.User_Data_Tables  select p;

            string[] array=new string[q.Count()];
           
            int i=0;
            while(i<q.Count())
            {
                foreach (var userlist in q)
                {
                    array[i] = userlist.USER_NAME;//kullanıcı adlarını alarak bir diziye yazdırdık.
                    MessageBox.Show(array[i]);//burada test ettik alan verileri...

                    MainForm main = (MainForm)Application.OpenForms["MainForm"];
                    main.lstView_User.Items.Add(array[i]); //form uygulaması açıkken kullanıcı adlarını listview e veri ekleme işlemleri
                }
                break;
                    
                
            }


            
        }

    }



}
