namespace KPI5.Domain.Contracts.Kpi;

public class KpiValidationRequest
{
    public Entities.Kpi.Kpi? KpiId { get; set; }
    
    public string? Rule { get; set; }
}