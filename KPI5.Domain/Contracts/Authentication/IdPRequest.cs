namespace KPI5.Domain.Contracts.Authentication;

public class IdPRequest
{
    public Entities.Authentication.Authentication? AuthenticationId { get; set; }

    public string? ProviderName { get; set; }

    public string? IdPToken { get; set; }
    
    public DateTime? SessionExpiry { get; set; }
}