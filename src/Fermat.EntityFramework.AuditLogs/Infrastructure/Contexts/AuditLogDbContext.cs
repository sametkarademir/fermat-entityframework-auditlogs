using Fermat.EntityFramework.AuditLogs.Domain.Entities;
using Fermat.EntityFramework.AuditLogs.Domain.Options;
using Fermat.EntityFramework.AuditLogs.Infrastructure.EntityConfigurations;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Fermat.EntityFramework.AuditLogs.Infrastructure.Contexts;

/// <summary>
/// Database context for managing audit logs and entity property changes.
/// </summary>
public class AuditLogDbContext : DbContext
{
    public DbSet<AuditLog> AuditLogs { get; set; }
    public DbSet<EntityPropertyChange> EntityPropertyChanges { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AuditLogDbContext"/> class.
    /// </summary>
    /// <param name="options">The options for this context.</param>
    public AuditLogDbContext(DbContextOptions options) : base(options)
    {
    }

    /// <summary>
    /// Configures the database model and its relationships.
    /// </summary>
    /// <param name="builder">The model builder instance.</param>
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(AuditLogConfiguration).Assembly);
        builder.ApplyConfigurationsFromAssembly(typeof(EntityPropertyChangeConfiguration).Assembly);
    }
}