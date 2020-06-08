using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BinaryTrade.Models
{
	public interface ITrade
	{
			Asset Asset { get; set; }
			int Expiration { get; set; }
			decimal Amount { get; set; }
			int Direction { get; set; }
			int Payout { get; set; }

	}
}