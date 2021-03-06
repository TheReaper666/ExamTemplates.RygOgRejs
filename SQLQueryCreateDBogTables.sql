﻿CREATE DATABASE RygOgRejsDB
GO
USE RygOgRejsDB
CREATE TABLE Journeys(
PKJourneyId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Destination VARCHAR(50) NOT NULL,
DepartureTime DATETIME NOT NULL,
Adults INT NOT NULL DEFAULT 0,
Children INT NOT NULL DEFAULT 0,
isFirstClass BIT NOT NULL DEFAULT 0,
LuggageAmmount FLOAT NOT NULL
);
GO

CREATE TABLE Payers(
PKPayerId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
FirstName VARCHAR(30) NOT NULL,
LastName VARCHAR(100) NOT NULL,
SocialSecurityNumber INT NOT NULL,
FKJourneyId INT FOREIGN KEY REFERENCES dbo.Journeys(PKJourneyId) NOT NULL
);
GO
CREATE TABLE Transactions(
PKTransactionId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Amount FLOAT NOT NULL,
FKPayerId INT FOREIGN KEY REFERENCES dbo.Payers(PKPayerId)NOT NULL,
FKJourneyId INT FOREIGN KEY REFERENCES dbo.Journeys(PKJourneyId) NOT NULL
);
GO

