using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResturentPos.controllers;
//using static yourNameSpace.YourClass;

namespace ResturentPos.controllers
{
    class authController
    {
        //db controller instance
        dbController user = new dbController();

        public Array AuthanticateUser(string userName , string password)
        {
            var authUser = new string[4];
            authUser = (string[]) user.getUser("select * from users where users.userName = '" + userName + "';");

            var userData = new string[2];

            //get user password
            userData[0] = authUser[3];

            //get user type
            userData[1] = authUser[2];
            return userData;
        }
    }
}
