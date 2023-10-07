using Microsoft.EntityFrameworkCore;
using Postgrest.Models;

namespace KPI5.Domain.Entities;

public class BaseEntity : BaseModel
{
    [Postgrest.Attributes.PrimaryKey("id")]
    public Guid id { get; set; }
}