using KPI5.Domain.Entities.Kpi;

namespace KPI5.Domain.Contracts.Kpi;

public class KpiResponse
{
    public Guid id { get; set; }
    
    public Guid? CircleId { get; set; }
    
    public string? CircleName { get; set; }

    public string? Name { get; set; }

    public float? Value { get; set; }

    public string? ValueType { get; set; }

    public string? Range { get; set; }

    public string? Periodicity { get; set; }

    public string? Field { get; set; }
}