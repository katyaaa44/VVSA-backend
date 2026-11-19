using Microsoft.AspNetCore.Mvc;

namespace VVSA_backend.Controllers;

[ApiController]
[Route("api/transaction")]
public class TransactionController : ControllerBase
{
    [HttpGet(Name = "GetTransaction")]
    public string Get()
    {
        return "First controller request";
    }
}