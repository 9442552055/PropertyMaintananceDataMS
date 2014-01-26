using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyMaintenance.Data.Entity
{
    public class Block:IdBasedEntity
    {
        public long ApartmentId { get; set; }
        public string BlockName { get; set; }
        public int NumOfFloors { get; set; }

        //Virtual Properties

        public virtual Apartment Apartment { get; set; }
    }
}



