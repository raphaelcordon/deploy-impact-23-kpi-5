using Postgrest.Attributes;

namespace KPI5.Domain.Entities.Notification;

[Table("Notification")]
public class Notification : BaseEntity
{
    [Column("UserId")]
    public User.User? UserId { get; set; }
    
    [Column("Message")]
    public string? Message { get; set; }
    
    [Column("NotificationDate")]
    public DateTime? NotificationDate { get; set; }
}