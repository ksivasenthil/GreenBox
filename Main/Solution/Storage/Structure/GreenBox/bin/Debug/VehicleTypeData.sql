USE [GreenBox];
GO

DECLARE @LAND_ID AS [UNIQUEIDENTIFIER];
DECLARE @DEFAULT_ID AS [UNIQUEIDENTIFIER];

SELECT @DEFAULT_ID = NEWID();

SELECT @LAND_ID = TM.[Id]
FROM [dbo].[TransportMode] TM
WHERE
TM.[Description] = 'Land';

IF ISNULL(@LAND_ID,@DEFAULT_ID) <> @DEFAULT_ID
BEGIN
INSERT INTO [dbo].[VehicleType]
VALUES
(NEWID(), @LAND_ID, 'Heavy Trucks');

INSERT INTO [dbo].[VehicleType]
VALUES
(NEWID(), @LAND_ID, 'Light Trucks');

INSERT INTO [dbo].[VehicleType]
VALUES
(NEWID(), @LAND_ID, 'Small Trucks');

INSERT INTO [dbo].[VehicleType]
VALUES
(NEWID(), @LAND_ID, 'Very Heavy Trucks');

INSERT INTO [dbo].[VehicleType]
VALUES
(NEWID(), @LAND_ID, 'Medium Trucks');
END
GO