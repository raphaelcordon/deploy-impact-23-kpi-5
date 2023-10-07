namespace KPI5.Domain.Contracts.Kpi;

public class KpiUserFavoritesResponse
{
    public Guid id { get; set; }
    
    public Entities.User.User? UserId { get; set; }
    
    public Entities.Kpi.Kpi? KpiId { get; set; }
}