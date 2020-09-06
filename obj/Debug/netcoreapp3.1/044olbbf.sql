IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE TABLE [Client] (
        [ID] nvarchar(450) NOT NULL,
        [Title] nvarchar(10) NULL,
        [FirstName] nvarchar(50) NOT NULL,
        [LastName] nvarchar(50) NOT NULL,
        [AddressLine1] nvarchar(50) NOT NULL,
        [AddressLine2] nvarchar(max) NULL,
        [City] nvarchar(max) NULL,
        [County] nvarchar(max) NULL,
        [Postcode] nvarchar(8) NOT NULL,
        [Phone] nvarchar(11) NOT NULL,
        [Email] nvarchar(max) NULL,
        [EntryDate] datetime2 NOT NULL,
        [PropertyAddres] bit NOT NULL,
        CONSTRAINT [PK_Client] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE TABLE [Painter] (
        [PainterID] nvarchar(10) NOT NULL,
        [FirstName] nvarchar(50) NOT NULL,
        [LastName] nvarchar(50) NOT NULL,
        [DrivingLicence] int NOT NULL,
        [YearOfStart] datetime2 NOT NULL,
        [CurrentLocation] nvarchar(max) NULL,
        CONSTRAINT [PK_Painter] PRIMARY KEY ([PainterID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE TABLE [Property] (
        [PropertyID] nvarchar(10) NOT NULL,
        [ClintID] nvarchar(450) NOT NULL,
        [Address] nvarchar(50) NOT NULL,
        [Location] nvarchar(max) NULL,
        [County] nvarchar(max) NULL,
        [Postcode] nvarchar(8) NOT NULL,
        [PropertyType] int NOT NULL,
        [NumberOfRooms] int NULL,
        CONSTRAINT [PK_Property] PRIMARY KEY ([PropertyID]),
        CONSTRAINT [FK_Property_Client_ClintID] FOREIGN KEY ([ClintID]) REFERENCES [Client] ([ID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE TABLE [Project] (
        [ProjectID] nvarchar(8) NOT NULL,
        [PropertyID] nvarchar(10) NULL,
        [StartDate] datetime2 NOT NULL,
        [EndDate] datetime2 NOT NULL,
        [ActualEndDate] datetime2 NULL,
        [ProjectScope] nvarchar(max) NULL,
        [ProjectImage] nvarchar(max) NULL,
        [ImageDate] datetime2 NULL,
        CONSTRAINT [PK_Project] PRIMARY KEY ([ProjectID]),
        CONSTRAINT [FK_Project_Property_PropertyID] FOREIGN KEY ([PropertyID]) REFERENCES [Property] ([PropertyID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE TABLE [PaintingWork] (
        [WorkID] nvarchar(10) NOT NULL,
        [ProjectID] nvarchar(8) NULL,
        [PropertyArea] nvarchar(max) NOT NULL,
        [Surface] int NOT NULL,
        [ExpectedHours] int NOT NULL,
        [ActualHours] int NULL,
        [WorkImage] nvarchar(max) NULL,
        [ImageDate] datetime2 NULL,
        CONSTRAINT [PK_PaintingWork] PRIMARY KEY ([WorkID]),
        CONSTRAINT [FK_PaintingWork_Project_ProjectID] FOREIGN KEY ([ProjectID]) REFERENCES [Project] ([ProjectID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE TABLE [PaintingJob] (
        [ID] int NOT NULL IDENTITY,
        [WorkID] nvarchar(10) NOT NULL,
        [SelfEmployedPainterID] nvarchar(10) NOT NULL,
        [UnderCoatType] int NOT NULL,
        [UnderCoatName] nvarchar(50) NULL,
        [Paint] nvarchar(50) NOT NULL,
        [Brand] nvarchar(max) NULL,
        [Finish] int NOT NULL,
        [Color] nvarchar(max) NULL,
        [StartDate] datetime2 NOT NULL,
        [EndDate] datetime2 NULL,
        [ManHours] int NULL,
        [Stages] int NOT NULL,
        [JobImage] nvarchar(max) NULL,
        [ImageDate] datetime2 NULL,
        CONSTRAINT [PK_PaintingJob] PRIMARY KEY ([ID]),
        CONSTRAINT [FK_PaintingJob_Painter_SelfEmployedPainterID] FOREIGN KEY ([SelfEmployedPainterID]) REFERENCES [Painter] ([PainterID]) ON DELETE CASCADE,
        CONSTRAINT [FK_PaintingJob_PaintingWork_WorkID] FOREIGN KEY ([WorkID]) REFERENCES [PaintingWork] ([WorkID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE TABLE [SubContractWork] (
        [SubContractWorkID] nvarchar(15) NOT NULL,
        [ProjectID] nvarchar(8) NULL,
        [WorkImage] nvarchar(max) NULL,
        [SignedOff] nvarchar(max) NULL,
        [StartDate] datetime2 NOT NULL,
        [EndDate] datetime2 NOT NULL,
        [ActualEndDate] datetime2 NULL,
        [Discriminator] nvarchar(max) NOT NULL,
        [Carpentry] int NULL,
        [SubContractorID] nvarchar(20) NULL,
        [ElectricalWork_SubContractorID] nvarchar(20) NULL,
        [WorkScope] int NULL,
        [WorkArea] nvarchar(max) NULL,
        [WireType] nvarchar(max) NULL,
        [Plastering_SubContractorID] nvarchar(20) NULL,
        [Plastering_WorkArea] nvarchar(max) NULL,
        [PlumbingWork_SubContractorID] nvarchar(20) NULL,
        [PlumbingArea] int NULL,
        [Tiling_SubContractorID] nvarchar(20) NULL,
        [PropertyArea] nvarchar(max) NULL,
        [TilingArea] int NULL,
        [ColourTheme] nvarchar(max) NULL,
        [Type] nvarchar(max) NULL,
        [WallPaperWork_SubContractorID] nvarchar(20) NULL,
        [WallPaperWork_ColourTheme] nvarchar(max) NULL,
        [Grade] nvarchar(max) NULL,
        CONSTRAINT [PK_SubContractWork] PRIMARY KEY ([SubContractWorkID]),
        CONSTRAINT [FK_SubContractWork_Project_ProjectID] FOREIGN KEY ([ProjectID]) REFERENCES [Project] ([ProjectID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE TABLE [SubContractor] (
        [SubContractorID] nvarchar(20) NOT NULL,
        [SubContractWorkID] nvarchar(15) NULL,
        [FirstName] nvarchar(max) NULL,
        [LastName] nvarchar(max) NULL,
        [CertificateNumber] nvarchar(max) NULL,
        [CompanyName] nvarchar(max) NULL,
        [phone] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [SkillSet] int NOT NULL,
        CONSTRAINT [PK_SubContractor] PRIMARY KEY ([SubContractorID]),
        CONSTRAINT [FK_SubContractor_SubContractWork_SubContractWorkID] FOREIGN KEY ([SubContractWorkID]) REFERENCES [SubContractWork] ([SubContractWorkID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE INDEX [IX_PaintingJob_SelfEmployedPainterID] ON [PaintingJob] ([SelfEmployedPainterID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE UNIQUE INDEX [IX_PaintingJob_WorkID] ON [PaintingJob] ([WorkID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE INDEX [IX_PaintingWork_ProjectID] ON [PaintingWork] ([ProjectID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE UNIQUE INDEX [IX_Project_PropertyID] ON [Project] ([PropertyID]) WHERE [PropertyID] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE INDEX [IX_Property_ClintID] ON [Property] ([ClintID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE INDEX [IX_SubContractor_SubContractWorkID] ON [SubContractor] ([SubContractWorkID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE INDEX [IX_SubContractWork_SubContractorID] ON [SubContractWork] ([SubContractorID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE INDEX [IX_SubContractWork_ElectricalWork_SubContractorID] ON [SubContractWork] ([ElectricalWork_SubContractorID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE INDEX [IX_SubContractWork_Plastering_SubContractorID] ON [SubContractWork] ([Plastering_SubContractorID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE INDEX [IX_SubContractWork_PlumbingWork_SubContractorID] ON [SubContractWork] ([PlumbingWork_SubContractorID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE INDEX [IX_SubContractWork_ProjectID] ON [SubContractWork] ([ProjectID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE INDEX [IX_SubContractWork_Tiling_SubContractorID] ON [SubContractWork] ([Tiling_SubContractorID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    CREATE INDEX [IX_SubContractWork_WallPaperWork_SubContractorID] ON [SubContractWork] ([WallPaperWork_SubContractorID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    ALTER TABLE [SubContractWork] ADD CONSTRAINT [FK_SubContractWork_SubContractor_SubContractorID] FOREIGN KEY ([SubContractorID]) REFERENCES [SubContractor] ([SubContractorID]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    ALTER TABLE [SubContractWork] ADD CONSTRAINT [FK_SubContractWork_SubContractor_ElectricalWork_SubContractorID] FOREIGN KEY ([ElectricalWork_SubContractorID]) REFERENCES [SubContractor] ([SubContractorID]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    ALTER TABLE [SubContractWork] ADD CONSTRAINT [FK_SubContractWork_SubContractor_Plastering_SubContractorID] FOREIGN KEY ([Plastering_SubContractorID]) REFERENCES [SubContractor] ([SubContractorID]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    ALTER TABLE [SubContractWork] ADD CONSTRAINT [FK_SubContractWork_SubContractor_PlumbingWork_SubContractorID] FOREIGN KEY ([PlumbingWork_SubContractorID]) REFERENCES [SubContractor] ([SubContractorID]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    ALTER TABLE [SubContractWork] ADD CONSTRAINT [FK_SubContractWork_SubContractor_Tiling_SubContractorID] FOREIGN KEY ([Tiling_SubContractorID]) REFERENCES [SubContractor] ([SubContractorID]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    ALTER TABLE [SubContractWork] ADD CONSTRAINT [FK_SubContractWork_SubContractor_WallPaperWork_SubContractorID] FOREIGN KEY ([WallPaperWork_SubContractorID]) REFERENCES [SubContractor] ([SubContractorID]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602121939_FirstMigration')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200602121939_FirstMigration', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200604144748_RGBcolor')
BEGIN
    ALTER TABLE [PaintingJob] ADD [ColorRGB] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200604144748_RGBcolor')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200604144748_RGBcolor', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200604212306_PaintingUpdate')
BEGIN
    ALTER TABLE [PaintingWork] ADD [WorkArea] nvarchar(max) NOT NULL DEFAULT N'';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200604212306_PaintingUpdate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200604212306_PaintingUpdate', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200605080123_PaintingUpdate-2')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[PaintingWork]') AND [c].[name] = N'ActualHours');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [PaintingWork] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [PaintingWork] DROP COLUMN [ActualHours];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200605080123_PaintingUpdate-2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200605080123_PaintingUpdate-2', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200605091609_PaintingUpdate-3')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[PaintingJob]') AND [c].[name] = N'Color');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [PaintingJob] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [PaintingJob] DROP COLUMN [Color];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200605091609_PaintingUpdate-3')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[PaintingJob]') AND [c].[name] = N'ColorRGB');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [PaintingJob] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [PaintingJob] DROP COLUMN [ColorRGB];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200605091609_PaintingUpdate-3')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[PaintingJob]') AND [c].[name] = N'Paint');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [PaintingJob] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [PaintingJob] DROP COLUMN [Paint];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200605091609_PaintingUpdate-3')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[PaintingJob]') AND [c].[name] = N'UnderCoatType');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [PaintingJob] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [PaintingJob] ALTER COLUMN [UnderCoatType] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200605091609_PaintingUpdate-3')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[PaintingJob]') AND [c].[name] = N'Brand');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [PaintingJob] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [PaintingJob] ALTER COLUMN [Brand] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200605091609_PaintingUpdate-3')
BEGIN
    ALTER TABLE [PaintingJob] ADD [Ceiling] nvarchar(50) NOT NULL DEFAULT N'';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200605091609_PaintingUpdate-3')
BEGIN
    ALTER TABLE [PaintingJob] ADD [Door] nvarchar(50) NOT NULL DEFAULT N'';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200605091609_PaintingUpdate-3')
BEGIN
    ALTER TABLE [PaintingJob] ADD [Wall] nvarchar(50) NOT NULL DEFAULT N'';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200605091609_PaintingUpdate-3')
BEGIN
    ALTER TABLE [PaintingJob] ADD [WallColourValue] nvarchar(max) NOT NULL DEFAULT N'';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200605091609_PaintingUpdate-3')
BEGIN
    ALTER TABLE [PaintingJob] ADD [Window] nvarchar(50) NOT NULL DEFAULT N'';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200605091609_PaintingUpdate-3')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200605091609_PaintingUpdate-3', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200608162919_June8')
BEGIN
    ALTER TABLE [PaintingWork] ADD [EntryDate] datetime2 NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200608162919_June8')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[PaintingJob]') AND [c].[name] = N'Window');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [PaintingJob] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [PaintingJob] ALTER COLUMN [Window] nvarchar(50) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200608162919_June8')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[PaintingJob]') AND [c].[name] = N'Wall');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [PaintingJob] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [PaintingJob] ALTER COLUMN [Wall] nvarchar(50) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200608162919_June8')
BEGIN
    DECLARE @var8 sysname;
    SELECT @var8 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[PaintingJob]') AND [c].[name] = N'Door');
    IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [PaintingJob] DROP CONSTRAINT [' + @var8 + '];');
    ALTER TABLE [PaintingJob] ALTER COLUMN [Door] nvarchar(50) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200608162919_June8')
BEGIN
    DECLARE @var9 sysname;
    SELECT @var9 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[PaintingJob]') AND [c].[name] = N'Ceiling');
    IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [PaintingJob] DROP CONSTRAINT [' + @var9 + '];');
    ALTER TABLE [PaintingJob] ALTER COLUMN [Ceiling] nvarchar(50) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200608162919_June8')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200608162919_June8', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200609093242_June-9')
BEGIN
    ALTER TABLE [Property] ADD [EntryDate] datetime2 NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200609093242_June-9')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200609093242_June-9', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623081248_June23')
BEGIN
    ALTER TABLE [PaintingJob] ADD [WallColourName] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623081248_June23')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200623081248_June23', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200823145653_August23')
BEGIN
    ALTER TABLE [SubContractor] DROP CONSTRAINT [FK_SubContractor_SubContractWork_SubContractWorkID];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200823145653_August23')
BEGIN
    DROP TABLE [SubContractWork];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200823145653_August23')
BEGIN
    DROP TABLE [SubContractor];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200823145653_August23')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200823145653_August23', N'3.1.4');
END;

GO

