using Microsoft.AspNetCore.Mvc;

namespace RequestService.Controllers;

[Route("[controller]")]
public class RequestController : Controller
{
    
    [HttpGet]
    public List<string> Get()
    {
        List<string> list = new List<string>();
        list.Add("Request Controller");
        return list;
    }
}