using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    //kısıtladık
    public class EfEntityRepositoryBase<TEntity, TContext>  : IEntityRepository<TEntity> 
        where TEntity: class,IEntity,new()
        where TContext :DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext()) //Belleği hızlıca temizlemek
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter); //Bu filtreyi oraya uygula. Product döndürecek
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                //filtre göndermediys db bütün verileri getir. filtre varsa filtrelenenleri getir.
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();  //ToList gelmesi için using system LINQ
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext()) //Belleği hızlıca temizlemek
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
