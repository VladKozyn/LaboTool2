CREATE TABLE [dbo].[Knoop]
(
	[knoopId] INT NOT NULL,
	[puntX] FLOAT NOT NULL,
	[puntY] FLOAT NOT NULL,
	[graafId] INT REFERENCES Graaf(graafId) NOT NULL,
	
	CONSTRAINT [PK_Knoop] PRIMARY KEY CLUSTERED ( [knoopId], [graafId] ),


)
