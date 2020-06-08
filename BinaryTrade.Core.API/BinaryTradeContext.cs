using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BinaryTrade.Core.API
{
  public class BinaryTradeContext : DbContext
  {
    public BinaryTradeContext(DbContextOptions<BinaryTradeContext> options) : base(options)
    {

    }

    public DbSet<Models.BinaryTrade> BinaryTrades { get; set; }
  }
}
