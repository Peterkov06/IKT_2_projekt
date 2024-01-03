CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET=utf8mb4;

START TRANSACTION;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    ALTER DATABASE CHARACTER SET utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `CoreNumbers` (
        `CoreNumberID` int NOT NULL AUTO_INCREMENT,
        `CoreNum` int NOT NULL,
        CONSTRAINT `PK_CoreNumbers` PRIMARY KEY (`CoreNumberID`)
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `DDRtypes` (
        `DDRtypeId` int NOT NULL AUTO_INCREMENT,
        `DDRtypeName` longtext CHARACTER SET utf8mb4 NOT NULL,
        CONSTRAINT `PK_DDRtypes` PRIMARY KEY (`DDRtypeId`)
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `GDDRtypes` (
        `GDDRtypeId` int NOT NULL AUTO_INCREMENT,
        `GDDRtypeName` longtext CHARACTER SET utf8mb4 NOT NULL,
        CONSTRAINT `PK_GDDRtypes` PRIMARY KEY (`GDDRtypeId`)
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `KeyboardLayouts` (
        `TypeID` int NOT NULL AUTO_INCREMENT,
        `LayoutName` longtext CHARACTER SET utf8mb4 NOT NULL,
        CONSTRAINT `PK_KeyboardLayouts` PRIMARY KEY (`TypeID`)
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `KeyboardSizes` (
        `TypeID` int NOT NULL AUTO_INCREMENT,
        `SizeName` longtext CHARACTER SET utf8mb4 NOT NULL,
        CONSTRAINT `PK_KeyboardSizes` PRIMARY KEY (`TypeID`)
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `KeyboardTypes` (
        `TypeID` int NOT NULL AUTO_INCREMENT,
        `TypeName` longtext CHARACTER SET utf8mb4 NOT NULL,
        CONSTRAINT `PK_KeyboardTypes` PRIMARY KEY (`TypeID`)
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `Manufacturers` (
        `ManufacturerId` int NOT NULL AUTO_INCREMENT,
        `ManufacturerName` longtext CHARACTER SET utf8mb4 NOT NULL,
        CONSTRAINT `PK_Manufacturers` PRIMARY KEY (`ManufacturerId`)
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `OverclockPresets` (
        `OverclockPresetID` int NOT NULL AUTO_INCREMENT,
        `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
        CONSTRAINT `PK_OverclockPresets` PRIMARY KEY (`OverclockPresetID`)
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `PeriferialConnectionTypes` (
        `PConnectionID` int NOT NULL AUTO_INCREMENT,
        `PConnectionName` longtext CHARACTER SET utf8mb4 NOT NULL,
        CONSTRAINT `PK_PeriferialConnectionTypes` PRIMARY KEY (`PConnectionID`)
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `RamKits` (
        `RAMkitID` int NOT NULL AUTO_INCREMENT,
        `RAMkitNum` int NOT NULL,
        CONSTRAINT `PK_RamKits` PRIMARY KEY (`RAMkitID`)
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `ScreenSyncTypes` (
        `ScreenSyncTypeID` int NOT NULL AUTO_INCREMENT,
        `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
        CONSTRAINT `PK_ScreenSyncTypes` PRIMARY KEY (`ScreenSyncTypeID`)
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `ScreenSyncs` (
        `ScreenSyncID` int NOT NULL AUTO_INCREMENT,
        `SyncRate` int NOT NULL,
        CONSTRAINT `PK_ScreenSyncs` PRIMARY KEY (`ScreenSyncID`)
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `StorageConnectionTypes` (
        `StorageConnectionID` int NOT NULL AUTO_INCREMENT,
        `StorageConnectionName` longtext CHARACTER SET utf8mb4 NOT NULL,
        CONSTRAINT `PK_StorageConnectionTypes` PRIMARY KEY (`StorageConnectionID`)
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `StorageTypes` (
        `StorageTypeID` int NOT NULL AUTO_INCREMENT,
        `StorageTypeName` longtext CHARACTER SET utf8mb4 NOT NULL,
        CONSTRAINT `PK_StorageTypes` PRIMARY KEY (`StorageTypeID`)
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `ThreadNumbers` (
        `ThreadNumberID` int NOT NULL AUTO_INCREMENT,
        `ThreadNum` int NOT NULL,
        CONSTRAINT `PK_ThreadNumbers` PRIMARY KEY (`ThreadNumberID`)
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `Types` (
        `TypeID` int NOT NULL AUTO_INCREMENT,
        `TypeName` longtext CHARACTER SET utf8mb4 NOT NULL,
        CONSTRAINT `PK_Types` PRIMARY KEY (`TypeID`)
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `CPUsockets` (
        `CPUsocketId` int NOT NULL AUTO_INCREMENT,
        `CPUsocketType` longtext CHARACTER SET utf8mb4 NOT NULL,
        `ManufacturerID` int NOT NULL,
        CONSTRAINT `PK_CPUsockets` PRIMARY KEY (`CPUsocketId`),
        CONSTRAINT `FK_CPUsockets_Manufacturers_ManufacturerID` FOREIGN KEY (`ManufacturerID`) REFERENCES `Manufacturers` (`ManufacturerId`) ON DELETE CASCADE
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `GPUs` (
        `Id` int NOT NULL AUTO_INCREMENT,
        `Type` int NOT NULL,
        `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
        `Manufacturer` int NOT NULL,
        `Price` int NOT NULL,
        `GDDRtype` int NOT NULL,
        `VRAMamount` int NOT NULL,
        `CoreNum` int NOT NULL,
        `ClockSpeed` float NOT NULL,
        `StockNum` int NOT NULL,
        CONSTRAINT `PK_GPUs` PRIMARY KEY (`Id`),
        CONSTRAINT `FK_GPUs_GDDRtypes_GDDRtype` FOREIGN KEY (`GDDRtype`) REFERENCES `GDDRtypes` (`GDDRtypeId`) ON DELETE CASCADE,
        CONSTRAINT `FK_GPUs_Manufacturers_Manufacturer` FOREIGN KEY (`Manufacturer`) REFERENCES `Manufacturers` (`ManufacturerId`) ON DELETE CASCADE,
        CONSTRAINT `FK_GPUs_Types_Type` FOREIGN KEY (`Type`) REFERENCES `Types` (`TypeID`) ON DELETE CASCADE
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `Keyboards` (
        `Id` int NOT NULL AUTO_INCREMENT,
        `Type` int NOT NULL,
        `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
        `Manufacturer` int NOT NULL,
        `Price` int NOT NULL,
        `ConnectionType` int NOT NULL,
        `Wireless` tinyint(1) NOT NULL,
        `KeyboardType` int NOT NULL,
        `Layout` int NOT NULL,
        `Size` int NOT NULL,
        CONSTRAINT `PK_Keyboards` PRIMARY KEY (`Id`),
        CONSTRAINT `FK_Keyboards_KeyboardLayouts_Layout` FOREIGN KEY (`Layout`) REFERENCES `KeyboardLayouts` (`TypeID`) ON DELETE CASCADE,
        CONSTRAINT `FK_Keyboards_KeyboardSizes_Size` FOREIGN KEY (`Size`) REFERENCES `KeyboardSizes` (`TypeID`) ON DELETE CASCADE,
        CONSTRAINT `FK_Keyboards_KeyboardTypes_KeyboardType` FOREIGN KEY (`KeyboardType`) REFERENCES `KeyboardTypes` (`TypeID`) ON DELETE CASCADE,
        CONSTRAINT `FK_Keyboards_Manufacturers_Manufacturer` FOREIGN KEY (`Manufacturer`) REFERENCES `Manufacturers` (`ManufacturerId`) ON DELETE CASCADE,
        CONSTRAINT `FK_Keyboards_PeriferialConnectionTypes_ConnectionType` FOREIGN KEY (`ConnectionType`) REFERENCES `PeriferialConnectionTypes` (`PConnectionID`) ON DELETE CASCADE,
        CONSTRAINT `FK_Keyboards_Types_Type` FOREIGN KEY (`Type`) REFERENCES `Types` (`TypeID`) ON DELETE CASCADE
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `Monitors` (
        `Id` int NOT NULL AUTO_INCREMENT,
        `Type` int NOT NULL,
        `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
        `Manufacturer` int NOT NULL,
        `Price` int NOT NULL,
        `Size` float NOT NULL,
        `Xresolution` int NOT NULL,
        `Yresolution` int NOT NULL,
        `MonitorType` int NOT NULL,
        `ColorAccuracy` float NOT NULL,
        `Brightness` float NOT NULL,
        `DynamicContrast` int NOT NULL,
        `StaticContrast` int NOT NULL,
        `RefreshRate` int NOT NULL,
        `RefreshingTech` int NOT NULL,
        `StockNum` int NOT NULL,
        CONSTRAINT `PK_Monitors` PRIMARY KEY (`Id`),
        CONSTRAINT `FK_Monitors_Manufacturers_Manufacturer` FOREIGN KEY (`Manufacturer`) REFERENCES `Manufacturers` (`ManufacturerId`) ON DELETE CASCADE,
        CONSTRAINT `FK_Monitors_ScreenSyncTypes_RefreshingTech` FOREIGN KEY (`RefreshingTech`) REFERENCES `ScreenSyncTypes` (`ScreenSyncTypeID`) ON DELETE CASCADE,
        CONSTRAINT `FK_Monitors_ScreenSyncs_RefreshRate` FOREIGN KEY (`RefreshRate`) REFERENCES `ScreenSyncs` (`ScreenSyncID`) ON DELETE CASCADE,
        CONSTRAINT `FK_Monitors_Types_Type` FOREIGN KEY (`Type`) REFERENCES `Types` (`TypeID`) ON DELETE CASCADE
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `Mouses` (
        `Id` int NOT NULL AUTO_INCREMENT,
        `Type` int NOT NULL,
        `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
        `Manufacturer` int NOT NULL,
        `Price` int NOT NULL,
        `ConnectionType` int NOT NULL,
        `Wireless` tinyint(1) NOT NULL,
        `DPI` int NOT NULL,
        CONSTRAINT `PK_Mouses` PRIMARY KEY (`Id`),
        CONSTRAINT `FK_Mouses_Manufacturers_Manufacturer` FOREIGN KEY (`Manufacturer`) REFERENCES `Manufacturers` (`ManufacturerId`) ON DELETE CASCADE,
        CONSTRAINT `FK_Mouses_PeriferialConnectionTypes_ConnectionType` FOREIGN KEY (`ConnectionType`) REFERENCES `PeriferialConnectionTypes` (`PConnectionID`) ON DELETE CASCADE,
        CONSTRAINT `FK_Mouses_Types_Type` FOREIGN KEY (`Type`) REFERENCES `Types` (`TypeID`) ON DELETE CASCADE
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `RAMs` (
        `Id` int NOT NULL AUTO_INCREMENT,
        `Type` int NOT NULL,
        `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
        `Manufacturer` int NOT NULL,
        `Price` int NOT NULL,
        `DDRtype` int NOT NULL,
        `Amount` int NOT NULL,
        `ClockSpeed` float NOT NULL,
        `KitNum` int NOT NULL,
        `OverclockType` int NOT NULL,
        `StockNum` int NOT NULL,
        CONSTRAINT `PK_RAMs` PRIMARY KEY (`Id`),
        CONSTRAINT `FK_RAMs_DDRtypes_DDRtype` FOREIGN KEY (`DDRtype`) REFERENCES `DDRtypes` (`DDRtypeId`) ON DELETE CASCADE,
        CONSTRAINT `FK_RAMs_Manufacturers_Manufacturer` FOREIGN KEY (`Manufacturer`) REFERENCES `Manufacturers` (`ManufacturerId`) ON DELETE CASCADE,
        CONSTRAINT `FK_RAMs_OverclockPresets_OverclockType` FOREIGN KEY (`OverclockType`) REFERENCES `OverclockPresets` (`OverclockPresetID`) ON DELETE CASCADE,
        CONSTRAINT `FK_RAMs_RamKits_KitNum` FOREIGN KEY (`KitNum`) REFERENCES `RamKits` (`RAMkitID`) ON DELETE CASCADE,
        CONSTRAINT `FK_RAMs_Types_Type` FOREIGN KEY (`Type`) REFERENCES `Types` (`TypeID`) ON DELETE CASCADE
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `Storages` (
        `Id` int NOT NULL AUTO_INCREMENT,
        `Type` int NOT NULL,
        `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
        `Manufacturer` int NOT NULL,
        `Price` int NOT NULL,
        `StorageType` int NOT NULL,
        `WriteSpeed` int NOT NULL,
        `ReadSpeed` int NOT NULL,
        `ConnectionType` int NOT NULL,
        `Space` int NOT NULL,
        `StockNum` int NOT NULL,
        CONSTRAINT `PK_Storages` PRIMARY KEY (`Id`),
        CONSTRAINT `FK_Storages_Manufacturers_Manufacturer` FOREIGN KEY (`Manufacturer`) REFERENCES `Manufacturers` (`ManufacturerId`) ON DELETE CASCADE,
        CONSTRAINT `FK_Storages_StorageConnectionTypes_ConnectionType` FOREIGN KEY (`ConnectionType`) REFERENCES `StorageConnectionTypes` (`StorageConnectionID`) ON DELETE CASCADE,
        CONSTRAINT `FK_Storages_StorageTypes_StorageType` FOREIGN KEY (`StorageType`) REFERENCES `StorageTypes` (`StorageTypeID`) ON DELETE CASCADE,
        CONSTRAINT `FK_Storages_Types_Type` FOREIGN KEY (`Type`) REFERENCES `Types` (`TypeID`) ON DELETE CASCADE
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `CPUs` (
        `Id` int NOT NULL AUTO_INCREMENT,
        `Type` int NOT NULL,
        `Manufacturer` int NOT NULL,
        `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
        `Price` int NOT NULL,
        `SocketType` int NOT NULL,
        `MaxRAM` int NOT NULL,
        `DDRtype` int NOT NULL,
        `CoreNum` int NOT NULL,
        `ThreadCount` int NOT NULL,
        `ClockSpeed` float NOT NULL,
        `TurboClockSpeed` float NOT NULL,
        `StockNum` int NOT NULL,
        CONSTRAINT `PK_CPUs` PRIMARY KEY (`Id`),
        CONSTRAINT `FK_CPUs_CPUsockets_SocketType` FOREIGN KEY (`SocketType`) REFERENCES `CPUsockets` (`CPUsocketId`) ON DELETE CASCADE,
        CONSTRAINT `FK_CPUs_CoreNumbers_CoreNum` FOREIGN KEY (`CoreNum`) REFERENCES `CoreNumbers` (`CoreNumberID`) ON DELETE CASCADE,
        CONSTRAINT `FK_CPUs_DDRtypes_DDRtype` FOREIGN KEY (`DDRtype`) REFERENCES `DDRtypes` (`DDRtypeId`) ON DELETE CASCADE,
        CONSTRAINT `FK_CPUs_Manufacturers_Manufacturer` FOREIGN KEY (`Manufacturer`) REFERENCES `Manufacturers` (`ManufacturerId`) ON DELETE CASCADE,
        CONSTRAINT `FK_CPUs_ThreadNumbers_ThreadCount` FOREIGN KEY (`ThreadCount`) REFERENCES `ThreadNumbers` (`ThreadNumberID`) ON DELETE CASCADE,
        CONSTRAINT `FK_CPUs_Types_Type` FOREIGN KEY (`Type`) REFERENCES `Types` (`TypeID`) ON DELETE CASCADE
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE TABLE `Motherboards` (
        `Id` int NOT NULL AUTO_INCREMENT,
        `Type` int NOT NULL,
        `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
        `Manufacturer` int NOT NULL,
        `Price` int NOT NULL,
        `RamSlots` int NOT NULL,
        `CPUsocket` int NOT NULL,
        `SataNum` int NOT NULL,
        `M2Num` int NOT NULL,
        `PCIeNum` int NOT NULL,
        `DDRtype` int NOT NULL,
        `StockNum` int NOT NULL,
        CONSTRAINT `PK_Motherboards` PRIMARY KEY (`Id`),
        CONSTRAINT `FK_Motherboards_CPUsockets_CPUsocket` FOREIGN KEY (`CPUsocket`) REFERENCES `CPUsockets` (`CPUsocketId`) ON DELETE CASCADE,
        CONSTRAINT `FK_Motherboards_DDRtypes_DDRtype` FOREIGN KEY (`DDRtype`) REFERENCES `DDRtypes` (`DDRtypeId`) ON DELETE CASCADE,
        CONSTRAINT `FK_Motherboards_Manufacturers_Manufacturer` FOREIGN KEY (`Manufacturer`) REFERENCES `Manufacturers` (`ManufacturerId`) ON DELETE CASCADE,
        CONSTRAINT `FK_Motherboards_Types_Type` FOREIGN KEY (`Type`) REFERENCES `Types` (`TypeID`) ON DELETE CASCADE
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_CPUs_CoreNum` ON `CPUs` (`CoreNum`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_CPUs_DDRtype` ON `CPUs` (`DDRtype`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_CPUs_Manufacturer` ON `CPUs` (`Manufacturer`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_CPUs_SocketType` ON `CPUs` (`SocketType`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_CPUs_ThreadCount` ON `CPUs` (`ThreadCount`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_CPUs_Type` ON `CPUs` (`Type`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_CPUsockets_ManufacturerID` ON `CPUsockets` (`ManufacturerID`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_GPUs_GDDRtype` ON `GPUs` (`GDDRtype`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_GPUs_Manufacturer` ON `GPUs` (`Manufacturer`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_GPUs_Type` ON `GPUs` (`Type`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Keyboards_ConnectionType` ON `Keyboards` (`ConnectionType`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Keyboards_KeyboardType` ON `Keyboards` (`KeyboardType`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Keyboards_Layout` ON `Keyboards` (`Layout`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Keyboards_Manufacturer` ON `Keyboards` (`Manufacturer`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Keyboards_Size` ON `Keyboards` (`Size`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Keyboards_Type` ON `Keyboards` (`Type`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Monitors_Manufacturer` ON `Monitors` (`Manufacturer`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Monitors_RefreshRate` ON `Monitors` (`RefreshRate`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Monitors_RefreshingTech` ON `Monitors` (`RefreshingTech`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Monitors_Type` ON `Monitors` (`Type`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Motherboards_CPUsocket` ON `Motherboards` (`CPUsocket`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Motherboards_DDRtype` ON `Motherboards` (`DDRtype`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Motherboards_Manufacturer` ON `Motherboards` (`Manufacturer`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Motherboards_Type` ON `Motherboards` (`Type`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Mouses_ConnectionType` ON `Mouses` (`ConnectionType`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Mouses_Manufacturer` ON `Mouses` (`Manufacturer`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Mouses_Type` ON `Mouses` (`Type`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_RAMs_DDRtype` ON `RAMs` (`DDRtype`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_RAMs_KitNum` ON `RAMs` (`KitNum`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_RAMs_Manufacturer` ON `RAMs` (`Manufacturer`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_RAMs_OverclockType` ON `RAMs` (`OverclockType`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_RAMs_Type` ON `RAMs` (`Type`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Storages_ConnectionType` ON `Storages` (`ConnectionType`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Storages_Manufacturer` ON `Storages` (`Manufacturer`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Storages_StorageType` ON `Storages` (`StorageType`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    CREATE INDEX `IX_Storages_Type` ON `Storages` (`Type`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231217103708_ShopMigration') THEN

    INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
    VALUES ('20231217103708_ShopMigration', '7.0.10');

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

COMMIT;

START TRANSACTION;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231224085328_ShopMigrationV2') THEN

    CREATE TABLE `MonitorTypes` (
        `MonitorTypeID` int NOT NULL AUTO_INCREMENT,
        `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
        CONSTRAINT `PK_MonitorTypes` PRIMARY KEY (`MonitorTypeID`)
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231224085328_ShopMigrationV2') THEN

    INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
    VALUES ('20231224085328_ShopMigrationV2', '7.0.10');

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

COMMIT;

START TRANSACTION;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231224095422_ShopMigrationV3') THEN

    ALTER TABLE `Mouses` ADD `StockNum` int NOT NULL DEFAULT 0;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231224095422_ShopMigrationV3') THEN

    CREATE INDEX `IX_Monitors_MonitorType` ON `Monitors` (`MonitorType`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231224095422_ShopMigrationV3') THEN

    ALTER TABLE `Monitors` ADD CONSTRAINT `FK_Monitors_MonitorTypes_MonitorType` FOREIGN KEY (`MonitorType`) REFERENCES `MonitorTypes` (`MonitorTypeID`) ON DELETE CASCADE;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231224095422_ShopMigrationV3') THEN

    INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
    VALUES ('20231224095422_ShopMigrationV3', '7.0.10');

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

COMMIT;

START TRANSACTION;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231224100801_ShopMigrationV4') THEN

    ALTER TABLE `Keyboards` ADD `StockNum` int NOT NULL DEFAULT 0;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231224100801_ShopMigrationV4') THEN

    INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
    VALUES ('20231224100801_ShopMigrationV4', '7.0.10');

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

COMMIT;

START TRANSACTION;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231224102015_ShopMigrationV5') THEN

    ALTER TABLE `KeyboardSizes` MODIFY COLUMN `SizeName` int NOT NULL;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20231224102015_ShopMigrationV5') THEN

    INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
    VALUES ('20231224102015_ShopMigrationV5', '7.0.10');

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

COMMIT;

START TRANSACTION;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20240102180812_ShopMighrationV6') THEN

    CREATE TABLE `Comments` (
        `CommentTypeID` int NOT NULL AUTO_INCREMENT,
        `Stars` int NOT NULL,
        `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
        `CommentStrg` longtext CHARACTER SET utf8mb4 NOT NULL,
        CONSTRAINT `PK_Comments` PRIMARY KEY (`CommentTypeID`)
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20240102180812_ShopMighrationV6') THEN

    INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
    VALUES ('20240102180812_ShopMighrationV6', '7.0.10');

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

COMMIT;

