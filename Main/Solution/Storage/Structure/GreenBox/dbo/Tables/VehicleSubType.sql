CREATE TABLE [dbo].[VehicleSubType] (
    [Id]            UNIQUEIDENTIFIER NOT NULL,
    [VehicleTypeId] UNIQUEIDENTIFIER NOT NULL,
    [Description]   VARCHAR (100)    NULL,
    [FuelTypeId]    UNIQUEIDENTIFIER NULL,
    [Mileage]       DECIMAL (8, 2)   NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([FuelTypeId]) REFERENCES [dbo].[FuelType] ([Id]),
    FOREIGN KEY ([VehicleTypeId]) REFERENCES [dbo].[VehicleType] ([Id])
);

