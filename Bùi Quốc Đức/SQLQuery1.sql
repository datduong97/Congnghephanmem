create database CNPM
use CNPM

CREATE TABLE [dbo].[Bill](
	[IdBill] [int] IDENTITY(1,1) NOT NULL primary key,
	[DateCheckIn] [date] NOT NULL,
	[DateCheckOut] [date] NOT NULL,
	[IdTable] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[Discount] [int] NOT NULL,
	[TotalPrice] [float] NOT NULL)
-------------------------------
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 5/25/2019 2:22:05 PM ******/

CREATE TABLE [dbo].[BillInfo](
	[IdBillInfo] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdBill] [int] NOT NULL,
	[IdFood] [int] NOT NULL,
	[IdDrink] [int] NULL,
	[Count] [float] NOT NULL,
	[IdEmp] [nvarchar](25) NULL)
GO
/****** Object:  Table [dbo].[BookedTable]    Script Date: 5/25/2019 2:22:05 PM ******/

CREATE TABLE [dbo].[BookedTable](
	[IdTable] [int] NOT NULL primary key,
	[CustomerName] [nvarchar](30) NOT NULL,
	[CustomerPhone] [nchar](12) NOT NULL,
	[CustomerAddress] [nvarchar](60) NOT NULL,
	[BookDate] [nchar](10) NOT NULL,
	[BookTimeStart] [char](10) NOT NULL,
	[BookTimeEnd] [char](10) NOT NULL)
GO
/****** Object:  Table [dbo].[Drink]    Script Date: 5/25/2019 2:22:05 PM ******/

CREATE TABLE [dbo].[Drink](
	[IdDrink] [int] IDENTITY(1,1) NOT NULL primary key,
	[DrinkName] [nvarchar](100) NOT NULL,
	[IdCategoryDrink] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[Image] [nvarchar](50) NULL)
GO
/****** Object:  Table [dbo].[DrinkCategory]    Script Date: 5/25/2019 2:22:05 PM ******/

CREATE TABLE [dbo].[DrinkCategory](
	[IdCategoryDrink] [int] NOT NULL primary key,
	[DrinkCategoryName] [nvarchar](100) NOT NULL)
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 5/25/2019 2:22:05 PM ******/

CREATE TABLE [dbo].[Employees](
	[IdEmp] [nvarchar](25) NOT NULL primary key,
	[Fullname] [nvarchar](50) NULL,
	[Address] [nvarchar](60) NULL,
	[Phone] [char](10) NULL,
)
GO
/****** Object:  Table [dbo].[Food]    Script Date: 5/25/2019 2:22:05 PM ******/

CREATE TABLE [dbo].[Food](
	[IdFood] [int] IDENTITY(1,1) NOT NULL primary key,
	[FoodName] [nvarchar](100) NOT NULL,
	[IdCategoryFood] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[Image] [nvarchar](50) NULL)
GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 5/25/2019 2:22:05 PM ******/

CREATE TABLE [dbo].[FoodCategory](
	[IdCategoryFood] [int] NOT NULL primary key,
	[FoodCategoryName] [nvarchar](100) NOT NULL,
 )
GO
/****** Object:  Table [dbo].[Table]    Script Date: 5/25/2019 2:22:05 PM ******/

CREATE TABLE [dbo].[Table](
	[IdTable] [int] IDENTITY(1,1) NOT NULL primary key,
	[TableName] [nvarchar](100) NOT NULL,
	[Status] [bit] NOT NULL)
