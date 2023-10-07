using KPI5.Domain.Contracts.User;
using KPI5.Domain.Entities.User;
using Microsoft.AspNetCore.Mvc;

namespace KPI5.API.Controllers.User;

[ApiController]
[Route("[controller]")]
public class RoleController : ControllerBase
{
    private readonly Supabase.Client _client;

    public RoleController(Supabase.Client client)
    {
        _client = client;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll(int skip = 0, int range = 25)
    {
        var response = await _client.From<Role>()
            .Offset(skip) // skip a certain number of rows
            .Limit(range) //number of rows to fetch
            .Get();

        var dbResponse = response.Models;
       
        var getResponse = new List<RoleResponse>();
        
        foreach (var item in dbResponse)
        {
            var tempData = new RoleResponse();
            tempData.id = item.id;
            tempData.RoleName = item.RoleName;
            tempData.PermissionId = item.PermissionId;
            
            getResponse.Add(tempData);
        }
        return Ok(getResponse);
    }
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var response = await _client.From<Role>()
            .Where(n => n.id == id)
            .Get();

        var dbResponse = response.Models.FirstOrDefault();
        if (dbResponse is null)
        {
            return NotFound();
        }

        var getResponse = new RoleResponse
        {
            id = dbResponse.id,
            RoleName = dbResponse.RoleName,
            PermissionId = dbResponse.PermissionId
        };
        return Ok(getResponse);
    }
    
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] RoleRequest create)
    {
        var dbRequest = new Role
        {
            RoleName = create.RoleName,
            PermissionId = create.PermissionId
        };
        var response = await _client.From<Role>().Insert(dbRequest);
        var newRequest = response.Models.First();

        return Ok(newRequest.id);
    }
    
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] RoleResponse model)
    {
        var response = await _client.From<Role>()
            .Where(n => n.id == id)
            .Single();
        
        if (response is null)
        {
            return NotFound();
        }

        response.RoleName = model.RoleName;
        response.PermissionId = model.PermissionId;
        

        await _client.From<Role>().Update(response);
        return Ok(response.id);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var response = _client.From<Role>()
            .Where(x => x.id == id)
            .Delete();
        
        return Ok();
    }
}

