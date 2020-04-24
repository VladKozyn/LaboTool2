CREATE TABLE [dbo].[Gemeente_Straat]
(
	[gemeenteId] INT NOT NULL, 
    [StratenId] INT NOT NULL,
	PRIMARY KEY CLUSTERED([gemeenteId],[StratenId]),

)
