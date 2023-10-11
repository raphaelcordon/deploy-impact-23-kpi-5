using KPI5.Domain.Contracts.Dashboard;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace KPI5.API.Controllers.Dashboard;

[ApiController]
[Route("v1/[controller]")]
public class DashboardController : ControllerBase
{
    private readonly Supabase.Client _client;

    public DashboardController(Supabase.Client client)
    {
        _client = client;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll(int skip = 0, int range = 25)
    {
        var response = await _client.From<Domain.Entities.Dashboard.Dashboard>()
            .Select("id, CircleId, Circle!inner(Name), Title, CreationDate, VisualisationType, KpiId, Kpi!inner(Name, Value, Range), Field, TemplateId, DashboardTemplate!inner(Name, Layout)")
            .Offset(skip) // skip a certain number of rows
            .Limit(range) //number of rows to fetch
            .Get();

        var dbResponse = JsonConvert.DeserializeObject<List<dynamic>>(response.Content);
       
        var getResponse = new List<DashboardResponse>();
        
        foreach (var item in dbResponse)
        {
            var tempData = new DashboardResponse();
            tempData.id = Guid.Parse(item.id.ToString());
            tempData.Title = item.Title;
            tempData.CreationDate = item.CreationDate;
            tempData.VisualisationType = item.VisualisationType;
            tempData.Field = item.Field;
            tempData.TemplateId = Guid.Parse(item.TemplateId.ToString());
            tempData.TemplateName = item.DashboardTemplate.Name;
            tempData.TemplateLayout = item.DashboardTemplate.Layout;
            tempData.CircleId = Guid.Parse(item.CircleId.ToString());
            tempData.CircleName = item.Circle.Name;
            tempData.KpiId = Guid.Parse(item.KpiId.ToString());
            tempData.KpiName = item.Kpi.Name;
            tempData.KpiRange = item.Kpi.Range;
            tempData.KpiValue = item.Kpi.Value;
            
            getResponse.Add(tempData);
        }
        return Ok(getResponse);
    }
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var response = await _client.From<Domain.Entities.Dashboard.Dashboard>()
            .Select("id, CircleId, Circle!inner(Name), Title, CreationDate, VisualisationType, KpiId, Kpi!inner(Name, Value, Range), Field, TemplateId, DashboardTemplate!inner(Name, Layout)")
            .Where(n => n.id == id)
            .Get();

        var dbResponseArray = JsonConvert.DeserializeObject<List<dynamic>>(response.Content);
        if (dbResponseArray == null || !dbResponseArray.Any())
        {
            return NotFound();
        }
        var dbResponse = dbResponseArray.First();

        var getResponse = new DashboardResponse
        {
            id = Guid.Parse(dbResponse.id.ToString()),
            Title = dbResponse.Title,
            CreationDate = dbResponse.CreationDate,
            VisualisationType = dbResponse.VisualisationType,
            Field = dbResponse.Field,
            TemplateId = Guid.Parse(dbResponse.TemplateId.ToString()),
            TemplateName = dbResponse.DashboardTemplate.Name,
            TemplateLayout = dbResponse.DashboardTemplate.Layout,
            CircleId = Guid.Parse(dbResponse.CircleId.ToString()),
            CircleName = dbResponse.Circle.Name,
            KpiId = Guid.Parse(dbResponse.KpiId.ToString()),
            KpiName = dbResponse.Kpi.Name,
            KpiRange = dbResponse.Kpi.Range,
            KpiValue = dbResponse.Kpi.Value
        };
        return Ok(getResponse);
    }
}