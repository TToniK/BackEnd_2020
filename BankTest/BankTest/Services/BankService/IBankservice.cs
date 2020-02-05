using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankTest.Models;
using BankTest.Repositories;

namespace BankTest.Services
{
    interface IBankservice
    {
        Bank Create(Bank bank);

        List<Bank> Read();

        Bank Read(int id);

        Bank Update(int id, Bank bank);

        Bank Delete(int id);
    }
}
