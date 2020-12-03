﻿CREATE TABLE [dbo].[MenuItems]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(200) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [Price] DECIMAL(18, 2) NOT NULL,
)
