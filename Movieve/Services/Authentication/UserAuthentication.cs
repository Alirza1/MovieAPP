using Movieve.Models;
using Movieve.Services.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Movieve.Services
{
    public class UserAuthentication
    {
        public bool CheckCredentials(string username, string password)
        {
            List<User> users = new List<User>();
            users = JsonSerialization.JsonDeserialize("users.json");
            foreach (var user in users)
            {
                if (user.Username == username)
                {
                    if (user.Password == password)
                    {
                        MessageBox.Show($" Welcome {user.Username}","Info");
                        return true;
                    }
                }
            }
            MessageBox.Show("Not Found");   
            return false;

        }
        public void UserSerialize()
        {
            List<User> users = new List<User>()
            {
                new User()
                {
                    Username = "aallirza",
                    Password = "alirza1234",
                },
                new User()
                {
                    Username = "elvincamalzade",
                    Password = "elvin1234",
                },
            };
            JsonSerialization.JsonSerialize(users, "users.json");
        }
    }
}
