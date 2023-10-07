namespace KPI5.Domain.Contracts.Notification;

public class NotificationResponse
{
    public Guid id { get; set; }
    
    public Entities.User.User? UserId { get; set; }

    public string? Message { get; set; }
    
    public DateTime? NotificationDate { get; set; }
}