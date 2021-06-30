USE [guilde_des_heros]
GO

/****** Object:  Table [dbo].[hero]    Script Date: 29/06/2021 15:37:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[hero]') AND type in (N'U'))
DROP TABLE [dbo].[hero]
GO

/****** Object:  Table [dbo].[hero]    Script Date: 29/06/2021 15:37:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[hero](
	[her_id] [int] IDENTITY(1,1) NOT NULL,
	[her_nom] [varchar](50) NULL,
	[her_prenom] [varchar](50) NULL,
	[her_specialite] [varchar](50) NULL,
	[her_classe] [varchar](50) NULL,
	[her_level] [int] NULL,
	[her_puissance] [int] NULL,
	[her_nb_mission] [int] NULL,
	[her_reputation] [int] NULL,
 CONSTRAINT [PK_hero] PRIMARY KEY CLUSTERED 
(
	[her_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

