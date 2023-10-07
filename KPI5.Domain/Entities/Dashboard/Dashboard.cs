using Postgrest.Attributes;

namespace KPI5.Domain.Entities.Dashboard;

[Table("Dashboard")]
public class Dashboard : BaseEntity
{
    [Column("CircleId")]
    public Circle.Circle? CircleId { get; set; }
    
    [Column("Title")]
    public string? Title { get; set; }
    
    [Column("CreationDate")]
    public DateTime? CreationDate { get; set; }
    
    [Column("VisualisationType")]
    public string? VisualisationType { get; set; }
    
    [Column("KpiId")]
    public Kpi.Kpi? KpiId { get; set; }
    
    [Column("Field")]
    public string? Field { get; set; }
    
    [Column("TemplateId")]
    public DashboardTemplate? TemplateId { get; set; }
}