namespace KPI5.Domain.Contracts.Notification;

public class NotificationRequest
{
    public Entities.User.User? UserId { get; set; }

    public string? Message { get; set; }
    
    public DateTime? NotificationDate { get; set; }
}