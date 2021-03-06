USE [master]
GO
/****** Object:  Database [World]    Script Date: 25.10.2014 г. 17:11:44 ч. ******/
CREATE DATABASE [World]
GO
ALTER DATABASE [World] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [World].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [World] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [World] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [World] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [World] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [World] SET ARITHABORT OFF 
GO
ALTER DATABASE [World] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [World] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [World] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [World] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [World] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [World] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [World] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [World] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [World] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [World] SET  DISABLE_BROKER 
GO
ALTER DATABASE [World] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [World] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [World] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [World] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [World] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [World] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [World] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [World] SET RECOVERY FULL 
GO
ALTER DATABASE [World] SET  MULTI_USER 
GO
ALTER DATABASE [World] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [World] SET DB_CHAINING OFF 
GO
ALTER DATABASE [World] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [World] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [World] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'World', N'ON'
GO
USE [World]
GO
/****** Object:  Table [dbo].[Continent]    Script Date: 25.10.2014 г. 17:11:44 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continent](
	[ContinentId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Continent] PRIMARY KEY CLUSTERED 
(
	[ContinentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Country]    Script Date: 25.10.2014 г. 17:11:44 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[CountryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Language] [nvarchar](20) NULL,
	[Poulation] [int] NULL,
	[ContinentId] [int] NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Town]    Script Date: 25.10.2014 г. 17:11:44 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Town](
	[TownId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Population] [int] NULL,
	[CountryId] [int] NOT NULL,
 CONSTRAINT [PK_Town] PRIMARY KEY CLUSTERED 
(
	[TownId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Continent] ON 

INSERT [dbo].[Continent] ([ContinentId], [Name]) VALUES (7, N'Africa')
INSERT [dbo].[Continent] ([ContinentId], [Name]) VALUES (9, N'Antarctica')
INSERT [dbo].[Continent] ([ContinentId], [Name]) VALUES (2, N'Asia')
INSERT [dbo].[Continent] ([ContinentId], [Name]) VALUES (8, N'Australia')
INSERT [dbo].[Continent] ([ContinentId], [Name]) VALUES (1, N'Europe')
INSERT [dbo].[Continent] ([ContinentId], [Name]) VALUES (3, N'NorthAmerica')
INSERT [dbo].[Continent] ([ContinentId], [Name]) VALUES (4, N'SouthAmerica')
SET IDENTITY_INSERT [dbo].[Continent] OFF
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([CountryId], [Name], [Language], [Poulation], [ContinentId]) VALUES (1, N'Bulgaria', N'Bulgarian', 7364570, 1)
INSERT [dbo].[Country] ([CountryId], [Name], [Language], [Poulation], [ContinentId]) VALUES (2, N'Germany', N'German', 80716000, 1)
INSERT [dbo].[Country] ([CountryId], [Name], [Language], [Poulation], [ContinentId]) VALUES (4, N'Italy', N'Italian', 60782668, 1)
INSERT [dbo].[Country] ([CountryId], [Name], [Language], [Poulation], [ContinentId]) VALUES (6, N'Canada', N'English/French', 35160000, 3)
INSERT [dbo].[Country] ([CountryId], [Name], [Language], [Poulation], [ContinentId]) VALUES (7, N'United States', N'English', 318968000, 3)
INSERT [dbo].[Country] ([CountryId], [Name], [Language], [Poulation], [ContinentId]) VALUES (8, N'Nigeria', NULL, NULL, 7)
INSERT [dbo].[Country] ([CountryId], [Name], [Language], [Poulation], [ContinentId]) VALUES (10, N'France', N'French', 66616416, 1)
INSERT [dbo].[Country] ([CountryId], [Name], [Language], [Poulation], [ContinentId]) VALUES (11, N'Japan', N'Japanese', 126434964, 2)
INSERT [dbo].[Country] ([CountryId], [Name], [Language], [Poulation], [ContinentId]) VALUES (12, N'China', N'Chinese', 1357380000, 2)
INSERT [dbo].[Country] ([CountryId], [Name], [Language], [Poulation], [ContinentId]) VALUES (14, N'Brazil', N'Portuguese', 202656788, 4)
SET IDENTITY_INSERT [dbo].[Country] OFF
SET IDENTITY_INSERT [dbo].[Town] ON 

INSERT [dbo].[Town] ([TownId], [Name], [Population], [CountryId]) VALUES (1, N'Sofia', 123, 1)
INSERT [dbo].[Town] ([TownId], [Name], [Population], [CountryId]) VALUES (2, N'Burgas', 345, 1)
INSERT [dbo].[Town] ([TownId], [Name], [Population], [CountryId]) VALUES (3, N'New York', 678, 7)
INSERT [dbo].[Town] ([TownId], [Name], [Population], [CountryId]) VALUES (4, N'Tokyo', 911, 11)
INSERT [dbo].[Town] ([TownId], [Name], [Population], [CountryId]) VALUES (5, N'Yokohama', 32, 11)
INSERT [dbo].[Town] ([TownId], [Name], [Population], [CountryId]) VALUES (6, N'Paris', 42, 10)
INSERT [dbo].[Town] ([TownId], [Name], [Population], [CountryId]) VALUES (7, N'Frankfurt', 5345, 2)
INSERT [dbo].[Town] ([TownId], [Name], [Population], [CountryId]) VALUES (8, N'Chicago', NULL, 7)
INSERT [dbo].[Town] ([TownId], [Name], [Population], [CountryId]) VALUES (9, N'Plovdiv', NULL, 1)
INSERT [dbo].[Town] ([TownId], [Name], [Population], [CountryId]) VALUES (10, N'Berlin', NULL, 2)
SET IDENTITY_INSERT [dbo].[Town] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_Continent]    Script Date: 25.10.2014 г. 17:11:44 ч. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UK_Continent] ON [dbo].[Continent]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_Country]    Script Date: 25.10.2014 г. 17:11:44 ч. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UK_Country] ON [dbo].[Country]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_Town]    Script Date: 25.10.2014 г. 17:11:44 ч. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UK_Town] ON [dbo].[Town]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Country]  WITH CHECK ADD  CONSTRAINT [FK_Country_Continent] FOREIGN KEY([ContinentId])
REFERENCES [dbo].[Continent] ([ContinentId])
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [FK_Country_Continent]
GO
ALTER TABLE [dbo].[Town]  WITH CHECK ADD  CONSTRAINT [FK_Town_Country] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Country] ([CountryId])
GO
ALTER TABLE [dbo].[Town] CHECK CONSTRAINT [FK_Town_Country]
GO
USE [master]
GO
ALTER DATABASE [World] SET  READ_WRITE 
GO
