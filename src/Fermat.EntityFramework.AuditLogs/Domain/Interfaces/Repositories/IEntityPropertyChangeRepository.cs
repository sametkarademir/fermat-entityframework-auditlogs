using Fermat.EntityFramework.AuditLogs.Domain.Entities;
using Fermat.EntityFramework.Shared.Interfaces;

namespace Fermat.EntityFramework.AuditLogs.Domain.Interfaces.Repositories;

/// <summary>
/// Repository interface for managing entity property changes.
/// </summary>
public interface IEntityPropertyChangeRepository : IRepository<EntityPropertyChange, Guid>
{
}