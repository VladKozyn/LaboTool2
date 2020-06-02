CREATE TABLE [dbo].[Graaf]
(
	[graafId] INT NOT NULL PRIMARY KEY,
    [straatId] INT REFERENCES Straat(straatId) NOT NULL
)
