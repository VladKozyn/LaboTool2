CREATE TABLE [dbo].[Segment]
(
	[segmentId] INT NOT NULL PRIMARY KEY,
	[beginKnoop] INT NOT NULL,
	[eindKnoop] INT NOT NULL,
	[knoopId] INT REFERENCES Knoop(knoopId) NOT NULL
)
