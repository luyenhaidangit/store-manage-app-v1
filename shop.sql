USE [master]
GO
/****** Object:  Database [Shop]    Script Date: 14/04/2023 9:06:41 CH ******/
CREATE DATABASE [Shop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Shop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Shop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Shop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Shop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Shop] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Shop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Shop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Shop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Shop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Shop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Shop] SET ARITHABORT OFF 
GO
ALTER DATABASE [Shop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Shop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Shop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Shop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Shop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Shop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Shop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Shop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Shop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Shop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Shop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Shop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Shop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Shop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Shop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Shop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Shop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Shop] SET RECOVERY FULL 
GO
ALTER DATABASE [Shop] SET  MULTI_USER 
GO
ALTER DATABASE [Shop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Shop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Shop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Shop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Shop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Shop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Shop', N'ON'
GO
ALTER DATABASE [Shop] SET QUERY_STORE = ON
GO
ALTER DATABASE [Shop] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Shop]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 14/04/2023 9:06:41 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](80) NOT NULL,
	[Sex] [nvarchar](3) NOT NULL,
	[Birthday] [datetime] NULL,
	[NumberPhone] [varchar](10) NOT NULL,
	[Andress] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ImportBill]    Script Date: 14/04/2023 9:06:41 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImportBill](
	[Id] [int] NOT NULL,
	[StaffId] [int] NOT NULL,
	[SupplierId] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_ImportBill] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ImportBillDetails]    Script Date: 14/04/2023 9:06:41 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImportBillDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[ImportBillId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_ImportBillDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 14/04/2023 9:06:41 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[OrderId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 14/04/2023 9:06:41 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustormerId] [int] NOT NULL,
	[StaffId] [int] NOT NULL,
	[Status] [varchar](20) NOT NULL,
	[Andress] [nvarchar](200) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategories]    Script Date: 14/04/2023 9:06:41 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](80) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProductCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 14/04/2023 9:06:41 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](160) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Image] [nvarchar](160) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Quantity] [int] NOT NULL,
	[ProductCategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staffs]    Script Date: 14/04/2023 9:06:41 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staffs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](80) NOT NULL,
	[Sex] [nvarchar](3) NULL,
	[Birthday] [datetime] NOT NULL,
	[NumberPhone] [varchar](10) NOT NULL,
	[Andress] [nvarchar](200) NULL,
 CONSTRAINT [PK_Staffs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 14/04/2023 9:06:41 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](80) NOT NULL,
	[NumberPhone] [varchar](10) NOT NULL,
	[Email] [varchar](80) NOT NULL,
	[Andress] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ImportBill]  WITH CHECK ADD  CONSTRAINT [FK_ImportBill_Staffs] FOREIGN KEY([StaffId])
REFERENCES [dbo].[Staffs] ([Id])
GO
ALTER TABLE [dbo].[ImportBill] CHECK CONSTRAINT [FK_ImportBill_Staffs]
GO
ALTER TABLE [dbo].[ImportBill]  WITH CHECK ADD  CONSTRAINT [FK_ImportBill_Suppliers] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Suppliers] ([Id])
GO
ALTER TABLE [dbo].[ImportBill] CHECK CONSTRAINT [FK_ImportBill_Suppliers]
GO
ALTER TABLE [dbo].[ImportBillDetails]  WITH CHECK ADD  CONSTRAINT [FK_ImportBillDetails_ImportBill] FOREIGN KEY([ImportBillId])
REFERENCES [dbo].[ImportBill] ([Id])
GO
ALTER TABLE [dbo].[ImportBillDetails] CHECK CONSTRAINT [FK_ImportBillDetails_ImportBill]
GO
ALTER TABLE [dbo].[ImportBillDetails]  WITH CHECK ADD  CONSTRAINT [FK_ImportBillDetails_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[ImportBillDetails] CHECK CONSTRAINT [FK_ImportBillDetails_Products]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustormerId])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Staffs] FOREIGN KEY([StaffId])
REFERENCES [dbo].[Staffs] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Staffs]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_ProductCategories] FOREIGN KEY([ProductCategoryId])
REFERENCES [dbo].[ProductCategories] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_ProductCategories]
GO
USE [master]
GO
ALTER DATABASE [Shop] SET  READ_WRITE 
GO

INSERT INTO ProductCategories (Name, Description)
VALUES (N'Điện thoại', 'Hehe');
INSERT INTO ProductCategories (Name, Description)
VALUES (N'Máy tính', 'Hehe');
INSERT INTO ProductCategories (Name, Description)
VALUES (N'Bim bim', 'Hehe');
INSERT INTO ProductCategories (Name, Description)
VALUES (N'Bàn là', 'Hehe');

INSERT INTO Products (Name, Description, Image, Price, Quantity, ProductCategoryId)
VALUES (N'Iphone 14', N'Description for Product 1', 'image1.jpg', 10000000, 100, 1);

INSERT INTO Products (Name, Description, Image, Price, Quantity, ProductCategoryId)
VALUES (N'Iphone 15', N'Description for Product 1', 'image1.jpg', 9000000, 100, 1);

INSERT INTO Products (Name, Description, Image, Price, Quantity, ProductCategoryId)
VALUES (N'Iphone 16', N'Description for Product 1', 'image1.jpg', 9000000, 100, 1);


