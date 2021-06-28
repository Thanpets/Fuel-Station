
CREATE TABLE [dbo].[Transactions](
    [ID] [uniqueidentifier] NOT NULL,
    [Date] [date] NOT NULL,
    [CustomerID] [uniqueidentifier] NOT NULL,
	[DiscountValue] [decimal](18, 2) NOT NULL,
	[TotalValue] [decimal](18, 2) NOT NULL
)

CREATE TABLE [dbo].[TransactionLines](
    [ID] [uniqueidentifier] NOT NULL,
    [TransactionID] [uniqueidentifier] NOT NULL,
    [ItemID] [uniqueidentifier] NOT NULL,
    Quantity [int] NOT NULL,
	[ItemPrice] [decimal](18, 2) NOT NULL,
	[Value] [decimal](18, 2) NOT NULL
)
