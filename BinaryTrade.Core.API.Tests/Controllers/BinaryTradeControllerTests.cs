using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BinaryTrade.Core.API.Controllers;
using NUnit.Framework;

namespace BinaryTrade.Core.API.Tests.Controllers
{
  [TestFixture]
  public class BinaryTradeControllerTests
  {
    [Test]
    public async Task Get_Given_Nothing_Should_ReturnTrades()
    {
      var controller = new BinaryTradeController();

      var actual = await controller.Get();

      Assert.IsNotNull(actual);
    }
  }
}
