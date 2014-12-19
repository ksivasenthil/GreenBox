CREATE TABLE [dbo].[PathLeg] (
    [Id]            UNIQUEIDENTIFIER NOT NULL,
    [PathId]        UNIQUEIDENTIFIER NULL,
    [FromLatitude]  DECIMAL (18, 5)  NOT NULL,
    [FromLongitude] DECIMAL (18, 5)  NOT NULL,
    [ToLatitude]    DECIMAL (18, 5)  NOT NULL,
    [ToLongitude]   DECIMAL (18, 5)  NOT NULL,
    [Duration]      TIME (7)         NULL,
    [Distance]      DECIMAL (6, 2)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([PathId]) REFERENCES [dbo].[MyPath] ([Id])
);

