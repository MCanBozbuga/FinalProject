﻿
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // generic constraint -- generic=kısıtlama
    // class : referans tip
    // IEntity : IEntity olabilir veya IEntity implement eden bir nesne olabilir.
    //new() = new'lenebilir olmalı.
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity); //Referans olarak Prodct aldık. İnterfacelerin kendileri public değildir. Metotları public'dir.
        void Update(T entity);
        void Delete(T entity);
        
    }
}
