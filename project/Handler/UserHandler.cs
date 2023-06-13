using project.Factory;
using project.Model;
using project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project.Handler
{
    public class UserHandler
    {
        public static void RegisterUser(string userName, string email, string gender, string password)
        {
            user user= UserFactory.CreateUser(userName, email, gender, password);
            UserRepository.RegisterUser(user);
        }
    }
}