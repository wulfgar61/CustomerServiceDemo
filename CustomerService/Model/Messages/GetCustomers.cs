using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomerService.Model.Dtos;
using ServiceStack;

namespace CustomerService.Model.Messages
{
    [Route("/Customers", "GET")]
    public class GetCustomers
        : IReturn<GetCustomersResponse>
    {
    }

    public class GetCustomersResponse
    {
        public List<Customer> Customers { get; set; }
    }
}