﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using ShopManager.Models;

namespace ShopManager.Repositories
{
    public class GenericClass<TEntity>  where TEntity:class
   {
       private DBModel _context;
       private DbSet<TEntity> _table;

       public GenericClass(DBModel context)
       {
           _context = context;
           _table = context.Set<TEntity>();
       }


       public  virtual void Create(TEntity entity)
       {
            _table.Add(entity);
       }

       public virtual void Update(TEntity entity)
       {
           _table.Attach(entity);
           _context.Entry(entity).State = EntityState.Modified;
       }

       public virtual TEntity GetById(object id)
       {
           return _table.Find(id);
       }

       public virtual void Delete(TEntity entity)
       {
           if (_context.Entry(entity).State == EntityState.Detached)
           {
               _table.Attach(entity);
           }
           _table.Remove(entity);
       }


       public virtual void DeleteById(object id)
       {
           var entity = GetById(id);
            Delete(entity);
       }


       public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> whereVariable = null,
           Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderbyVariable = null, string joinString = "")
       {
           IQueryable<TEntity> query = _table;

           if (whereVariable != null)
           {
               query = query.Where(whereVariable);

           }

           if (orderbyVariable !=null)
           {
               query = orderbyVariable(query);
           }

           if (joinString != null)
           {
               foreach (string item in joinString.Split(','))
               {
                   query = query.Include(item);
               }
           }

           return query.ToList();
       }
   }
}
