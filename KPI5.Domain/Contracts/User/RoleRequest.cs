using KPI5.Domain.Entities.User;

namespace KPI5.Domain.Contracts.User;

public class RoleRequest
{
    public string? RoleName { get; set; } 
    public UserPermission? PermissionId { get; set; }    
}