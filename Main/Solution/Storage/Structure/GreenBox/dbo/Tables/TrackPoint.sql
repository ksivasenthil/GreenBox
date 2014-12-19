CREATE TABLE [dbo].[TrackPoint] (
    [Id]             UNIQUEIDENTIFIER NOT NULL,
    [SegmentId]      UNIQUEIDENTIFIER NULL,
    [Latitude]       DECIMAL (18, 5)  NOT NULL,
    [Longitude]      DECIMAL (18, 5)  NOT NULL,
    [Elevation]      DECIMAL (18, 5)  NOT NULL,
    [TrackPointTime] DATETIME         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([SegmentId]) REFERENCES [dbo].[TrackSegment] ([Id])
);

