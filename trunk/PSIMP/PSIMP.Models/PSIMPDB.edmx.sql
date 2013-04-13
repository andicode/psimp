
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 04/11/2013 21:50:58
-- Generated from EDMX file: Z:\Projects\PSIMP\PSIMP\PSIMP.Models\PSIMPDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PSIMP];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PersonEducation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PsimpSet_Education] DROP CONSTRAINT [FK_PersonEducation];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonTrain]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PsimpSet_Train] DROP CONSTRAINT [FK_PersonTrain];
GO
IF OBJECT_ID(N'[dbo].[FK_UserProfilePsimp]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PsimpSet] DROP CONSTRAINT [FK_UserProfilePsimp];
GO
IF OBJECT_ID(N'[dbo].[FK_UpdateUserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PsimpSet] DROP CONSTRAINT [FK_UpdateUserId];
GO
IF OBJECT_ID(N'[dbo].[FK_Person_inherits_Psimp]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PsimpSet_Person] DROP CONSTRAINT [FK_Person_inherits_Psimp];
GO
IF OBJECT_ID(N'[dbo].[FK_Education_inherits_Psimp]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PsimpSet_Education] DROP CONSTRAINT [FK_Education_inherits_Psimp];
GO
IF OBJECT_ID(N'[dbo].[FK_Train_inherits_Psimp]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PsimpSet_Train] DROP CONSTRAINT [FK_Train_inherits_Psimp];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PsimpSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PsimpSet];
GO
IF OBJECT_ID(N'[dbo].[UserProfile]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserProfile];
GO
IF OBJECT_ID(N'[dbo].[PsimpSet_Person]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PsimpSet_Person];
GO
IF OBJECT_ID(N'[dbo].[PsimpSet_Education]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PsimpSet_Education];
GO
IF OBJECT_ID(N'[dbo].[PsimpSet_Train]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PsimpSet_Train];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PsimpSet'
CREATE TABLE [dbo].[PsimpSet] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [CreateTime] datetime  NULL,
    [UpdateTime] datetime  NULL,
    [IsDelete] bit  NOT NULL,
    [CreateUserId] int  NULL,
    [UpdateUserId] int  NULL
);
GO

-- Creating table 'UserProfile'
CREATE TABLE [dbo].[UserProfile] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PsimpSet_Person'
CREATE TABLE [dbo].[PsimpSet_Person] (
    [Name] nvarchar(max)  NOT NULL,
    [Sex] nvarchar(max)  NOT NULL,
    [Height] int  NULL,
    [Census] nvarchar(max)  NOT NULL,
    [IDCard] nvarchar(max)  NOT NULL,
    [Age] int  NULL,
    [Telephone] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL,
    [Picture] nvarchar(max)  NULL,
    [Id] bigint  NOT NULL
);
GO

-- Creating table 'PsimpSet_Education'
CREATE TABLE [dbo].[PsimpSet_Education] (
    [PersonId] bigint  NOT NULL,
    [SchoolName] nvarchar(max)  NOT NULL,
    [BeginDate] datetime  NOT NULL,
    [EndDate] datetime  NULL,
    [Discipline] nvarchar(max)  NULL,
    [Degree] nvarchar(max)  NULL,
    [Remark] nvarchar(max)  NULL,
    [Id] bigint  NOT NULL
);
GO

-- Creating table 'PsimpSet_Train'
CREATE TABLE [dbo].[PsimpSet_Train] (
    [Agency] nvarchar(max)  NOT NULL,
    [DateTime] datetime  NOT NULL,
    [Location] nvarchar(max)  NULL,
    [Curriculum] nvarchar(max)  NULL,
    [Certificate] nvarchar(max)  NULL,
    [Details] nvarchar(max)  NULL,
    [CertDetails] nvarchar(max)  NULL,
    [PersonId] bigint  NOT NULL,
    [Id] bigint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PsimpSet'
ALTER TABLE [dbo].[PsimpSet]
ADD CONSTRAINT [PK_PsimpSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [UserId] in table 'UserProfile'
ALTER TABLE [dbo].[UserProfile]
ADD CONSTRAINT [PK_UserProfile]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [Id] in table 'PsimpSet_Person'
ALTER TABLE [dbo].[PsimpSet_Person]
ADD CONSTRAINT [PK_PsimpSet_Person]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PsimpSet_Education'
ALTER TABLE [dbo].[PsimpSet_Education]
ADD CONSTRAINT [PK_PsimpSet_Education]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PsimpSet_Train'
ALTER TABLE [dbo].[PsimpSet_Train]
ADD CONSTRAINT [PK_PsimpSet_Train]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PersonId] in table 'PsimpSet_Education'
ALTER TABLE [dbo].[PsimpSet_Education]
ADD CONSTRAINT [FK_PersonEducation]
    FOREIGN KEY ([PersonId])
    REFERENCES [dbo].[PsimpSet_Person]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonEducation'
CREATE INDEX [IX_FK_PersonEducation]
ON [dbo].[PsimpSet_Education]
    ([PersonId]);
GO

-- Creating foreign key on [PersonId] in table 'PsimpSet_Train'
ALTER TABLE [dbo].[PsimpSet_Train]
ADD CONSTRAINT [FK_PersonTrain]
    FOREIGN KEY ([PersonId])
    REFERENCES [dbo].[PsimpSet_Person]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonTrain'
CREATE INDEX [IX_FK_PersonTrain]
ON [dbo].[PsimpSet_Train]
    ([PersonId]);
GO

-- Creating foreign key on [CreateUserId] in table 'PsimpSet'
ALTER TABLE [dbo].[PsimpSet]
ADD CONSTRAINT [FK_UserProfilePsimp]
    FOREIGN KEY ([CreateUserId])
    REFERENCES [dbo].[UserProfile]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserProfilePsimp'
CREATE INDEX [IX_FK_UserProfilePsimp]
ON [dbo].[PsimpSet]
    ([CreateUserId]);
GO

-- Creating foreign key on [UpdateUserId] in table 'PsimpSet'
ALTER TABLE [dbo].[PsimpSet]
ADD CONSTRAINT [FK_UpdateUserId]
    FOREIGN KEY ([UpdateUserId])
    REFERENCES [dbo].[UserProfile]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UpdateUserId'
CREATE INDEX [IX_FK_UpdateUserId]
ON [dbo].[PsimpSet]
    ([UpdateUserId]);
GO

-- Creating foreign key on [Id] in table 'PsimpSet_Person'
ALTER TABLE [dbo].[PsimpSet_Person]
ADD CONSTRAINT [FK_Person_inherits_Psimp]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[PsimpSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'PsimpSet_Education'
ALTER TABLE [dbo].[PsimpSet_Education]
ADD CONSTRAINT [FK_Education_inherits_Psimp]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[PsimpSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'PsimpSet_Train'
ALTER TABLE [dbo].[PsimpSet_Train]
ADD CONSTRAINT [FK_Train_inherits_Psimp]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[PsimpSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------