USE [master]
GO
/****** Object:  Database [guilde_des_heros]    Script Date: 30/06/2021 08:43:29 ******/
CREATE DATABASE [guilde_des_heros]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'guilde_des_heros', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\guilde_des_heros.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'guilde_des_heros_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\guilde_des_heros_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [guilde_des_heros] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [guilde_des_heros].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [guilde_des_heros] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [guilde_des_heros] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [guilde_des_heros] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [guilde_des_heros] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [guilde_des_heros] SET ARITHABORT OFF 
GO
ALTER DATABASE [guilde_des_heros] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [guilde_des_heros] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [guilde_des_heros] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [guilde_des_heros] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [guilde_des_heros] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [guilde_des_heros] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [guilde_des_heros] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [guilde_des_heros] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [guilde_des_heros] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [guilde_des_heros] SET  DISABLE_BROKER 
GO
ALTER DATABASE [guilde_des_heros] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [guilde_des_heros] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [guilde_des_heros] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [guilde_des_heros] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [guilde_des_heros] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [guilde_des_heros] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [guilde_des_heros] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [guilde_des_heros] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [guilde_des_heros] SET  MULTI_USER 
GO
ALTER DATABASE [guilde_des_heros] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [guilde_des_heros] SET DB_CHAINING OFF 
GO
ALTER DATABASE [guilde_des_heros] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [guilde_des_heros] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [guilde_des_heros] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [guilde_des_heros] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [guilde_des_heros] SET QUERY_STORE = OFF
GO
USE [guilde_des_heros]
GO
/****** Object:  Table [dbo].[hero]    Script Date: 30/06/2021 08:43:29 ******/
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
/****** Object:  Table [dbo].[objet]    Script Date: 30/06/2021 08:43:29 ******/
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
USE [master]
GO
ALTER DATABASE [guilde_des_heros] SET  READ_WRITE 
GO
