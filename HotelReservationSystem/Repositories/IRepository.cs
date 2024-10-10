﻿using HotelReservationSystem.Models;
using System.Linq.Expressions;

namespace HotelReservationSystem.Repositories
{
    public interface IRepository<T> where T : BaseModel
    {
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        IQueryable<TResult> Get<TResult>(Expression<Func<T, bool>> predicate,
            Expression<Func<T, TResult>> selector);
        IQueryable<T> GetByID(int id);
        T GetByIDWithTracking(int id);
        Task<T> First(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
        void HardDelete(int id);
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
