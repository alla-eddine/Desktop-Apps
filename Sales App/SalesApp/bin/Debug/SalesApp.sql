USE [master]
GO
/****** Object:  Database [sales]    Script Date: 22/02/2025 6:55:42 PM ******/
CREATE DATABASE [sales]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'sales', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\sales.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'sales_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\sales_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [sales] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sales].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sales] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sales] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sales] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sales] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sales] SET ARITHABORT OFF 
GO
ALTER DATABASE [sales] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [sales] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sales] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sales] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sales] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sales] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sales] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sales] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sales] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sales] SET  DISABLE_BROKER 
GO
ALTER DATABASE [sales] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sales] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sales] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sales] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sales] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sales] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [sales] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sales] SET RECOVERY FULL 
GO
ALTER DATABASE [sales] SET  MULTI_USER 
GO
ALTER DATABASE [sales] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sales] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sales] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [sales] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
USE [sales]
GO
/****** Object:  Table [dbo].[Barcode]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barcode](
	[Pro_Name] [nvarchar](250) NULL,
	[Pro_Barcode] [nvarchar](250) NULL,
	[Pro_Price] [nvarchar](250) NULL,
	[barcode] [nvarchar](250) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Buy]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buy](
	[Order_Id] [int] NOT NULL,
	[Date] [nvarchar](50) NULL,
	[Sup_Id] [int] NULL,
 CONSTRAINT [PK_Buy] PRIMARY KEY CLUSTERED 
(
	[Order_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Buy_Detail]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buy_Detail](
	[Order_Id] [int] NULL,
	[Sup_Id] [int] NULL,
	[Pro_Id] [int] NULL,
	[Date] [nvarchar](50) NULL,
	[Qty] [real] NULL,
	[User_Name] [nvarchar](50) NULL,
	[Price] [real] NULL,
	[Discount] [real] NULL,
	[Total] [real] NULL,
	[Total_Order] [real] NULL,
	[Price_Paid] [real] NULL,
	[Price_Rest] [real] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Client_Id] [nvarchar](250) NOT NULL,
	[Client_Name] [nvarchar](50) NULL,
	[Client_Adress] [nvarchar](250) NULL,
	[Client_Phone] [nvarchar](50) NULL,
	[Client_Notes] [nvarchar](350) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Client_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer_Money]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_Money](
	[Order_Id] [int] NULL,
	[Cus_Name] [nvarchar](250) NULL,
	[Price] [real] NULL,
	[Order_Date] [nvarchar](50) NULL,
	[Reminder_Date] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer_Report]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_Report](
	[Order_Id] [int] NULL,
	[Price] [real] NULL,
	[Date] [varchar](50) NULL,
	[Cus_Name] [nvarchar](250) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deserved]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deserved](
	[Des_Id] [int] NOT NULL,
	[Des_Price] [real] NOT NULL,
	[Des_Date] [nvarchar](50) NOT NULL,
	[Des_Note] [nvarchar](250) NULL,
	[Type_Id] [int] NOT NULL,
 CONSTRAINT [PK_Deserved_1] PRIMARY KEY CLUSTERED 
(
	[Des_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeservedType]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeservedType](
	[DesType_Id] [int] IDENTITY(1,1) NOT NULL,
	[DesType_Name] [nvarchar](250) NULL,
 CONSTRAINT [PK_Deserved] PRIMARY KEY CLUSTERED 
(
	[DesType_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employe]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employe](
	[Emp_Id] [int] IDENTITY(1,1) NOT NULL,
	[Emp_Name] [nvarchar](50) NULL,
	[Emp_Adress] [nvarchar](250) NULL,
	[Emp_Phone] [nvarchar](50) NULL,
	[Sallary] [real] NULL,
 CONSTRAINT [PK_Employe] PRIMARY KEY CLUSTERED 
(
	[Emp_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderPrintData]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderPrintData](
	[Logo] [image] NULL,
	[Name] [nchar](250) NULL,
	[Address] [nchar](250) NULL,
	[Description] [nchar](250) NULL,
	[Phone] [nchar](250) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Pro_Id] [int] IDENTITY(1,1) NOT NULL,
	[Pro_Name] [nvarchar](250) NULL,
	[Qty] [real] NULL,
	[Buy_Price] [real] NULL,
	[Pro_Image] [varbinary](max) NULL,
	[MinQty] [real] NULL,
	[Wholesell_Price] [real] NULL,
	[Retail_Price] [real] NULL,
	[MaxDiscount] [real] NULL,
	[Profit] [real] NULL,
	[Barcode] [nvarchar](250) NULL,
	[IdCategorie] [int] NULL,
	[PriceShow] [real] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Pro_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products_Group]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products_Group](
	[Group_Id] [int] NOT NULL,
	[Group_Name] [varchar](150) NOT NULL,
 CONSTRAINT [PK_Categorie] PRIMARY KEY CLUSTERED 
(
	[Group_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Random_Barcode]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Random_Barcode](
	[Barcode] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Return]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Return](
	[Order_Id] [int] IDENTITY(1,1) NOT NULL,
	[Order_Date] [nvarchar](50) NULL,
 CONSTRAINT [PK_Return] PRIMARY KEY CLUSTERED 
(
	[Order_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Return_Details]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Return_Details](
	[Order_Id] [int] NULL,
	[Cust_Id] [int] NULL,
	[Sup_Id] [int] NULL,
	[Pro_Id] [int] NULL,
	[Date] [nvarchar](50) NULL,
	[Qty] [real] NULL,
	[User_Name] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sale]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[Order_Id] [int] NOT NULL,
	[Date] [nvarchar](50) NULL,
	[Cust_Name] [nvarchar](250) NULL,
 CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED 
(
	[Order_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sale_Details]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale_Details](
	[Order_Id] [int] NULL,
	[Cust_Name] [nvarchar](250) NULL,
	[Pro_Id] [int] NULL,
	[Date] [nvarchar](50) NULL,
	[Qty] [real] NULL,
	[User_Name] [nvarchar](50) NULL,
	[Price] [real] NULL,
	[Discount] [real] NULL,
	[Total] [real] NULL,
	[Total_Order] [real] NULL,
	[Price_Paid] [real] NULL,
	[Price_Rest] [real] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales_Rb7h]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales_Rb7h](
	[Order_Id] [int] NULL,
	[Cust_Name] [nvarchar](250) NULL,
	[Pro_Id] [int] NULL,
	[Date] [nvarchar](50) NULL,
	[Qty] [real] NULL,
	[User_Name] [nvarchar](50) NULL,
	[Price] [real] NULL,
	[Discount] [real] NULL,
	[Total] [real] NULL,
	[Total_Order] [real] NULL,
	[Price_Paid] [real] NULL,
	[Price_Rest] [real] NULL,
	[BuyPrice] [real] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Store]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Store](
	[Store_Id] [int] NOT NULL,
	[Store_Name] [nvarchar](250) NULL,
 CONSTRAINT [PK_Store] PRIMARY KEY CLUSTERED 
(
	[Store_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier_Money]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier_Money](
	[Order_Id] [int] NULL,
	[Sup_Id] [int] NULL,
	[Price] [real] NULL,
	[Order_Date] [nvarchar](50) NULL,
	[Reminder_Date] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier_Report]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier_Report](
	[Order_Id] [int] NULL,
	[Price] [real] NULL,
	[Date] [varchar](50) NULL,
	[Sup_Id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[Sup_Id] [int] IDENTITY(1,1) NOT NULL,
	[Sup_Name] [nvarchar](50) NULL,
	[Sup_Adress] [nvarchar](250) NULL,
	[Sup_Phone] [nvarchar](50) NULL,
	[Sup_Notes] [nvarchar](350) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[Sup_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[Unit_Id] [int] NOT NULL,
	[Unit_Name] [nvarchar](250) NULL,
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[Unit_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserAccess]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAccess](
	[User_ID] [int] NOT NULL,
	[User_Sales] [nvarchar](50) NULL,
	[User_Purchase] [nvarchar](50) NULL,
	[User_Products] [nvarchar](50) NULL,
	[User_Expances] [nvarchar](50) NULL,
	[User_Returns] [nvarchar](50) NULL,
	[User_Clients] [nvarchar](50) NULL,
	[User_Setting] [nvarchar](50) NULL,
	[User_Users] [nvarchar](50) NULL,
	[User_Supplier] [nvarchar](50) NULL,
	[User_SalesReport] [nvarchar](50) NULL,
	[User_PurchaseReport] [nvarchar](50) NULL,
	[User_SalesRebh] [nvarchar](50) NULL,
	[User_TopProduct] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[User_Id] [int] IDENTITY(1,1) NOT NULL,
	[User_Name] [nvarchar](250) NOT NULL,
	[User_Password] [nvarchar](250) NOT NULL,
	[User_Type] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[User_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[UserAccess] ([User_ID], [User_Sales], [User_Purchase], [User_Products], [User_Expances], [User_Returns], [User_Clients], [User_Setting], [User_Users], [User_Supplier], [User_SalesReport], [User_PurchaseReport], [User_SalesRebh], [User_TopProduct]) VALUES (13, N'true', N'true', N'true', N'true', N'true', N'true', N'true', N'true', N'true', N'true', N'true', N'true', N'true')
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([User_Id], [User_Name], [User_Password], [User_Type]) VALUES (13, N'a', N'a', N'admin')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Buy_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Buy_Detail_Buy] FOREIGN KEY([Order_Id])
REFERENCES [dbo].[Buy] ([Order_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Buy_Detail] CHECK CONSTRAINT [FK_Buy_Detail_Buy]
GO
ALTER TABLE [dbo].[Buy_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Buy_Detail_Products] FOREIGN KEY([Pro_Id])
REFERENCES [dbo].[Products] ([Pro_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Buy_Detail] CHECK CONSTRAINT [FK_Buy_Detail_Products]
GO
ALTER TABLE [dbo].[Buy_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Buy_Detail_Suppliers] FOREIGN KEY([Sup_Id])
REFERENCES [dbo].[Suppliers] ([Sup_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Buy_Detail] CHECK CONSTRAINT [FK_Buy_Detail_Suppliers]
GO
ALTER TABLE [dbo].[Deserved]  WITH CHECK ADD  CONSTRAINT [FK_Deserved_DeservedType] FOREIGN KEY([Type_Id])
REFERENCES [dbo].[DeservedType] ([DesType_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Deserved] CHECK CONSTRAINT [FK_Deserved_DeservedType]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categorie] FOREIGN KEY([IdCategorie])
REFERENCES [dbo].[Products_Group] ([Group_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categorie]
GO
ALTER TABLE [dbo].[Return_Details]  WITH CHECK ADD  CONSTRAINT [FK_Return_Details_Products] FOREIGN KEY([Pro_Id])
REFERENCES [dbo].[Products] ([Pro_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Return_Details] CHECK CONSTRAINT [FK_Return_Details_Products]
GO
ALTER TABLE [dbo].[Return_Details]  WITH CHECK ADD  CONSTRAINT [FK_Return_Details_Return] FOREIGN KEY([Order_Id])
REFERENCES [dbo].[Return] ([Order_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Return_Details] CHECK CONSTRAINT [FK_Return_Details_Return]
GO
ALTER TABLE [dbo].[Sale_Details]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Details_Products] FOREIGN KEY([Pro_Id])
REFERENCES [dbo].[Products] ([Pro_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sale_Details] CHECK CONSTRAINT [FK_Sale_Details_Products]
GO
ALTER TABLE [dbo].[Sale_Details]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Details_Sale] FOREIGN KEY([Order_Id])
REFERENCES [dbo].[Sale] ([Order_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sale_Details] CHECK CONSTRAINT [FK_Sale_Details_Sale]
GO
/****** Object:  StoredProcedure [dbo].[BuyReports]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[BuyReports]

AS




SELECT [Order_Id] as 'رقم الفاتورة' ,Suppliers.Sup_Name as 'إسم المورد' ,Products.Pro_Name as 'إسم المنتج' ,[Date] as 'تاريخ الفاتورة' ,[Buy_Detail].[Qty] as 'الكمية' ,[Price] as 'سعر الشراء' ,[Discount] as 'الخصم' ,[Total] as 'الإجمالي' ,[Total_Order] as 'إجمالي الفاتورة' ,[Price_Paid] as 'المبلغ المدفوع' ,[Price_Rest] as 'المبلغ المتبقي' ,[User_Name] as 'إسم المستخدم' FROM [dbo].[Buy_Detail],Suppliers,Products where [Buy_Detail].Sup_Id = Suppliers.Sup_Id and [Buy_Detail].Pro_Id = Products.Pro_Id  ORDER BY Order_Id ASC
GO
/****** Object:  StoredProcedure [dbo].[CustomerMoneyReport]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




create procedure [dbo].[CustomerMoneyReport]

AS


SELECT [Order_Id] as 'رقم الفاتورة' , [Cus_Name] as 'اسم العميل' , [Price] as 'المبلغ' , [Order_Date] as 'تاريخ الفاتورة' , [Reminder_Date] as 'تاريخ الاستحقاق' FROM [dbo].[Customer_Money]
GO
/****** Object:  StoredProcedure [dbo].[OrderBuy]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[OrderBuy]
as
SELECT [Order_Id] as 'رقم الفاتورة'
      ,Suppliers.Sup_Name as 'اسم المورد'
      ,Products.Pro_Name as 'اسم المنتج'
      ,[Date] as 'تاريخ الفاتورة'
      ,[Buy_Detail].[Qty] as 'الكمية'
      ,[User_Name] as 'اسم المستخدم'
      ,[Price] as 'سعر الشراء'
      ,[Discount] as 'الخصم'
      ,[Total] as 'اجمالي المنتج'
      ,[Total_Order] as 'الاجمالي الكلي'
      ,[Price_Paid] as 'المبلغ المدفوع'
      ,[Price_Rest] as 'المبلغ المتبقي'
FROM [dbo].[Buy_Detail],Suppliers,Products where Suppliers.Sup_Id = [Buy_Detail].Sup_Id and Products.Pro_Id = [Buy_Detail].Pro_Id 

GO
/****** Object:  StoredProcedure [dbo].[OrderSale]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [dbo].[OrderSale]

AS



SELECT [Order_Id] as 'رقم الفاتورة' , [Cust_Name] as 'العميل' , Products.Pro_Name as 'المنتج' , [Sale_Details].[Qty] as 'الكمية' ,[Price] as 'السعر' ,[Discount] as 'الخصم' ,[Total] as 'الاجمالي' ,[Total_Order] as 'اجمالي الفاتورة' ,[Price_Paid] as 'مبلغ المدفوع' ,[Price_Rest] as 'المتبقي' ,[User_Name] as 'المستخدم' , [Date] as 'التاريخ' FROM [dbo].[Sale_Details],Products where Products.Pro_Id = Sale_Details.Pro_Id
GO
/****** Object:  StoredProcedure [dbo].[SaleReports]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [dbo].[SaleReports]

AS



SELECT [Order_Id] as 'رقم الفاتورة' , [Cust_Name] as 'العميل' , Products.Pro_Name as 'المنتج' , [Sale_Details].[Qty] as 'الكمية' ,[Price] as 'السعر' ,[Discount] as 'الخصم' ,[Total] as 'الاجمالي' ,[Total_Order] as 'اجمالي الفاتورة' ,[Price_Paid] as 'مبلغ المدفوع' ,[Price_Rest] as 'المتبقي' ,[User_Name] as 'المستخدم' , [Date] as 'التاريخ' FROM [dbo].[Sale_Details],Products where Products.Pro_Id = Sale_Details.Pro_Id
GO
/****** Object:  StoredProcedure [dbo].[SalesRb7h]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[SalesRb7h]

AS




SELECT [Order_Id] as 'رقم الفاتورة' , [Cust_Name] as 'العميل' , Products.Pro_Name as 'المنتج' , [Sales_Rb7h].[Qty] as 'الكمية' , [BuyPrice] as 'سعر الشراء' ,[Price] as 'سعر البيع' ,[Discount] as 'الخصم' ,[Total] as 'الاجمالي' ,(Price - BuyPrice) * (Sales_Rb7h.Qty) as 'إجمالي الربح',[Total_Order] as 'اجمالي الفاتورة' ,[Price_Paid] as 'مبلغ المدفوع' ,[Price_Rest] as 'المتبقي' ,[User_Name] as 'المستخدم' , [Date] as 'التاريخ' FROM [dbo].[Sales_Rb7h],Products where Products.Pro_Id = Sales_Rb7h.Pro_Id order by Order_Id ASC
GO
/****** Object:  StoredProcedure [dbo].[SupplierMonneyReport]    Script Date: 22/02/2025 6:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE procedure [dbo].[SupplierMonneyReport]

AS


SELECT [Order_Id] AS 'رقم الفاتورة' ,Suppliers.Sup_Id AS 'رقم المورد' ,Suppliers.Sup_Name AS 'إسم المورد' ,[Price] AS 'المبلغ' ,[Order_Date] AS 'تاريخ الفاتورة' ,[Reminder_Date] AS 'تاريخ التسديد' FROM [dbo].[Supplier_Money], Suppliers WHERE  Suppliers.Sup_Id = [Supplier_Money].Sup_Id

GO
USE [master]
GO
ALTER DATABASE [sales] SET  READ_WRITE 
GO
