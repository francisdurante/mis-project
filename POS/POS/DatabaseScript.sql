USE [POS]
GO
/****** Object:  Table [dbo].[AuditTrail]    Script Date: 7/17/2008 12:30:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AuditTrail](
	[AuditID] [int] IDENTITY(1,1) NOT NULL,
	[Actions] [varchar](max) NULL,
	[ProcessBy] [varchar](50) NOT NULL,
	[LoggedInUser] [varchar](50) NOT NULL,
	[ProcessDate] [datetime] NOT NULL,
	[ActionField] [varchar](50) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ItemCategory]    Script Date: 7/17/2008 12:30:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ItemCategory](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](50) NOT NULL,
	[Status] [varchar](20) NOT NULL DEFAULT ('ACTIVE'),
	[CreatedBy] [int] NOT NULL,
	[CreatedAt] [datetime] NOT NULL DEFAULT (getdate()),
	[UpdateAt] [date] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ItemList]    Script Date: 7/17/2008 12:30:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ItemList](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemCode] [varchar](50) NOT NULL,
	[ItemName] [varchar](50) NOT NULL,
	[ItemCategory] [varchar](50) NOT NULL,
	[ItemPrice] [decimal](9, 2) NOT NULL,
	[ItemQuantity] [int] NULL,
	[CreatedAt] [date] NOT NULL,
	[UpdateAt] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TransactionDetails]    Script Date: 7/17/2008 12:30:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionDetails](
	[TransactionDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[TransactionID] [int] NULL,
	[ItemID] [int] NULL,
	[Quantity] [int] NULL,
	[ItemTransactionStatus] [int] NULL,
	[TotalAmount] [float] NULL,
	[DateInserted] [datetime] NULL DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[TransactionDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 7/17/2008 12:30:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Transactions](
	[TransactionID] [int] IDENTITY(1,1) NOT NULL,
	[TransactionNumber] [varchar](50) NULL,
	[TotalItemCount] [int] NULL,
	[TotalItemAmount] [float] NULL,
	[TransactionDate] [datetime] NULL CONSTRAINT [DF_Date]  DEFAULT (getdate()),
	[TransactionStatus] [decimal](4, 0) NULL DEFAULT ((0)),
	[PostedBy] [int] NULL,
	[CreatedAt] [datetime] NULL DEFAULT (getdate()),
	[UpdateAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 7/17/2008 12:30:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserInfo](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [decimal](4, 0) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[FullName] [varchar](50) NOT NULL,
	[Position] [varchar](50) NOT NULL,
	[Status] [varchar](20) NULL,
	[State] [varchar](20) NULL,
	[CreatedBy] [decimal](4, 0) NULL,
	[CreatedAt] [datetime] NOT NULL DEFAULT (getdate()),
	[UpdateAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserPosition]    Script Date: 7/17/2008 12:30:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserPosition](
	[UserPositionID] [int] IDENTITY(1,1) NOT NULL,
	[PositionName] [varchar](50) NOT NULL,
	[PositionStatus] [varchar](50) NOT NULL,
	[CreatedBy] [int] NULL,
	[CreatedAt] [datetime] NOT NULL DEFAULT (getdate()),
	[UpdateAt] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[TransactionDetails]  WITH CHECK ADD FOREIGN KEY([ItemID])
REFERENCES [dbo].[ItemList] ([ItemID])
GO
ALTER TABLE [dbo].[TransactionDetails]  WITH CHECK ADD FOREIGN KEY([TransactionID])
REFERENCES [dbo].[Transactions] ([TransactionID])
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD FOREIGN KEY([PostedBy])
REFERENCES [dbo].[UserInfo] ([UserID])
GO
/****** Object:  StoredProcedure [dbo].[toRetrieveItemDetails]    Script Date: 7/17/2008 12:30:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Francis Durante
-- Create date: 05/23/2018
-- Description:	to retreieve Item Detail
-- =============================================
CREATE PROCEDURE [dbo].[toRetrieveItemDetails] 
	@itemCode VARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
SELECT * FROM dbo.ItemList WHERE ItemCode = @itemCode;

END

GO
/****** Object:  StoredProcedure [dbo].[toSaveInAuditTrail]    Script Date: 7/17/2008 12:30:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Francis Durante
-- Create date: 5/27/2018
-- Description:	to Save Actions 
-- =============================================
CREATE PROCEDURE [dbo].[toSaveInAuditTrail] 
	@actions Varchar(max),
	@processBy Varchar(50),
	@loggedInUser varchar(50),
	@processDate datetime,
	@actionField varchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;
	INSERT INTO dbo.AuditTrail(Actions,ProcessBy,LoggedInUser,ProcessDate,ActionField) 
	VALUES (@actions,@processBy,@loggedInUser,@processDate,@actionField);
END

GO
/****** Object:  StoredProcedure [dbo].[toSaveInTransactions]    Script Date: 7/17/2008 12:30:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Francis Durante>
-- Create date: <07/8/2018>
-- Description:	To save transactions
-- @transactionStatus 1 - successful transaction,
--					  2 - return transaction
--                    3 - other
-- =============================================
CREATE PROCEDURE [dbo].[toSaveInTransactions]
	@transactionNumber VARCHAR(20),
	@totalItemCount INT,
	@totalAmount float,
	@postedBy INT

AS
BEGIN
DECLARE @transactionID INT

	SET NOCOUNT ON;
	INSERT INTO dbo.Transactions(TransactionNumber,
	TotalItemCount,
	TotalItemAmount,
	TransactionStatus,
	PostedBy)
	VALUES
	(@transactionNumber,
	@totalItemCount,
	@totalAmount,
	1,
	@postedBy)

SET @transactionID = (SELECT TransactionID FROM dbo.Transactions WHERE TransactionNumber = @transactionNumber)
SELECT 'reponse' = @transactionID;
END

GO
/****** Object:  StoredProcedure [dbo].[toSaveTransactionDetails]    Script Date: 7/17/2008 12:30:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Francis Durante
-- Create date: 07/08/2018
-- Description:	to save transaction details
--ItemTransactionStatus 1 - Item Ok,
--						2 - Return Item
--						3 - Other
-- =============================================
CREATE PROCEDURE [dbo].[toSaveTransactionDetails]
@itemCode varchar(20),
@quantity int,
@totalAmount float,
@transactionID INT
	
AS
BEGIN
DECLARE @itemID int

	SET NOCOUNT ON;
	SET @itemID = (SELECT ItemID FROM ItemList WHERE ItemCode = @itemCode)

IF @itemID IS NOT NULL
	BEGIN
		INSERT INTO TransactionDetails(TransactionID,
		ItemID,
		Quantity,
		ItemTransactionStatus,
		TotalAmount)
		VALUES(@transactionID,
		@itemID,
		@quantity,
		1,
		@totalAmount)
		
	END
END

GO
