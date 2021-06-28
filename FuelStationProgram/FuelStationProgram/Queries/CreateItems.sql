
CREATE TABLE [dbo].[Items](
	[ID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](40) NOT NULL,
	[Description] [nvarchar](255) NOT NULL,
	[ItemType] [nvarchar](40) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Cost] [decimal](18, 2) NOT NULL
)