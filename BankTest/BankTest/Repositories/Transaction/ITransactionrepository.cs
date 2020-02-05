using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankTest.Models;

namespace BankTest.Repositories
{
    public interface ITransactionrepository
    {
        Transaction Create(Transaction transaction);

        List<Transaction> Read();
    }
}
