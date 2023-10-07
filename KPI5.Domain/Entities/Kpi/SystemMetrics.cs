using Postgrest.Attributes;

namespace KPI5.Domain.Entities.Kpi;

[Table("SystemMetrics")]
public class SystemMetrics : BaseEntity
{
    [Column("MetricName")]
    public string? MetricName { get; set; }
    
    [Column("Value")]
    public float? Value { get; set; }
    
    [Column("Timestamp")]
    public DateTime? Timestamp { get; set; }
}