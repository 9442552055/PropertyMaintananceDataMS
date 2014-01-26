using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyMaintenance.Data.Entity
{
    public abstract class IdBasedEntity : ITraceableEntity
    {
        public long Id { get; set; }

        public DateTime CreatedDTTM { get; set; }

        public DateTime? ModifiedTTM { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }
    }
}
