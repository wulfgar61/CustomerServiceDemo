using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;

namespace CustomerService.Model.Messages
{
    [Route("/Customers/{CustomerId}", "DELETE")]
    public class DeleteCustomer
        : IReturnVoid
    {
        public int CustomerId { get; set; }
    }
}