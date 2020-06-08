using System.Threading.Tasks;
using DataAccess;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace BinaryTrade.Core.API.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class BinaryTradeController : Controller
  {
    public BinaryTradeController(BinaryTradeRepository repository = null)
    {
      
    }

    [HttpPost]
    public async Task<IActionResult> Post(Models.BinaryTrade trade)
    {
      var repository = new BinaryTradeRepository();

      repository.SaveBinaryTradeAsync(new DataAccess.Models.BinaryTrade
      {
        Asset = new Asset { Name = trade.Asset.Name, Id = int.Parse(trade.Asset.Value) },
        Expiration = trade.Expiration,
        Amount = trade.Amount,
        Payout = trade.Payout,
        Direction = trade.Direction
      });

      return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var repository = new BinaryTradeRepository();

      return Ok(await repository.GetBinaryTradesAsync());
    }
  }
}
