using BankTest.Models;
using BankTest.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankTest.Services.BankService
{
    public class Bankservice : IBankservice
    {
        private readonly IBankrepository _bankrepository;
        private IBankrepository bankrepository;

        public Bankservice(IBankrepository _bankrepository)
        {
            _bankrepository = bankrepository;
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
            throw new NotImplementedException();
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
