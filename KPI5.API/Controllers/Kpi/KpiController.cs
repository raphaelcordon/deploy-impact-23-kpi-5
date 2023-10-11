using KPI5.Domain.Contracts.Kpi;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace KPI5.API.Controllers.Kpi;

[ApiController]
[Route("v1/[controller]")]
public class KpiController : ControllerBase
{
    private readonly Supabase.Client _client;

    public KpiController(Supabase.Client client)
    {
        _client = client;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll(int skip = 0, int range = 25)
    {
        var response = await _client.From<Domain.Entities.Kpi.Kpi>()
            .Select("id, CircleId, Circle!inner(Name), Name, Value, ValueType, Range, Periodicity, Field")
            .Offset(skip) // skip a certain number of rows
            .Limit(range) //number of rows to fetch
            .Get();
        
        var dbResponse = JsonConvert.DeserializeObject<List<dynamic>>(response.Content);

       
        var getResponse = new List<KpiResponse>();
        
        foreach (var item in dbResponse)
        {
            var tempData = new KpiResponse();
            tempData.id = Guid.Parse(item.id.ToString());
            tempData.CircleId = Guid.Parse(item.CircleId.ToString());
            tempData.CircleName = item.Circle.Name;
            tempData.Name = item.Name;
            tempData.Value = item.Value;
            tempData.ValueType = item.ValueType;
            tempData.Range = item.Range;
            tempData.Periodicity = item.Periodicity;
            tempData.Field = item.Field;
            
            getResponse.Add(tempData);
        }
        return Ok(getResponse);
    }
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var response = await _client.From<Domain.Entities.Kpi.Kpi>()
            .Select("id, CircleId, Circle!inner(Name), Name, Value, ValueType, Range, Periodicity, Field")
            .Where(n => n.id == id)
            .Get();

        var dbResponseArray = JsonConvert.DeserializeObject<List<dynamic>>(response.Content);
        if (dbResponseArray == null || !dbResponseArray.Any())
        {
            return NotFound();
        }
        var dbResponse = dbResponseArray.First();

        var getResponse = new KpiResponse
        {
            id = Guid.Parse(dbResponse.id.ToString()),
            CircleId = Guid.Parse(dbResponse.CircleId.ToString()),
            CircleName = dbResponse.Circle.Name,
            Name = dbResponse.Name,
            Value = dbResponse.Value,
            ValueType = dbResponse.ValueType,
            Range = dbResponse.Range,
            Periodicity = dbResponse.Periodicity,
            Field = dbResponse.Field,
        };
        return Ok(getResponse);
    }
}