﻿CREATE TABLE [dbo].[View]
(
	[ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY CONSTRAINT [DF_View_ID] DEFAULT NEWID(), 
    [Name] NVARCHAR(MAX) NOT NULL, 
    [Document] XML NOT NULL,
	CONSTRAINT [PK_View_ID] PRIMARY KEY (ID),
	CONSTRAINT [UNQ_View_Name] UNIQUE (Name),
	CONSTRAINT [UNQ_View_Document] UNIQUE (Document)
)