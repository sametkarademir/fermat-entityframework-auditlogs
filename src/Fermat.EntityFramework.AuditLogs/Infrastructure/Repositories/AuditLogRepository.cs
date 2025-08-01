using Fermat.EntityFramework.AuditLogs.Domain.Entities;
using Fermat.EntityFramework.AuditLogs.Domain.Interfaces.Repositories;
using Fermat.EntityFramework.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Fermat.EntityFramework.AuditLogs.Infrastructure.Repositories;

/// <summary>
/// Repository implementation for managing audit log entries in the database.
/// </summary>
/// <typeparam name="TContext">The type of the database context.</typeparam>
public class AuditLogRepository<TContext> : EfRepositoryBase<AuditLog, Guid, TContext>, IAuditLogRepository where TContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AuditLogRepository{TContext}"/> class.
    /// </summary>
    /// <param name="dbContext">The database context instance.</param>
    public AuditLogRepository(TContext dbContext) : base(dbContext)
    {
    }
}