﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerService.Model.Dtos
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}