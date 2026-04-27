using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabFood
{
    public class userInfo
    {
        public static List<(string Username, string Password, string Phone, string Address)> 
        Users = new List<(string, string, string, string)>();

        public static void AddUser(string username, string password, string phone, string address)
        {
            Users.Add((username, password, phone, address));
        }

        public static bool ValidateUser(string username, string password)
        {
            return Users.Any(user => user.Username == username && user.Password == password);
        }


    }
}