using DataBase.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DateBase.EfEntityFaremworkBase
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addcontext = context.Entry(entity);
                addcontext.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context= new TContext())
            {
                var deleteContext = context.Entry(entity);
                deleteContext.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updateContext = context.Entry(entity);
                updateContext.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
