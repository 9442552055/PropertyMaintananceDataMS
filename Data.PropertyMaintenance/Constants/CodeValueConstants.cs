using PropertyMaintenance.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyMaintenance.Data.Constants
{
    public static class CodeValueConstants
    {
        public static class UnitStatus
        {
            public static CodeValue ReadyToOccupy = new CodeValue { Code = "Unit status", Value = "Ready to occupy", Key = 1 };
            public static CodeValue UnderConstruction = new CodeValue { Code = "Unit status", Value = "Under construction", Key = 2 };
            public static CodeValue OccupiedByOwner = new CodeValue { Code = "Unit status", Value = "Occupied by owner", Key = 3 };
            public static CodeValue OccupiedByTenant = new CodeValue { Code = "Unit status", Value = "Occupied by tenant", Key = 4 };
            public static CodeValue[] UnitStatuses = new CodeValue[] { 
                ReadyToOccupy,UnderConstruction,OccupiedByOwner,OccupiedByTenant
            };
        }

        public static class UnitType
        {
            public static CodeValue BHK1 = new CodeValue { Code = "Unit type", Value = "1 BHK", Key = 1 };
            public static CodeValue BHK2 = new CodeValue { Code = "Unit type", Value = "2 BHK", Key = 2 };
            public static CodeValue BHK3 = new CodeValue { Code = "Unit type", Value = "3 BHK", Key = 3 };
            public static CodeValue BHK4 = new CodeValue { Code = "Unit type", Value = "4 BHK", Key = 4 };
            public static CodeValue[] UnitTypes = new CodeValue[] { 
                BHK1,BHK2,BHK3,BHK4
            };
        }
    }
}
