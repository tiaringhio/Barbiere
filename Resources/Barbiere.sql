USE [master]
GO
/****** Object:  Database [Barbiere]    Script Date: 09/09/2019 18:43:40 ******/
CREATE DATABASE [Barbiere]
GO
ALTER DATABASE [Barbiere] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Barbiere].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Barbiere] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Barbiere] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Barbiere] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Barbiere] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Barbiere] SET ARITHABORT OFF 
GO
ALTER DATABASE [Barbiere] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Barbiere] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Barbiere] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Barbiere] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Barbiere] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Barbiere] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Barbiere] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Barbiere] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Barbiere] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Barbiere] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Barbiere] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Barbiere] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Barbiere] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Barbiere] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Barbiere] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Barbiere] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Barbiere] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Barbiere] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Barbiere] SET  MULTI_USER 
GO
ALTER DATABASE [Barbiere] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Barbiere] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Barbiere] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Barbiere] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Barbiere] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Barbiere] SET QUERY_STORE = OFF
GO
USE [Barbiere]
GO
/****** Object:  Table [dbo].[Clienti]    Script Date: 09/09/2019 18:43:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clienti](
	[clientID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](20) NOT NULL,
	[Cognome] [varchar](20) NOT NULL,
	[Utente] [varchar](20) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[Admin] [bit] NOT NULL,
 CONSTRAINT [PK_Clienti] PRIMARY KEY CLUSTERED 
(
	[clientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prenotazioni]    Script Date: 09/09/2019 18:43:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prenotazioni](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Utente] [varchar](50) NOT NULL,
	[Data] [date] NOT NULL,
	[Ora] [time](7) NOT NULL,
 CONSTRAINT [PK_Prenotazioni] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[AddBooking]    Script Date: 09/09/2019 18:43:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddBooking]
(
	@Utente varchar(50),
	@Data datetime,
	@Ora datetime
)
AS
INSERT INTO Prenotazioni(Utente,Data,Ora)
	VALUES (@Utente,@Data,@Ora)
GO
/****** Object:  StoredProcedure [dbo].[FutureBookings]    Script Date: 09/09/2019 18:43:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FutureBookings]
AS
BEGIN
	SELECT C.Nome, C.Cognome, P.Data, P.Ora
	FROM Clienti C LEFT JOIN Prenotazioni P ON C.Utente = P.Utente
	WHERE Data >= CAST(GETDATE() AS DATE)
END
GO
/****** Object:  StoredProcedure [dbo].[LoginChecker]    Script Date: 09/09/2019 18:43:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LoginChecker]
	@Utente varchar(20),
	@Password varchar(20)
AS
BEGIN
	SELECT * FROM Clienti
	WHERE Utente = @Utente AND Password = @Password
END
GO
/****** Object:  StoredProcedure [dbo].[PasswordRecovery]    Script Date: 09/09/2019 18:43:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PasswordRecovery]
	@Utente varchar(20),
	@Password varchar (20)
AS
BEGIN
	UPDATE Clienti SET Password = @Password
	WHERE Utente = @Utente
END
GO
/****** Object:  StoredProcedure [dbo].[UserAdd]    Script Date: 09/09/2019 18:43:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UserAdd]
	@Nome varchar(20),
	@Cognome varchar(20),
	@Utente varchar(20),
	@Password varchar(20),
	@Admin bit
AS
BEGIN
	INSERT INTO Clienti(Nome,Cognome,Utente,Password,Admin)
		VALUES (@Nome,@Cognome,@Utente,@Password,@Admin)
END
GO
/****** Object:  StoredProcedure [dbo].[UserPasswordChange]    Script Date: 09/09/2019 18:43:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UserPasswordChange]
	@Utente varchar(20),
	@Password varchar (20),
	@OldUser varchar (20),
	@OldPassword varchar(20)
AS
BEGIN
	-- Cambio Tutto
	IF (@Utente != '' AND @Password != '')
		UPDATE Clienti SET Utente = @Utente, Password = @Password
		WHERE Utente = @OldUser
		AND Password = @OldPassword

	-- Cambio password dato utente giusto
	ELSE IF (@Password != '')
		UPDATE Clienti SET Password = @Password
		WHERE Utente = @OldUser
		AND Password = @OldPassword

	-- Cambio utente data password giusta
	ELSE IF(@Utente != '')
		UPDATE Clienti SET Utente = @Utente
		WHERE Utente = @OldUser
		AND Password = @OldPassword

END
GO
/****** Object:  StoredProcedure [dbo].[ViewBookings]    Script Date: 09/09/2019 18:43:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewBookings]
	@Utente varchar(20)
AS
BEGIN
	SELECT C.Nome, C.Cognome, P.Data, P.Ora
	FROM Clienti C LEFT JOIN Prenotazioni P ON C.Utente = P.Utente
	WHERE P.Utente = @Utente;
END
GO
USE [master]
GO
ALTER DATABASE [Barbiere] SET  READ_WRITE 
GO
