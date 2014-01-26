using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyMaintenance.Data.Entity
{
    public interface ITraceableEntity
    {
         DateTime CreatedDTTM { get; set; }
         DateTime? ModifiedTTM { get; set; }
         string CreatedBy { get; set; }
         string ModifiedBy { get; set; }
    }
}
