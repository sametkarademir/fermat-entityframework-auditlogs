using System.Text.Json.Serialization;
using Fermat.EntityFramework.AuditLogs.Domain.Enums;
using FluentValidation;

namespace Fermat.EntityFramework.AuditLogs.Application.DTOs.AuditLogs;

public class GetListAuditLogRequestDto
{
    public string? EntityId { get; set; }
    public string? EntityName { get; set; }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public States? States { get; set; }

    public int Page { get; set; } = 1;
    public int PerPage { get; set; } = 25;
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public Guid? UserId { get; set; }
    public Guid? SnapshotId { get; set; }
    public Guid? SessionId { get; set; }
    public Guid? CorrelationId { get; set; }
}

public class GetListAuditLogRequestValidation : AbstractValidator<GetListAuditLogRequestDto>
{
    public GetListAuditLogRequestValidation()
    {
        RuleFor(x => x.Page)
            .GreaterThan(0);

        RuleFor(x => x.PerPage)
            .InclusiveBetween(1, 100);

        RuleFor(x => x.EntityId)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.EntityName)
            .NotEmpty()
            .MaximumLength(500);

        RuleFor(x => x.States)
            .IsInEnum();

        RuleFor(x => x.StartDate)
            .LessThan(x => x.EndDate)
            .LessThanOrEqualTo(DateTime.Today);

        RuleFor(x => x.EndDate)
            .LessThanOrEqualTo(DateTime.Today)
            .GreaterThan(x => x.StartDate);

        RuleFor(x => x.UserId)
            .Must(x => x == null || x != Guid.Empty);

        RuleFor(x => x.SnapshotId)
            .Must(x => x == null || x != Guid.Empty);

        RuleFor(x => x.SessionId)
            .Must(x => x == null || x != Guid.Empty);

        RuleFor(x => x.CorrelationId)
            .Must(x => x == null || x != Guid.Empty);
    }
}