CREATE TABLE [dbo].[Trade]
(
  [Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [Asset] INT NULL, 
    [Expiration] INT NULL, 
    [Amount] DECIMAL NULL, 
    [Direction] INT NULL, 
    [Payout] INT NULL, 
    CONSTRAINT [FK_Trade_Asset] FOREIGN KEY ([Asset]) REFERENCES [Asset]([Id])
)
