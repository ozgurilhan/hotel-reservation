USE [master]
GO
/****** Object:  Database [Reservation]    Script Date: 31/05/2022 14:38:57 ******/
CREATE DATABASE [Reservation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Reservation', FILENAME = N'/var/opt/mssql/data/Reservation.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Reservation_log', FILENAME = N'/var/opt/mssql/data/Reservation_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Reservation] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Reservation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Reservation] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Reservation] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Reservation] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Reservation] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Reservation] SET ARITHABORT OFF 
GO
ALTER DATABASE [Reservation] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Reservation] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Reservation] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Reservation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Reservation] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Reservation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Reservation] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Reservation] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Reservation] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Reservation] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Reservation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Reservation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Reservation] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Reservation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Reservation] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Reservation] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Reservation] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Reservation] SET RECOVERY FULL 
GO
ALTER DATABASE [Reservation] SET  MULTI_USER 
GO
ALTER DATABASE [Reservation] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Reservation] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Reservation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Reservation] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Reservation] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Reservation] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Reservation] SET QUERY_STORE = OFF
GO
USE [Reservation]
GO
/****** Object:  User [KapadokyaUser]    Script Date: 31/05/2022 14:38:58 ******/
--CREATE USER [KapadokyaUser] FOR LOGIN [KapadokyaUser] WITH DEFAULT_SCHEMA=[dbo]
--GO
--ALTER ROLE [db_owner] ADD MEMBER [KapadokyaUser]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 31/05/2022 14:38:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NOT NULL,
	[CheckInTime] [datetime] NOT NULL,
	[CheckOutTime] [datetime] NOT NULL,
	[RoomId] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_Reservation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 31/05/2022 14:38:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[IsAdmin] [bit] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hotel]    Script Date: 31/05/2022 14:38:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hotel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NOT NULL,
	[HotelName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Hotel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 31/05/2022 14:38:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NOT NULL,
	[RoomName] [varchar](50) NOT NULL,
	[HotelId] [int] NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Booking] ON 

INSERT [dbo].[Booking] ([Id], [CreatedAt], [UpdatedAt], [CheckInTime], [CheckOutTime], [RoomId], [CustomerId], [Price]) VALUES (13, CAST(N'2022-05-30T16:43:28.847' AS DateTime), CAST(N'2022-05-30T16:43:28.847' AS DateTime), CAST(N'2022-05-03T00:00:00.000' AS DateTime), CAST(N'2022-05-06T00:00:00.000' AS DateTime), 1, 8, 300)
INSERT [dbo].[Booking] ([Id], [CreatedAt], [UpdatedAt], [CheckInTime], [CheckOutTime], [RoomId], [CustomerId], [Price]) VALUES (14, CAST(N'2022-05-31T08:54:28.437' AS DateTime), CAST(N'2022-05-31T08:54:28.437' AS DateTime), CAST(N'2022-06-14T00:00:00.000' AS DateTime), CAST(N'2022-06-16T00:00:00.000' AS DateTime), 6, 8, 0)
INSERT [dbo].[Booking] ([Id], [CreatedAt], [UpdatedAt], [CheckInTime], [CheckOutTime], [RoomId], [CustomerId], [Price]) VALUES (15, CAST(N'2022-05-31T09:37:03.000' AS DateTime), CAST(N'2022-05-31T09:37:03.000' AS DateTime), CAST(N'2022-06-01T00:00:00.000' AS DateTime), CAST(N'2022-06-03T00:00:00.000' AS DateTime), 1, 3, 200)
SET IDENTITY_INSERT [dbo].[Booking] OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Id], [CreatedAt], [UpdatedAt], [FirstName], [LastName], [UserName], [Password], [IsAdmin]) VALUES (3, CAST(N'2022-05-27T21:49:30.097' AS DateTime), CAST(N'2022-05-27T21:49:30.097' AS DateTime), N'Hande', N'Sarica', N'hande', N'1234', 0)
INSERT [dbo].[Customer] ([Id], [CreatedAt], [UpdatedAt], [FirstName], [LastName], [UserName], [Password], [IsAdmin]) VALUES (4, CAST(N'2022-05-27T21:49:45.093' AS DateTime), CAST(N'2022-05-27T21:49:45.093' AS DateTime), N'Özgür', N'Ilhan', N'ozgur', N'1234', 0)
INSERT [dbo].[Customer] ([Id], [CreatedAt], [UpdatedAt], [FirstName], [LastName], [UserName], [Password], [IsAdmin]) VALUES (8, CAST(N'2022-05-27T21:49:45.093' AS DateTime), CAST(N'2022-05-27T21:49:45.093' AS DateTime), N'Admin', N'User', N'admin', N'admin', 1)
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Hotel] ON 

