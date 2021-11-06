USE master
GO


IF EXISTS (SELECT * FROM sysdatabases WHERE name='GameLibrary')
		ALTER DATABASE GameLibrary SET SINGLE_USER WITH ROLLBACK IMMEDIATE 
		DROP DATABASE GameLibrary
go

CREATE DATABASE GameLibrary;
GO

ALTER DATABASE GameLibrary
SET MULTI_USER

USE GameLibrary
GO

IF (exists (select *
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_NAME = 'Game'))

DROP TABLE Game
GO

CREATE TABLE Game
(
	GameID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Title NVARCHAR(20) NOT NULL,
	Genre NVARCHAR(20),
	Rating NVARCHAR(4),
	Director NVARCHAR(50) NOT NULL,
	Composer NVARCHAR(50),
	Artist NVARCHAR(50),
	Company NVARCHAR(50) NOT NULL,
	[Year] VARCHAR(4),
	Console NVARCHAR(20)
)