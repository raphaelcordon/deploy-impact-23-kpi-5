namespace KPI5.Domain.Contracts.Kpi;

public class SystemMetricsResponse
{
    public Guid id { get; set; }
    
    public string? MetricName { get; set; }
    
    public float? Value { get; set; }
    
    public DateTime? Timestamp { get; set; }
}