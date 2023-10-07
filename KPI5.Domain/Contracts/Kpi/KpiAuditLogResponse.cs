namespace KPI5.Domain.Contracts.Kpi;

public class KpiAuditLogResponse
{
    public Guid id { get; set; }
    
    public Entities.User.User? UserId { get; set; }

    public string? ActionType { get; set; }

    public DateTime? Timestamp { get; set; }

    public Entities.Kpi.Kpi? KpiId { get; set; }

    public string? Details { get; set; }

    public float? PreviousValue { get; set; }

    public float? UpdatedValue { get; set; }
}