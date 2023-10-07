using Postgrest.Attributes;

namespace KPI5.Domain.Entities.User;

[Table("Role")]
public class Role : BaseEntity
{
    [Column("RoleName")]
    public string? RoleName { get; set; } 
    
    [Column("PermissionId")]
    public Permission? PermissionId { get; set; }    
}