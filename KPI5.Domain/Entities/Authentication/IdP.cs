using Postgrest.Attributes;

namespace KPI5.Domain.Entities.Authentication;

[Table("IdP")]
public class IdP : BaseEntity
{
    [Column("AuthenticationId")]
    public Authentication? AuthenticationId { get; set; }
    
    [Column("ProviderName")]
    public string? ProviderName { get; set; }
    
    [Column("IdPToken")]
    public string? IdPToken { get; set; }
    
    [Column("SessionExpiry")]
    public DateTime? SessionExpiry { get; set; }
}