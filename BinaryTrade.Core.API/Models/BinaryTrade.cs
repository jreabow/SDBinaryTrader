using BinaryTrade.Models;

namespace BinaryTrade.Core.API.Models
{
    public class BinaryTrade
    {
      public Asset Asset { get; set; }
      public int Expiration { get; set; }
      public decimal Amount { get; set; }
      public int Direction { get; set; }
      public int Payout { get; set; }
  }
}
