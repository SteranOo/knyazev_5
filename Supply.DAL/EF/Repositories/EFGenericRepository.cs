﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Supply.DAL.Entities;
using Supply.DAL.Interfaces;

namespace Supply.DAL.EF.Repositories
{
    public class EFGenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected DbContext _dbcontext;
        protected readonly IDbSet<T> _dbset;

        public EFGenericRepository(DbContext context)
        {
            _dbcontext = context;
            _dbset = context.Set<T>();
        }

        public virtual T Get(int id)
        {
            return _dbset.FirstOrDefault(x => x.Id == id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbset.AsEnumerable();
        }

        //public virtual IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        //{
        //    return _dbset.Where(predicate).AsEnumerable();
        //}

        public virtual T Add(T entity)
        {
            return _dbset.Add(entity);
        }

        public void Edit(T entity)
        {
            _dbcontext.Entry(entity).State = EntityState.Modified;
        }

        public virtual T Delete(T entity)
        {
            return _dbset.Remove(entity);
        }
    }
}
