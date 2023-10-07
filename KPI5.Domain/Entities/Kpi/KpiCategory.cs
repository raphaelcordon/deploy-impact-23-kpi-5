using Postgrest.Attributes;

namespace KPI5.Domain.Entities.Kpi;

[Table("KpiCategory")]
public class KpiCategory : BaseEntity
{
    [Column("KpiCategoryName")]
    public string? KpiCategoryName { get; set; }
}