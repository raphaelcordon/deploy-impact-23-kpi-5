using KPI5.Domain.Entities.User;

namespace KPI5.Domain.Contracts.User;

public class RoleResponse
{
    public Guid id { get; set; }
    public string? RoleName { get; set; } 
    public Permission? PermissionId { get; set; }    
}