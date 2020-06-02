CREATE TABLE [dbo].[Segment]
(
	[segmentId] INT NOT NULL PRIMARY KEY,
	[beginKnoop] FLOAT NOT NULL,
	[eindKnoop] FLOAT NOT NULL,
	[knoopId] INT REFERENCES Knoop(knoopId) NOT NULL
)
