using AngularTrainingApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace AngularTrainingApi.Repositories
{
    public static class UserAuthRepository
    {
        public static UserAuth Get(string userName, string password)
        {
            var users = new List<UserAuth>();
            users.Add(new UserAuth { Id = 1, UserName = "batman", Password = "batman", Role = "manager" });
            users.Add(new UserAuth { Id = 2, UserName = "robin", Password = "robin", Role = "employee" });
            return users.Where( user => user.UserName.ToLower() == userName && user.Password == password).FirstOrDefault();
        }
    }
}
