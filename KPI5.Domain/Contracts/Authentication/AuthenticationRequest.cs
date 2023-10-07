namespace KPI5.Domain.Contracts.Authentication;

public class AuthenticationRequest
{
    public Entities.User.User? UserId { get; set; }
    
    public string? AuthenticationType { get; set; }
    
    public Guid? ExternalId { get; set; }
}