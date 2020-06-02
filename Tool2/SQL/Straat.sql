CREATE TABLE [dbo].[Straat]
(
	[straatId] INT NOT NULL PRIMARY KEY,
    [straatNaam] VARCHAR(50) NOT NULL, 
	[lengteStraat] FLOAT NOT NULL,
	[gemeenteId] INT REFERENCES Gemeente(gemeenteId) NOT NULL
)
