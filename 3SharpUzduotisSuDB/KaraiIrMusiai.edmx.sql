
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/14/2016 20:30:21
-- Generated from EDMX file: C:\Users\Vartotojas\Desktop\3uzd\3SharpUzduotisSuDB\3SharpUzduotisSuDB\KaraiIrMusiai.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [KaraiIrMusiai];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'KarasSet'
CREATE TABLE [dbo].[KarasSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Pavadinimas] nvarchar(max)  NOT NULL,
    [Prasidejo] nvarchar(max)  NOT NULL,
    [Baigesi] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MusisSet'
CREATE TABLE [dbo].[MusisSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Pavadinimas] nvarchar(max)  NOT NULL,
    [Prasidejo] nvarchar(max)  NOT NULL,
    [Baigesi] nvarchar(max)  NOT NULL,
    [Vieta_Id] int  NOT NULL,
    [Karas_Id] int  NOT NULL,
    [Laimetojas_Id] int  NOT NULL,
    [MusioDalyvis_Id] int  NOT NULL
);
GO

-- Creating table 'ValstybeSet'
CREATE TABLE [dbo].[ValstybeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Pavadinimas] nvarchar(max)  NOT NULL,
    [Susikure] nvarchar(max)  NOT NULL,
    [Zlugo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'KarvedysSet'
CREATE TABLE [dbo].[KarvedysSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Vardas] nvarchar(max)  NOT NULL,
    [Pavarde] nvarchar(max)  NOT NULL,
    [Slapyvardis] nvarchar(max)  NOT NULL,
    [Gime] nvarchar(max)  NOT NULL,
    [Mire] nvarchar(max)  NOT NULL,
    [PulkuSkaicius] nvarchar(max)  NOT NULL,
    [Tautybe] nvarchar(max)  NOT NULL,
    [Tarnauja_Id] int  NOT NULL,
    [MusioDalyvis_Id] int  NOT NULL
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
    ON DELETE NO ACTION ON UPDATE NO ACTION;
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