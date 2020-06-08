using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
  public class BinaryTrade
  {
    public string Id { get; set; }
    public Asset Asset { get; set; }
    public int Expiration { get; set; }
    public decimal Amount { get; set; }
    public int Direction { get; set; }
    public int Payout { get; set; }
  }
}
