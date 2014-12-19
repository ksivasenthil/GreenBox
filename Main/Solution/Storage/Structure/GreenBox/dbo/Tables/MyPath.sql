CREATE TABLE [dbo].[MyPath] (
    [Id]            UNIQUEIDENTIFIER NOT NULL,
    [Description]   VARCHAR (512)    NULL,
    [FromLocation]  VARCHAR (1024)   NULL,
    [FromLatitude]  DECIMAL (18, 5)  NOT NULL,
    [FromLongitude] DECIMAL (18, 5)  NOT NULL,
    [ToLocation]    VARCHAR (1024)   NULL,
    [ToLatitude]    DECIMAL (18, 5)  NOT NULL,
    [ToLongitude]   DECIMAL (18, 5)  NOT NULL,
    [TotalDistance] DECIMAL (8, 2)   NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

