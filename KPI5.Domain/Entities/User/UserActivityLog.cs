using Postgrest.Attributes;

namespace KPI5.Domain.Entities.User;

[Table("UserActivityLog")]
public class UserActivityLog : BaseEntity
{
    [Column("UserId")]
    public User? UserId { get; set; }
    
    [Column("ActionType")]
    public string? ActionType { get; set; }
        
    [Column("Timestamp")]
    public DateTime? Timestamp { get; set; }
    
    
}