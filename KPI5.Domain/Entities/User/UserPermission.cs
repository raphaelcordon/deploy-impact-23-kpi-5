using Postgrest.Attributes;

namespace KPI5.Domain.Entities.User;

[Table("Permission")]
public class UserPermission : BaseEntity
{
    [Column("PermissionName")]
    public string? PermissionName { get; set; }    
}