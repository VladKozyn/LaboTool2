CREATE TABLE [dbo].[Punt]
(
	[puntX] FLOAT (53) NOT NULL,
	[puntY] FLOAT (53) NOT NULL,
	[segmentId] INT REFERENCES Segment(segmentId) NOT NULL
	CONSTRAINT [PK_Punt] PRIMARY KEY CLUSTERED ( [puntX], [puntY],[segmentId] )

)
