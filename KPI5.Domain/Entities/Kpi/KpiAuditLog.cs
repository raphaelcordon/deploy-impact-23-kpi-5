using KPI5.Domain.Entities.KPI5;
using Postgrest.Attributes;

namespace KPI5.Domain.Entities.Kpi;

[Table("KpiAuditLog")]
public class KpiAuditLog : BaseEntity
{
    [Column("UserId")]
    public User.User? UserId { get; set; }
    
    [Column("ActionType")]
    public string? ActionType { get; set; }
    
    [Column("Timestamp")]
    public DateTime? Timestamp { get; set; }
    
    [Column("KpiId")]
    public Kpi? KpiId { get; set; }
    
    [Column("Details")]
    public string? Details { get; set; }
    
    [Column("PreviousValue")]
    public float? PreviousValue { get; set; }
    
    [Column("UpdatedValue")]
    public float? UpdatedValue { get; set; }
}