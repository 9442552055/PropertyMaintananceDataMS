using PropertyMaintenance.Data.Entity;
using PropertyMaintenance.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyMaintenance.Repository
{
    public class GenericRepository<Entity> : IGenericRepository<Entity>
       // where DataContext : DbContext
        where Entity : IdBasedEntity

    {
        private DbContext _context;
        protected DbContext Contect { get { return _context; } }
        public GenericRepository(DbContext Context)
        {
            this._context = Context;
        }

        public DbSet<Entity> GetTable()
        {
            return _context.Set<Entity>();
        }
        public DbSet<JoinEntity> GetJoinTable<JoinEntity>() where JoinEntity : IdBasedEntity {
            return _context.Set<JoinEntity>();
        
        }

        public virtual IQueryable<Entity> GetAll()
        {
            return _context.Set<Entity>();
        }

        public virtual IQueryable<Entity> GetAllBy(System.Linq.Expressions.Expression<Func<Entity, bool>> predicate)
        {
            return _context.Set<Entity>().Where(predicate);
        }

        public virtual void Add(Entity entity)
        {
            _context.Set<Entity>().Add(entity);
        }

        public virtual void Delete(Entity entity)
        {
            try
            {
                _context.Set<Entity>().Remove(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                //throw new Exception(HttpStatusCode.NotFound.ToString());
            }
        }

        public virtual void Delete(List<Entity> entities)
        {
            try
            {
                foreach (Entity entity in entities.ToList())
                {
                    _context.Set<Entity>().Remove(entity);
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
               // throw new Exception(HttpStatusCode.NotFound.ToString());
            }
        }


        public virtual void Save(List<Entity> entities)
        {
            foreach (Entity entity in entities.ToList())
            {
                _context.Set<Entity>().Add(entity);
            }
            _context.SaveChanges();
        }

        public virtual Entity Save(Entity entity)
        {
            _context.Set<Entity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public virtual string Save()
        {
            List<string> Errors = new List<string>();
            try
            {
                _context.SaveChanges();
                return string.Empty; ;
            }

            catch (DbEntityValidationException dbEx)
            {

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Errors.Add(string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage));
                    }
                }
                return string.Join(",", Errors.ToArray()); ;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual Entity GetById(int id)
        {
            //try
            //{
                return _context.Set<Entity>().Find(id);
            //}
            //catch (Exception ex)
            //{
                //throw new Exception(HttpStatusCode.NotFound.ToString());
            //}

        }

        public virtual void DeleteById(int id)
        {
            try
            {
                var entity = _context.Set<Entity>().Find(id);
                _context.Set<Entity>().Remove(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
               // throw new Exception(HttpStatusCode.NotFound.ToString());
            }
        }

        public virtual void DeleteByIds(List<int> ids)
        {
            try
            {
                foreach (var id in ids)
                {
                    var entity = _context.Set<Entity>().Find(id);
                    _context.Set<Entity>().Remove(entity);
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
              //  throw new Exception(HttpStatusCode.NotFound.ToString());
            }
        }

        public virtual void Edit(Entity entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public virtual Entity Update(Entity entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }

        public virtual void Update(List<Entity> entities)
        {
            foreach (Entity entity in entities.ToList())
            {
                _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            }
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context != null)
                _context.Dispose();
        }
    }
}
