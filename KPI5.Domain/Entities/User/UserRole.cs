using Postgrest.Attributes;

namespace KPI5.Domain.Entities.User;

[Table("Role")]
public class UserRole : BaseEntity
{
    [Column("RoleName")]
    public string? RoleName { get; set; } 
    
    [Column("PermissionId")]
    public UserPermission? PermissionId { get; set; }    
}