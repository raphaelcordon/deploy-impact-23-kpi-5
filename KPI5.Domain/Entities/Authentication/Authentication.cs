using Postgrest.Attributes;

namespace KPI5.Domain.Entities.Authentication;

[Table("Authentication")]
public class Authentication : BaseEntity
{
    [Column("UserId")]
    public User.User? UserId { get; set; }
    
    [Column("AuthenticationType")]
    public string? AuthenticationType { get; set; }
    
    [Column("ExternalId")]
    public Guid? ExternalId { get; set; }
}