using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BinaryTrade.Models
{
	public class Trade : ITrade
	{
		public Asset Asset { get; set; }
		public int Expiration { get; set; }
		public decimal Amount { get; set; }
		public int Direction { get; set; }
		public int Payout { get; set; }
	}


}