namespace KPI5.Domain.Contracts.Kpi;

public class CommentResponse
{
    public Guid id { get; set; }
    
    public Entities.Kpi.Kpi? KpiId { get; set; }
    
    public Entities.User.User? UserId { get; set; }
    
    public string? CommentText { get; set; }
    
    public DateTime? CommentDate { get; set; }
}