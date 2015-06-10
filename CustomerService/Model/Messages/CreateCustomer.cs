using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomerService.Model.Dtos;
using ServiceStack;

namespace CustomerService.Model.Messages
{
    [Route("/Customers", "POST")]
    public class CreateCustomer
        : IReturn<CreateCustomerResponse>
    {
        public Customer Customer { get; set; }
    }

    public class CreateCustomerResponse
    {
        public int CustomerId { get; set; }
    }
}