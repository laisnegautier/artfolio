﻿IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [AspNetRoles] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [AspNetUsers] (
    [Id] nvarchar(450) NOT NULL,
    [UserName] nvarchar(256) NULL,
    [NormalizedUserName] nvarchar(256) NULL,
    [Email] nvarchar(256) NULL,
    [NormalizedEmail] nvarchar(256) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    [Lastname] nvarchar(max) NOT NULL,
    [Firstname] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    [DateOfBirth] datetime2 NOT NULL,
    [Nationality] int NOT NULL,
    [Gender] int NOT NULL,
    [PhotoFilePath] nvarchar(max) NULL,
    [IsPubliclyVisible] bit NOT NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [CreativeCommons] (
    [CreativeCommonsId] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NULL,
    [Acronym] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [LicenseDeedUrl] nvarchar(max) NULL,
    [LegalCodeUrl] nvarchar(max) NULL,
    [BY] bit NOT NULL,
    [SA] bit NOT NULL,
    [ND] bit NOT NULL,
    [NC] bit NOT NULL,
    [Zero] bit NOT NULL,
    CONSTRAINT [PK_CreativeCommons] PRIMARY KEY ([CreativeCommonsId])
);

GO

CREATE TABLE [Tags] (
    [TagId] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Tags] PRIMARY KEY ([TagId])
);

GO

