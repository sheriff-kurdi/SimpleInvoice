IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200618230306_init')
BEGIN
    CREATE TABLE [Invoices] (
        [Id] nvarchar(450) NOT NULL,
        [Date] nvarchar(max) NULL,
        [ItemName] nvarchar(max) NOT NULL,
        [UnitName] nvarchar(max) NOT NULL,
        [ItemPrice] float NOT NULL,
        [Quantity] int NOT NULL,
        [Discount] float NOT NULL,
        [Total] float NOT NULL,
        [Taxes] float NOT NULL,
        [Net] float NOT NULL,
        CONSTRAINT [PK_Invoices] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200618230306_init')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200618230306_init', N'3.1.5');
END;

GO

