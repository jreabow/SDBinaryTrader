using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace BinaryTrade.API.Controllers
{
	public class AssetsController : ApiController
	{
		// GET api/values
		public IEnumerable<SelectListItem> Get()
		{
			return  new List<SelectListItem>()
			{
				new SelectListItem
				{
					Text = "EUR/USD",
					Value = "0"
				},
				new SelectListItem
				{
					Text = "USD/JPY",
					Value = "1"
				},
				new SelectListItem
				{
					Text = "GBP/USD",
					Value = "2"
				}
			};
		}
		
	}
}
