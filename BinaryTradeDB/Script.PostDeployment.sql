/*
Post-Deployment Script Template              
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.    
 Use SQLCMD syntax to include a file in the post-deployment script.      
 Example:      :r .\myfile.sql                
 Use SQLCMD syntax to reference a variable in the post-deployment script.    
 Example:      :setvar TableName MyTable              
               SELECT * FROM [$(TableName)]          
--------------------------------------------------------------------------------------
*/

IF NOT EXISTS (SELECT 1 FROM dbo.Asset WHERE Id = 1) 
BEGIN 
   INSERT INTO dbo.Asset (Id, Name) VALUES (1, N'EUR/USD')
END
GO 
IF NOT EXISTS (SELECT 1 FROM dbo.Asset WHERE Id = 2) 
BEGIN 
   INSERT INTO dbo.Asset (Id, Name) VALUES (2, N'JPY/USD')
END
GO 
IF NOT EXISTS (SELECT 1 FROM dbo.Asset WHERE Id = 3) 
BEGIN 
   INSERT INTO dbo.Asset (Id, Name) VALUES (3, N'GBP/USD')
END
GO 

IF NOT EXISTS (SELECT 1 FROM dbo.Trade WHERE Id = '0ed77ff8-4bf2-4ae7-bd1d-1e7fe16cde10') 
BEGIN 
   INSERT INTO dbo.Trade (Id, Asset, Expiration, Amount, Direction, Payout) VALUES ('0ed77ff8-4bf2-4ae7-bd1d-1e7fe16cde10', 1, 10, 100, 1, 1000);
END
GO 

IF NOT EXISTS (SELECT 1 FROM dbo.Trade WHERE Id = '1231af2b-cfba-4581-922c-f7ce8a9f5a8d') 
BEGIN 
   INSERT INTO dbo.Trade (Id, Asset, Expiration, Amount, Direction, Payout) VALUES ('1231af2b-cfba-4581-922c-f7ce8a9f5a8d', 2, 5, 50, 2, 500);
END
GO 