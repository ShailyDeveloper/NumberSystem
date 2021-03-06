USE [master]
GO

/****** Object:  Database [MVC]    Script Date: 17-06-2020 04:12:08 ******/
CREATE DATABASE [MVC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MVC', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MVC.mdf' , SIZE = 102400KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MVC_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MVC_log.ldf' , SIZE = 10240KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [MVC] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MVC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [MVC] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [MVC] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [MVC] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [MVC] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [MVC] SET ARITHABORT OFF 
GO

ALTER DATABASE [MVC] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [MVC] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [MVC] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [MVC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [MVC] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [MVC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [MVC] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [MVC] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [MVC] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [MVC] SET  DISABLE_BROKER 
GO

ALTER DATABASE [MVC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [MVC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [MVC] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [MVC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [MVC] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [MVC] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [MVC] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [MVC] SET RECOVERY FULL 
GO

ALTER DATABASE [MVC] SET  MULTI_USER 
GO

ALTER DATABASE [MVC] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [MVC] SET DB_CHAINING OFF 
GO

ALTER DATABASE [MVC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [MVC] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [MVC] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [MVC] SET  READ_WRITE 
GO




USE [MVC]
GO

/****** Object:  Table [dbo].[NumberData]    Script Date: 17-06-2020 04:13:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[NumberData](
	[SlNo] [int] IDENTITY(1,1) NOT NULL,
	[Number] [float] NULL,
	[NumberText] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO



USE [MVC]
GO

/****** Object:  StoredProcedure [dbo].[InsertData]    Script Date: 17-06-2020 04:21:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertData] 
@Number float,
@NumberText VARCHAR(MAX)
AS

INSERT INTO dbo.NumberData(Number,NumberText) VALUES(@Number,@NumberText)


GO

