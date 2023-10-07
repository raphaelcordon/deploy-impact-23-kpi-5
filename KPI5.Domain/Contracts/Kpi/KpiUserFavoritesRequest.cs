namespace KPI5.Domain.Contracts.Kpi;

public class KpiUserFavoritesRequest
{
    public Entities.User.User? UserId { get; set; }
    
    public Entities.Kpi.Kpi? KpiId { get; set; }
}