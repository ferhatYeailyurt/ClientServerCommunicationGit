using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientServerCommunication;

using ClientServerCommunication.Model;
using ClientServerCommunication.db_objects;

namespace ClientServerCommunication.Controller
{
    class User_OperaitonsController
    {
        UserDBDataClassesDataContext usDataContext;
        User_Data_Table usDataTable;
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
                MessageBox.Show("İşlem Hatalı!!!");
            }

        }



    }
}
