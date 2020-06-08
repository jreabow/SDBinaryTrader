using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace BinaryTrade.API.Controllers
{
	public class ExpiresController : ApiController
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
