CREATE TABLE [dbo].[Provincie_Gemeente]
(
	[provincieId] INT NOT NULL, 
    [gemeenteIds] INT NOT NULL,
	PRIMARY KEY CLUSTERED([provincieId],[gemeenteIds]),

)
