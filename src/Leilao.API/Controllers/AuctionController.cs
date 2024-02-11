// Ignore Spelling: API Leilao

using Microsoft.AspNetCore.Mvc;

namespace Leilao.API.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class AuctionController : ControllerBase
  {
    [HttpGet]
    public IActionResult GetCurrentAuction()
    {
      return Ok("Paulo");
    }
  }
}