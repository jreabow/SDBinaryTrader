using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BinaryTrade.API.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class DirectionsController : Controller
  {
		// GET api/directions
		public IEnumerable<SelectListItem> Get()
		{
			return new List<SelectListItem>()
			{
				new SelectListItem
				{
					Text = "Up",
					Value = "1"
				},
				new SelectListItem
				{
					Text = "Down",
					Value = "2"
				}
			};
		}

	
	}
}
