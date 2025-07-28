using Fermat.EntityFramework.AuditLogs.Domain.Entities;
using Fermat.EntityFramework.Shared.Interfaces;

namespace Fermat.EntityFramework.AuditLogs.Domain.Interfaces.Repositories;

/// <summary>
/// Repository interface for managing audit logs.
/// </summary>
public interface IAuditLogRepository : IRepository<AuditLog, Guid>
{
}