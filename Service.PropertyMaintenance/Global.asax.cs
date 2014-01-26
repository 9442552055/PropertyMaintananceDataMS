using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PropertyMaintenance.Service.Controllers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dependencies;
using System.Web.Optimization;
using System.Web.Routing;

namespace PropertyMaintenance.Service
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //AreaRegistration.RegisterAllAreas();
           
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            GlobalConfiguration.Configuration.DependencyResolver = new ApiDependencyResolver();
           // FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
           // RouteConfig.RegisterRoutes(RouteTable.Routes);
           // BundleConfig.RegisterBundles(BundleTable.Bundles);
           // AuthConfig.RegisterAuth();
        }
    }

    public class ApiDependencyResolver : IDependencyResolver
    {
        private PropertyMaintenance.IRepository.IAddressRepository _addressRepository;
        
        public IDependencyScope BeginScope()
        {
            // This example does not support child scopes, so we simply return 'this'.
            return this;
        }

        public object GetService(Type serviceType)
        {
            Data.PropertyMaintenanceContext Db = new Data.PropertyMaintenanceContext("DefaultConnection");
            if (serviceType == typeof(AddressController))
            {
                if (_addressRepository == null) _addressRepository = new PropertyMaintenance.Repository.AddressRepository(Db);
                return new AddressController(_addressRepository);
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return new List<object>();
        }

        public void Dispose()
        {
            // When BeginScope returns 'this', the Dispose method must be a no-op.
        }
    }
}