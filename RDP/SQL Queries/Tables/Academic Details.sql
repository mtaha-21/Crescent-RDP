USE [RDP_DB]
GO

/****** Object:  Table [dbo].[academic_details]    Script Date: 10/11/2021 3:10:25 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[academic_details](
	[category] [nvarchar](50) NULL,
	[type_of_registration] [nvarchar](50) NULL,
	[if_part_time] [nvarchar](50) NULL,
	[ug_university_or_college] [nvarchar](50) NULL,
	[ug_year_of_passing] [nvarchar](50) NULL,
	[ug_month_of_passing] [nvarchar](50) NULL,
	[ug_class] [nvarchar](50) NULL,
	[pg_university_or_college] [nvarchar](50) NULL,
	[pg_year_of_passing] [nvarchar](50) NULL,
	[pg_month_of_passing] [nvarchar](50) NULL,
	[pg_class] [nvarchar](50) NULL,
	[pg_part_time_or_full_time] [nvarchar](50) NULL,
	[other_qualification] [nvarchar](50) NULL,
	[year_of_passing] [nvarchar](50) NULL,
	[month_of_passing] [nvarchar](50) NULL,
	[class] [nvarchar](50) NULL,
	[part_time_or_full_time] [nvarchar](50) NULL,
	[bachelor_degree_discipline] [nvarchar](50) NULL,
	[bsem_1] [nvarchar](50) NULL,
	[bsem_2] [nvarchar](50) NULL,
	[bsem_3] [nvarchar](50) NULL,
	[bsem_4] [nvarchar](50) NULL,
	[bsem_5] [nvarchar](50) NULL,
	[bsem_6] [nvarchar](50) NULL,
	[bsem_7] [nvarchar](50) NULL,
	[bsem_8] [nvarchar](50) NULL,
	[master_degree_discipline] [nvarchar](50) NULL,
	[msem_1] [nvarchar](50) NULL,
	[msem_2] [nvarchar](50) NULL,
	[msem_3] [nvarchar](50) NULL,
	[msem_4] [nvarchar](50) NULL,
	[msem_5] [nvarchar](50) NULL,
	[msem_6] [nvarchar](50) NULL,
	[specify] [nvarchar](50) NULL,
	[org_worked] [nvarchar](50) NULL,
	[designation] [nvarchar](50) NULL,
	[no_of_yrs_worked] [nvarchar](50) NULL,
	[work_mode] [nvarchar](50) NULL,
	[specify_name] [nvarchar](50) NULL,
	[name_of_org] [nvarchar](50) NULL,
	[designation1] [nvarchar](50) NULL,
	[yrs_worked] [nvarchar](50) NULL,
	[work_mode1] [nvarchar](50) NULL,
	[name_add_emp] [nvarchar](50) NULL,
	[designation2] [nvarchar](50) NULL,
	[mode_of_emp] [nvarchar](50) NULL,
	[scale_of_pay] [nvarchar](50) NULL,
	[working_since] [nvarchar](50) NULL,
	[total_yrs] [nvarchar](50) NULL
) ON [PRIMARY]
GO

