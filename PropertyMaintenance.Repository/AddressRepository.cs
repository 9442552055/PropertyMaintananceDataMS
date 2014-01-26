using PropertyMaintenance.Data.Entity;
using PropertyMaintenance.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyMaintenance.Repository
{
    public class AddressRepository:GenericRepository<Address>, IAddressRepository
      //  where Db: DbContext
    {
        public AddressRepository(DbContext Db)
            : base(Db)
        { 

        }
        
    }
}