CREATE TABLE [AspNetRoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserLogins] (
    [LoginProvider] nvarchar(128) NOT NULL,
    [ProviderKey] nvarchar(128) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
    CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserRoles] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(128) NOT NULL,
    [Name] nvarchar(128) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
    CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Collections] (
    [CollectionId] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [CreationDate] datetime2 NOT NULL,
    [ArtistId] nvarchar(450) NULL,
    CONSTRAINT [PK_Collections] PRIMARY KEY ([CollectionId]),
    CONSTRAINT [FK_Collections_AspNetUsers_ArtistId] FOREIGN KEY ([ArtistId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [FollowRelations] (
    [FromArtistId] nvarchar(450) NOT NULL,
    [ToArtistId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_FollowRelations] PRIMARY KEY ([FromArtistId], [ToArtistId]),
    CONSTRAINT [FK_FollowRelations_AspNetUsers_FromArtistId] FOREIGN KEY ([FromArtistId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_FollowRelations_AspNetUsers_ToArtistId] FOREIGN KEY ([ToArtistId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Messages] (
    [MessageId] int NOT NULL IDENTITY,
    [Content] nvarchar(max) NULL,
    [CreationDate] datetime2 NOT NULL,
    [IsRead] bit NOT NULL,
    [SenderId] nvarchar(450) NULL,
    [ReceiverId] nvarchar(450) NULL,
    CONSTRAINT [PK_Messages] PRIMARY KEY ([MessageId]),
    CONSTRAINT [FK_Messages_AspNetUsers_ReceiverId] FOREIGN KEY ([ReceiverId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Messages_AspNetUsers_SenderId] FOREIGN KEY ([SenderId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Artworks] (
    [ArtworkId] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [NormalizedTitle] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [CreationDate] datetime2 NOT NULL,
    [ReleaseDate] datetime2 NOT NULL,
    [TerritorialJuridiction] nvarchar(max) NULL,
    [Privacy] int NOT NULL,
    [Category] int NOT NULL,
    [ArtistId] nvarchar(450) NULL,
    [CollectionId] int NULL,
    [CCLicenseCreativeCommonsId] int NULL,
    CONSTRAINT [PK_Artworks] PRIMARY KEY ([ArtworkId]),
    CONSTRAINT [FK_Artworks_AspNetUsers_ArtistId] FOREIGN KEY ([ArtistId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Artworks_CreativeCommons_CCLicenseCreativeCommonsId] FOREIGN KEY ([CCLicenseCreativeCommonsId]) REFERENCES [CreativeCommons] ([CreativeCommonsId]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Artworks_Collections_CollectionId] FOREIGN KEY ([CollectionId]) REFERENCES [Collections] ([CollectionId]) ON DELETE NO ACTION
);

GO

CREATE TABLE [ArtworkTags] (
    [ArtworkId] int NOT NULL,
    [TagId] int NOT NULL,
    CONSTRAINT [PK_ArtworkTags] PRIMARY KEY ([ArtworkId], [TagId]),
    CONSTRAINT [FK_ArtworkTags_Artworks_ArtworkId] FOREIGN KEY ([ArtworkId]) REFERENCES [Artworks] ([ArtworkId]) ON DELETE CASCADE,
    CONSTRAINT [FK_ArtworkTags_Tags_TagId] FOREIGN KEY ([TagId]) REFERENCES [Tags] ([TagId]) ON DELETE CASCADE
);

GO

CREATE TABLE [Documents] (
    [DocumentId] int NOT NULL IDENTITY,
    [IsMainDocument] bit NOT NULL,
    [Position] int NOT NULL,
    [Media] int NOT NULL,
    [FilePath] nvarchar(max) NULL,
    [ContentType] nvarchar(max) NULL,
    [ArtworkId] int NULL,
    CONSTRAINT [PK_Documents] PRIMARY KEY ([DocumentId]),
    CONSTRAINT [FK_Documents_Artworks_ArtworkId] FOREIGN KEY ([ArtworkId]) REFERENCES [Artworks] ([ArtworkId]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Reports] (
    [ReportId] int NOT NULL IDENTITY,
    [Content] nvarchar(max) NULL,
    [ArtworkId] int NULL,
    [ArtistId] nvarchar(450) NULL,
    CONSTRAINT [PK_Reports] PRIMARY KEY ([ReportId]),
    CONSTRAINT [FK_Reports_AspNetUsers_ArtistId] FOREIGN KEY ([ArtistId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Reports_Artworks_ArtworkId] FOREIGN KEY ([ArtworkId]) REFERENCES [Artworks] ([ArtworkId]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Supports] (
    [SupportId] int NOT NULL IDENTITY,
    [Content] nvarchar(max) NULL,
    [CreationDate] datetime2 NOT NULL,
    [ArtworkId] int NULL,
    [ArtistId] nvarchar(450) NULL,
    CONSTRAINT [PK_Supports] PRIMARY KEY ([SupportId]),
    CONSTRAINT [FK_Supports_AspNetUsers_ArtistId] FOREIGN KEY ([ArtistId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Supports_Artworks_ArtworkId] FOREIGN KEY ([ArtworkId]) REFERENCES [Artworks] ([ArtworkId]) ON DELETE NO ACTION
);

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CreativeCommonsId', N'Acronym', N'BY', N'Description', N'LegalCodeUrl', N'LicenseDeedUrl', N'NC', N'ND', N'SA', N'Title', N'Zero') AND [object_id] = OBJECT_ID(N'[CreativeCommons]'))
    SET IDENTITY_INSERT [CreativeCommons] ON;
INSERT INTO [CreativeCommons] ([CreativeCommonsId], [Acronym], [BY], [Description], [LegalCodeUrl], [LicenseDeedUrl], [NC], [ND], [SA], [Title], [Zero])
VALUES (1, N'by', CAST(1 AS bit), N'This license lets others distribute, remix, tweak, and build upon your work, even commercially, as long as they credit you for the original creation. ', N'https://creativecommons.org/licenses/by/4.0/legalcode', N'https://creativecommons.org/licenses/by/4.0', CAST(0 AS bit), CAST(0 AS bit), CAST(0 AS bit), N'Attribution', CAST(0 AS bit)),
(2, N'by-sa', CAST(1 AS bit), N'This license lets others remix, tweak, and build upon your work even for commercial purposes, as long as they credit you and license their new creations under the identical terms.', N'https://creativecommons.org/licenses/by-sa/4.0/legalcode', N'https://creativecommons.org/licenses/by-sa/4.0', CAST(0 AS bit), CAST(0 AS bit), CAST(1 AS bit), N'Attribution-ShareAlike', CAST(0 AS bit)),
(3, N'by-nd', CAST(1 AS bit), N'This license lets others reuse the work for any purpose, including commercially; however, it cannot be shared with others in adapted form, and credit must be provided to you.', N'https://creativecommons.org/licenses/by-nd/4.0/legalcode', N'https://creativecommons.org/licenses/by-nd/4.0', CAST(0 AS bit), CAST(1 AS bit), CAST(0 AS bit), N'Attribution-NoDerivs', CAST(0 AS bit)),
(4, N'by-nc', CAST(1 AS bit), N'This license lets others remix, tweak, and build upon your work non-commercially, and although their new works must also acknowledge you and be non-commercial, they don’t have to license their derivative works on the same terms.', N'https://creativecommons.org/licenses/by-nc/4.0/legalcode', N'https://creativecommons.org/licenses/by-nc/4.0', CAST(1 AS bit), CAST(0 AS bit), CAST(0 AS bit), N'Attribution-NonCommercial', CAST(0 AS bit)),
(5, N'by-nc-sa', CAST(1 AS bit), N'This license lets others remix, tweak, and build upon your work non-commercially, as long as they credit you and license their new creations under the identical terms.', N'https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode', N'https://creativecommons.org/licenses/by-nc-sa/4.0', CAST(1 AS bit), CAST(0 AS bit), CAST(1 AS bit), N'Attribution-NonCommercial-ShareAlike', CAST(0 AS bit)),
(6, N'by-nc-nd', CAST(1 AS bit), N'This license is the most restrictive of our six main licenses, only allowing others to download your works and share them with others as long as they credit you, but they can’t change them in any way or use them commercially.', N'https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode', N'https://creativecommons.org/licenses/by-nc-nd/4.0', CAST(1 AS bit), CAST(1 AS bit), CAST(0 AS bit), N'Attribution-NonCommercial-NoDerivs', CAST(0 AS bit)),
(7, N'cc-zero', CAST(0 AS bit), N'Use this universal tool if you are a holder of copyright or database rights, and you wish to waive all your interests that may exist in your work worldwide. Because copyright laws differ around the world, you may use this tool even though you may not have copyright in your jurisdiction, but want to be sure to eliminate any copyrights you may have in other jurisdictions.', N'https://creativecommons.org/publicdomain/zero/1.0/legalcode', N'https://creativecommons.org/publicdomain/zero/1.0/', CAST(0 AS bit), CAST(0 AS bit), CAST(0 AS bit), N'CC0', CAST(1 AS bit));
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CreativeCommonsId', N'Acronym', N'BY', N'Description', N'LegalCodeUrl', N'LicenseDeedUrl', N'NC', N'ND', N'SA', N'Title', N'Zero') AND [object_id] = OBJECT_ID(N'[CreativeCommons]'))
    SET IDENTITY_INSERT [CreativeCommons] OFF;

GO

CREATE INDEX [IX_Artworks_ArtistId] ON [Artworks] ([ArtistId]);

GO

CREATE INDEX [IX_Artworks_CCLicenseCreativeCommonsId] ON [Artworks] ([CCLicenseCreativeCommonsId]);

GO

CREATE INDEX [IX_Artworks_CollectionId] ON [Artworks] ([CollectionId]);

GO

CREATE INDEX [IX_ArtworkTags_TagId] ON [ArtworkTags] ([TagId]);

GO

CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);

GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;

GO

CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);

GO

CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);

GO

CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);

GO

CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);

GO

CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;

GO

CREATE INDEX [IX_Collections_ArtistId] ON [Collections] ([ArtistId]);

GO

CREATE INDEX [IX_Documents_ArtworkId] ON [Documents] ([ArtworkId]);

GO

CREATE INDEX [IX_FollowRelations_ToArtistId] ON [FollowRelations] ([ToArtistId]);

GO

CREATE INDEX [IX_Messages_ReceiverId] ON [Messages] ([ReceiverId]);

GO

CREATE INDEX [IX_Messages_SenderId] ON [Messages] ([SenderId]);

GO

CREATE INDEX [IX_Reports_ArtistId] ON [Reports] ([ArtistId]);

GO

CREATE INDEX [IX_Reports_ArtworkId] ON [Reports] ([ArtworkId]);

GO

CREATE INDEX [IX_Supports_ArtistId] ON [Supports] ([ArtistId]);

GO

CREATE INDEX [IX_Supports_ArtworkId] ON [Supports] ([ArtworkId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200328182913_Initial', N'3.1.3');

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUsers]') AND [c].[name] = N'Description');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUsers] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [AspNetUsers] ALTER COLUMN [Description] nvarchar(max) NULL;

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Artworks]') AND [c].[name] = N'Privacy');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Artworks] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Artworks] ALTER COLUMN [Privacy] bit NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200331070610_visibilityEnum', N'3.1.3');

GO

ALTER TABLE [Artworks] ADD [IsDerivating] bit NOT NULL DEFAULT CAST(0 AS bit);

GO

ALTER TABLE [Artworks] ADD [LicenseDerivating] nvarchar(max) NULL;

GO

ALTER TABLE [Artworks] ADD [LinkDerivating] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200331071248_derivatingt', N'3.1.3');

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Supports]') AND [c].[name] = N'Content');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Supports] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [Supports] ALTER COLUMN [Content] nvarchar(max) NOT NULL;

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Messages]') AND [c].[name] = N'Content');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Messages] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [Messages] ALTER COLUMN [Content] nvarchar(max) NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200331074417_nullableColumns', N'3.1.3');

GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Documents]') AND [c].[name] = N'FilePath');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Documents] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [Documents] ALTER COLUMN [FilePath] nvarchar(max) NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200331074820_nullableDocument', N'3.1.3');

GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Collections]') AND [c].[name] = N'Name');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Collections] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [Collections] ALTER COLUMN [Name] nvarchar(max) NOT NULL;

GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Collections]') AND [c].[name] = N'Description');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Collections] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [Collections] ALTER COLUMN [Description] nvarchar(max) NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200331075542_lastNullable', N'3.1.3');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200401181340_CreationDAte', N'3.1.3');

GO

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Documents]') AND [c].[name] = N'FilePath');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Documents] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [Documents] ALTER COLUMN [FilePath] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200401181857_Redon', N'3.1.3');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200401190329_NewIsMainDocument', N'3.1.3');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200401190635_Media', N'3.1.3');

GO

ALTER TABLE [Artworks] ADD [AuthorDerivating] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200401191434_AuthorDerivating', N'3.1.3');

GO

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Artworks]') AND [c].[name] = N'TerritorialJuridiction');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Artworks] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [Artworks] DROP COLUMN [TerritorialJuridiction];

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200401192916_RemoveTeritorial', N'3.1.3');

GO

