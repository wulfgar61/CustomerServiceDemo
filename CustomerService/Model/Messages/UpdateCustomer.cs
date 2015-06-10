using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomerService.Model.Dtos;
using ServiceStack;

namespace CustomerService.Model.Messages
{
    [Route("/Customers", "PUT")]
    public class UpdateCustomer
        : IReturnVoid
    {
        public Customer Customer { get; set; }
    }
}