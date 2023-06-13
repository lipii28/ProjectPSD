using project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project.Factory
{
    public class UserFactory
    {
        public static user CreateUser(string username, string email, string gender, string password) 
        {
            user User = new user();

            User.userName = username;
            User.userEmail = email;
            User.userGender = gender;
            User.userPassword = password;

            return User;
        }
    }
}