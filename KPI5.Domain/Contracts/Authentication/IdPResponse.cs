namespace KPI5.Domain.Contracts.Authentication;

public class IdPResponse
{
    public Guid id { get; set; }
    
    public Entities.Authentication.Authentication? AuthenticationId { get; set; }

    public string? ProviderName { get; set; }

    public string? IdPToken { get; set; }
    
    public DateTime? SessionExpiry { get; set; }
}