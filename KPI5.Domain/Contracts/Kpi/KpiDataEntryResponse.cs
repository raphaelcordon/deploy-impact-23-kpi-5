namespace KPI5.Domain.Contracts.Kpi;

public class KpiDataEntryResponse
{
    public Guid id { get; set; }
    
    public Entities.User.User? UserId { get; set; }
    
    public Entities.Kpi.Kpi? KpiId { get; set; }
    
    public DateTime? Timestamp { get; set; }

    public float? Value { get; set; }
}