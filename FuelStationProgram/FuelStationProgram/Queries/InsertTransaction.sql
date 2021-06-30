INSERT INTO [dbo].[Transactions]
           ([ID]
           ,[Date]
         ,[CustomerID]
         ,[DiscountValue]
         ,[TotalValue])
     VALUES
           (@ID,
           @Date,
           @CustomerID,
           @DiscountValue,
           @TotalValue)