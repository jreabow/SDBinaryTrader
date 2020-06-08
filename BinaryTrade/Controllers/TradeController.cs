using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using BinaryTrade.Models;

namespace BinaryTrade.Controllers
{
	public class TradeController : Controller
	{
		// GET: Trade
		public async Task<ActionResult> Index()
		{
		  var client = new HttpClient();

		  var response = await client.GetAsync("http://localhost:50511/BinaryTrade");

      ViewBag.Payout = await GetPayoutAsync() + "%";
			ViewBag.Assets = await GetAssetsAsync();
			ViewBag.Expiry = await GetExpiresAsync();
			ViewBag.Direction = await GetDirectionsAsync();

		  if (response.IsSuccessStatusCode)
		  {
		    var content = response.Content.ReadAsStringAsync().Result;
		    var trades = new JavaScriptSerializer().Deserialize<Trade[]>(content);
		    return View(trades);
      }

		  return View();
		}

	  [HttpGet]
	  public async Task<ActionResult> Buy()
	  {
	    ViewBag.Payout = await GetPayoutAsync() + "%";
	    ViewBag.Assets = await GetAssetsAsync();
	    ViewBag.Expiry = await GetExpiresAsync();
	    ViewBag.Direction = await GetDirectionsAsync();

	    return View("Buy");
    }

    [HttpPost]
		public ActionResult Buy(Trade trade)
		{
			if (!ModelState.IsValid)
			{
			  return View("Buy");
			}

		  var client = new HttpClient();

		  var response = client
		    .PostAsync("http://localhost:50511/BinaryTrade", new StringContent(System.Web.Helpers.Json.Encode(trade), Encoding.UTF8, "application/json"))
		    .Result;

      return Content("");
		}

		private async Task<List<SelectListItem>> GetAssetsAsync()
		{
			var client = new HttpClient();
			var response = client.GetAsync("http://localhost:50511/assets");
			if (response.Result.IsSuccessStatusCode)
			{
				var content = response.Result.Content.ReadAsStringAsync().Result;
				return new JavaScriptSerializer().Deserialize<List<SelectListItem>>(content);
			}
			return null;

		}

		private Task<List<SelectListItem>> GetExpiresAsync()
		{
			var client = new HttpClient();
			var response =  client.GetAsync("http://localhost:50511/expires").Result;
			if (response.IsSuccessStatusCode)
			{
				var content = response.Content.ReadAsStringAsync().Result;
				return Task.FromResult(new JavaScriptSerializer().Deserialize<List<SelectListItem>>(content));
			}
			return null;

		}
		private async Task<List<SelectListItem>> GetDirectionsAsync()
		{
			var client = new HttpClient();
			var response = client.GetAsync("http://localhost:50511/directions");
			if (response.Result.IsSuccessStatusCode)
			{
				var content = response.Result.Content.ReadAsStringAsync().Result;
				return new JavaScriptSerializer().Deserialize<List<SelectListItem>>(content);
			}
			return null;

		}

		private async Task<double> GetPayoutAsync()
		{
			var client = new HttpClient();
			var response = await client.GetAsync("http://localhost:50511/payout");

			if (response.IsSuccessStatusCode)
			{
				var content = response.Content.ReadAsStringAsync().Result;
				return new JavaScriptSerializer().Deserialize<double>(content);
			}
			return 0;

		}
	}
}