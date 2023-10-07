namespace KPI5.Domain.Contracts.Kpi;

public class KpiValidationLogResponse
{
    public Guid id { get; set; }
    
    public Entities.Kpi.Kpi? KpiId { get; set; }
    
    public string? Status { get; set; }
    
    public string? Message { get; set; }
    
    public DateTime? Timestamp { get; set; }
}