CREATE TABLE [dbo].[TrackSegment] (
    [Id]      UNIQUEIDENTIFIER NOT NULL,
    [TrackId] UNIQUEIDENTIFIER NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([TrackId]) REFERENCES [dbo].[MyTrack] ([Id])
);

