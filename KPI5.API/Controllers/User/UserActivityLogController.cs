using KPI5.Domain.Contracts.User;
using KPI5.Domain.Entities.User;
using Microsoft.AspNetCore.Mvc;

namespace KPI5.API.Controllers.User;

[ApiController]
[Route("[controller]")]
public class UserActivityLogController : ControllerBase
{
    private readonly Supabase.Client _client;

    public UserActivityLogController(Supabase.Client client)
    {
        _client = client;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll(int skip = 0, int range = 25)
    {
        var response = await _client.From<UserActivityLog>()
            .Offset(skip) // skip a certain number of rows
            .Limit(range) //number of rows to fetch
            .Get();

        var dbResponse = response.Models;
       
        var getResponse = new List<UserActivityLogResponse>();
        
        foreach (var item in dbResponse)
        {
            var tempData = new UserActivityLogResponse();
            tempData.id = item.id;
            tempData.UserId = item.UserId;
            tempData.ActionType = item.ActionType;
            tempData.Timestamp = item.Timestamp;
            
            getResponse.Add(tempData);
        }
        return Ok(getResponse);
    }
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var response = await _client.From<UserActivityLog>()
            .Where(n => n.id == id)
            .Get();

        var dbResponse = response.Models.FirstOrDefault();
        if (dbResponse is null)
        {
            return NotFound();
        }

        var getResponse = new UserActivityLogResponse
        {
            id = dbResponse.id,
            UserId = dbResponse.UserId,
            ActionType = dbResponse.ActionType,
            Timestamp = dbResponse.Timestamp
        };
        return Ok(getResponse);
    }
    
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] UserActivityLogRequest create)
    {
        var dbRequest = new UserActivityLog
        {
            UserId = create.UserId,
            ActionType = create.ActionType,
        };
        var response = await _client.From<UserActivityLog>().Insert(dbRequest);
        var newRequest = response.Models.First();

        return Ok(newRequest.id);
    }
    
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UserActivityLogResponse model)
    {
        var response = await _client.From<UserActivityLog>()
            .Where(n => n.id == id)
            .Single();
        
        if (response is null)
        {
            return NotFound();
        }

        response.UserId = model.UserId;
        response.ActionType = model.ActionType;

        await _client.From<UserActivityLog>().Update(response);
        return Ok(response.id);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var response = _client.From<UserActivityLog>()
            .Where(x => x.id == id)
            .Delete();
        
        return Ok();
    }
}

