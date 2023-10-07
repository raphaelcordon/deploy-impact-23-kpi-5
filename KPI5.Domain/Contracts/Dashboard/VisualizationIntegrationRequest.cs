namespace KPI5.Domain.Contracts.Dashboard;

public class VisualizationIntegrationRequest
{
    public Entities.Dashboard.Dashboard? DashboardId { get; set; }
    
    public string? Type { get; set; }
    
    public string? Configuration { get; set; }
}