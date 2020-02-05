using BankTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankTest.Data;

namespace BankTest.Repositories
{
    public class Bankrepository : IBankrepository
    {
        private readonly BankdbContext _bankdbContext;

        public Bankrepository(BankdbContext bankdbContext)
        {
            _bankdbContext = bankdbContext;
        }
        public Bank Create(Bank bank)
        {
            throw new NotImplementedException();
        }

        public Bank Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bank> Read()
        {
            var banks = _bankdbContext.Bank.ToList();
            return banks;
        }

        public Bank Read(int id)
        {
            throw new NotImplementedException();
        }

        public Bank Update(int id, Bank bank)
        {
            throw new NotImplementedException();
        }
    }
}
