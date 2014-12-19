CREATE TABLE [dbo].[MyTrack] (
    [Id]             UNIQUEIDENTIFIER NOT NULL,
    [Description]    VARCHAR (512)    NULL,
    [MyTripOn]       DATETIME         NULL,
    [PathID]         UNIQUEIDENTIFIER NULL,
    [VehicleTypeID]  UNIQUEIDENTIFIER NULL,
    [FuelConsumed]   DECIMAL (6, 2)   NULL,
    [VehiclesWeight] DECIMAL (6, 2)   NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([PathID]) REFERENCES [dbo].[MyPath] ([Id])
);

