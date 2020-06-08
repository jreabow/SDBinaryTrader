using Microsoft.AspNetCore.Mvc;

namespace BinaryTrade.Core.API.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class PayoutController : Controller
  {
		// GET api/expiries
		public double Get()
		{
			return 80;
		}
	}
}
