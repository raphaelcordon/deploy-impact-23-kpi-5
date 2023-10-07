using Postgrest.Attributes;

namespace KPI5.Domain.Entities.Authentication;

[Table("SocialLogin")]
public class SocialLogin : BaseEntity
{
    [Column("AuthenticationId")]
    public Authentication? AuthenticationId { get; set; }
    
    [Column("ProviderName")]
    public string? ProviderName { get; set; }
    
    [Column("AccessToken")]
    public string? AccessToken { get; set; }
    
    [Column("RefreshToken")]
    public string? RefreshToken { get; set; }
    
    [Column("TokenExpiry")]
    public DateTime? TokenExpiry { get; set; }
}