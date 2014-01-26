using PropertyMaintenance.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;

namespace PropertyMaintenance.IRepository
{
    public interface IGenericRepository<Entity> : IDisposable
        where Entity : IdBasedEntity
        //where Db : DbContext
    {
        DbSet<Entity> GetTable();
        DbSet<JoinEntity> GetJoinTable<JoinEntity>() where JoinEntity : IdBasedEntity;
        IQueryable<Entity> GetAll();
        //IQueryable<T> GetAllBy(Expression<Func<T, bool>> predicate);        
        Entity GetById(int id);
        void Add(Entity entity);
        void Edit(Entity entity);
        void Delete(Entity entity);
        void Delete(List<Entity> entities);
        void DeleteById(int id);
        Entity Update(Entity entity);
        string Save();
        void Save(List<Entity> entities);
        Entity Save(Entity entity);
        void Update(List<Entity> entities);
        void DeleteByIds(List<int> ids);
    }

}
