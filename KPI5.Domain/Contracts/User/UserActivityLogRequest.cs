namespace KPI5.Domain.Contracts.User;


public class UserActivityLogRequest
{
    public Entities.User.User? UserId { get; set; }
    
    public string? ActionType { get; set; }

    public DateTime? Timestamp { get; set; }
    
    
}