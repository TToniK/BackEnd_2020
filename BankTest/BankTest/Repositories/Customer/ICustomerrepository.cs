using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankTest.Models;

namespace BankTest.Repositories
{
    public interface ICustomerrepository
    {
        Customer Create(Customer customer);

        List<Customer> Read();

        Customer Read(int id);

        Customer Update(int id, Customer customer);

        Customer Delete(int id);
    }
}
