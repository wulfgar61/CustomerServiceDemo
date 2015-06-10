using System.Reflection;
using CustomerService.Interfaces;
using CustomerService.Managers;
using CustomerService.Repositories;
using CustomerService.Services;
using Funq;
using ServiceStack;
using ServiceStack.Text;
using ServiceStack.Validation;

namespace CustomerService
{
    public class AppHost
        : AppHostBase
    {
        public AppHost() : base("Customer Service", typeof(CustomersService).Assembly)
        {
        }

        public override void Configure(Container container)
        {
            JsConfig.EmitCamelCaseNames = true;
            JsConfig.DateHandler = DateHandler.ISO8601;

            //plugins
            base.Plugins.Add(new ValidationFeature());
            base.Plugins.Add(new PostmanFeature());

            ContainerManager.Register(container);
        }
    }
}