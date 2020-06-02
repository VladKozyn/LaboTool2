CREATE TABLE [dbo].[Punt]
(
	[puntX] FLOAT NOT NULL,
	[puntY] FLOAT NOT NULL,
	[segmentId] INT REFERENCES Segment(segmentId) NOT NULL
	CONSTRAINT [PK_Punt] PRIMARY KEY CLUSTERED ( [puntX], [puntY] )
)
