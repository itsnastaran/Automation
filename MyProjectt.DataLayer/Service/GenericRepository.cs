﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace MyProjectt.DataLayer.Service
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        
            private projectmainEntities2 _db;
            private DbSet<TEntity> _dbSet;
            public GenericRepository(projectmainEntities2 context)
            {
                _db = context;
                _dbSet = _db.Set<TEntity>();
            }

            public virtual TEntity GetByID(object ID)
            {
                return _dbSet.Find(ID);
            }
            public virtual bool Insert(TEntity entity)
            {
                try
                {
                    _dbSet.Add(entity);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            public virtual bool Delete(TEntity entity)
            {
                try
                {
                    if (_db.Entry(entity).State == EntityState.Detached)
                    {
                        _dbSet.Attach(entity);
                    }
                    _dbSet.Remove(entity);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            public virtual bool Delete(object ID)
            {
                try
                {
                    var result = GetByID(ID);
                    Delete(result);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public virtual bool Update(TEntity entity)
            {
                try
                {
                    if (_db.Entry(entity).State == EntityState.Detached)
                    {
                        _dbSet.Attach(entity);
                    }
                    _db.Entry(entity).State = EntityState.Modified;
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null)
            {
                IQueryable<TEntity> query = _dbSet;
                if (where != null)
                {
                    query = query.Where(where);
                }
                return query.ToList();
            }
        }
}



