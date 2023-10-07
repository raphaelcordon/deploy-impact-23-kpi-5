namespace KPI5.Domain.Contracts.Dashboard;

public class VisualizationIntegrationResponse
{
    public Guid id { get; set; }
    
    public Entities.Dashboard.Dashboard? DashboardId { get; set; }
    
    public string? Type { get; set; }
    
    public string? Configuration { get; set; }
}