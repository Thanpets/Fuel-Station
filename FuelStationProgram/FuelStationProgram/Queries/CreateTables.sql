CREATE TABLE [dbo].[Customers](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [varchar](40) NOT NULL,
	[Surname] [varchar](40) NOT NULL,
	[CardNumber] [int] NOT NULL
)

CREATE TABLE [dbo].[Employees](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [varchar](40) NOT NULL,
	[Surname] [varchar](40) NOT NULL,
	[DateStart] [date] NOT NULL,
	[DateEnd] [date] NOT NULL,
	[Salary] [decimal](18,2) NOT NULL
)

CREATE TABLE [dbo].[Items](
	[ID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](40) NOT NULL,
	[Description] [nvarchar](255) NOT NULL,
	[ItemType] [nvarchar](40) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Cost] [decimal](18, 2) NOT NULL
)