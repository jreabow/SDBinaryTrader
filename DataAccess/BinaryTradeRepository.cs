using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess
{
  public class BinaryTradeRepository
  {
    private string ConnectionString;

    public BinaryTradeRepository(string connectionString = null)
    {
      ConnectionString = connectionString ?? @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BinaryTradeDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True"; 
    }

    public async void SaveBinaryTradeAsync(BinaryTrade binaryTrade)
    {
      using (SqlConnection connection = new SqlConnection(ConnectionString))
      {
        var command = new SqlCommand
        {
          Connection = connection,
          CommandType = CommandType.StoredProcedure,
          CommandText = "dbo.AddTrade"
        };

        command.Parameters.AddWithValue("@Asset", binaryTrade.Asset.Id);
        command.Parameters.AddWithValue("@Expiration", binaryTrade.Expiration);
        command.Parameters.AddWithValue("@Amount", binaryTrade.Amount);
        command.Parameters.AddWithValue("@Direction", binaryTrade.Direction);
        command.Parameters.AddWithValue("@Payout", binaryTrade.Payout);

        await connection.OpenAsync();

        command.ExecuteNonQuery();
      }
    }

    public async Task<BinaryTrade[]> GetBinaryTradesAsync()
    {
      using (SqlConnection connection = new SqlConnection(ConnectionString))
      {
        var command = new SqlCommand
        {
          Connection = connection,
          CommandType = CommandType.Text,
          CommandText = "SELECT * FROM dbo.Trade"
        };

        await connection.OpenAsync();

        var reader = await command.ExecuteReaderAsync();

        var trades = new List<BinaryTrade>();

        if (reader.HasRows)
        {
          for (;;)
          {
            if (!await reader.ReadAsync()) break;

            var trade = new BinaryTrade
            {
              Id = reader.GetGuid(0).ToString(),
              Asset = new Asset {Id = reader.GetInt32(1)},
              Expiration = reader.GetInt32(2),
              Amount = reader.GetDecimal(3),
              Direction = reader.GetInt32(4),
              Payout = reader.GetInt32(5)
            };

            trades.Add(trade);
          }
        }

        return trades.ToArray();
      }
    }
  }
}