GO
--------------------------------
CREATE TABLE [dbo].[Account](
	[Username] [nvarchar](100) NOT NULL primary key,
	[DisplayName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL)
-------------------------------------
INSERT [dbo].[Account]  VALUES (N'admin', N'admin', N'1', 1)
INSERT [dbo].[Account]  VALUES (N'admin1', N'Anh Duc', N'123456', 1)
INSERT [dbo].[Account]  VALUES (N'test', N'tester', N'12345', 1)
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ( [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES ( CAST(N'2019-05-25' AS Date), CAST(N'2019-05-25' AS Date), 1, 0, 20, 10)
INSERT [dbo].[Bill] ( [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES ( CAST(N'2019-05-25' AS Date), CAST(N'2019-05-25' AS Date), 11, 2, 0, 15)
INSERT [dbo].[Bill] ( [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES ( CAST(N'2019-05-14' AS Date), CAST(N'2019-05-25' AS Date), 0, 0, 10, 100)
INSERT [dbo].[Bill] ([DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES ( CAST(N'2019-05-06' AS Date), CAST(N'2019-05-25' AS Date), 0, 1, 10, 100)
SET IDENTITY_INSERT [dbo].[Bill] OFF
INSERT [dbo].[BookedTable] ([idTable], [CustomerName], [CustomerPhone], [CustomerAddress], [BookDate], [BookTimeStart], [BookTimeEnd]) VALUES (4, N'ád', N'0787        ', N'2_2018_2019', N'20/12/2018', N'5         ', N'6         ')
INSERT [dbo].[BookedTable] ([idTable], [CustomerName], [CustomerPhone], [CustomerAddress], [BookDate], [BookTimeStart], [BookTimeEnd]) VALUES (6, N'ád', N'qưqe        ', N'qưew', N'qưew      ', N'qewq      ', N'queqw     ')
INSERT [dbo].[BookedTable] ([idTable], [CustomerName], [CustomerPhone], [CustomerAddress], [BookDate], [BookTimeStart], [BookTimeEnd]) VALUES (7, N'ád', N'sad         ', N'ấ', N'đa        ', N'?         ', N'123       ')
SET IDENTITY_INSERT [dbo].[Drink] ON 

INSERT [dbo].[Drink] ([idDrink], [DrinkName], [idCategoryDrink], [price], [image]) VALUES (2, N'Trà Đào', 1, 20000, NULL)
INSERT [dbo].[Drink] ([idDrink], [DrinkName], [idCategoryDrink], [price], [image]) VALUES (3, N'Nước Cam', 2, 20000, NULL)
INSERT [dbo].[Drink] ([idDrink], [DrinkName], [idCategoryDrink], [price], [image]) VALUES (5, N'Nước Dâu', 2, 20000, NULL)
INSERT [dbo].[Drink] ([idDrink], [DrinkName], [idCategoryDrink], [price], [image]) VALUES (6, N'Trà Sữa 1', 1, 30000, NULL)
INSERT [dbo].[Drink] ([idDrink], [DrinkName], [idCategoryDrink], [price], [image]) VALUES (8, N'Trà đạo', 1, 20, NULL)
SET IDENTITY_INSERT [dbo].[Drink] OFF
SET IDENTITY_INSERT [dbo].[DrinkCategory] ON 
INSERT [dbo].[DrinkCategory] ([idCategoryDrink], [DrinkCategoryName]) VALUES (1, N'Trà')
INSERT [dbo].[DrinkCategory] ([idCategoryDrink], [DrinkCategoryName]) VALUES (2, N'Nước trái cây')
INSERT [dbo].[DrinkCategory] ([idCategoryDrink], [DrinkCategoryName]) VALUES (3, N'Nước ngọt')
INSERT [dbo].[DrinkCategory] ([idCategoryDrink], [DrinkCategoryName]) VALUES (4, N'Đồ uống khác')

INSERT [dbo].[Food] ( FoodName, [idCategoryFood], [price], [image]) VALUES ( N'KFC123', 1, 30000, N'tradau.png')
INSERT [dbo].[Food] ( FoodName, [idCategoryFood], [price], [image]) VALUES ( N'Khoai Tây chiên', 2, 20000, N'trabacha.jpg')
INSERT [dbo].[Food] ( FoodName, [idCategoryFood], [price], [image]) VALUES ( N'ga ran', 1, 1000078, NULL)
SET IDENTITY_INSERT [dbo].[Food] OFF
INSERT [dbo].[FoodCategory] ([idCategoryFood], [FoodCategoryName]) VALUES (1, N'Thức ăn nhanh')
INSERT [dbo].[FoodCategory] ([idCategoryFood], [FoodCategoryName]) VALUES (2, N'Thức ăn nhẹ')
SET IDENTITY_INSERT [dbo].[Table] ON 

INSERT [dbo].[Table] ( [TableName], [status]) VALUES ( N'Ban1', 0)
INSERT [dbo].[Table] ( [TableName], [status]) VALUES ( N'Ban moi sdat', 0)
INSERT [dbo].[Table] ( [TableName], [status]) VALUES ( N'ban duc', 1)
INSERT [dbo].[Table] ( [TableName], [status]) VALUES ( N'ban duc qee', 0)
INSERT [dbo].[Table] ( [TableName], [status]) VALUES ( N'Ban sưa', 0)
INSERT [dbo].[Table] ( [TableName], [status]) VALUES ( N'bàn 1 nè', 0)