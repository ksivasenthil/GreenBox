﻿USE [GreenBox];
GO

DECLARE @HEAVY_TRUCKS_ID AS [UNIQUEIDENTIFIER];
DECLARE @LIGHT_TRUCKS_ID AS [UNIQUEIDENTIFIER];
DECLARE @SMALL_TRUCKS_ID AS [UNIQUEIDENTIFIER];
DECLARE @VERY_HEAVY_TRUCKS_ID AS [UNIQUEIDENTIFIER];
DECLARE @MEDIUM_TRUCKS_ID AS [UNIQUEIDENTIFIER];
DECLARE @FUEL_TYPE_ID AS [UNIQUEIDENTIFIER];
DECLARE @DEFAULT_ID AS [UNIQUEIDENTIFIER];


SELECT @DEFAULT_ID = NEWID();

SELECT @HEAVY_TRUCKS_ID = VT.[Id]
FROM [dbo].[VehicleType] VT
WHERE
VT.[Description] = 'Heavy Trucks';

SELECT @LIGHT_TRUCKS_ID = VT.[Id]
FROM [dbo].[VehicleType] VT
WHERE
VT.[Description] = 'Light Trucks';

SELECT @SMALL_TRUCKS_ID = VT.[Id]
FROM [dbo].[VehicleType] VT
WHERE
VT.[Description] = 'Small Trucks';

SELECT @VERY_HEAVY_TRUCKS_ID = VT.[Id]
FROM [dbo].[VehicleType] VT
WHERE
VT.[Description] = 'Very Heavy Trucks';

SELECT @MEDIUM_TRUCKS_ID = VT.[Id]
FROM [dbo].[VehicleType] VT
WHERE
VT.[Description] = 'Medium Trucks';

SELECT @FUEL_TYPE_ID = FT.Id
FROM [dbo].[FuelType] FT
WHERE
FT.[Description] = 'Diesel';

IF ISNULL(@HEAVY_TRUCKS_ID,@DEFAULT_ID) <> @DEFAULT_ID
BEGIN

INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @HEAVY_TRUCKS_ID, 'Heavy Hauler', @FUEL_TYPE_ID, 9.01);

END

IF ISNULL(@VERY_HEAVY_TRUCKS_ID,@DEFAULT_ID) <> @DEFAULT_ID
BEGIN

INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @VERY_HEAVY_TRUCKS_ID, 'Log Carrier', @FUEL_TYPE_ID, 6.78);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @VERY_HEAVY_TRUCKS_ID, 'Concrete Transport Truck', @FUEL_TYPE_ID, 6.78);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @VERY_HEAVY_TRUCKS_ID, 'Refrigirator Truck', @FUEL_TYPE_ID, 6.78);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @VERY_HEAVY_TRUCKS_ID, 'Garbage Truck', @FUEL_TYPE_ID, 6.78);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @VERY_HEAVY_TRUCKS_ID, 'Dump Truck', @FUEL_TYPE_ID, 6.78);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @VERY_HEAVY_TRUCKS_ID, 'Semi-Trailer Truck', @FUEL_TYPE_ID, 6.78);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @VERY_HEAVY_TRUCKS_ID, 'Ballast Tractor', @FUEL_TYPE_ID, 6.78);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @VERY_HEAVY_TRUCKS_ID, 'Crane Truck', @FUEL_TYPE_ID, 6.78);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @VERY_HEAVY_TRUCKS_ID, 'Tank Truck', @FUEL_TYPE_ID, 6.78);

END

IF ISNULL(@MEDIUM_TRUCKS_ID,@DEFAULT_ID) <> @DEFAULT_ID
BEGIN

INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @MEDIUM_TRUCKS_ID, 'Flatbet Truck', @FUEL_TYPE_ID, 11.01);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @MEDIUM_TRUCKS_ID, 'Bottler', @FUEL_TYPE_ID, 11.01);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @MEDIUM_TRUCKS_ID, 'Fire Truck', @FUEL_TYPE_ID, 11.01);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @MEDIUM_TRUCKS_ID, 'Medium Standard Truck', @FUEL_TYPE_ID, 11.01);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @MEDIUM_TRUCKS_ID, 'Multi Stop Truck', @FUEL_TYPE_ID, 11.01);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @MEDIUM_TRUCKS_ID, 'Platform Truck', @FUEL_TYPE_ID, 11.01);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @MEDIUM_TRUCKS_ID, 'Van', @FUEL_TYPE_ID, 11.01);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @MEDIUM_TRUCKS_ID, 'Medium Duty Truck', @FUEL_TYPE_ID, 11.01);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @MEDIUM_TRUCKS_ID, 'Box Truck', @FUEL_TYPE_ID, 11.01);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @MEDIUM_TRUCKS_ID, 'Delivery Truck', @FUEL_TYPE_ID, 11.01);

END

IF ISNULL(@SMALL_TRUCKS_ID,@DEFAULT_ID) <> @DEFAULT_ID
BEGIN

INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @SMALL_TRUCKS_ID, 'Pickup Truck', @FUEL_TYPE_ID, 12.34);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @SMALL_TRUCKS_ID, 'Cab Forward', @FUEL_TYPE_ID, 12.34);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @SMALL_TRUCKS_ID, 'Sedan Delivery', @FUEL_TYPE_ID, 12.34);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @SMALL_TRUCKS_ID, 'Tow Truck', @FUEL_TYPE_ID, 12.34);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @SMALL_TRUCKS_ID, 'Panel Van', @FUEL_TYPE_ID, 12.34);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @SMALL_TRUCKS_ID, 'Sport Utility Vehicle', @FUEL_TYPE_ID, 12.34);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @SMALL_TRUCKS_ID, 'Minivan', @FUEL_TYPE_ID, 12.34);


INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @SMALL_TRUCKS_ID, 'Canopy Express', @FUEL_TYPE_ID, 12.34);

END

IF ISNULL(@LIGHT_TRUCKS_ID,@DEFAULT_ID) <> @DEFAULT_ID
BEGIN

INSERT INTO [dbo].[VehicleSubType]
VALUES
(NEWID(), @LIGHT_TRUCKS_ID, 'Mini Truck', @FUEL_TYPE_ID, 13.14);

END
GO