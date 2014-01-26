using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyMaintenance.Data
{
    public class PropertyMaintenanceContext: DbContext
    {
        public PropertyMaintenanceContext(string connection)
            : base(connection)
        {
 
        }

        public PropertyMaintenanceContext()
            : base()
        {

        }
    }
}
