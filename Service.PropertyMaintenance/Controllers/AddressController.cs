using PropertyMaintenance.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace PropertyMaintenance.Service.Controllers
{
    public class AddressController : ApiController
    {
        public AddressController(IRepository.IAddressRepository addressRepository) 
        {
 
        }

        // GET api/address
        public HttpResponseMessage GetAddresses()
        {
            Address[] Addresses=  new Address[] { new Address{},new Address{} };
            return Request.CreateResponse(HttpStatusCode.OK, Addresses, JsonMediaTypeFormatter.DefaultMediaType);
        }

        // GET api/address/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/address
        public void Post([FromBody]string value)
        {
        }

        // PUT api/address/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/address/5
        public void Delete(int id)
        {
        }
    }
}
