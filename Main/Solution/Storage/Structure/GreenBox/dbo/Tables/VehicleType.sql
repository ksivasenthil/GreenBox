CREATE TABLE [dbo].[VehicleType] (
    [Id]              UNIQUEIDENTIFIER NOT NULL,
    [TransportModeId] UNIQUEIDENTIFIER NOT NULL,
    [Description]     VARCHAR (100)    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([TransportModeId]) REFERENCES [dbo].[TransportMode] ([Id])
);

