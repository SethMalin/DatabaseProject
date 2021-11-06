USE GameLibrary
GO

IF EXISTS(
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_NAME = 'usp_GetAll')
BEGIN
DROP PROCEDURE usp_GetAll
END
GO

CREATE PROCEDURE usp_GetAll
AS
BEGIN
SELECT
GameID, Title, Genre, Rating, Director, Composer, Artist, Company, [Year], Console
FROM
Game
END
GO

IF EXISTS(
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_NAME = 'usp_GetByID')
BEGIN
DROP PROCEDURE usp_GetByID
END
GO

CREATE PROCEDURE usp_GetByID(
@GameID INT)
AS
BEGIN
SELECT
GameID,Title, Genre, Rating, Director, Composer, Artist, Company, [Year], Console
FROM
Game
WHERE
GameID = @GameID
END
GO

IF EXISTS(
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_NAME = 'usp_GetByTitle')
BEGIN
DROP PROCEDURE usp_GetByTitle
END
GO

CREATE PROCEDURE usp_GetByTitle(
@Title NVARCHAR(20))
AS
BEGIN
SELECT
GameID, Title, Genre, Rating, Director, Composer, Artist, Company, [Year], Console
FROM
Game
WHERE
Title LIKE '%' + @Title + '%'
END
GO


IF EXISTS(
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_NAME = 'usp_GetByGenre')
BEGIN
DROP PROCEDURE usp_GetByGenre
END
GO

CREATE PROCEDURE usp_GetByGenre(
@Genre NVARCHAR(20))
AS
BEGIN
SELECT
GameID, Title, Genre, Rating, Director, Composer, Artist, Company, [Year], Console
FROM
Game
WHERE
Genre LIKE '%' + @Genre + '%'
END
GO

IF EXISTS(
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_NAME = 'usp_GetByRating')
BEGIN
DROP PROCEDURE usp_GetByRating
END
GO

CREATE PROCEDURE usp_GetByRating(
@Rating NVARCHAR(4))
AS
BEGIN
SELECT
GameID, Title, Genre, Rating, Director, Composer, Artist, Company, [Year], Console
FROM
Game
WHERE
Rating LIKE '%' + @Rating + '%'
END
GO

IF EXISTS(
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_NAME = 'usp_GetByDirector')
BEGIN
DROP PROCEDURE usp_GetByDirector
END
GO

CREATE PROCEDURE usp_GetByDirector(
@Director NVARCHAR(50))
AS
BEGIN
SELECT
GameID, Title, Genre, Rating, Director, Composer, Artist, Company, [Year], Console
FROM
Game
WHERE
Director LIKE '%' + @Director + '%'
END
GO

IF EXISTS(
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_NAME = 'usp_GetByComposer')
BEGIN
DROP PROCEDURE usp_GetByComposer
END
GO

CREATE PROCEDURE usp_GetByComposer(
@Composer NVARCHAR(50))
AS
BEGIN
SELECT
GameID, Title, Genre, Rating, Director, Composer, Artist, Company, [Year], Console
FROM
Game
WHERE
Composer LIKE '%' + @Composer + '%'
END
GO

IF EXISTS(
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_NAME = 'usp_GetByArtist')
BEGIN
DROP PROCEDURE usp_GetByArtist
END
GO

CREATE PROCEDURE usp_GetByArtist(
@Artist NVARCHAR(50))
AS
BEGIN
SELECT
GameID, Title, Genre, Rating, Director, Composer, Artist, Company, [Year], Console
FROM
Game
WHERE
Artist LIKE '%' + @Artist + '%'
END
GO

IF EXISTS(
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_NAME = 'usp_GetByCompany')
BEGIN
DROP PROCEDURE usp_GetByCompany
END
GO

CREATE PROCEDURE usp_GetByCompany(
@Company NVARCHAR(50))
AS
BEGIN
SELECT
GameID, Title, Genre, Rating, Director, Composer, Artist, Company, [Year], Console
FROM
Game
WHERE
Company LIKE '%' + @Company + '%'
END
GO

IF EXISTS(
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_NAME = 'usp_GetByYear')
BEGIN
DROP PROCEDURE usp_GetByYear
END
GO

CREATE PROCEDURE usp_GetByYear(
@Year VARCHAR(4))
AS
BEGIN
SELECT
GameID, Title, Genre, Rating, Director, Composer, Artist, Company, [Year], Console
FROM
Game
WHERE
[Year] LIKE '%' + @Year + '%'
END
GO


IF EXISTS(
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_NAME = 'usp_GetByConsole')
BEGIN
DROP PROCEDURE usp_GetByConsole
END
GO

CREATE PROCEDURE usp_GetByConsole(
@Console NVARCHAR(20))
AS
BEGIN
SELECT
GameID, Title, Genre, Rating, Director, Composer, Artist, Company, [Year], Console
FROM
Game
WHERE
Console LIKE '%' + @Console + '%'
END
GO


IF EXISTS(
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_NAME = 'usp_CreateGame')
BEGIN
DROP PROCEDURE usp_CreateGame
END
GO

CREATE PROCEDURE usp_CreateGame(
@Title NVARCHAR(20),
@Genre NVARCHAR(20),
@Rating NVARCHAR(4),
@Director NVARCHAR(50),
@Composer NVARCHAR(50),
@Artist NVARCHAR(50),
@Company NVARCHAR(50),
@Year VARCHAR(4),
@Console NVARCHAR(20))
AS
BEGIN
INSERT INTO Game (Title, Genre, Rating, Director, Composer, Artist, Company, [Year], Console)
VALUES(
@Title,
@Genre,
@Rating,
@Director,
@Composer,
@Artist,
@Company,
@Year,
@Console)
END
GO

IF EXISTS(
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_NAME = 'usp_UpdateGame')
BEGIN
DROP PROCEDURE usp_UpdateGame
END
GO

CREATE PROCEDURE usp_UpdateGame(
@GameID INT,
@Title NVARCHAR(20),
@Genre NVARCHAR(20),
@Rating NVARCHAR(4),
@Director NVARCHAR(50),
@Composer NVARCHAR(50),
@Artist NVARCHAR(50),
@Company NVARCHAR(50),
@Year VARCHAR(4),
@Console NVARCHAR(20))
AS
BEGIN
UPDATE Game
SET
Title = @Title,
Genre = @Genre,
Rating = @Rating,
Director = @Director,
Composer = @Composer,
Artist = @Artist,
Company = @Company,
[Year] = @Year,
Console = @Console
WHERE
GameID = @GameID
END
GO

IF EXISTS(
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_NAME = 'usp_DeleteGame')
BEGIN
DROP PROCEDURE usp_DeleteGame
END
GO

CREATE PROCEDURE usp_DeleteGame(
@GameID INT)
AS
BEGIN
DELETE FROM Game
WHERE
GameID = @GameID
END
GO
