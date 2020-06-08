using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace BinaryTrade.API.Controllers
{
	public class DirectionsController : ApiController
	{
		// GET api/directions
		public IEnumerable<SelectListItem> Get()
		{
			return new List<SelectListItem>()
			{
				new SelectListItem
				{
					Text = "Up",
					Value = "0"
				},
				new SelectListItem
				{
					Text = "Down",
					Value = "1"
				}
			};
		}

	
	}
}