INSERT [dbo].[Hotel] ([Id], [CreatedAt], [UpdatedAt], [HotelName]) VALUES (1, CAST(N'2022-05-28T20:30:10.023' AS DateTime), CAST(N'2022-05-28T20:30:10.023' AS DateTime), N'Antalya Belek')
INSERT [dbo].[Hotel] ([Id], [CreatedAt], [UpdatedAt], [HotelName]) VALUES (2, CAST(N'2022-05-28T20:33:09.443' AS DateTime), CAST(N'2022-05-28T20:33:09.443' AS DateTime), N'Pera Palas')
INSERT [dbo].[Hotel] ([Id], [CreatedAt], [UpdatedAt], [HotelName]) VALUES (3, CAST(N'2022-05-28T20:40:51.920' AS DateTime), CAST(N'2022-05-28T20:40:51.920' AS DateTime), N'Hilton')
INSERT [dbo].[Hotel] ([Id], [CreatedAt], [UpdatedAt], [HotelName]) VALUES (11, CAST(N'2022-05-30T15:54:16.747' AS DateTime), CAST(N'2022-05-30T15:54:16.747' AS DateTime), N'New Hotel')
SET IDENTITY_INSERT [dbo].[Hotel] OFF
GO
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([Id], [CreatedAt], [UpdatedAt], [RoomName], [HotelId], [Price]) VALUES (1, CAST(N'2022-05-29T13:38:32.720' AS DateTime), CAST(N'2022-05-30T15:37:12.217' AS DateTime), N'101', 1, 100)
INSERT [dbo].[Room] ([Id], [CreatedAt], [UpdatedAt], [RoomName], [HotelId], [Price]) VALUES (2, CAST(N'2022-05-29T19:10:14.223' AS DateTime), CAST(N'2022-05-29T19:10:14.223' AS DateTime), N'102', 1, 0)
INSERT [dbo].[Room] ([Id], [CreatedAt], [UpdatedAt], [RoomName], [HotelId], [Price]) VALUES (3, CAST(N'2022-05-29T19:10:40.680' AS DateTime), CAST(N'2022-05-29T19:10:40.680' AS DateTime), N'1001', 2, 0)
INSERT [dbo].[Room] ([Id], [CreatedAt], [UpdatedAt], [RoomName], [HotelId], [Price]) VALUES (4, CAST(N'2022-05-29T19:10:55.987' AS DateTime), CAST(N'2022-05-29T19:10:55.987' AS DateTime), N'1002', 2, 0)
INSERT [dbo].[Room] ([Id], [CreatedAt], [UpdatedAt], [RoomName], [HotelId], [Price]) VALUES (5, CAST(N'2022-05-30T11:27:47.300' AS DateTime), CAST(N'2022-05-30T11:57:25.577' AS DateTime), N'102', 3, 50)
INSERT [dbo].[Room] ([Id], [CreatedAt], [UpdatedAt], [RoomName], [HotelId], [Price]) VALUES (6, CAST(N'2022-05-30T15:34:15.233' AS DateTime), CAST(N'2022-05-30T15:34:15.233' AS DateTime), N'103', 1, 0)
INSERT [dbo].[Room] ([Id], [CreatedAt], [UpdatedAt], [RoomName], [HotelId], [Price]) VALUES (7, CAST(N'2022-05-30T15:54:27.363' AS DateTime), CAST(N'2022-05-30T15:54:27.363' AS DateTime), N'1001', 11, 0)
INSERT [dbo].[Room] ([Id], [CreatedAt], [UpdatedAt], [RoomName], [HotelId], [Price]) VALUES (8, CAST(N'2022-05-30T15:54:33.677' AS DateTime), CAST(N'2022-05-30T15:54:33.677' AS DateTime), N'102', 11, 0)
SET IDENTITY_INSERT [dbo].[Room] OFF
GO
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_CreatedAt]  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_UpdatedAt]  DEFAULT (getdate()) FOR [UpdatedAt]
GO
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_IsAdmin]  DEFAULT ((0)) FOR [IsAdmin]
GO
ALTER TABLE [dbo].[Room] ADD  CONSTRAINT [DF_Room_Price]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_Hotel] FOREIGN KEY([HotelId])
REFERENCES [dbo].[Hotel] ([Id])
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_Hotel]
GO
/****** Object:  StoredProcedure [dbo].[sel_bookings_by_customer_id]    Script Date: 31/05/2022 14:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sel_bookings_by_customer_id](@customerId INT = NULL, @isAdmin BIT)
AS
BEGIN
	IF (@isAdmin = 1)
	SET @customerId = NULL;

	SELECT b.Id, b.CheckInTime, b.CheckOutTime, c.FirstName, c.LastName, r.RoomName, h.HotelName, b.Price FROM Booking b 
	LEFT JOIN Customer c ON b.CustomerId = c.Id
	LEFT JOIN Room r ON b.RoomId = r.Id
	LEFT JOIN Hotel h ON r.HotelId = h.Id
	WHERE ((@customerId = NULL OR @isAdmin = 1) OR b.CustomerId = @customerId)
	ORDER BY b.CheckInTime DESC
END
GO
/****** Object:  StoredProcedure [dbo].[sel_get_hotel_by_id]    Script Date: 31/05/2022 14:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sel_get_hotel_by_id](@id INT)
AS
BEGIN
	SELECT * FROM Hotel WHERE Id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sel_get_room_by_id]    Script Date: 31/05/2022 14:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sel_get_room_by_id](@id INT)
AS
BEGIN
	SELECT * FROM Room WHERE Id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sel_login]    Script Date: 31/05/2022 14:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sel_login] (@userName VARCHAR(50), @password VARCHAR(50))
AS
BEGIN
	SELECT * FROM Customer c WHERE c.UserName = @userName AND c.Password = @password
END
GO
/****** Object:  StoredProcedure [dbo].[sel_rooms_by_hotel_id]    Script Date: 31/05/2022 14:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sel_rooms_by_hotel_id](@hotelId INT)
AS
BEGIN
	SELECT * FROM Room r WHERE r.HotelId = @hotelId ORDER BY r.RoomName;
END
GO
/****** Object:  StoredProcedure [dbo].[sel_search_hotels]    Script Date: 31/05/2022 14:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sel_search_hotels](@hotelName VARCHAR(200))
AS
BEGIN
	SELECT * FROM Hotel h WHERE h.HotelName LIKE '%' + @hotelName + '%' ORDER BY h.HotelName 
END
GO
USE [master]
GO
ALTER DATABASE [Reservation] SET  READ_WRITE 
GO
