﻿using FileShare.DataAccess.Base.Model;
using FileShare.DataAccess.Base.Model.BaseEntity;
using FileShare.DataAccess.Base.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace FileShare.DataAccess.Base.Repository
{
    /// <summary>
    /// Abstract base class for easy, and fast creation of repositories.
    /// </summary>
    /// <typeparam name="TModel">The database model which the repository manages.</typeparam>
    /// <typeparam name="TContext">The database context which the repository makes the changes to.</typeparam>
    public abstract class RepositoryBase<TModel, TContext> : IRepositoryBase<TModel>
        where TModel : BaseEntity
        where TContext : BaseContext<TContext>, new()
    {
        protected TContext context;

        public RepositoryBase(TContext context)
        {
            this.context = context;
        }


        // Create
        public virtual async Task AddAsync(TModel model, CancellationToken cancellationToken = default)
        {
            await context.AddAsync(model, cancellationToken);
        }

        // Read
        public virtual async Task<TModel> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await context.Set<TModel>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        // Update
        public virtual void Update(TModel model)
        {
            context.Update(model);
        }

        // Delete
        public virtual void Remove(TModel model)
        {
            context.Remove(model);
        }

        // Delete
        public virtual void RemoveById(Guid id)
        {
            var model = context.Set<TModel>().Where(x => x.Id == id).FirstOrDefault();
            context.Remove(model);
        }

        // Exists
        public virtual async Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await context.Set<TModel>().Where(x => x.Id == id).AsNoTracking().Select(x => x.Id).AnyAsync(cancellationToken);
        }
    }
}