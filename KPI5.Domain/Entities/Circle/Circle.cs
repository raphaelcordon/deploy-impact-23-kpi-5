using Postgrest.Attributes;

namespace KPI5.Domain.Entities.Circle;

[Table("Circle")]
public class Circle : BaseEntity
{
    [Column("Name")]
    public string? Name { get; set; }  
}