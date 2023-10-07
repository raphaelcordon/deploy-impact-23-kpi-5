using KPI5.Domain.Entities.Kpi;

namespace KPI5.Domain.Contracts.Kpi;

public class KpiResponse
{
    public Guid id { get; set; }
    
    public Entities.Circle.Circle? CircleId { get; set; }

    public string? Name { get; set; }

    public float? Value { get; set; }

    public string? ValueType { get; set; }

    public KpiCategory? CategoryId { get; set; }
}