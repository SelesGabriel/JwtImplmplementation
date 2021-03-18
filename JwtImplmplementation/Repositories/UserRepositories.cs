using JwtImplmplementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtImplmplementation.Repositories
{
    public class UserRepositories
    {
        public static User GetUser(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "selesgabriel", Password = "teste", Role = "Chefe" });
            users.Add(new User{ Id = 2, Username = "selesgabriel2", Password = "teste2", Role = "Funcionário" });
            return users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
        }
    }
}
