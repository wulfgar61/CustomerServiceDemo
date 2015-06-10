using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomerService.Model.Dtos;
using ServiceStack;

namespace CustomerService.Model.Messages
{
    [Route("/Customers/{CustomerId}", "GET")]
    public class GetCustomer
        : IReturn<GetCustomerResponse>
    {
        public int CustomerId { get; set; }
    }

    public class GetCustomerResponse
    {
        public Customer Customer { get; set; }
    }
}