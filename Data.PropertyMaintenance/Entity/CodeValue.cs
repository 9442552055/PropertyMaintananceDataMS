using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyMaintenance.Data.Entity
{
    public class CodeValue : IdBasedEntity
    {
        public string Code { get; set; }
        public int Key { get; set; }
        public string Value { get; set; }
    }
}
