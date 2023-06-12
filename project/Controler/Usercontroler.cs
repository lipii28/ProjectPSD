using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project.Controler
{
    public class Usercontroler
    {
        public static string Validasi(string nama, string email, string password, string confirm, string gender)
        {
            if (nama.Length < 5 || nama.Length > 15)
            {
                return "Nama Kureng";
            }
            else if (email.EndsWith(".com"))
            {
                return "Email Salah";
            }
            else if (gender == null)
            {
                return "Punya Gender Tidak ?";
            }
            else if (password == confirm) 
            {
                return "Password Salah";
            }
            else if(confirm == password)
            {
                return "Password Salah";
            }
            else
            {
                return "Sukses Sekale";
            }

        }
    }
}