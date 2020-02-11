using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankTest.Models;

namespace BankTest.Services.UserService
{
    interface IUserservice
    {
        User Create(User user);

        List<User> Read();

        User read(int id);

        User update(int id, User user);

        User delete(int id);
    }
}
