USE [RDP_DB]
GO

/****** Object:  Table [dbo].[personal_details]    Script Date: 10/11/2021 3:14:52 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[personal_details](
	[full_name] [nvarchar](50) NULL,
	[date_of_birth] [nvarchar](50) NULL,
	[age] [nvarchar](50) NULL,
	[gender] [nvarchar](50) NULL,
	[nationality] [nvarchar](50) NULL,
	[if_foreign_country] [nvarchar](50) NULL,
	[passport] [nvarchar](50) NULL,
	[social_status] [nvarchar](50) NULL,
	[marital_status] [nvarchar](50) NULL,
	[telephone] [nvarchar](50) NULL,
	[mobile_number] [nvarchar](50) NULL,
	[email_id] [nvarchar](50) NOT NULL,
	[residential_address] [nvarchar](50) NULL,
	[office_address] [nvarchar](50) NULL,
	[address_for_communication] [nvarchar](50) NULL,
 CONSTRAINT [PK_personal_details] PRIMARY KEY CLUSTERED 
(
	[email_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


