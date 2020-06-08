using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BinaryTrade.Core.API.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class AssetsController : Controller
  {
		public IEnumerable<SelectListItem> Get()
		{
			return  new List<SelectListItem>()
			{
				new SelectListItem
				{
					Text = "EUR/USD",
					Value = "1"
				},
				new SelectListItem
				{
					Text = "JPY/USD",
					Value = "2"
				},
				new SelectListItem
				{
					Text = "GBP/USD",
					Value = "3"
				}
			};
		}
		
	}
}
