﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Supply.DAL.Entities;

namespace Supply.DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        //IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        TEntity Add(TEntity entity);
        void Edit(TEntity entity);
        TEntity Delete(TEntity entity);
    }
}
