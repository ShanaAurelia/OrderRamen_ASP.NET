using PSD_LAB_PROJECT.Model;
using PSD_LAB_PROJECT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB_PROJECT.Handler
{
    public class UserHandler
    {
        public static User createUserHandler(string username, string email, string gender, string password)
        {
            return UserRepository.CreateUserRepo(username, email, gender, password);
        }

        public static User loginUserHandler(string username)
        {
            return UserRepository.getUserLogin(username);
        }

        public static List<UserOutput> getDataForStaff()
        {
            return UserRepository.dataForStaff();
        }

        public static List<UserOutput> getDataForAdmin()
        {
            return UserRepository.dataForAdmin();
        }
    }
}