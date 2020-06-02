CREATE TABLE [dbo].[Gemeente]
(
	[gemeenteId] INT NOT NULL PRIMARY KEY,
    [gemeenteNaam] VARCHAR(50) NOT NULL, 
	[totaalAantalStraten] INT NOT NULL,
	[provincieId] INT REFERENCES Provincie(provincieID) NOT NULL
)
