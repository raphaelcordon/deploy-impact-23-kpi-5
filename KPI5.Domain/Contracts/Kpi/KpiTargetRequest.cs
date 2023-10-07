namespace KPI5.Domain.Contracts.Kpi;

public class KpiTargetRequest
{
    public Entities.Kpi.Kpi? KpiId { get; set; }
    
    public float? TargetValue { get; set; }
    
    public DateTime? StartDate { get; set; }
    
    public DateTime? EndDate { get; set; }
    
    public string? OutcomeNotification { get; set; }
}