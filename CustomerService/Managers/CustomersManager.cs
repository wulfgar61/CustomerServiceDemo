using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomerService.Interfaces;
using CustomerService.Model.Dtos;

namespace CustomerService.Managers
{
    public class CustomersManager
        : ICustomersManager
    {
        private readonly ICustomersRepository customersRepository;

        public CustomersManager(ICustomersRepository customersRepository)
        {
            this.customersRepository = customersRepository;
        }

        public int Create(Customer customer)
        {
            return this.customersRepository.Create(customer);
        }

        public Customer Get(int customerId)
        {
            return this.customersRepository.Get(customerId);
        }

        public List<Customer> List()
        {
            return this.customersRepository.List();
        }

        public void Update(Customer customer)
        {
            this.customersRepository.Update(customer);
        }

        public void Delete(int customerId)
        {
            this.customersRepository.Delete(customerId);
        }
    }
}