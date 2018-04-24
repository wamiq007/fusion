using Fusion.Domain.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fusion.Data;

namespace Fusion.Domain.Users
{
    public class UserService
    {
        FusionDBEntities db;
        public UserService()
        {
            db = new FusionDBEntities();
        }

        public UsersModel ValidateUser(string username, string password)
        {
            var user = db.Users.Where(p => p.Username == username && p.Password == password);
            return ProjectUsersModel(user).FirstOrDefault();
        }


        public IEnumerable<UsersModel> GetAllUsers()
        {
            return ProjectUsersModel(db.Users);
        }

        private IQueryable<UsersModel> ProjectUsersModel(IQueryable<User> users)
        {
            return from user in users
                   select new UsersModel
                   {
                       EmailAddress = user.EmailAddress,
                       UserID = user.UserID,
                       Username = user.Username,
                       FirstName = user.FirstName,
                       LastName = user.LastName
                   };
        }
    }
}
