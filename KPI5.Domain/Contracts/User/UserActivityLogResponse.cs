namespace KPI5.Domain.Contracts.User;


public class UserActivityLogResponse
{
    public Guid id { get; set; }
    
    public Entities.User.User? UserId { get; set; }
    
    public string? ActionType { get; set; }
    
    public DateTime? Timestamp { get; set; }
    
    
}