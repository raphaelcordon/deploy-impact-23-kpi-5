using Postgrest.Attributes;

namespace KPI5.Domain.Entities.User;

[Table("User")]
public class User : BaseEntity
{
    [Column("Name")]
    public string? Name { get; set; }
    
    [Column("Salted")]
    public string? Salted { get; set; }
    
    [Column("Hashed")]
    public string? Hashed { get; set; }
    
    [Column("Email")]
    public string? Email { get; set; }
    
    [Column("CreationDate")]
    public DateTime? CreationDate { get; set; }
    
    [Column("Field")]
    public string? Field { get; set; }
    
    [Column("RoleId")]
    public UserRole? RoleId { get; set; }
    
    [Column("CircleId")]
    public Circle.Circle? CircleId { get; set; }
}

    

    

    
