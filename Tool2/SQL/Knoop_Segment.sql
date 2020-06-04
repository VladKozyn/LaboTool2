CREATE TABLE [dbo].[Knoop_Segment]
(
	[knoopId] INT NOT NULL ,
	[segmentId] INT NOT NULL, 
	PRIMARY KEY CLUSTERED([segmentId],[knoopId]),
    CONSTRAINT [FK_Knoop_Segment_segmentId] FOREIGN KEY ([segmentId]) REFERENCES [dbo].[Segment]([segmentId]), 
    CONSTRAINT [FK_Knoop_Segment_knoopId] FOREIGN KEY ([knoopId]) REFERENCES [dbo].[Knoop]([knoopId]),
	
)
