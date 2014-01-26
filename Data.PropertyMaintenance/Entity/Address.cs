using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyMaintenance.Data.Entity
{
   public  class Address:IdBasedEntity
    {
        public string PersonName{get;set;}
        public string DoorNumber{ get; set; }
        public string Street { get; set; }
        public string Area { get; set; }
        public string City{get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}
