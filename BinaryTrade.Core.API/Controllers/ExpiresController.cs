using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BinaryTrade.Core.API.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class ExpiresController : Controller
  {
		// GET api/expiries
		public IEnumerable<SelectListItem> Get()
		{
			return new List<SelectListItem>()
			{
				new SelectListItem
				{
					Text = "1 Hour",
					Value = "0"
				},
				new SelectListItem
				{
					Text = "6 Hours",
					Value = "1"
				},
				new SelectListItem
				{
					Text = "12 Hours",
					Value = "2"
				},
				new SelectListItem
				{
					Text = "24 Hours",
					Value = "3"
				}
			};
		}

	
	}
}
