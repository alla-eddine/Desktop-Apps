USE [master]
GO
/****** Object:  Database [bloodbanksystem]    Script Date: 11/01/2025 7:02:15 PM ******/
CREATE DATABASE [bloodbanksystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bloodbanksystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\bloodbanksystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bloodbanksystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\bloodbanksystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bloodbanksystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bloodbanksystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bloodbanksystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bloodbanksystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bloodbanksystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bloodbanksystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [bloodbanksystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bloodbanksystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bloodbanksystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bloodbanksystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bloodbanksystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bloodbanksystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bloodbanksystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bloodbanksystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bloodbanksystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bloodbanksystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bloodbanksystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bloodbanksystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bloodbanksystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bloodbanksystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bloodbanksystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bloodbanksystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bloodbanksystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bloodbanksystem] SET RECOVERY FULL 
GO
ALTER DATABASE [bloodbanksystem] SET  MULTI_USER 
GO
ALTER DATABASE [bloodbanksystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bloodbanksystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bloodbanksystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bloodbanksystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'bloodbanksystem', N'ON'
GO
USE [bloodbanksystem]
GO
/****** Object:  Table [dbo].[donors]    Script Date: 11/01/2025 7:02:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[donors](
	[donor_id] [bigint] IDENTITY(1,1) NOT NULL,
	[register_num] [bigint] NULL,
	[donor_fullname] [nvarchar](max) NULL,
	[donor_group] [nchar](10) NULL,
	[donation_date] [date] NULL,
	[donor_phone] [nvarchar](50) NULL,
	[donor_type] [nvarchar](50) NULL,
	[donor_poche] [nvarchar](50) NULL,
	[donor_sexe] [nchar](10) NULL,
	[donor_birthdate] [date] NULL,
	[donor_birthplace] [nvarchar](max) NULL,
	[donor_adress] [nvarchar](max) NULL,
 CONSTRAINT [PK_donors] PRIMARY KEY CLUSTERED 
(
	[donor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 11/01/2025 7:02:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [nvarchar](max) NULL,
	[user_password] [nvarchar](max) NULL,
	[user_type] [nvarchar](50) NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[donors] ON 

INSERT [dbo].[donors] ([donor_id], [register_num], [donor_fullname], [donor_group], [donation_date], [donor_phone], [donor_type], [donor_poche], [donor_sexe], [donor_birthdate], [donor_birthplace], [donor_adress]) VALUES (2, 10, N'fd000', N'AB-       ', CAST(N'2026-01-06' AS Date), N'fred00000000', N'Cp', N'Poche', N'Female    ', CAST(N'2021-01-06' AS Date), N'frd0000000', N'frds0000000')
SET IDENTITY_INSERT [dbo].[donors] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([user_id], [user_name], [user_password], [user_type]) VALUES (1, N'admin', N'admin', N'adminstrateur')
INSERT [dbo].[users] ([user_id], [user_name], [user_password], [user_type]) VALUES (2, N'fd', N'fgf', N'utilisateur')
INSERT [dbo].[users] ([user_id], [user_name], [user_password], [user_type]) VALUES (3, N'admin', N'admin0', N'adminstrateur')
SET IDENTITY_INSERT [dbo].[users] OFF
GO
USE [master]
GO
ALTER DATABASE [bloodbanksystem] SET  READ_WRITE 
GO
