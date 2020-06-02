CREATE TABLE [dbo].[Knoop]
(
	[knoopId] INT NOT NULL PRIMARY KEY,
	[puntX] FLOAT NOT NULL,
	[puntY] FLOAT NOT NULL,
	[graafId] INT REFERENCES Graaf(graafId) NOT NULL
)
