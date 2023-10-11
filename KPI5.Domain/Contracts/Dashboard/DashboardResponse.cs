using KPI5.Domain.Entities.Dashboard;
using KPI5.Domain.Entities.Kpi;

namespace KPI5.Domain.Contracts.Dashboard;

public class DashboardResponse
{
    public Guid id { get; set; }
    public string? Title { get; set; }
    public DateTime? CreationDate { get; set; }
    public string? VisualisationType { get; set; }
    public string? Field { get; set; }
    public Guid? TemplateId { get; set; }
    public string? TemplateName { get; set; }
    public string? TemplateLayout { get; set; }
    
    public Guid? CircleId { get; set; }
    public string? CircleName { get; set; }
    
    public Guid? KpiId { get; set; }
    public string? KpiName { get; set; }
    public float? KpiValue { get; set; }
    public string? KpiRange { get; set; }
}