using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyMaintenance.Data.Entity
{
    public class Contact : IdBasedEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber1 { get; set; }
        public string MobileNumber2 { get; set; }
        public string EmailId1 { get; set; }
        public string EmailId2 { get; set; }
        public long TemporaryAddressId { get; set; }
        public long PermanantAddressId { get; set; }

        //Virtual Properties
        public virtual Address TemporaryAddress { get; set; }
        public virtual Address PermanantAddress { get; set; }
    }
}
