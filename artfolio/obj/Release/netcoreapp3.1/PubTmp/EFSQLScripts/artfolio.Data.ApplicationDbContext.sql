IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
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
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(128) NOT NULL,
        [ProviderKey] nvarchar(128) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(128) NOT NULL,
        [Name] nvarchar(128) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'00000000000000_CreateIdentitySchema', N'3.1.2');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [Gender] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE TABLE [Artists] (
        [ArtistId] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NULL,
        [Name] nvarchar(max) NOT NULL,
        [PublicLink] nvarchar(max) NOT NULL,
        [Photo] varbinary(max) NULL,
        [IsPubliclyVisible] bit NOT NULL,
        CONSTRAINT [PK_Artists] PRIMARY KEY ([ArtistId]),
        CONSTRAINT [FK_Artists_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE TABLE [Messages] (
        [MessageId] int NOT NULL IDENTITY,
        CONSTRAINT [PK_Messages] PRIMARY KEY ([MessageId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE TABLE [Tags] (
        [TagId] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Tags] PRIMARY KEY ([TagId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE TABLE [ArtfolioStyleSheets] (
        [ArtfolioStyleSheetId] int NOT NULL IDENTITY,
        [BorderColor] nvarchar(max) NULL,
        [BackgroundCover] varbinary(max) NULL,
        [TextColor] nvarchar(max) NULL,
        [LinkColor] nvarchar(max) NULL,
        [LinkHoverColor] nvarchar(max) NULL,
        [FontCategory] nvarchar(max) NULL,
        [FontParagraph] nvarchar(max) NULL,
        [FontTitles] nvarchar(max) NULL,
        [ArtistId] int NULL,
        CONSTRAINT [PK_ArtfolioStyleSheets] PRIMARY KEY ([ArtfolioStyleSheetId]),
        CONSTRAINT [FK_ArtfolioStyleSheets_Artists_ArtistId] FOREIGN KEY ([ArtistId]) REFERENCES [Artists] ([ArtistId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE TABLE [Artworks] (
        [ArtworkId] int NOT NULL IDENTITY,
        [Title] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NULL,
        [CreationDate] datetime2 NOT NULL,
        [ReleaseDate] datetime2 NOT NULL,
        [Privacy] int NOT NULL,
        [License] int NOT NULL,
        [Category] int NOT NULL,
        [ArtistId] int NULL,
        CONSTRAINT [PK_Artworks] PRIMARY KEY ([ArtworkId]),
        CONSTRAINT [FK_Artworks_Artists_ArtistId] FOREIGN KEY ([ArtistId]) REFERENCES [Artists] ([ArtistId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE TABLE [Collections] (
        [CollectionId] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [CreationDate] datetime2 NOT NULL,
        [ArtistId] int NULL,
        CONSTRAINT [PK_Collections] PRIMARY KEY ([CollectionId]),
        CONSTRAINT [FK_Collections_Artists_ArtistId] FOREIGN KEY ([ArtistId]) REFERENCES [Artists] ([ArtistId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE TABLE [ArtworkTags] (
        [ArtworkTagId] int NOT NULL IDENTITY,
        [ArtworkId] int NOT NULL,
        [TagId] int NOT NULL,
        CONSTRAINT [PK_ArtworkTags] PRIMARY KEY ([ArtworkTagId]),
        CONSTRAINT [FK_ArtworkTags_Artworks_ArtworkId] FOREIGN KEY ([ArtworkId]) REFERENCES [Artworks] ([ArtworkId]) ON DELETE CASCADE,
        CONSTRAINT [FK_ArtworkTags_Tags_TagId] FOREIGN KEY ([TagId]) REFERENCES [Tags] ([TagId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE TABLE [Documents] (
        [DocumentId] int NOT NULL IDENTITY,
        [IsMainDocument] bit NOT NULL,
        [Position] int NOT NULL,
        [Media] int NOT NULL,
        [FilePath] nvarchar(max) NULL,
        [ArtworkId] int NULL,
        CONSTRAINT [PK_Documents] PRIMARY KEY ([DocumentId]),
        CONSTRAINT [FK_Documents_Artworks_ArtworkId] FOREIGN KEY ([ArtworkId]) REFERENCES [Artworks] ([ArtworkId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE TABLE [Reports] (
        [ReportId] int NOT NULL IDENTITY,
        [Content] nvarchar(max) NULL,
        [ArtworkId] int NULL,
        [ArtistId] int NULL,
        CONSTRAINT [PK_Reports] PRIMARY KEY ([ReportId]),
        CONSTRAINT [FK_Reports_Artists_ArtistId] FOREIGN KEY ([ArtistId]) REFERENCES [Artists] ([ArtistId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Reports_Artworks_ArtworkId] FOREIGN KEY ([ArtworkId]) REFERENCES [Artworks] ([ArtworkId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE TABLE [Supports] (
        [SupportId] int NOT NULL IDENTITY,
        [Content] nvarchar(max) NULL,
        [CreationDate] datetime2 NOT NULL,
        [ArtworkId] int NULL,
        [ArtistId] int NULL,
        CONSTRAINT [PK_Supports] PRIMARY KEY ([SupportId]),
        CONSTRAINT [FK_Supports_Artists_ArtistId] FOREIGN KEY ([ArtistId]) REFERENCES [Artists] ([ArtistId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Supports_Artworks_ArtworkId] FOREIGN KEY ([ArtworkId]) REFERENCES [Artworks] ([ArtworkId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE TABLE [ArtworkCollections] (
        [ArtworkCollectionId] int NOT NULL IDENTITY,
        [IsMasterpiece] bit NOT NULL,
        [ArtworkId] int NULL,
        [CollectionId] int NULL,
        CONSTRAINT [PK_ArtworkCollections] PRIMARY KEY ([ArtworkCollectionId]),
        CONSTRAINT [FK_ArtworkCollections_Artworks_ArtworkId] FOREIGN KEY ([ArtworkId]) REFERENCES [Artworks] ([ArtworkId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_ArtworkCollections_Collections_CollectionId] FOREIGN KEY ([CollectionId]) REFERENCES [Collections] ([CollectionId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE INDEX [IX_ArtfolioStyleSheets_ArtistId] ON [ArtfolioStyleSheets] ([ArtistId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE INDEX [IX_Artists_UserId] ON [Artists] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE INDEX [IX_ArtworkCollections_ArtworkId] ON [ArtworkCollections] ([ArtworkId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE INDEX [IX_ArtworkCollections_CollectionId] ON [ArtworkCollections] ([CollectionId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE INDEX [IX_Artworks_ArtistId] ON [Artworks] ([ArtistId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE INDEX [IX_ArtworkTags_ArtworkId] ON [ArtworkTags] ([ArtworkId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE INDEX [IX_ArtworkTags_TagId] ON [ArtworkTags] ([TagId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE INDEX [IX_Collections_ArtistId] ON [Collections] ([ArtistId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE INDEX [IX_Documents_ArtworkId] ON [Documents] ([ArtworkId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE INDEX [IX_Reports_ArtistId] ON [Reports] ([ArtistId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE INDEX [IX_Reports_ArtworkId] ON [Reports] ([ArtworkId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE INDEX [IX_Supports_ArtistId] ON [Supports] ([ArtistId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    CREATE INDEX [IX_Supports_ArtworkId] ON [Supports] ([ArtworkId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226094413_ReinitModels')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200226094413_ReinitModels', N'3.1.2');
END;

GO

