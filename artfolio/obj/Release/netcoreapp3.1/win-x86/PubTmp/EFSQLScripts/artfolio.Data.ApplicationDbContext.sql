IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE TABLE [Artists] (
        [ArtistId] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [PublicLink] nvarchar(max) NOT NULL,
        [Photo] varbinary(max) NULL,
        [IsPubliclyVisible] bit NOT NULL,
        CONSTRAINT [PK_Artists] PRIMARY KEY ([ArtistId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE TABLE [ArtworkCategory] (
        [ArtworkCategoryId] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NOT NULL,
        [Image] varbinary(max) NOT NULL,
        CONSTRAINT [PK_ArtworkCategory] PRIMARY KEY ([ArtworkCategoryId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
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
        [Gender] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE TABLE [CreativeCommonsLicenses] (
        [CreativeCommonsLicenseId] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [Version] real NOT NULL,
        [IsDeprecated] bit NOT NULL,
        [OfficialLink] nvarchar(max) NULL,
        [Logo] varbinary(max) NULL,
        CONSTRAINT [PK_CreativeCommonsLicenses] PRIMARY KEY ([CreativeCommonsLicenseId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE TABLE [DocumentTypes] (
        [DocumentTypeId] int NOT NULL IDENTITY,
        [Type] nvarchar(max) NOT NULL,
        [Media] nvarchar(max) NULL,
        CONSTRAINT [PK_DocumentTypes] PRIMARY KEY ([DocumentTypeId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE TABLE [Followers] (
        [FollowerId] int NOT NULL IDENTITY,
        CONSTRAINT [PK_Followers] PRIMARY KEY ([FollowerId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE TABLE [Messages] (
        [MessageId] int NOT NULL IDENTITY,
        CONSTRAINT [PK_Messages] PRIMARY KEY ([MessageId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE TABLE [OtherLicenses] (
        [OtherLicenseId] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_OtherLicenses] PRIMARY KEY ([OtherLicenseId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE TABLE [Tags] (
        [TagId] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Tags] PRIMARY KEY ([TagId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE TABLE [Artworks] (
        [ArtworkId] int NOT NULL IDENTITY,
        [Title] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NULL,
        [CreationDate] datetime2 NOT NULL,
        [ArtistId] int NULL,
        [ArtworkCategoryId] int NULL,
        CONSTRAINT [PK_Artworks] PRIMARY KEY ([ArtworkId]),
        CONSTRAINT [FK_Artworks_Artists_ArtistId] FOREIGN KEY ([ArtistId]) REFERENCES [Artists] ([ArtistId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Artworks_ArtworkCategory_ArtworkCategoryId] FOREIGN KEY ([ArtworkCategoryId]) REFERENCES [ArtworkCategory] ([ArtworkCategoryId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE TABLE [ArtworkLicenses] (
        [ArtworkLicenseId] int NOT NULL IDENTITY,
        [ArtworkId] int NOT NULL,
        [CreativeCommonsLicenseId] int NULL,
        [OtherLicenseId] int NULL,
        CONSTRAINT [PK_ArtworkLicenses] PRIMARY KEY ([ArtworkLicenseId]),
        CONSTRAINT [FK_ArtworkLicenses_Artworks_ArtworkId] FOREIGN KEY ([ArtworkId]) REFERENCES [Artworks] ([ArtworkId]) ON DELETE CASCADE,
        CONSTRAINT [FK_ArtworkLicenses_CreativeCommonsLicenses_CreativeCommonsLicenseId] FOREIGN KEY ([CreativeCommonsLicenseId]) REFERENCES [CreativeCommonsLicenses] ([CreativeCommonsLicenseId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_ArtworkLicenses_OtherLicenses_OtherLicenseId] FOREIGN KEY ([OtherLicenseId]) REFERENCES [OtherLicenses] ([OtherLicenseId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE TABLE [Documents] (
        [DocumentId] int NOT NULL IDENTITY,
        [ArtworkId] int NOT NULL,
        [DocumentTypeId] int NOT NULL,
        CONSTRAINT [PK_Documents] PRIMARY KEY ([DocumentId]),
        CONSTRAINT [FK_Documents_Artworks_ArtworkId] FOREIGN KEY ([ArtworkId]) REFERENCES [Artworks] ([ArtworkId]) ON DELETE CASCADE,
        CONSTRAINT [FK_Documents_DocumentTypes_DocumentTypeId] FOREIGN KEY ([DocumentTypeId]) REFERENCES [DocumentTypes] ([DocumentTypeId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE TABLE [RelatedDocuments] (
        [RelatedDocumentId] int NOT NULL IDENTITY,
        [Position] int NOT NULL,
        [ArtworkId] int NOT NULL,
        [DocumentTypeId] int NOT NULL,
        CONSTRAINT [PK_RelatedDocuments] PRIMARY KEY ([RelatedDocumentId]),
        CONSTRAINT [FK_RelatedDocuments_Artworks_ArtworkId] FOREIGN KEY ([ArtworkId]) REFERENCES [Artworks] ([ArtworkId]) ON DELETE CASCADE,
        CONSTRAINT [FK_RelatedDocuments_DocumentTypes_DocumentTypeId] FOREIGN KEY ([DocumentTypeId]) REFERENCES [DocumentTypes] ([DocumentTypeId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_ArtfolioStyleSheets_ArtistId] ON [ArtfolioStyleSheets] ([ArtistId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_ArtworkCollections_ArtworkId] ON [ArtworkCollections] ([ArtworkId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_ArtworkCollections_CollectionId] ON [ArtworkCollections] ([CollectionId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_ArtworkLicenses_ArtworkId] ON [ArtworkLicenses] ([ArtworkId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_ArtworkLicenses_CreativeCommonsLicenseId] ON [ArtworkLicenses] ([CreativeCommonsLicenseId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_ArtworkLicenses_OtherLicenseId] ON [ArtworkLicenses] ([OtherLicenseId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_Artworks_ArtistId] ON [Artworks] ([ArtistId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_Artworks_ArtworkCategoryId] ON [Artworks] ([ArtworkCategoryId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_ArtworkTags_ArtworkId] ON [ArtworkTags] ([ArtworkId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_ArtworkTags_TagId] ON [ArtworkTags] ([TagId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_Collections_ArtistId] ON [Collections] ([ArtistId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_Documents_ArtworkId] ON [Documents] ([ArtworkId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_Documents_DocumentTypeId] ON [Documents] ([DocumentTypeId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_RelatedDocuments_ArtworkId] ON [RelatedDocuments] ([ArtworkId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_RelatedDocuments_DocumentTypeId] ON [RelatedDocuments] ([DocumentTypeId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_Reports_ArtistId] ON [Reports] ([ArtistId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_Reports_ArtworkId] ON [Reports] ([ArtworkId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_Supports_ArtistId] ON [Supports] ([ArtistId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    CREATE INDEX [IX_Supports_ArtworkId] ON [Supports] ([ArtworkId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105002_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200209105002_Initial', N'3.1.2');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105503_ArtistToUserLink')
BEGIN
    ALTER TABLE [Artists] ADD [UserId] nvarchar(450) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105503_ArtistToUserLink')
BEGIN
    CREATE INDEX [IX_Artists_UserId] ON [Artists] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105503_ArtistToUserLink')
BEGIN
    ALTER TABLE [Artists] ADD CONSTRAINT [FK_Artists_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209105503_ArtistToUserLink')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200209105503_ArtistToUserLink', N'3.1.2');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209171048_DeleteSomeDatabaseForMoreEnumeration')
BEGIN
    ALTER TABLE [Documents] DROP CONSTRAINT [FK_Documents_DocumentTypes_DocumentTypeId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209171048_DeleteSomeDatabaseForMoreEnumeration')
BEGIN
    DROP TABLE [ArtworkLicenses];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209171048_DeleteSomeDatabaseForMoreEnumeration')
BEGIN
    DROP TABLE [RelatedDocuments];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209171048_DeleteSomeDatabaseForMoreEnumeration')
BEGIN
    DROP TABLE [CreativeCommonsLicenses];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209171048_DeleteSomeDatabaseForMoreEnumeration')
BEGIN
    DROP TABLE [OtherLicenses];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209171048_DeleteSomeDatabaseForMoreEnumeration')
BEGIN
    DROP TABLE [DocumentTypes];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209171048_DeleteSomeDatabaseForMoreEnumeration')
BEGIN
    DROP INDEX [IX_Documents_DocumentTypeId] ON [Documents];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209171048_DeleteSomeDatabaseForMoreEnumeration')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Documents]') AND [c].[name] = N'DocumentTypeId');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Documents] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Documents] DROP COLUMN [DocumentTypeId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209171048_DeleteSomeDatabaseForMoreEnumeration')
BEGIN
    ALTER TABLE [Documents] ADD [Category] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209171048_DeleteSomeDatabaseForMoreEnumeration')
BEGIN
    ALTER TABLE [Documents] ADD [IsMainDocument] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209171048_DeleteSomeDatabaseForMoreEnumeration')
BEGIN
    ALTER TABLE [Documents] ADD [Position] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209171048_DeleteSomeDatabaseForMoreEnumeration')
BEGIN
    ALTER TABLE [Artworks] ADD [License] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209171048_DeleteSomeDatabaseForMoreEnumeration')
BEGIN
    ALTER TABLE [Artworks] ADD [Privacy] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209171048_DeleteSomeDatabaseForMoreEnumeration')
BEGIN
    ALTER TABLE [Artworks] ADD [PublicationDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200209171048_DeleteSomeDatabaseForMoreEnumeration')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200209171048_DeleteSomeDatabaseForMoreEnumeration', N'3.1.2');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212075439_artworkModelDataAnnotation')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Artworks]') AND [c].[name] = N'PublicationDate');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Artworks] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Artworks] DROP COLUMN [PublicationDate];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212075439_artworkModelDataAnnotation')
BEGIN
    ALTER TABLE [Artworks] ADD [ReleaseDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212075439_artworkModelDataAnnotation')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200212075439_artworkModelDataAnnotation', N'3.1.2');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212084039_testStringUserId')
BEGIN
    ALTER TABLE [Artists] DROP CONSTRAINT [FK_Artists_AspNetUsers_UserId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212084039_testStringUserId')
BEGIN
    DROP INDEX [IX_Artists_UserId] ON [Artists];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212084039_testStringUserId')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Artists]') AND [c].[name] = N'UserId');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Artists] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Artists] ALTER COLUMN [UserId] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212084039_testStringUserId')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200212084039_testStringUserId', N'3.1.2');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212090539_InversePropertyUser')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Artists]') AND [c].[name] = N'UserId');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Artists] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [Artists] DROP COLUMN [UserId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212090539_InversePropertyUser')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [ArtistId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212090539_InversePropertyUser')
BEGIN
    CREATE UNIQUE INDEX [IX_AspNetUsers_ArtistId] ON [AspNetUsers] ([ArtistId]) WHERE [ArtistId] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212090539_InversePropertyUser')
BEGIN
    ALTER TABLE [AspNetUsers] ADD CONSTRAINT [FK_AspNetUsers_Artists_ArtistId] FOREIGN KEY ([ArtistId]) REFERENCES [Artists] ([ArtistId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212090539_InversePropertyUser')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200212090539_InversePropertyUser', N'3.1.2');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212093928_transitionForFollowerTable')
BEGIN
    ALTER TABLE [Followers] ADD [FollowerId2Needed] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212093928_transitionForFollowerTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200212093928_transitionForFollowerTable', N'3.1.2');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212094559_testFollower')
BEGIN
    DROP TABLE [Followers];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212094559_testFollower')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200212094559_testFollower', N'3.1.2');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212095526_startFromScratch')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200212095526_startFromScratch', N'3.1.2');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212115918_OneToOneChangeArtistUser')
BEGIN
    ALTER TABLE [AspNetUsers] DROP CONSTRAINT [FK_AspNetUsers_Artists_ArtistId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212115918_OneToOneChangeArtistUser')
BEGIN
    DROP INDEX [IX_AspNetUsers_ArtistId] ON [AspNetUsers];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212115918_OneToOneChangeArtistUser')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUsers]') AND [c].[name] = N'ArtistId');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUsers] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [AspNetUsers] DROP COLUMN [ArtistId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212115918_OneToOneChangeArtistUser')
BEGIN
    ALTER TABLE [Artists] ADD [UserId] nvarchar(450) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212115918_OneToOneChangeArtistUser')
BEGIN
    CREATE INDEX [IX_Artists_UserId] ON [Artists] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212115918_OneToOneChangeArtistUser')
BEGIN
    ALTER TABLE [Artists] ADD CONSTRAINT [FK_Artists_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200212115918_OneToOneChangeArtistUser')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200212115918_OneToOneChangeArtistUser', N'3.1.2');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200217072937_AjoutCategoryEnum')
BEGIN
    ALTER TABLE [Artworks] DROP CONSTRAINT [FK_Artworks_ArtworkCategory_ArtworkCategoryId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200217072937_AjoutCategoryEnum')
BEGIN
    DROP TABLE [ArtworkCategory];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200217072937_AjoutCategoryEnum')
BEGIN
    DROP INDEX [IX_Artworks_ArtworkCategoryId] ON [Artworks];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200217072937_AjoutCategoryEnum')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Artworks]') AND [c].[name] = N'ArtworkCategoryId');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Artworks] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [Artworks] DROP COLUMN [ArtworkCategoryId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200217072937_AjoutCategoryEnum')
BEGIN
    ALTER TABLE [Artworks] ADD [Category] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200217072937_AjoutCategoryEnum')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200217072937_AjoutCategoryEnum', N'3.1.2');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200217093818_UpdateDocumentMedia')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Documents]') AND [c].[name] = N'Category');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Documents] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [Documents] DROP COLUMN [Category];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200217093818_UpdateDocumentMedia')
BEGIN
    ALTER TABLE [Documents] ADD [Media] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200217093818_UpdateDocumentMedia')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200217093818_UpdateDocumentMedia', N'3.1.2');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200217135159_modifDocument')
BEGIN
    ALTER TABLE [Documents] DROP CONSTRAINT [FK_Documents_Artworks_ArtworkId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200217135159_modifDocument')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Documents]') AND [c].[name] = N'ArtworkId');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Documents] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [Documents] ALTER COLUMN [ArtworkId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200217135159_modifDocument')
BEGIN
    ALTER TABLE [Documents] ADD [File] nvarchar(max) NOT NULL DEFAULT N'';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200217135159_modifDocument')
BEGIN
    ALTER TABLE [Documents] ADD CONSTRAINT [FK_Documents_Artworks_ArtworkId] FOREIGN KEY ([ArtworkId]) REFERENCES [Artworks] ([ArtworkId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200217135159_modifDocument')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200217135159_modifDocument', N'3.1.2');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200217140110_UpdateDocument')
BEGIN
    ALTER TABLE [Documents] ADD [FileName] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200217140110_UpdateDocument')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200217140110_UpdateDocument', N'3.1.2');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200217142633_updateDocAgain')
BEGIN
    DECLARE @var8 sysname;
    SELECT @var8 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Documents]') AND [c].[name] = N'File');
    IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Documents] DROP CONSTRAINT [' + @var8 + '];');
    ALTER TABLE [Documents] DROP COLUMN [File];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200217142633_updateDocAgain')
BEGIN
    DECLARE @var9 sysname;
    SELECT @var9 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Documents]') AND [c].[name] = N'FileName');
    IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Documents] DROP CONSTRAINT [' + @var9 + '];');
    ALTER TABLE [Documents] DROP COLUMN [FileName];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200217142633_updateDocAgain')
BEGIN
    ALTER TABLE [Documents] ADD [FilePath] nvarchar(max) NOT NULL DEFAULT N'';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200217142633_updateDocAgain')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200217142633_updateDocAgain', N'3.1.2');
END;

GO

