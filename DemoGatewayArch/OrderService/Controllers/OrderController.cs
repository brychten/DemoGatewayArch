using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    [HttpGet]
    public List<string> Get()
    {
        List<string> list = new List<string>();
        list.Add("Order Controller");
        return list;
    }
}