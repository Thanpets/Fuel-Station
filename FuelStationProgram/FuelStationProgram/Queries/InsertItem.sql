INSERT INTO [dbo].[Items]
           ([ID]
           ,[Code]
           ,[Description]
           ,[ItemType]
           ,[Price]
           ,[Cost])
     VALUES
           (@ID,
           @Code,
           @Description,
           @ItemType,
           @Price,
           @Cost)
