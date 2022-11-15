﻿using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Project.Core.Configurations.Entity;
using Project.Data;

//using AIH.ERP.Analytic.Domain.Common.Configurations;

//using AIH.ERP.Analytic.Core.Configurations.Entity;

namespace Project.DataAccess.Repository
{
    public class Repository<T> : IRepository<T>
        where T : class,IEntity, new()
    {
        private readonly ApplicationDbContext _context;
        private bool _isQueryFilterApplied = true;
        private bool _isAsNoTrackingApplied;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void SetGlobalQueryFilterStatus(bool status)
        {
            this._isQueryFilterApplied = status;
        }
        public void SetAsNoTrackingStatus(bool status)
        {
            this._isAsNoTrackingApplied = status;
        }
        public virtual IQueryable<T> GetAll()
        {
            return _context.Set<T>().ApplyQueryFilter(this._isQueryFilterApplied);
        }
        public virtual IQueryable<T> GetAll(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied);
            foreach (var includeProperty in includeProperties) query = query.IncludeAll(includeProperty);
            return query;
        }

        public virtual IQueryable<T> GetAll(params string[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied);
            foreach (var includeProperty in includeProperties) query = query.IncludeAll(includeProperty);
            return query;
        }

        public virtual async Task<int> CountAsync()
        {
            return await _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied).CountAsync();
        }
        public virtual async Task<int> CountAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied).CountAsync(predicate);
        }

        public virtual async Task<int> CountAsync(Expression<Func<T, bool>> predicate,
            params string[] includeProperties)
        {

            return await _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied).IncludeAll(includeProperties).CountAsync(predicate);
        }

        public Task<T?> GetFirstAsync()
        {
            return _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied).FirstOrDefaultAsync();
        }


        public virtual Task<T?> GetFirstAsync(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied).FirstOrDefaultAsync(predicate);
        }
        public virtual Task<T?> GetFirstAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied).IncludeAll(includeProperties);

            return query.FirstOrDefaultAsync(predicate);
        }

        public virtual Task<T?> GetFirstAsync(Expression<Func<T, bool>> predicate, params string[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied).IncludeAll(includeProperties);


            return query.FirstOrDefaultAsync(predicate);
        }

        public virtual Task<T> GetSingleLastAsync(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied);
            return query.LastOrDefaultAsync(predicate);
        }

        public Task<T?> GetSingleLastAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied).IncludeAll(includeProperties);
            return query.LastOrDefaultAsync(predicate);
        }

        public Task<T?> GetSingleLastAsync(Expression<Func<T, bool>> predicate, params string[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied).IncludeAll(includeProperties);
            return query.LastOrDefaultAsync(predicate);
        }

        public virtual Task<T?> GetSingleLastAsync()
        {
            IQueryable<T> query = _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied);
            return query.LastOrDefaultAsync();
        }


        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied).Where(predicate);
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {

            IQueryable<T> query = _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied).IncludeAll(includeProperties);
            return query.Where(predicate);
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate, params string[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied).IncludeAll(includeProperties);
            return query.Where(predicate);
        }

        public virtual Task<bool> IsExistAsync(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied).AnyAsync(predicate);
        }
        public virtual Task<bool> IsExistAsync(Expression<Func<T, bool>> predicate,
            params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied).IncludeAll(includeProperties);
            return query.AnyAsync(predicate);
        }

        public Task<bool> IsExistAsync(Expression<Func<T, bool>> predicate, params string[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied).IncludeAll(includeProperties);
            return query.AnyAsync(predicate);
        }

        public virtual async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity).ConfigureAwait(false);
        }
        public virtual Task AddRangeAsync(List<T> entity)
        {
            return _context.Set<T>().AddRangeAsync(entity);
        }
        public virtual void Update(T entity)
        {
            EntityEntry dbEntityEntry = _context.Entry<T>(entity);
            dbEntityEntry.State = EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            EntityEntry dbEntityEntry = _context.Entry<T>(entity);
            dbEntityEntry.State = EntityState.Deleted;
            // _context.Set<T>(this.isQueryFilterApplied).Remove(entity);
            // entity.Status = RecordStatus.Deleted;
            // entity.DateDeleted=DateTime.Now;

        }
        public virtual void DeleteWhere(Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> entities = _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied).Where(predicate);
            foreach (var entity in entities)
            {
                this.Delete(entity);
            }
            // _context.Set<T>(this.isQueryFilterApplied).RemoveRange(entities);
        }
        /// <summary>
        /// Get a table
        /// </summary>
        public IQueryable<T> Table => _context.Set<T>().ApplyAsNoTracking(this._isAsNoTrackingApplied).ApplyQueryFilter(this._isQueryFilterApplied);


    }
}
