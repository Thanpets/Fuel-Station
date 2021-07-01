INSERT INTO [dbo].[TransactionLines]
           ([ID]
         ,[TransactionID]
          ,[ItemID]
          ,[Quantity]
       ,[ItemPrice]
       ,[Value])
     VALUES
           (@ID,
           @TransactionID,
           @ItemID,
           @Quantity,
           @ItemPrice,
           @Value)