
CREATE TABLE [dbo].[Employees](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [varchar](40) NOT NULL,
	[Surname] [varchar](40) NOT NULL,
	[DateStart] [date] NOT NULL,
	[DateEnd] [date] NOT NULL,
	[Salary] [decimal](18,2) NOT NULL
)
