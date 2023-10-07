namespace KPI5.Domain.Contracts.Authentication;

public class SocialLoginResponse
{
    public Guid id { get; set; }
    
    public Entities.Authentication.Authentication? AuthenticationId { get; set; }
    
    public string? ProviderName { get; set; }

    public string? AccessToken { get; set; }

    public string? RefreshToken { get; set; }

    public DateTime? TokenExpiry { get; set; }
}