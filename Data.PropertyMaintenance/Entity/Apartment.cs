using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyMaintenance.Data.Entity
{
    public class Apartment : IdBasedEntity
    {
        public string ApartmentName { get; set; }
        public long ApartmentAddressId { get; set; }
        public long? ApartmentContactId { get; set; }

        //Virtual Properties
        public virtual Address ApartmentAddress { get; set; }
        public virtual Contact ApartmentContact { get; set; }
    }
}
