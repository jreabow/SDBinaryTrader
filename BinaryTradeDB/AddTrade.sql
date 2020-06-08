CREATE PROCEDURE [dbo].[AddTrade]
    @Asset INT, 
    @Expiration INT, 
    @Amount DECIMAL, 
    @Direction INT, 
    @Payout INT
AS

  INSERT INTO BinaryTradeDB.dbo.Trade VALUES (NEWID(), @Asset, @Expiration, @Amount, @Direction, @Payout)

RETURN 0
