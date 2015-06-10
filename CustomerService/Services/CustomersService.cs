using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomerService.Interfaces;
using CustomerService.Model.Messages;
using ServiceStack;

namespace CustomerService.Services
{
    public class CustomersService
        : Service
    {
        private readonly ICustomersManager customersManager;

        public CustomersService(ICustomersManager customersManager)
        {
            this.customersManager = customersManager;
        }

        public GetCustomerResponse Get(GetCustomer request)
        {
            var customer = this.customersManager.Get(request.CustomerId);
            return new GetCustomerResponse() { Customer = customer };
        }

        public GetCustomersResponse Get(GetCustomers request)
        {
            var customers = this.customersManager.List();
            return new GetCustomersResponse() { Customers = customers };
        }

        public CreateCustomerResponse Post(CreateCustomer request)
        {
            int customerId = this.customersManager.Create(request.Customer);
            return new CreateCustomerResponse(){ CustomerId = customerId};
        }

        public void Put(UpdateCustomer request)
        {
            this.customersManager.Update(request.Customer);
        }

        public void Delete(DeleteCustomer request)
        {
            this.customersManager.Delete(request.CustomerId);
        }
    }
}