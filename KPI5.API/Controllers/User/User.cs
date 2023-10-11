using KPI5.Domain.Contracts.User;
using Microsoft.AspNetCore.Mvc;

namespace KPI5.API.Controllers.User;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly Supabase.Client _client;

    public UserController(Supabase.Client client)
    {
        _client = client;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll(int skip = 0, int range = 25)
    {
        var response = await _client.From<Domain.Entities.User.User>()
            .Offset(skip) // skip a certain number of rows
            .Limit(range) //number of rows to fetch
            .Get();

        var dbResponse = response.Models;
       
        var getResponse = new List<UserResponse>();
        
        foreach (var item in dbResponse)
        {
            var tempData = new UserResponse();
            tempData.id = item.id;
            tempData.Name = item.Name;
            tempData.Salted = item.Salted;
            tempData.Hashed = item.Hashed;
            tempData.Email = item.Email;
            tempData.CreationDate = item.CreationDate;
            tempData.Field = item.Field;
            tempData.RoleId = item.RoleId;
            tempData.CircleId = item.CircleId;
            
            getResponse.Add(tempData);
        }
        return Ok(getResponse);
    }
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var response = await _client.From<Domain.Entities.User.User>()
            .Where(n => n.id == id)
            .Get();

        var dbResponse = response.Models.FirstOrDefault();
        if (dbResponse is null)
        {
            return NotFound();
        }

        var getResponse = new UserResponse
        {
            id = dbResponse.id,
            Name = dbResponse.Name,
            Salted = dbResponse.Salted,
            Hashed = dbResponse.Hashed,
            Email = dbResponse.Email,
            CreationDate = dbResponse.CreationDate,
            Field = dbResponse.Field,
            RoleId = dbResponse.RoleId,
            CircleId = dbResponse.CircleId
        };
        return Ok(getResponse);
    }
    
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] UserRequest create)
    {
        var dbRequest = new Domain.Entities.User.User
        {
            Name = create.Name,
            Salted = create.Salted,
            Hashed = create.Hashed,
            Email = create.Email,
            CreationDate = create.CreationDate,
            Field = create.Field,
            RoleId = create.RoleId,
            CircleId = create.CircleId
        };
        var response = await _client.From<Domain.Entities.User.User>().Insert(dbRequest);
        var newRequest = response.Models.First();

        return Ok(newRequest.id);
    }
    
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UserResponse model)
    {
        var response = await _client.From<Domain.Entities.User.User>()
            .Where(n => n.id == id)
            .Single();
        
        if (response is null)
        {
            return NotFound();
        }
        
        response.Name = model.Name;
        response.Salted = model.Salted;
        response.Hashed = model.Hashed;
        response.Email = model.Email;
        response.CreationDate = model.CreationDate;
        response.Field = model.Field;
        response.RoleId = model.RoleId;
        response.CircleId = model.CircleId;

        await _client.From<Domain.Entities.User.User>().Update(response);
        return Ok(response.id);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var response = _client.From<Domain.Entities.User.User>()
            .Where(x => x.id == id)
            .Delete();
        
        return Ok();
    }
}

