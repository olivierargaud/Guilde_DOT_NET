USE [guilde_des_heros]
GO

ALTER TABLE [dbo].[objet] DROP CONSTRAINT [FK_objet_hero]
GO

/****** Object:  Table [dbo].[objet]    Script Date: 29/06/2021 15:39:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[objet]') AND type in (N'U'))
DROP TABLE [dbo].[objet]
GO

/****** Object:  Table [dbo].[objet]    Script Date: 29/06/2021 15:39:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[objet](
	[obj_id] [int] IDENTITY(1,1) NOT NULL,
	[obj_nom] [varchar](50) NULL,
	[obj_level] [int] NULL,
	[obj_quantite] [int] NULL,
	[obj_description] [varchar](150) NULL,
	[obj_prix] [float] NULL,
	[obj_hero_id] [int] NULL,
 CONSTRAINT [PK_objet] PRIMARY KEY CLUSTERED 
(
	[obj_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[objet]  WITH CHECK ADD  CONSTRAINT [FK_objet_hero] FOREIGN KEY([obj_hero_id])
REFERENCES [dbo].[hero] ([her_id])
GO

ALTER TABLE [dbo].[objet] CHECK CONSTRAINT [FK_objet_hero]
GO

