CREATE TABLE [dbo].[Provincie]
(
	[provincieId] INT NOT NULL PRIMARY KEY, 
	[provincieNaam] NCHAR(10) NULL,
    [gemeenteIds] INT,
)
