CREATE TABLE [dbo].[FuelType] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [Description]  VARCHAR (100)    NOT NULL,
	[HeatingValue] DECIMAL (8,2) NOT NULL,
    [CO2EmissionFactor] DECIMAL (8, 2)   NOT NULL,
    [ErrorMargin]  DECIMAL (4, 3)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

