using KPI5.Domain.Entities.Dashboard;
using KPI5.Domain.Entities.Kpi;

namespace KPI5.Domain.Contracts.Dashboard;

public class DashboardRequest
{
    public Entities.Circle.Circle? CircleId { get; set; }

    public string? Title { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? VisualisationType { get; set; }

    public Entities.Kpi.Kpi? KpiId { get; set; }

    public string? Field { get; set; }

    public DashboardTemplate? TemplateId { get; set; }
}