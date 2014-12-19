CREATE TABLE [dbo].[PathStep] (
    [ID]               UNIQUEIDENTIFIER NOT NULL,
    [TripLegId]        UNIQUEIDENTIFIER NULL,
    [FromLatitude]     DECIMAL (18, 5)  NOT NULL,
    [FromLongitude]    DECIMAL (18, 5)  NOT NULL,
    [ToLatitude]       DECIMAL (18, 5)  NOT NULL,
    [ToLongitude]      DECIMAL (18, 5)  NOT NULL,
    [PolylinePoints]   VARCHAR (500)    NULL,
    [HtmlInstructions] VARCHAR (MAX)    NULL,
    [Duration]         TIME (7)         NULL,
    [Distance]         DECIMAL (6, 2)   NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([TripLegId]) REFERENCES [dbo].[PathLeg] ([Id])
);

