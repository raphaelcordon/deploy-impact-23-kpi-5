using Postgrest.Attributes;

namespace KPI5.Domain.Entities.Kpi;

[Table("Kpi")]
public class Kpi : BaseEntity
{
    [Column("CircleId")]
    public Circle.Circle? CircleId { get; set; }
    
    [Column("Name")]
    public string? Name { get; set; }
    
    [Column("Value")]
    public float? Value { get; set; }
    
    [Column("ValueType")]
    public string? ValueType { get; set; }
    
    [Column("CategoryId")]
    public KpiCategory? CategoryId { get; set; }
}