USE [master]
GO
/****** Object:  Database [VetStationDb]    Script Date: 10/14/2022 8:23:31 AM ******/
CREATE DATABASE [VetStationDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VetStationDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVEREXP\MSSQL\DATA\VetStationDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VetStationDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVEREXP\MSSQL\DATA\VetStationDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [VetStationDb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VetStationDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VetStationDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VetStationDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VetStationDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VetStationDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VetStationDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [VetStationDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [VetStationDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VetStationDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VetStationDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VetStationDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VetStationDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VetStationDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VetStationDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VetStationDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VetStationDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [VetStationDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VetStationDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VetStationDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VetStationDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VetStationDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VetStationDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VetStationDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VetStationDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VetStationDb] SET  MULTI_USER 
GO
ALTER DATABASE [VetStationDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VetStationDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VetStationDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VetStationDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VetStationDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VetStationDb] SET QUERY_STORE = OFF
GO
USE [VetStationDb]
GO
/****** Object:  Table [dbo].[Animal]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animal](
	[AnimalID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[DateOfBirth] [datetime] NULL,
	[AnimalNote] [nvarchar](max) NULL,
	[Sex] [char](1) NOT NULL,
	[IsSterilized] [char](1) NOT NULL,
	[IsAlive] [char](1) NOT NULL,
	[IsDangerous] [char](1) NOT NULL,
	[DangerousExplaned] [nvarchar](max) NULL,
	[DateOfDeath] [datetime] NULL,
	[Description] [nvarchar](max) NOT NULL,
	[BreedID] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeleted] [datetime] NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_Animal] PRIMARY KEY CLUSTERED 
(
	[AnimalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnimalImage]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnimalImage](
	[AnimalImageID] [int] IDENTITY(1,1) NOT NULL,
	[AnimalImageUrl] [nvarchar](max) NOT NULL,
	[AnimalID] [int] NOT NULL,
	[Caption] [nvarchar](50) NULL,
	[IsMain] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeleted] [datetime] NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_AnimalImage] PRIMARY KEY CLUSTERED 
(
	[AnimalImageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnimalMicrochip]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnimalMicrochip](
	[AnimalMicrochipID] [int] NOT NULL,
	[MicrochipID] [int] NOT NULL,
	[AnimalID] [int] NOT NULL,
	[IsExternalMicrochip] [bit] NULL,
	[ExternalMicrochipNumber] [nvarchar](20) NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeleted] [datetime] NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_AnimalMicrochip] PRIMARY KEY CLUSTERED 
(
	[AnimalMicrochipID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnimalTreatement]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnimalTreatement](
	[AnimalTreatementID] [int] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[AnimalID] [int] NOT NULL,
	[IsPayed] [bit] NULL,
	[TotalPrice] [decimal](18, 2) NULL,
	[UserID] [int] NULL,
	[AppointementID] [int] NULL,
	[IsActive] [bit] NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeleted] [datetime] NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_AnimalTreatement] PRIMARY KEY CLUSTERED 
(
	[AnimalTreatementID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointement]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointement](
	[AppointementID] [int] NOT NULL,
	[DateTimeStart] [datetime] NOT NULL,
	[DateTimeEnd] [datetime] NULL,
	[VetID] [int] NULL,
	[AnimalID] [int] NOT NULL,
	[AppointemenStatusID] [int] NOT NULL,
	[UserID] [int] NULL,
	[ClientID] [int] NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeleted] [datetime] NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_Appointement] PRIMARY KEY CLUSTERED 
(
	[AppointementID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppointementStatus]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppointementStatus](
	[AppointementStatusID] [int] NOT NULL,
	[StatusName] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeleted] [datetime] NULL,
	[EditedByUserID] [int] NULL,
 CONSTRAINT [PK_AppointementStatus] PRIMARY KEY CLUSTERED 
(
	[AppointementStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Breed]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Breed](
	[BreedID] [int] IDENTITY(1,1) NOT NULL,
	[BreedName] [nvarchar](200) NOT NULL,
	[SpeciesID] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeleted] [datetime] NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_Breed] PRIMARY KEY CLUSTERED 
(
	[BreedID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[City]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[CityID] [int] NOT NULL,
	[CityName] [nvarchar](100) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CountryID] [int] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeleted] [datetime] NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ClientID] [int] NOT NULL,
	[FirstName] [nvarchar](200) NOT NULL,
	[LastName] [nvarchar](200) NOT NULL,
	[JMBG] [nvarchar](13) NULL,
	[IDCardNumber] [nvarchar](20) NULL,
	[Address] [nvarchar](200) NULL,
	[PPT] [nvarchar](20) NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NULL,
	[Note] [nvarchar](max) NULL,
	[CityID] [int] NULL,
	[Username] [nvarchar](max) NOT NULL,
	[PasswordHash] [nvarchar](max) NOT NULL,
	[PasswordSalt] [nvarchar](max) NOT NULL,
	[IsRegisteredOnline] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeleted] [datetime] NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientAnimal]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientAnimal](
	[ClientAnimalID] [int] NOT NULL,
	[ClientID] [int] NOT NULL,
	[AnimalID] [int] NOT NULL,
	[AnimalIDCardNo] [nvarchar](50) NULL,
	[IsCurrentOwner] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeleted] [datetime] NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_ClientAnimal] PRIMARY KEY CLUSTERED 
(
	[ClientAnimalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[CountryID] [int] NOT NULL,
	[CountryName] [nvarchar](50) NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeleted] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_Drzava] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceItem]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceItem](
	[InvoiceItemID] [int] IDENTITY(1,1) NOT NULL,
	[OrderInvoiceID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Discount] [decimal](5, 2) NULL,
 CONSTRAINT [PK_InvoiceItem] PRIMARY KEY CLUSTERED 
(
	[InvoiceItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Microchip]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Microchip](
	[MicrochipID] [int] NOT NULL,
	[BatchSerialNumber] [nvarchar](50) NULL,
	[Code] [nvarchar](15) NOT NULL,
	[IsBuiltIn] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[EditedByUserID] [int] NULL,
 CONSTRAINT [PK_Microchip] PRIMARY KEY CLUSTERED 
(
	[MicrochipID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Note]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Note](
	[NoteID] [int] NOT NULL,
	[NoteText] [nvarchar](max) NULL,
	[NoteTypeID] [int] NOT NULL,
	[AnimalTreatementID] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeleted] [datetime] NOT NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_Note] PRIMARY KEY CLUSTERED 
(
	[NoteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NoteType]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NoteType](
	[NoteTypeID] [int] NOT NULL,
	[NoteName] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeleted] [datetime] NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_NoteType] PRIMARY KEY CLUSTERED 
(
	[NoteTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[OrderNumber] [nvarchar](20) NOT NULL,
	[ClientID] [int] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[Status] [bit] NOT NULL,
	[IsCanceled] [bit] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderInvoice]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderInvoice](
	[OrderInvoiceID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNo] [nvarchar](50) NOT NULL,
	[DateOfInvoice] [datetime] NOT NULL,
	[UserID] [int] NOT NULL,
	[Signed] [bit] NOT NULL,
	[TotalWithoutPDV] [decimal](18, 2) NOT NULL,
	[TotalWithPDV] [decimal](18, 2) NOT NULL,
	[OrderID] [int] NULL,
 CONSTRAINT [PK_OrderInvoiceID] PRIMARY KEY CLUSTERED 
(
	[OrderInvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItems]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItems](
	[OrderItemsID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_OrderItems] PRIMARY KEY CLUSTERED 
(
	[OrderItemsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[Code] [nvarchar](20) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[ProductType] [int] NOT NULL,
	[UnitOfMeasure] [int] NOT NULL,
	[ImagePath] [varbinary](max) NULL,
	[ThumbPath] [varbinary](max) NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductType]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductType](
	[ProductTypeID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ProductType] PRIMARY KEY CLUSTERED 
(
	[ProductTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purchase]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase](
	[PurchaseID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseReceiptNo] [nvarchar](20) NOT NULL,
	[DateOfPurchase] [datetime] NOT NULL,
	[PurchaseInvoice] [decimal](18, 2) NOT NULL,
	[PDV] [numeric](18, 2) NOT NULL,
	[Napomena] [nvarchar](500) NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_Purchase] PRIMARY KEY CLUSTERED 
(
	[PurchaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseItem]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseItem](
	[PurchaseItemID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_UlazStavke] PRIMARY KEY CLUSTERED 
(
	[PurchaseItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Review]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Review](
	[ReviewID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[ClientID] [int] NOT NULL,
	[DateReviewed] [datetime] NOT NULL,
	[Mark] [int] NOT NULL,
 CONSTRAINT [PK_Review] PRIMARY KEY CLUSTERED 
(
	[ReviewID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](200) NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeactivated] [datetime] NOT NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[ServiceID] [int] NOT NULL,
	[ServiceCode] [nvarchar](max) NOT NULL,
	[ServiceName] [nvarchar](200) NOT NULL,
	[ServiceTypeID] [int] NOT NULL,
	[ServiceMeasureID] [int] NOT NULL,
	[Price] [decimal](18, 2) NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeleted] [datetime] NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceMeasure]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceMeasure](
	[ServiceMeasureID] [int] NOT NULL,
	[MeasureName] [nvarchar](20) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeleted] [datetime] NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_ServiceMeasure] PRIMARY KEY CLUSTERED 
(
	[ServiceMeasureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceType]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceType](
	[ServiceTypeID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceTypeName] [nvarchar](200) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeleted] [datetime] NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_ServiceType] PRIMARY KEY CLUSTERED 
(
	[ServiceTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specie]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specie](
	[SpecieID] [int] IDENTITY(1,1) NOT NULL,
	[SpecieName] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeleted] [datetime] NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_Specie] PRIMARY KEY CLUSTERED 
(
	[SpecieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SpeciesService]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpeciesService](
	[SpeciesServiceID] [int] NOT NULL,
	[SpecieID] [int] NOT NULL,
	[ServiceID] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeleted] [datetime] NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_SpeciesService] PRIMARY KEY CLUSTERED 
(
	[SpeciesServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TreatementServices]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TreatementServices](
	[TreatementServiceID] [int] NOT NULL,
	[ServiceID] [int] NOT NULL,
	[AnimalTreatementID] [int] NOT NULL,
	[Quantity] [int] NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeleted] [datetime] NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_TreatementServices] PRIMARY KEY CLUSTERED 
(
	[TreatementServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](200) NOT NULL,
	[JMBG] [nvarchar](13) NULL,
	[Email] [nvarchar](max) NOT NULL,
	[CellPhone] [nvarchar](50) NULL,
	[Username] [nvarchar](max) NOT NULL,
	[PasswordHash] [nvarchar](50) NOT NULL,
	[PasswordSalt] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeactivated] [datetime] NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 10/14/2022 8:23:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[UserRoleID] [int] NOT NULL,
	[RoleID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[DateDeleted] [datetime] NULL,
	[ModifiedByUserID] [int] NULL,
 CONSTRAINT [PK_UserRole] PRIMARY KEY CLUSTERED 
(
	[UserRoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ClientAnimal] ADD  CONSTRAINT [DF_ClientAnimal_IsCurrentOwner]  DEFAULT ((1)) FOR [IsCurrentOwner]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Artikli_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Animal]  WITH CHECK ADD  CONSTRAINT [FK_Animal_Breed] FOREIGN KEY([BreedID])
REFERENCES [dbo].[Breed] ([BreedID])
GO
ALTER TABLE [dbo].[Animal] CHECK CONSTRAINT [FK_Animal_Breed]
GO
ALTER TABLE [dbo].[AnimalImage]  WITH CHECK ADD  CONSTRAINT [FK_AnimalImage_Animal] FOREIGN KEY([AnimalID])
REFERENCES [dbo].[Animal] ([AnimalID])
GO
ALTER TABLE [dbo].[AnimalImage] CHECK CONSTRAINT [FK_AnimalImage_Animal]
GO
ALTER TABLE [dbo].[AnimalMicrochip]  WITH CHECK ADD  CONSTRAINT [FK_AnimalMicrochip_Animal] FOREIGN KEY([AnimalID])
REFERENCES [dbo].[Animal] ([AnimalID])
GO
ALTER TABLE [dbo].[AnimalMicrochip] CHECK CONSTRAINT [FK_AnimalMicrochip_Animal]
GO
ALTER TABLE [dbo].[AnimalMicrochip]  WITH CHECK ADD  CONSTRAINT [FK_AnimalMicrochip_Microchip] FOREIGN KEY([MicrochipID])
REFERENCES [dbo].[Microchip] ([MicrochipID])
GO
ALTER TABLE [dbo].[AnimalMicrochip] CHECK CONSTRAINT [FK_AnimalMicrochip_Microchip]
GO
ALTER TABLE [dbo].[AnimalTreatement]  WITH CHECK ADD  CONSTRAINT [FK_AnimalTreatement_Animal] FOREIGN KEY([AnimalID])
REFERENCES [dbo].[Animal] ([AnimalID])
GO
ALTER TABLE [dbo].[AnimalTreatement] CHECK CONSTRAINT [FK_AnimalTreatement_Animal]
GO
ALTER TABLE [dbo].[AnimalTreatement]  WITH CHECK ADD  CONSTRAINT [FK_AnimalTreatement_Appointement1] FOREIGN KEY([AppointementID])
REFERENCES [dbo].[Appointement] ([AppointementID])
GO
ALTER TABLE [dbo].[AnimalTreatement] CHECK CONSTRAINT [FK_AnimalTreatement_Appointement1]
GO
ALTER TABLE [dbo].[AnimalTreatement]  WITH CHECK ADD  CONSTRAINT [FK_AnimalTreatement_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[AnimalTreatement] CHECK CONSTRAINT [FK_AnimalTreatement_User]
GO
ALTER TABLE [dbo].[Appointement]  WITH CHECK ADD  CONSTRAINT [FK_Appointement_AppointementStatus] FOREIGN KEY([AppointemenStatusID])
REFERENCES [dbo].[AppointementStatus] ([AppointementStatusID])
GO
ALTER TABLE [dbo].[Appointement] CHECK CONSTRAINT [FK_Appointement_AppointementStatus]
GO
ALTER TABLE [dbo].[Breed]  WITH CHECK ADD  CONSTRAINT [FK_Breed_Specie] FOREIGN KEY([SpeciesID])
REFERENCES [dbo].[Specie] ([SpecieID])
GO
ALTER TABLE [dbo].[Breed] CHECK CONSTRAINT [FK_Breed_Specie]
GO
ALTER TABLE [dbo].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_Country] FOREIGN KEY([CountryID])
REFERENCES [dbo].[Country] ([CountryID])
GO
ALTER TABLE [dbo].[City] CHECK CONSTRAINT [FK_City_Country]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_City] FOREIGN KEY([CityID])
REFERENCES [dbo].[City] ([CityID])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_City]
GO
ALTER TABLE [dbo].[ClientAnimal]  WITH CHECK ADD  CONSTRAINT [FK_ClientAnimal_Animal] FOREIGN KEY([AnimalID])
REFERENCES [dbo].[Animal] ([AnimalID])
GO
ALTER TABLE [dbo].[ClientAnimal] CHECK CONSTRAINT [FK_ClientAnimal_Animal]
GO
ALTER TABLE [dbo].[ClientAnimal]  WITH CHECK ADD  CONSTRAINT [FK_ClientAnimal_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
GO
ALTER TABLE [dbo].[ClientAnimal] CHECK CONSTRAINT [FK_ClientAnimal_Client]
GO
ALTER TABLE [dbo].[InvoiceItem]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceItem_OrderInvoice] FOREIGN KEY([OrderInvoiceID])
REFERENCES [dbo].[OrderInvoice] ([OrderInvoiceID])
GO
ALTER TABLE [dbo].[InvoiceItem] CHECK CONSTRAINT [FK_InvoiceItem_OrderInvoice]
GO
ALTER TABLE [dbo].[InvoiceItem]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceItem_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[InvoiceItem] CHECK CONSTRAINT [FK_InvoiceItem_Product]
GO
ALTER TABLE [dbo].[Note]  WITH CHECK ADD  CONSTRAINT [FK_Note_AnimalTreatement] FOREIGN KEY([AnimalTreatementID])
REFERENCES [dbo].[AnimalTreatement] ([AnimalTreatementID])
GO
ALTER TABLE [dbo].[Note] CHECK CONSTRAINT [FK_Note_AnimalTreatement]
GO
ALTER TABLE [dbo].[Note]  WITH CHECK ADD  CONSTRAINT [FK_Note_NoteType] FOREIGN KEY([NoteTypeID])
REFERENCES [dbo].[NoteType] ([NoteTypeID])
GO
ALTER TABLE [dbo].[Note] CHECK CONSTRAINT [FK_Note_NoteType]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Client]
GO
ALTER TABLE [dbo].[OrderInvoice]  WITH CHECK ADD  CONSTRAINT [FK_OrderInvoice_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[OrderInvoice] CHECK CONSTRAINT [FK_OrderInvoice_Order]
GO
ALTER TABLE [dbo].[OrderInvoice]  WITH CHECK ADD  CONSTRAINT [FK_OrderInvoice_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[OrderInvoice] CHECK CONSTRAINT [FK_OrderInvoice_User]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_Order]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_ProductType] FOREIGN KEY([ProductType])
REFERENCES [dbo].[ProductType] ([ProductTypeID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_ProductType]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK_Purchase_User]
GO
ALTER TABLE [dbo].[PurchaseItem]  WITH CHECK ADD  CONSTRAINT [FK_UlazStavke_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[PurchaseItem] CHECK CONSTRAINT [FK_UlazStavke_Product]
GO
ALTER TABLE [dbo].[PurchaseItem]  WITH CHECK ADD  CONSTRAINT [FK_UlazStavke_Purchase] FOREIGN KEY([PurchaseID])
REFERENCES [dbo].[Purchase] ([PurchaseID])
GO
ALTER TABLE [dbo].[PurchaseItem] CHECK CONSTRAINT [FK_UlazStavke_Purchase]
GO
ALTER TABLE [dbo].[Review]  WITH CHECK ADD  CONSTRAINT [FK_Review_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
GO
ALTER TABLE [dbo].[Review] CHECK CONSTRAINT [FK_Review_Client]
GO
ALTER TABLE [dbo].[Review]  WITH CHECK ADD  CONSTRAINT [FK_Review_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Review] CHECK CONSTRAINT [FK_Review_Product]
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK_Service_ServiceMeasure] FOREIGN KEY([ServiceMeasureID])
REFERENCES [dbo].[ServiceMeasure] ([ServiceMeasureID])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK_Service_ServiceMeasure]
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK_Service_ServiceType] FOREIGN KEY([ServiceTypeID])
REFERENCES [dbo].[ServiceType] ([ServiceTypeID])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK_Service_ServiceType]
GO
ALTER TABLE [dbo].[SpeciesService]  WITH CHECK ADD  CONSTRAINT [FK_SpeciesService_Service] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Service] ([ServiceID])
GO
ALTER TABLE [dbo].[SpeciesService] CHECK CONSTRAINT [FK_SpeciesService_Service]
GO
ALTER TABLE [dbo].[SpeciesService]  WITH CHECK ADD  CONSTRAINT [FK_SpeciesService_Specie] FOREIGN KEY([SpecieID])
REFERENCES [dbo].[Specie] ([SpecieID])
GO
ALTER TABLE [dbo].[SpeciesService] CHECK CONSTRAINT [FK_SpeciesService_Specie]
GO
ALTER TABLE [dbo].[TreatementServices]  WITH CHECK ADD  CONSTRAINT [FK_TreatementServices_AnimalTreatement] FOREIGN KEY([AnimalTreatementID])
REFERENCES [dbo].[AnimalTreatement] ([AnimalTreatementID])
GO
ALTER TABLE [dbo].[TreatementServices] CHECK CONSTRAINT [FK_TreatementServices_AnimalTreatement]
GO
ALTER TABLE [dbo].[TreatementServices]  WITH CHECK ADD  CONSTRAINT [FK_TreatementServices_Service] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Service] ([ServiceID])
GO
ALTER TABLE [dbo].[TreatementServices] CHECK CONSTRAINT [FK_TreatementServices_Service]
GO
ALTER TABLE [dbo].[UserRole]  WITH CHECK ADD  CONSTRAINT [FK_UserRole_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[UserRole] CHECK CONSTRAINT [FK_UserRole_Role]
GO
ALTER TABLE [dbo].[UserRole]  WITH CHECK ADD  CONSTRAINT [FK_UserRole_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[UserRole] CHECK CONSTRAINT [FK_UserRole_User]
GO
USE [master]
GO
ALTER DATABASE [VetStationDb] SET  READ_WRITE 
GO
