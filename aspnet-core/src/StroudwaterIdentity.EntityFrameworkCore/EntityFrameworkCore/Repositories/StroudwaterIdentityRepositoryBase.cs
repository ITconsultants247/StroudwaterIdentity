using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;

namespace StroudwaterIdentity.EntityFrameworkCore.Repositories
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class StroudwaterIdentityRepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<StroudwaterIdentityDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected StroudwaterIdentityRepositoryBase(IDbContextProvider<StroudwaterIdentityDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Add your common methods for all repositories
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="StroudwaterIdentityRepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class StroudwaterIdentityRepositoryBase<TEntity> : StroudwaterIdentityRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected StroudwaterIdentityRepositoryBase(IDbContextProvider<StroudwaterIdentityDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Do not add any method here, add to the class above (since this inherits it)!!!
    }
}
