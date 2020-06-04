CREATE TABLE [dbo].[Segment]
(
	[segmentId] INT NOT NULL,
	[beginKnoop] INT NOT NULL,
	[eindKnoop] INT NOT NULL,
	[knoopId] INT REFERENCES Knoop(knoopId) NOT NULL,
	
	ADD CONSTRAINT FK_Content_Libraries
   FOREIGN KEY(LibraryID, Application)
   REFERENCES dbo.Libraries(ID, Application)

   
)
