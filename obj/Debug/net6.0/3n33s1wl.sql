IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [users] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
    [LastName] nvarchar(100) NOT NULL,
    [EmailAddress] nvarchar(max) NOT NULL,
    [Password] nvarchar(max) NOT NULL,
    [CreatedBy] nvarchar(max) NOT NULL,
    [CreateAt] datetime2 NOT NULL,
    [UpdateBy] nvarchar(max) NOT NULL,
    [UpdatedAt] datetime2 NULL,
    [DeleteBy] nvarchar(max) NOT NULL,
    [DeletedAt] datetime2 NULL,
    [isDeleted] bit NOT NULL,
    CONSTRAINT [PK_users] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230219063443_Create user table', N'7.0.3');
GO

COMMIT;
GO

