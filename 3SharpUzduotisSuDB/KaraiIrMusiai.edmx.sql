
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/15/2016 06:53:13
-- Generated from EDMX file: C:\Users\Vartotojas\Desktop\3uzd\3SharpUzduotisSuDB\3SharpUzduotisSuDB\KaraiIrMusiai.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [C:\USERS\VARTOTOJAS\DOCUMENTS\KARAIIRMUSIAI.MDF];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ValstybeMusis]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MusisSet] DROP CONSTRAINT [FK_ValstybeMusis];
GO
IF OBJECT_ID(N'[dbo].[FK_KarasMusis]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MusisSet] DROP CONSTRAINT [FK_KarasMusis];
GO
IF OBJECT_ID(N'[dbo].[FK_ValstybeKarvedys]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KarvedysSet] DROP CONSTRAINT [FK_ValstybeKarvedys];
GO
IF OBJECT_ID(N'[dbo].[FK_KarvedysMusis1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MusisSet] DROP CONSTRAINT [FK_KarvedysMusis1];
GO
IF OBJECT_ID(N'[dbo].[FK_MusioDalyvisMusis]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MusisSet] DROP CONSTRAINT [FK_MusioDalyvisMusis];
GO
IF OBJECT_ID(N'[dbo].[FK_MusioDalyvisKarvedys]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KarvedysSet] DROP CONSTRAINT [FK_MusioDalyvisKarvedys];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[KarasSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KarasSet];
GO
IF OBJECT_ID(N'[dbo].[MusisSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MusisSet];
GO
IF OBJECT_ID(N'[dbo].[ValstybeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ValstybeSet];
GO
IF OBJECT_ID(N'[dbo].[KarvedysSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KarvedysSet];
GO
IF OBJECT_ID(N'[dbo].[MusioDalyvisSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MusioDalyvisSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'KarasSet'
CREATE TABLE [dbo].[KarasSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Pavadinimas] nvarchar(max)  NOT NULL,
    [Prasidejo] datetime  NOT NULL,
    [Baigesi] datetime  NULL
);
GO

-- Creating table 'MusisSet'
CREATE TABLE [dbo].[MusisSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Pavadinimas] nvarchar(max)  NOT NULL,
    [Prasidejo] datetime  NOT NULL,
    [Baigesi] datetime  NULL,
    [Vieta_Id] int  NOT NULL,
    [Karas_Id] int  NULL,
    [Laimetojas_Id] int  NOT NULL,
    [MusioDalyvis_Id] int  NULL
);
GO

-- Creating table 'ValstybeSet'
CREATE TABLE [dbo].[ValstybeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Pavadinimas] nvarchar(max)  NOT NULL,
    [Susikure] datetime  NOT NULL,
    [Zlugo] datetime  NULL
);
GO

-- Creating table 'KarvedysSet'
CREATE TABLE [dbo].[KarvedysSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Vardas] nvarchar(max)  NOT NULL,
    [Pavarde] nvarchar(max)  NULL,
    [Slapyvardis] nvarchar(max)  NULL,
    [Gime] datetime  NULL,
    [Mire] datetime  NULL,
    [PulkuSkaicius] int  NOT NULL,
    [Tautybe] nvarchar(max)  NULL,
    [Tarnauja_Id] int  NOT NULL,
    [MusioDalyvis_Id] int  NULL
);
GO

-- Creating table 'MusioDalyvisSet'
CREATE TABLE [dbo].[MusioDalyvisSet] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'KarasSet'
ALTER TABLE [dbo].[KarasSet]
ADD CONSTRAINT [PK_KarasSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MusisSet'
ALTER TABLE [dbo].[MusisSet]
ADD CONSTRAINT [PK_MusisSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ValstybeSet'
ALTER TABLE [dbo].[ValstybeSet]
ADD CONSTRAINT [PK_ValstybeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'KarvedysSet'
ALTER TABLE [dbo].[KarvedysSet]
ADD CONSTRAINT [PK_KarvedysSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MusioDalyvisSet'
ALTER TABLE [dbo].[MusioDalyvisSet]
ADD CONSTRAINT [PK_MusioDalyvisSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Vieta_Id] in table 'MusisSet'
ALTER TABLE [dbo].[MusisSet]
ADD CONSTRAINT [FK_ValstybeMusis]
    FOREIGN KEY ([Vieta_Id])
    REFERENCES [dbo].[ValstybeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ValstybeMusis'
CREATE INDEX [IX_FK_ValstybeMusis]
ON [dbo].[MusisSet]
    ([Vieta_Id]);
GO

-- Creating foreign key on [Karas_Id] in table 'MusisSet'
ALTER TABLE [dbo].[MusisSet]
ADD CONSTRAINT [FK_KarasMusis]
    FOREIGN KEY ([Karas_Id])
    REFERENCES [dbo].[KarasSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KarasMusis'
CREATE INDEX [IX_FK_KarasMusis]
ON [dbo].[MusisSet]
    ([Karas_Id]);
GO

-- Creating foreign key on [Tarnauja_Id] in table 'KarvedysSet'
ALTER TABLE [dbo].[KarvedysSet]
ADD CONSTRAINT [FK_ValstybeKarvedys]
    FOREIGN KEY ([Tarnauja_Id])
    REFERENCES [dbo].[ValstybeSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ValstybeKarvedys'
CREATE INDEX [IX_FK_ValstybeKarvedys]
ON [dbo].[KarvedysSet]
    ([Tarnauja_Id]);
GO

-- Creating foreign key on [Laimetojas_Id] in table 'MusisSet'
ALTER TABLE [dbo].[MusisSet]
ADD CONSTRAINT [FK_KarvedysMusis1]
    FOREIGN KEY ([Laimetojas_Id])
    REFERENCES [dbo].[KarvedysSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KarvedysMusis1'
CREATE INDEX [IX_FK_KarvedysMusis1]
ON [dbo].[MusisSet]
    ([Laimetojas_Id]);
GO

-- Creating foreign key on [MusioDalyvis_Id] in table 'MusisSet'
ALTER TABLE [dbo].[MusisSet]
ADD CONSTRAINT [FK_MusioDalyvisMusis]
    FOREIGN KEY ([MusioDalyvis_Id])
    REFERENCES [dbo].[MusioDalyvisSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MusioDalyvisMusis'
CREATE INDEX [IX_FK_MusioDalyvisMusis]
ON [dbo].[MusisSet]
    ([MusioDalyvis_Id]);
GO

-- Creating foreign key on [MusioDalyvis_Id] in table 'KarvedysSet'
ALTER TABLE [dbo].[KarvedysSet]
ADD CONSTRAINT [FK_MusioDalyvisKarvedys]
    FOREIGN KEY ([MusioDalyvis_Id])
    REFERENCES [dbo].[MusioDalyvisSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MusioDalyvisKarvedys'
CREATE INDEX [IX_FK_MusioDalyvisKarvedys]
ON [dbo].[KarvedysSet]
    ([MusioDalyvis_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------