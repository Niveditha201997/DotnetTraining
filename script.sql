USE [master]
GO
/****** Object:  Database [Mytraining]    Script Date: 9/13/2022 4:38:06 PM ******/
CREATE DATABASE [Mytraining]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Mytraining', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Mytraining.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Mytraining_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Mytraining_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Mytraining] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Mytraining].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Mytraining] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Mytraining] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Mytraining] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Mytraining] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Mytraining] SET ARITHABORT OFF 
GO
ALTER DATABASE [Mytraining] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Mytraining] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Mytraining] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Mytraining] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Mytraining] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Mytraining] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Mytraining] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Mytraining] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Mytraining] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Mytraining] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Mytraining] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Mytraining] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Mytraining] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Mytraining] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Mytraining] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Mytraining] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Mytraining] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Mytraining] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Mytraining] SET  MULTI_USER 
GO
ALTER DATABASE [Mytraining] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Mytraining] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Mytraining] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Mytraining] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Mytraining] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Mytraining] SET QUERY_STORE = OFF
GO
USE [Mytraining]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Mytraining]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 9/13/2022 4:38:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[customer_id] [int] NOT NULL,
	[cust_name] [varchar](30) NOT NULL,
	[city] [varchar](15) NOT NULL,
	[grade] [numeric](3, 0) NOT NULL,
	[salesman_id] [numeric](5, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 9/13/2022 4:38:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[ord_no] [int] NOT NULL,
	[purch_amt] [decimal](8, 2) NOT NULL,
	[ord_date] [date] NOT NULL,
	[customer_id] [numeric](5, 0) NOT NULL,
	[salesman_id] [numeric](5, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ord_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[salesman]    Script Date: 9/13/2022 4:38:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salesman](
	[salesman_id] [int] NOT NULL,
	[name] [varchar](30) NOT NULL,
	[city] [varchar](15) NOT NULL,
	[comission] [decimal](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[salesman_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[customer] ([customer_id], [cust_name], [city], [grade], [salesman_id]) VALUES (3001, N'Brad Guzan', N'Laondon', CAST(300 AS Numeric(3, 0)), CAST(5005 AS Numeric(5, 0)))
INSERT [dbo].[customer] ([customer_id], [cust_name], [city], [grade], [salesman_id]) VALUES (3002, N'Nick Rimando', N'New York', CAST(100 AS Numeric(3, 0)), CAST(5001 AS Numeric(5, 0)))
INSERT [dbo].[customer] ([customer_id], [cust_name], [city], [grade], [salesman_id]) VALUES (3003, N'Jozy Altidor', N'Moscow', CAST(200 AS Numeric(3, 0)), CAST(5007 AS Numeric(5, 0)))
INSERT [dbo].[customer] ([customer_id], [cust_name], [city], [grade], [salesman_id]) VALUES (3004, N'FabianJohnson', N'Paris', CAST(300 AS Numeric(3, 0)), CAST(5006 AS Numeric(5, 0)))
INSERT [dbo].[customer] ([customer_id], [cust_name], [city], [grade], [salesman_id]) VALUES (3005, N'Graham Zusi', N'California', CAST(200 AS Numeric(3, 0)), CAST(5002 AS Numeric(5, 0)))
INSERT [dbo].[customer] ([customer_id], [cust_name], [city], [grade], [salesman_id]) VALUES (3007, N'Brad Davis', N'New York', CAST(100 AS Numeric(3, 0)), CAST(5001 AS Numeric(5, 0)))
INSERT [dbo].[customer] ([customer_id], [cust_name], [city], [grade], [salesman_id]) VALUES (3008, N'Julian Green', N'Landon', CAST(300 AS Numeric(3, 0)), CAST(5002 AS Numeric(5, 0)))
INSERT [dbo].[customer] ([customer_id], [cust_name], [city], [grade], [salesman_id]) VALUES (3009, N'Geoff Cameron', N'Paris', CAST(300 AS Numeric(3, 0)), CAST(5003 AS Numeric(5, 0)))
GO
INSERT [dbo].[orders] ([ord_no], [purch_amt], [ord_date], [customer_id], [salesman_id]) VALUES (70001, CAST(150.50 AS Decimal(8, 2)), CAST(N'2012-10-05' AS Date), CAST(3005 AS Numeric(5, 0)), CAST(5002 AS Numeric(5, 0)))
INSERT [dbo].[orders] ([ord_no], [purch_amt], [ord_date], [customer_id], [salesman_id]) VALUES (70002, CAST(65.26 AS Decimal(8, 2)), CAST(N'2012-10-05' AS Date), CAST(3002 AS Numeric(5, 0)), CAST(5001 AS Numeric(5, 0)))
INSERT [dbo].[orders] ([ord_no], [purch_amt], [ord_date], [customer_id], [salesman_id]) VALUES (70003, CAST(2480.40 AS Decimal(8, 2)), CAST(N'2012-10-10' AS Date), CAST(3005 AS Numeric(5, 0)), CAST(5002 AS Numeric(5, 0)))
INSERT [dbo].[orders] ([ord_no], [purch_amt], [ord_date], [customer_id], [salesman_id]) VALUES (70004, CAST(110.50 AS Decimal(8, 2)), CAST(N'2012-08-17' AS Date), CAST(3009 AS Numeric(5, 0)), CAST(5003 AS Numeric(5, 0)))
INSERT [dbo].[orders] ([ord_no], [purch_amt], [ord_date], [customer_id], [salesman_id]) VALUES (70005, CAST(2400.60 AS Decimal(8, 2)), CAST(N'2012-07-27' AS Date), CAST(3005 AS Numeric(5, 0)), CAST(5002 AS Numeric(5, 0)))
INSERT [dbo].[orders] ([ord_no], [purch_amt], [ord_date], [customer_id], [salesman_id]) VALUES (70007, CAST(948.50 AS Decimal(8, 2)), CAST(N'2012-09-10' AS Date), CAST(3005 AS Numeric(5, 0)), CAST(5002 AS Numeric(5, 0)))
INSERT [dbo].[orders] ([ord_no], [purch_amt], [ord_date], [customer_id], [salesman_id]) VALUES (70008, CAST(5760.00 AS Decimal(8, 2)), CAST(N'2012-09-10' AS Date), CAST(3005 AS Numeric(5, 0)), CAST(5002 AS Numeric(5, 0)))
INSERT [dbo].[orders] ([ord_no], [purch_amt], [ord_date], [customer_id], [salesman_id]) VALUES (70009, CAST(270.65 AS Decimal(8, 2)), CAST(N'2012-09-10' AS Date), CAST(3001 AS Numeric(5, 0)), CAST(5005 AS Numeric(5, 0)))
INSERT [dbo].[orders] ([ord_no], [purch_amt], [ord_date], [customer_id], [salesman_id]) VALUES (70010, CAST(1983.43 AS Decimal(8, 2)), CAST(N'2012-10-10' AS Date), CAST(3005 AS Numeric(5, 0)), CAST(5002 AS Numeric(5, 0)))
INSERT [dbo].[orders] ([ord_no], [purch_amt], [ord_date], [customer_id], [salesman_id]) VALUES (70011, CAST(75.29 AS Decimal(8, 2)), CAST(N'2012-08-17' AS Date), CAST(3005 AS Numeric(5, 0)), CAST(5002 AS Numeric(5, 0)))
INSERT [dbo].[orders] ([ord_no], [purch_amt], [ord_date], [customer_id], [salesman_id]) VALUES (70012, CAST(250.45 AS Decimal(8, 2)), CAST(N'2012-06-27' AS Date), CAST(3005 AS Numeric(5, 0)), CAST(5002 AS Numeric(5, 0)))
INSERT [dbo].[orders] ([ord_no], [purch_amt], [ord_date], [customer_id], [salesman_id]) VALUES (70013, CAST(3045.00 AS Decimal(8, 2)), CAST(N'2012-04-25' AS Date), CAST(3005 AS Numeric(5, 0)), CAST(5002 AS Numeric(5, 0)))
GO
INSERT [dbo].[salesman] ([salesman_id], [name], [city], [comission]) VALUES (5001, N'James Hoog', N'New York', CAST(0.15 AS Decimal(5, 2)))
INSERT [dbo].[salesman] ([salesman_id], [name], [city], [comission]) VALUES (5002, N'Nail knite', N'Paris', CAST(0.13 AS Decimal(5, 2)))
INSERT [dbo].[salesman] ([salesman_id], [name], [city], [comission]) VALUES (5003, N'Lauson Hen', N'Sone Jose', CAST(0.12 AS Decimal(5, 2)))
INSERT [dbo].[salesman] ([salesman_id], [name], [city], [comission]) VALUES (5005, N'Pit Alex', N'Landon', CAST(0.11 AS Decimal(5, 2)))
INSERT [dbo].[salesman] ([salesman_id], [name], [city], [comission]) VALUES (5006, N'Mc Lyon', N'Paris', CAST(0.14 AS Decimal(5, 2)))
INSERT [dbo].[salesman] ([salesman_id], [name], [city], [comission]) VALUES (5007, N'Paul Adam', N'Rome', CAST(0.13 AS Decimal(5, 2)))
GO
USE [master]
GO
ALTER DATABASE [Mytraining] SET  READ_WRITE 
GO
