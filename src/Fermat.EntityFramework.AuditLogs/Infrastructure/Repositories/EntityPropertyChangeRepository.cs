using Fermat.EntityFramework.AuditLogs.Domain.Entities;
using Fermat.EntityFramework.AuditLogs.Domain.Interfaces.Repositories;
using Fermat.EntityFramework.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Fermat.EntityFramework.AuditLogs.Infrastructure.Repositories;

/// <summary>
/// Repository implementation for managing entity property changes in the database.
/// </summary>
/// <typeparam name="TContext">The type of the database context.</typeparam>
public class EntityPropertyChangeRepository<TContext> : EfRepositoryBase<EntityPropertyChange, Guid, TContext>, IEntityPropertyChangeRepository where TContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EntityPropertyChangeRepository{TContext}"/> class.
    /// </summary>
    /// <param name="dbContext">The database context instance.</param>
    public EntityPropertyChangeRepository(TContext dbContext) : base(dbContext)
    {
    }
}