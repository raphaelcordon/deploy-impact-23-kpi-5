using Postgrest.Attributes;

namespace KPI5.Domain.Entities.Dashboard;

[Table("VisualizationIntegration")]
public class VisualizationIntegration : BaseEntity
{
    [Column("DashboardId")]
    public Dashboard? DashboardId { get; set; }
    
    [Column("Type")]
    public string? Type { get; set; }
    
    [Column("Configuration")]
    public string? Configuration { get; set; }
}