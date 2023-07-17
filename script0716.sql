USE [master]
GO
/****** Object:  Database [HommieStore]    Script Date: 7/16/2023 10:44:07 PM ******/
CREATE DATABASE [HommieStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HommieStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.TRANWIBU\MSSQL\DATA\HommieStore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HommieStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.TRANWIBU\MSSQL\DATA\HommieStore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HommieStore] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HommieStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HommieStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HommieStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HommieStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HommieStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HommieStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [HommieStore] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [HommieStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HommieStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HommieStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HommieStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HommieStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HommieStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HommieStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HommieStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HommieStore] SET  ENABLE_BROKER 
GO
ALTER DATABASE [HommieStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HommieStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HommieStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HommieStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HommieStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HommieStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HommieStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HommieStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HommieStore] SET  MULTI_USER 
GO
ALTER DATABASE [HommieStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HommieStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HommieStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HommieStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HommieStore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HommieStore] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [HommieStore] SET QUERY_STORE = OFF
GO
USE [HommieStore]
GO
/****** Object:  Table [dbo].[Cart]    Script Date: 7/16/2023 10:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cart](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](45) NOT NULL,
	[ProductID] [int] NULL,
	[Quantity] [int] NULL,
	[LastUpdatedTime] [datetime] NULL,
 CONSTRAINT [PK_tblcart] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 7/16/2023 10:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblcategory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 7/16/2023 10:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](45) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
	[Address] [nvarchar](400) NOT NULL,
	[OrderTime] [datetime] NULL,
	[Message] [nvarchar](400) NULL,
	[ShippingFee] [float] NULL,
	[Status] [varchar](20) NULL,
	[Comment] [nvarchar](200) NULL,
	[LastUpdatedTime] [datetime] NULL,
 CONSTRAINT [PK_tblorder] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 7/16/2023 10:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NULL,
	[ProductID] [int] NULL,
	[Price] [float] NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_tblorder_detail] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 7/16/2023 10:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](400) NULL,
	[Quantity] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[CategoryID] [int] NULL,
	[Avatar] [varchar](5000) NULL,
	[Status] [bit] NOT NULL,
	[isDelete] [bit] NULL,
 CONSTRAINT [PK_tblproduct] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 7/16/2023 10:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Username] [varchar](45) NOT NULL,
	[Email] [varchar](320) NOT NULL,
	[Role] [varchar](50) NOT NULL,
	[Password] [varchar](59) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Gender] [tinyint] NULL,
	[Phone] [varchar](20) NULL,
	[Yob] [int] NULL,
	[Address] [nvarchar](400) NULL,
	[Avatar] [varchar](1000) NULL,
	[Enabled] [bit] NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cart] ON 

INSERT [dbo].[Cart] ([ID], [Username], [ProductID], [Quantity], [LastUpdatedTime]) VALUES (3, N'duyduc', 3, 5, CAST(N'2023-07-16T22:24:15.720' AS DateTime))
SET IDENTITY_INSERT [dbo].[Cart] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([ID], [Name]) VALUES (1, N'Cốc Sứ')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (2, N'Đồ Chơi')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (3, N'Đồng Hồ')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (4, N'Đèn Ngủ')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (5, N'Khung Ảnh')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (6, N'Hộp Bút')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([ID], [Username], [Name], [Phone], [Address], [OrderTime], [Message], [ShippingFee], [Status], [Comment], [LastUpdatedTime]) VALUES (1, N'duyduc', N'Duy Đức', N'09348984112', N'Thu Duc City', CAST(N'2023-06-15T16:01:40.000' AS DateTime), NULL, 10000, N'CONFIRMED', NULL, CAST(N'2023-06-15T16:01:40.000' AS DateTime))
INSERT [dbo].[Order] ([ID], [Username], [Name], [Phone], [Address], [OrderTime], [Message], [ShippingFee], [Status], [Comment], [LastUpdatedTime]) VALUES (2, N'duyduc', N'Quyết Trần', N'09765464645', N'Thu Duc City', CAST(N'2023-05-14T16:01:40.000' AS DateTime), NULL, 20000, N'PENDING', NULL, CAST(N'2023-05-14T16:01:40.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

INSERT [dbo].[OrderDetail] ([ID], [OrderID], [ProductID], [Price], [Quantity]) VALUES (7, 1, 4, 129000, 4)
INSERT [dbo].[OrderDetail] ([ID], [OrderID], [ProductID], [Price], [Quantity]) VALUES (8, 2, 3, 120000, 1)
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ID], [Name], [Description], [Quantity], [Price], [CategoryID], [Avatar], [Status], [isDelete]) VALUES (3, N'Bộ Cốc Sứ Tháp Eiffel x4', N'Bộ cốc được làm từ chất liệu sứ cao cấp với lớp men phủ bóng màu trắng sứ siêu nhẵn mịn.Dễ dàng chùi rửa sau mỗi lần sử dụng.Trên thân cốc được in họa tiết tháp Eiffel màu nâu mang phong cách cổ điển.Kích thước bộ cốc cao 21 cm. Đường kính miệng cốc là 7 cm', 999, 149000, 1, N'https://shopquatructuyen.com/wp-content/uploads/2018/07/bo-coc-su-thap-eiffel-2.jpg', 1, 1)
INSERT [dbo].[Product] ([ID], [Name], [Description], [Quantity], [Price], [CategoryID], [Avatar], [Status], [isDelete]) VALUES (4, N'Hộp đựng bút TOTORO', N'Hộp Đựng Bút Totoro Siêu Dễ Thương - Hộp Đựng Đồ Dùng Học Tập. Hộp bút in hình dễ thương. Chất liệu da PU, lót vải bố bên trong. Khóa may chắc chắn.', 999, 59000, 6, N'https://salt.tikicdn.com/cache/750x750/ts/product/a4/d3/bc/accd80f0b82a0a1a38bd3b667ff11114.jpg', 1, 0)
INSERT [dbo].[Product] ([ID], [Name], [Description], [Quantity], [Price], [CategoryID], [Avatar], [Status], [isDelete]) VALUES (7, N'Cốc Sứ Nốt Nhạc', N'Cốc sứ nốt nhạc được làm từ chất liệu sứ cao cấp với men trắng bóng.Trên thân cốc được in họa tiết đàn piano, nốt nhạc với màu đen tương phản rất đẹp mắt.Cốc sứ nốt nhạc đi kèm với nắp gỗ và thìa inox. Thể tích khoảng 400 ml.', 999, 139000, 1, N'https://shopquatructuyen.com/wp-content/uploads/2018/09/coc-tu-khuay-1.jpg', 1, 0)
INSERT [dbo].[Product] ([ID], [Name], [Description], [Quantity], [Price], [CategoryID], [Avatar], [Status], [isDelete]) VALUES (8, N'Cốc Phát Sáng', N'Cốc phát sáng làm từ chất liệu nhựa cứng. Sản phẩm dùng pin. Có chức năng tự động sáng khi rót nước. Khi hết nước cốc sẽ tự tắt. Đèn Led phát sáng đổi màu liên tục', 999, 89000, 1, N'https://shopquatructuyen.com/wp-content/uploads/2020/10/con-quay-mezmotop-4.jpg', 1, 0)
INSERT [dbo].[Product] ([ID], [Name], [Description], [Quantity], [Price], [CategoryID], [Avatar], [Status], [isDelete]) VALUES (9, N'Đồng Hồ Cổ Để Bàn', N'Đồng hồ cổ để bàn được là theo phong cách cổ điển với chất liệu kim loại được sơn màu vàng đồng nhuốm màu thời gian. Trông chiếc đồng hồ tưởng chừng rất cũ kỹ nhưng thực ra lại không phải như vậy. Thiết kế cổ điển cùng với màu sắc giả cổ đã tôn lên vẻ cổ kính cho chiếc đồng hồ này.', 999, 499000, 3, N'https://shopquatructuyen.com/wp-content/uploads/2018/08/dong-ho-dan-tuong-diy-clocl-1.jpg', 1, 0)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
INSERT [dbo].[User] ([Username], [Email], [Role], [Password], [Name], [Gender], [Phone], [Yob], [Address], [Avatar], [Enabled]) VALUES (N'duyduc', N'duyduc@gmail.com', N'CUSTOMER', N'123456', N'Duy Đức', 1, N'0934968395', 2002, N'Thu Duc City', NULL, 1)
INSERT [dbo].[User] ([Username], [Email], [Role], [Password], [Name], [Gender], [Phone], [Yob], [Address], [Avatar], [Enabled]) VALUES (N'quyettran', N'quyettran@gmail.com', N'STAFF', N'123456', N'Quyết Trần', 1, N'0897844555', 2002, N'12th District', NULL, 1)
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_enabled]  DEFAULT ((1)) FOR [Enabled]
GO
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD  CONSTRAINT [FK_Cart_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[Cart] CHECK CONSTRAINT [FK_Cart_Product]
GO
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD  CONSTRAINT [FK_Cart_User] FOREIGN KEY([Username])
REFERENCES [dbo].[User] ([Username])
GO
ALTER TABLE [dbo].[Cart] CHECK CONSTRAINT [FK_Cart_User]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Orders_User] FOREIGN KEY([Username])
REFERENCES [dbo].[User] ([Username])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Orders_User]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([ID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Orders]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([ID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
USE [master]
GO
ALTER DATABASE [HommieStore] SET  READ_WRITE 
GO
