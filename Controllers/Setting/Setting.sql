﻿USE [master]
GO

CREATE DATABASE [UserManagementDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UserManagementDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\UserManagementDB.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'UserManagementDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\UserManagementDB.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [UserManagementDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UserManagementDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UserManagementDB] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [UserManagementDB] SET ANSI_NULLS ON 
GO
ALTER DATABASE [UserManagementDB] SET ANSI_PADDING ON 
GO
ALTER DATABASE [UserManagementDB] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [UserManagementDB] SET ARITHABORT ON 
GO
ALTER DATABASE [UserManagementDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UserManagementDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UserManagementDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UserManagementDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UserManagementDB] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [UserManagementDB] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [UserManagementDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UserManagementDB] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [UserManagementDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UserManagementDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [UserManagementDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UserManagementDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UserManagementDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UserManagementDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UserManagementDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UserManagementDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UserManagementDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UserManagementDB] SET RECOVERY FULL 
GO
ALTER DATABASE [UserManagementDB] SET  MULTI_USER 
GO
ALTER DATABASE [UserManagementDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UserManagementDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UserManagementDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UserManagementDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [UserManagementDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [UserManagementDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'UserManagementDB', N'ON'
GO
ALTER DATABASE [UserManagementDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [UserManagementDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [UserManagementDB]
GO
/****** Object:  Table [dbo].[Photo]    Script Date: 2024-03-12 오후 3:59:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Photo](
	[Idx] [int] IDENTITY(1,1) NOT NULL,
	[uIdx] [int] NOT NULL,
	[photo] [varbinary](max) NULL,
	[isRepresent] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Idx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 2024-03-12 오후 3:59:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[idx] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](10) NOT NULL,
	[uid] [varchar](15) NOT NULL,
	[pwd] [varchar](20) NOT NULL,
	[nickName] [nvarchar](15) NOT NULL,
	[dob] [date] NOT NULL,
	[isAdmin] [bit] NOT NULL,
	[isLock] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[nickName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[uid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Photo]  WITH CHECK ADD FOREIGN KEY([uIdx])
REFERENCES [dbo].[User] ([idx])
GO
USE [master]
GO
ALTER DATABASE [UserManagementDB] SET  READ_WRITE 
GO
SET IDENTITY_INSERT [dbo].[User] ON;
BULK INSERT [dbo].[User] FROM 'C:\\DataFiles\\User.txt' WITH (FIELDTERMINATOR = '\\t', ROWTERMINATOR = '\\n', FIRSTROW = 2)
SET IDENTITY_INSERT [dbo].[User] OFF;
GO

