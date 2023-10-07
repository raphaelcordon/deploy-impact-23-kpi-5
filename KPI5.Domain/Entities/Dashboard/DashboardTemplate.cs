using Postgrest.Attributes;

namespace KPI5.Domain.Entities.Dashboard;

[Table("DashboardTemplate")]
public class DashboardTemplate : BaseEntity
{
    [Column("Name")]
    public string? Name { get; set; }
    
    [Column("Layout")]
    public string? Layout { get; set; }
}