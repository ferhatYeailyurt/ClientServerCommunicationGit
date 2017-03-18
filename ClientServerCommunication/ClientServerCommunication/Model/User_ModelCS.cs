using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientServerCommunication.Model
{
    class User_ModelCS
    {
        private String ad;
        private String soyad;
        private String email;
        private String sifre;

        public string Ad
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value;
            }
        }

        public string Soyad
        {
            get
            {
                return soyad;
            }

            set
            {
                soyad = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Sifre
        {
            get
            {
                return sifre;
            }

            set
            {
                sifre = value;
            }
        }
    }
}
