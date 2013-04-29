
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 04/29/2013 12:16:59
-- Generated from EDMX file: G:\Projects\PSIMP\PSIMP\PSIMP.Models\PSIMPDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PSIMPDB];
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

-- Creating table 'UserProfile'
CREATE TABLE [dbo].[UserProfile] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PM_PersonEducationalBackground1'
CREATE TABLE [dbo].[PM_PersonEducationalBackground1] (
    [ID] uniqueidentifier  NOT NULL,
    [SchoolName] nvarchar(20)  NOT NULL,
    [EduStartDate] datetime  NOT NULL,
    [EduEndDate] datetime  NOT NULL,
    [SpecialtyName] nvarchar(20)  NOT NULL,
    [Degree] nvarchar(40)  NOT NULL,
    [Descriptions] nvarchar(400)  NOT NULL
);
GO

-- Creating table 'PM_PersonPositionalTitlesInfo'
CREATE TABLE [dbo].[PM_PersonPositionalTitlesInfo] (
    [ID] uniqueidentifier  NOT NULL,
    [PositionalName] nvarchar(20)  NOT NULL,
    [PositionalType] nvarchar(40)  NOT NULL,
    [AssessmentDate] datetime  NOT NULL,
    [AssessmentBody] nvarchar(30)  NOT NULL,
    [Descriptions] nvarchar(80)  NOT NULL
);
GO

-- Creating table 'PM_PersonCertficateInfo'
CREATE TABLE [dbo].[PM_PersonCertficateInfo] (
    [ID] uniqueidentifier  NOT NULL,
    [CertficateName] nvarchar(30)  NOT NULL,
    [CertficateType] nvarchar(40)  NOT NULL,
    [CertficateNumber] nvarchar(40)  NOT NULL,
    [GotDate] datetime  NOT NULL,
    [Authority] nvarchar(30)  NOT NULL,
    [Descriptions] nvarchar(200)  NOT NULL
);
GO

-- Creating table 'PM_PersonWorkExperienceInfo'
CREATE TABLE [dbo].[PM_PersonWorkExperienceInfo] (
    [ID] uniqueidentifier  NOT NULL,
    [WorkStartDate] datetime  NOT NULL,
    [WorkEndDate] datetime  NOT NULL,
    [CompanyName] nvarchar(30)  NOT NULL,
    [Character] nvarchar(20)  NOT NULL,
    [SectorClass] nvarchar(20)  NOT NULL,
    [AtProject] nvarchar(20)  NOT NULL,
    [PositionName] nvarchar(20)  NOT NULL,
    [Salary] decimal(18,0)  NOT NULL,
    [ContractStatus] bit  NOT NULL,
    [WorkContent] nvarchar(200)  NOT NULL,
    [RefereesName] nvarchar(10)  NOT NULL,
    [RefereesPhoneNumber] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'PM_PersonBaseInfo'
CREATE TABLE [dbo].[PM_PersonBaseInfo] (
    [ID] uniqueidentifier  NOT NULL,
    [PersonName] nvarchar(20)  NOT NULL,
    [Sex] bit  NOT NULL,
    [Birthday] datetime  NOT NULL,
    [IDNumber] nvarchar(20)  NOT NULL,
    [RegisterAddress] nvarchar(40)  NOT NULL,
    [ContactNumber] nvarchar(20)  NOT NULL,
    [AlternateNumber] nvarchar(20)  NOT NULL,
    [TwoInchPhoto] varbinary(max)  NOT NULL
);
GO

-- Creating table 'PM_PersonTrainingExperience'
CREATE TABLE [dbo].[PM_PersonTrainingExperience] (
    [ID] uniqueidentifier  NOT NULL,
    [InstitutionsName] nvarchar(30)  NOT NULL,
    [TrainingStartDate] datetime  NOT NULL,
    [TrainingEndDate] datetime  NOT NULL,
    [TrainingAddress] nvarchar(50)  NOT NULL,
    [TrainingContent] nvarchar(200)  NOT NULL,
    [GotCertificate] nvarchar(20)  NOT NULL,
    [Descriptions] nvarchar(400)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserId] in table 'UserProfile'
ALTER TABLE [dbo].[UserProfile]
ADD CONSTRAINT [PK_UserProfile]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [ID] in table 'PM_PersonEducationalBackground1'
ALTER TABLE [dbo].[PM_PersonEducationalBackground1]
ADD CONSTRAINT [PK_PM_PersonEducationalBackground1]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PM_PersonPositionalTitlesInfo'
ALTER TABLE [dbo].[PM_PersonPositionalTitlesInfo]
ADD CONSTRAINT [PK_PM_PersonPositionalTitlesInfo]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PM_PersonCertficateInfo'
ALTER TABLE [dbo].[PM_PersonCertficateInfo]
ADD CONSTRAINT [PK_PM_PersonCertficateInfo]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PM_PersonWorkExperienceInfo'
ALTER TABLE [dbo].[PM_PersonWorkExperienceInfo]
ADD CONSTRAINT [PK_PM_PersonWorkExperienceInfo]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PM_PersonBaseInfo'
ALTER TABLE [dbo].[PM_PersonBaseInfo]
ADD CONSTRAINT [PK_PM_PersonBaseInfo]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PM_PersonTrainingExperience'
ALTER TABLE [dbo].[PM_PersonTrainingExperience]
ADD CONSTRAINT [PK_PM_PersonTrainingExperience]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------