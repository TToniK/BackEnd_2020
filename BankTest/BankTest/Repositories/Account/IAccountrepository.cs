using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankTest.Models;

namespace BankTest.Repositories
{
    public interface IAccountrepository
    {
        Account Create(Account account);

        List<Account> Read();

        Account Read(int id);

        Account Update(int id, Account account);

        Account Delete(int id);
    }
}
