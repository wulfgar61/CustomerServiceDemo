using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomerService.Interfaces;
using CustomerService.Model.Dtos;

namespace CustomerService.Repositories
{
    public class CustomersRepository
        : ICustomersRepository
    {
        private List<Customer> customers;
        private int currentId;

        private object padlock = new object();

        public CustomersRepository()
        {
            this.customers = new List<Customer>()
            {
                new Customer() { Id = 1, Name = "Jeff Green", UserName = "GreenGuy", Email = "GreenGuy@blah.com"},
                new Customer() { Id = 2, Name = "Jeff D", UserName = "JeffDude", Email = "JeffDude@blah.com"},
                new Customer() { Id = 3, Name = "James S", UserName = "JamesBro", Email = "JamesBro@blah.com"},
                new Customer() { Id = 4, Name = "Billy K", UserName = "BillyC", Email = "BillyC@blah.com"},
            };

            this.currentId = 5;
        }

        public int Create(Customer customer)
        {
            lock (this.padlock)
            {
                var existingCustomer = this.customers.SingleOrDefault(c => c.UserName.ToLower() == customer.UserName.ToLower());

                if (existingCustomer == null)
                {
                    customer.Id = this.currentId;
                    this.customers.Add(customer);
                    this.currentId++;     
                }
                else
                {
                    throw new Exception("UserName already exists!");
                }
                
            }

            return customer.Id;
        }

        public Customer Get(int customerId)
        {
            lock (this.padlock)
            {
                return this.customers.SingleOrDefault(c => c.Id == customerId); 
            }
        }

        public List<Customer> List()
        {
            lock (this.padlock)
            {
                return this.customers; 
            }
        }

        public void Update(Customer customer)
        {
            lock (this.padlock)
            {
                Customer existingCustomer = null;

                if (customer.Id > 0)
                {
                    existingCustomer = this.customers.SingleOrDefault(c => c.Id == customer.Id);
                }
                else if (!string.IsNullOrWhiteSpace(customer.UserName))
                {
                    existingCustomer = this.customers.SingleOrDefault(c => c.UserName.ToLower() == customer.UserName.ToLower());
                }

                if (existingCustomer != null) existingCustomer = customer; 
            }
        }

        public void Delete(int customerId)
        {
            lock (this.padlock)
            {
                var existingCustomer = this.customers.SingleOrDefault(c => c.Id == customerId);

                if (existingCustomer != null) this.customers.Remove(existingCustomer);
            }
        }
    }
}