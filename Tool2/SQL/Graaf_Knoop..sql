CREATE TABLE [dbo].[Graaf_Knoop]
(
	[graafId] INT NOT NULL ,
	[knoopId] INT NOT NULL, 
	PRIMARY KEY CLUSTERED ([graafId],[knoopId]),
    CONSTRAINT [FK_Graaf_Knoop_graafId] FOREIGN KEY ([graafId]) REFERENCES [dbo].[Graaf]([graafId]), 
    CONSTRAINT [FK_Graaf_Knoop_knoopId] FOREIGN KEY ([knoopId]) REFERENCES [dbo].[Knoop]([knoopId]),

	
)
