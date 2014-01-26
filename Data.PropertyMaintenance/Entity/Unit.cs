using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyMaintenance.Data.Entity
{
    public class Unit : IdBasedEntity
    {
        public string UnitName { get; set; }
        public string UnitDesctiption { get; set; }
        public decimal RentableAmount { get; set; }

        public long BlockId { get; set; }
        public long UnitTypeCodeValueId { get; set; }
        public long UnitStatusCodeValueId { get; set; }
        public long OwnerContactId { get; set; }

        public virtual Block Block { get; set; }
        public virtual CodeValue UnitTypeCodeValue { get; set; }
        public virtual CodeValue UnitStatusCodeValue { get; set; }
        public virtual Contact OwnerContact { get; set; }
    }
}

