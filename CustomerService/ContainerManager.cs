using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomerService.Interfaces;
using CustomerService.Managers;
using CustomerService.Repositories;
using Funq;

namespace CustomerService
{
    public static class ContainerManager
    {
        public static void Register(Container container)
        {
            //repos
            container.RegisterAutoWiredAs<CustomersRepository, ICustomersRepository>();

            //managers
            container.RegisterAutoWiredAs<CustomersManager, ICustomersManager>();
        }
    }
}