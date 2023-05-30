using PSD_LAB_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB_PROJECT.Factory
{
    public class UserFactory
    {
        public static User CreateUserFactory(string username, string email, string gender, string password)
        {
            User newUser = new User();
            newUser.Username = username;
            newUser.Password = password;
            newUser.Gender = gender;
            newUser.Email = email;
            newUser.RoleId = 3;
            return newUser;
        }
    }
}