using project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project.Repository
{
    public class UserRepository
    {
        public static void registerUser(user user)
        {
            DatabaseEntities db = new DatabaseEntities();
            db.users.Add(user);
            db.SaveChanges();
        }

        internal static void RegisterUser(object newUser)
        {
            throw new NotImplementedException();
        }
    }
}