CREATE TABLE [dbo].[FuelType] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [Description]  VARCHAR (100)    NOT NULL,
    [CO2Emissions] DECIMAL (8, 2)   NOT NULL,
    [ErrorMargin]  DECIMAL (4, 3)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

