using Fermat.EntityFramework.AuditLogs.Application.DTOs.AuditLogs;
using Fermat.EntityFramework.AuditLogs.Application.DTOs.EntityPropertyChanges;
using Fermat.EntityFramework.Shared.DTOs.Pagination;

namespace Fermat.EntityFramework.AuditLogs.Domain.Interfaces.Services;

/// <summary>
/// Application service interface for managing audit logs.
/// </summary>
public interface IAuditLogAppService
{
    /// <summary>
    /// Retrieves an audit log entry by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the audit log entry.</param>
    /// <returns>The audit log entry if found; otherwise, entity not found exception.</returns>
    Task<AuditLogResponseDto> GetByIdAsync(Guid id);

    /// <summary>
    /// Retrieves a paginated list of audit log entries based on specified filtering criteria.
    /// </summary>
    /// <param name="request">The request containing pagination and filtering parameters.</param>
    /// <returns>A paginated list of audit log entries.</returns>
    Task<PageableResponseDto<AuditLogResponseDto>> GetPageableAndFilterAsync(GetListAuditLogRequestDto request);

    /// <summary>
    /// Retrieves a summary of changes for a specific entity.
    /// </summary>
    /// <param name="request">The request containing entity identification and filtering criteria.</param>
    /// <returns>A summary of changes for the specified entity.</returns>
    Task<EntityChangeSummaryResponseDto> GetEntityChangeSummaryAsync(GetEntityChangeSummaryRequestDto request);

    /// <summary>
    /// Retrieves all property changes associated with a specific audit log entry.
    /// </summary>
    /// <param name="auditLogId">The unique identifier of the audit log entry.</param>
    /// <returns>A list of property changes for the specified audit log entry.</returns>
    Task<List<EntityPropertyChangeResponseDto>> GetEntityPropertyChangesAsync(Guid auditLogId);

    /// <summary>
    /// Removes audit log entries older than the specified date.
    /// </summary>
    /// <param name="olderThan">The cutoff date for removing old audit logs.</param>
    /// <returns>The number of audit log entries that were removed.</returns>
    Task<int> CleanupOldAuditLogsAsync(DateTime olderThan);

    /// <summary>
    /// Analyzes user activity patterns based on audit logs.
    /// </summary>
    /// <param name="request">The request containing analysis parameters.</param>
    /// <returns>An analysis of user activity patterns.</returns>
    Task<UserActivityAnalysisResponseDto> GetUserActivityAnalysisAsync(UserActivityAnalysisRequestDto request);

    /// <summary>
    /// Identifies the most frequently modified entities in the system.
    /// </summary>
    /// <param name="request">The request containing analysis parameters.</param>
    /// <returns>A list of the most frequently modified entities.</returns>
    Task<MostModifiedEntitiesResponseDto> GetMostModifiedEntitiesAsync(MostModifiedEntitiesRequestDto request);

    /// <summary>
    /// Analyzes trends in entity changes over time.
    /// </summary>
    /// <param name="request">The request containing analysis parameters.</param>
    /// <returns>An analysis of entity change trends.</returns>
    Task<EntityChangesTrendResponseDto> AnalyzeEntityChangesTrendAsync(EntityChangesTrendRequestDto request);

    /// <summary>
    /// Analyzes patterns in how users make changes to entities.
    /// </summary>
    /// <param name="request">The request containing analysis parameters.</param>
    /// <returns>An analysis of user change behavior patterns.</returns>
    Task<UserChangeBehaviorResponseDto> AnalyzeUserChangeBehaviorAsync(UserChangeBehaviorRequestDto request);
}