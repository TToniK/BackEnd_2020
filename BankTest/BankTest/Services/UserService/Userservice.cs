using BankTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankTest.Repositories;
using BankTest.Authentication;

namespace BankTest.Services.UserService
{
    public class Userservice : IUserservice
    {
        private readonly IUserrepository _userrepository;

        public Userservice(IUserrepository userrepository)
        {
            _userrepository = userrepository;
        }
        public User Create(User user)
        {
            user.Salt = PasswordHash.MakeSalt();
            user.PswHash = PasswordHash.HashPassword(user.PswHash, user.Salt);
            return _userrepository.Create(user);
        }

        public User delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> Read()
        {
            throw new NotImplementedException();
        }

        public User read(int id)
        {
            throw new NotImplementedException();
        }

        public User update(int id, User user)
        {
            throw new NotImplementedException();
        }
    }
}
