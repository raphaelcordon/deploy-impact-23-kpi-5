using Postgrest.Attributes;

namespace KPI5.Domain.Entities.Kpi;

[Table("KpiDataEntry")]
public class KpiDataEntry : BaseEntity
{
    [Column("UserId")]
    public User.User? UserId { get; set; }
    
    [Column("KpiId")]
    public Kpi? KpiId { get; set; }
    
    [Column("Timestamp")]
    public DateTime? Timestamp { get; set; }
    
    [Column("Value")]
    public float? Value { get; set; }
}