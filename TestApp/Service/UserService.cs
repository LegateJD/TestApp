using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using TestApp.Models;

namespace TestApp.Service
{
    public class UserService
    {
        private readonly IDbConnection _dbConection;

        public UserService(IDbConnection dbConection)
        {
            _dbConection = dbConection;
        }

        public IEnumerable<User> GetAll()
        {
            var sql = "select user_id UserId, phone, first_name FirstName, last_name LastName from users";

            var users = _dbConection.Query<User>(sql);

            return users;
        }
    }
}
