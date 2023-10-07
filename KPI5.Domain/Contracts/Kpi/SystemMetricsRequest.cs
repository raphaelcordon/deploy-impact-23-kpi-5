namespace KPI5.Domain.Contracts.Kpi;

public class SystemMetricsRequest
{
    public string? MetricName { get; set; }
    
    public float? Value { get; set; }
    
    public DateTime? Timestamp { get; set; }
}