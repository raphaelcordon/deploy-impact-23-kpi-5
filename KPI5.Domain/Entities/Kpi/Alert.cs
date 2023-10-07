using Postgrest.Attributes;

namespace KPI5.Domain.Entities.Kpi;

[Table("Alert")]
public class Alert : BaseEntity
{
    [Column("KpiId")]
    public Kpi? KpiId { get; set; }
    
    [Column("TresholdValue")]
    public float? TresholdValue { get; set; }
    
    [Column("AlertType")]
    public string? AlertType { get; set; }
}