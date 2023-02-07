USE [CloudTest]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 20.10.2022. 10:45:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[Id] [uniqueidentifier] NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[Province] [nvarchar](50) NULL,
	[City] [nvarchar](50) NOT NULL,
	[Population] [int] NOT NULL,
	[IsCapital] [bit] NOT NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cities] ADD  CONSTRAINT [DF_Cities_Id]  DEFAULT (newid()) FOR [Id]
GO
