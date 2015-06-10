using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomerService.Model.Dtos;

namespace CustomerService.Interfaces
{
    public interface ICustomersRepository
    {
        int Create(Customer customer);
        Customer Get(int customerId);
        List<Customer> List();
        void Update(Customer customer);
        void Delete(int customerId);
    }
}