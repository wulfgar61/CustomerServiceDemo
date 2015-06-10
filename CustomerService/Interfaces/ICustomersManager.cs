using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerService.Model.Dtos;

namespace CustomerService.Interfaces
{
    public interface ICustomersManager
    {
        int Create(Customer customer);
        Customer Get(int customerId);
        List<Customer> List();
        void Update(Customer customer);
        void Delete(int customerId);
    }
}
