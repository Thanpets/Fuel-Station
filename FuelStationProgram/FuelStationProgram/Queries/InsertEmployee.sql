INSERT INTO [dbo].[Employees]
           ([ID]
           ,[Name]
           ,[Surname]
           ,[DateStart]
           ,[DateEnd]
           ,[Salary])
     VALUES
           (@ID,
           @Name,
           @Surname,
           @DateStart,
           @DateEnd,
           @Salary)
