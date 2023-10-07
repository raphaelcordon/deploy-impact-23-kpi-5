using Postgrest.Attributes;

namespace KPI5.Domain.Entities.User;

[Table("Permission")]
public class Permission : BaseEntity
{
    [Column("PermissionName")]
    public string? PermissionName { get; set; }    
}