using MVCJsonResult.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCJsonResult.Services
{
    public class UserService
    {
        public static List<UserModel> GetUsers()
        {

            var users = new List<UserModel>
            {
                new UserModel
                {
                    UserName="ali",
                    Email ="test1@test.com"

                },
                new UserModel
                {
                    UserName="Sezgin",
                    Email ="test2@test.com"

                },
                new UserModel
                {
                    UserName="Murat",
                    Email ="test3@test.com"

                }
            };
            return users;


        }
    }
}