using FluentValidation;

namespace Fermat.EntityFramework.AuditLogs.Application.DTOs.AuditLogs;

public class GetEntityChangeSummaryRequestDto : DateRangeRequestDto
{
    public string EntityId { get; set; } = null!;
    public string EntityName { get; set; } = null!;
}

public class GetEntityChangeSummaryRequestValidator : AbstractValidator<GetEntityChangeSummaryRequestDto>
{
    public GetEntityChangeSummaryRequestValidator()
    {
        Include(new DateRangeRequestValidator());
        RuleFor(x => x.EntityId)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.EntityName)
            .NotEmpty()
            .MaximumLength(500);
    }
}