namespace KPI5.Domain.Contracts.Kpi;

public class KpiValidationResponse
{
    public Guid id { get; set; }
    
    public Entities.Kpi.Kpi? KpiId { get; set; }
    
    public string? Rule { get; set; }
}