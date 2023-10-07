using Postgrest.Attributes;

namespace KPI5.Domain.Entities.Kpi;

[Table("KpiValidationLog")]
public class KpiValidationLog : BaseEntity
{
    [Column("KpiId")]
    public Kpi? KpiId { get; set; }
    
    [Column("Status")]
    public string? Status { get; set; }
    
    [Column("Message")]
    public string? Message { get; set; }
    
    [Column("Timestamp")]
    public DateTime? Timestamp { get; set; }
}