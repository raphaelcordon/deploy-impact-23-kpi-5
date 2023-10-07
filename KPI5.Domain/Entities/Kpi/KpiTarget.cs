using Postgrest.Attributes;

namespace KPI5.Domain.Entities.Kpi;

[Table("KpiTarget")]
public class KpiTarget : BaseEntity
{
    [Column("KpiId")]
    public Kpi? KpiId { get; set; }
    
    [Column("TargetValue")]
    public float? TargetValue { get; set; }
    
    [Column("StartDate")]
    public DateTime? StartDate { get; set; }
    
    [Column("EndDate")]
    public DateTime? EndDate { get; set; }
    
    [Column("OutcomeNotification")]
    public string? OutcomeNotification { get; set; }
}