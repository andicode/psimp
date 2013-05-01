
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 04/30/2013 21:20:01
-- Generated from EDMX file: G:\Projects\PSIMP\PSIMP\PSIMP.Models\PSIMPDB.edmx
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

IF OBJECT_ID(N'[dbo].[FK_webpages_UsersInRoles_webpages_Roles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[webpages_UsersInRoles] DROP CONSTRAINT [FK_webpages_UsersInRoles_webpages_Roles];
GO
IF OBJECT_ID(N'[dbo].[FK_webpages_UsersInRoles_UserProfile]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[webpages_UsersInRoles] DROP CONSTRAINT [FK_webpages_UsersInRoles_UserProfile];
GO
IF OBJECT_ID(N'[dbo].[FK_UserProfilewebpages_Membership]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserProfile] DROP CONSTRAINT [FK_UserProfilewebpages_Membership];
GO
IF OBJECT_ID(N'[dbo].[FK_UserProfilewebpages_OAuthMembership]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[webpages_OAuthMembership] DROP CONSTRAINT [FK_UserProfilewebpages_OAuthMembership];
GO
IF OBJECT_ID(N'[dbo].[FK_EM_ProjectBaseInfoEM_ProjectContractBaseInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EM_ProjectContractBaseInfo] DROP CONSTRAINT [FK_EM_ProjectBaseInfoEM_ProjectContractBaseInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_EM_ProjectBaseInfoEM_ProjectPersonManage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EM_ProjectPersonManage] DROP CONSTRAINT [FK_EM_ProjectBaseInfoEM_ProjectPersonManage];
GO
IF OBJECT_ID(N'[dbo].[FK_EM_ProjectBaseInfoEM_ProjectContractPerformance]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EM_ProjectContractPerformance] DROP CONSTRAINT [FK_EM_ProjectBaseInfoEM_ProjectContractPerformance];
GO
IF OBJECT_ID(N'[dbo].[FK_EM_ProjectBaseInfoEM_ProjectTestPutOnFile]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EM_ProjectTestPutOnFile] DROP CONSTRAINT [FK_EM_ProjectBaseInfoEM_ProjectTestPutOnFile];
GO
IF OBJECT_ID(N'[dbo].[FK_EM_ProjectContractBaseInfoEM_ProjectContractDataInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EM_ProjectContractDataInfo] DROP CONSTRAINT [FK_EM_ProjectContractBaseInfoEM_ProjectContractDataInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_EM_ProjectContractBaseInfoEM_ProjectContractPayCondition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EM_ProjectContractPayCondition] DROP CONSTRAINT [FK_EM_ProjectContractBaseInfoEM_ProjectContractPayCondition];
GO
IF OBJECT_ID(N'[dbo].[FK_EM_ProjectContractBaseInfoEM_ProjectContractPersonInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EM_ProjectContractPersonInfo] DROP CONSTRAINT [FK_EM_ProjectContractBaseInfoEM_ProjectContractPersonInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_EM_ProjectContractBaseInfoEM_ProjectExpandInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EM_ProjectExpandInfo] DROP CONSTRAINT [FK_EM_ProjectContractBaseInfoEM_ProjectExpandInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_PM_CertificateManagePM_PersonBaseInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PM_CertificateManage] DROP CONSTRAINT [FK_PM_CertificateManagePM_PersonBaseInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_PM_PersonCertificateInfoPM_PersonBaseInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PM_PersonCertificateInfo] DROP CONSTRAINT [FK_PM_PersonCertificateInfoPM_PersonBaseInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_PM_PersonContractInfoPM_PersonBaseInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PM_PersonContractInfo] DROP CONSTRAINT [FK_PM_PersonContractInfoPM_PersonBaseInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_PM_PersonEducationalBackgroundPM_PersonBaseInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PM_PersonEducationalBackground1] DROP CONSTRAINT [FK_PM_PersonEducationalBackgroundPM_PersonBaseInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_PM_PersonInsuranceInfoPM_PersonBaseInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PM_PersonInsuranceInfo] DROP CONSTRAINT [FK_PM_PersonInsuranceInfoPM_PersonBaseInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_PM_PersonTrainingExperiencePM_PersonBaseInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PM_PersonTrainingExperience] DROP CONSTRAINT [FK_PM_PersonTrainingExperiencePM_PersonBaseInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_PM_PersonPositionalTitlesInfoPM_PersonBaseInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PM_PersonPositionalTitlesInfo] DROP CONSTRAINT [FK_PM_PersonPositionalTitlesInfoPM_PersonBaseInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_PM_PersonRegisterPM_PersonBaseInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PM_PersonRegister] DROP CONSTRAINT [FK_PM_PersonRegisterPM_PersonBaseInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_PM_PersonWorkExperienceInfoPM_PersonBaseInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PM_PersonWorkExperienceInfo] DROP CONSTRAINT [FK_PM_PersonWorkExperienceInfoPM_PersonBaseInfo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserProfile]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserProfile];
GO
IF OBJECT_ID(N'[dbo].[webpages_Membership]', 'U') IS NOT NULL
    DROP TABLE [dbo].[webpages_Membership];
GO
IF OBJECT_ID(N'[dbo].[webpages_OAuthMembership]', 'U') IS NOT NULL
    DROP TABLE [dbo].[webpages_OAuthMembership];
GO
IF OBJECT_ID(N'[dbo].[webpages_Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[webpages_Roles];
GO
IF OBJECT_ID(N'[dbo].[EM_ProjectBaseInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EM_ProjectBaseInfo];
GO
IF OBJECT_ID(N'[dbo].[EM_ProjectContractBaseInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EM_ProjectContractBaseInfo];
GO
IF OBJECT_ID(N'[dbo].[EM_ProjectContractDataInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EM_ProjectContractDataInfo];
GO
IF OBJECT_ID(N'[dbo].[EM_ProjectContractPayCondition]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EM_ProjectContractPayCondition];
GO
IF OBJECT_ID(N'[dbo].[EM_ProjectContractPerformance]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EM_ProjectContractPerformance];
GO
IF OBJECT_ID(N'[dbo].[EM_ProjectContractPersonInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EM_ProjectContractPersonInfo];
GO
IF OBJECT_ID(N'[dbo].[EM_ProjectExpandInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EM_ProjectExpandInfo];
GO
IF OBJECT_ID(N'[dbo].[EM_ProjectPersonManage]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EM_ProjectPersonManage];
GO
IF OBJECT_ID(N'[dbo].[EM_ProjectTestPutOnFile]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EM_ProjectTestPutOnFile];
GO
IF OBJECT_ID(N'[dbo].[PM_CertificateManage]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PM_CertificateManage];
GO
IF OBJECT_ID(N'[dbo].[PM_PersonBaseInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PM_PersonBaseInfo];
GO
IF OBJECT_ID(N'[dbo].[PM_PersonCertificateInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PM_PersonCertificateInfo];
GO
IF OBJECT_ID(N'[dbo].[PM_PersonContractInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PM_PersonContractInfo];
GO
IF OBJECT_ID(N'[dbo].[PM_PersonEducationalBackground1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PM_PersonEducationalBackground1];
GO
IF OBJECT_ID(N'[dbo].[PM_PersonInsuranceInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PM_PersonInsuranceInfo];
GO
IF OBJECT_ID(N'[dbo].[PM_PersonPositionalTitlesInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PM_PersonPositionalTitlesInfo];
GO
IF OBJECT_ID(N'[dbo].[PM_PersonRegister]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PM_PersonRegister];
GO
IF OBJECT_ID(N'[dbo].[PM_PersonTrainingExperience]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PM_PersonTrainingExperience];
GO
IF OBJECT_ID(N'[dbo].[PM_PersonWorkExperienceInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PM_PersonWorkExperienceInfo];
GO
IF OBJECT_ID(N'[dbo].[webpages_UsersInRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[webpages_UsersInRoles];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserProfile'
CREATE TABLE [dbo].[UserProfile] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NOT NULL,
    [webpages_Membership_UserId] int  NOT NULL
);
GO

-- Creating table 'webpages_Membership'
CREATE TABLE [dbo].[webpages_Membership] (
    [UserId] int  NOT NULL,
    [CreateDate] datetime  NULL,
    [ConfirmationToken] nvarchar(128)  NULL,
    [IsConfirmed] bit  NULL,
    [LastPasswordFailureDate] datetime  NULL,
    [PasswordFailuresSinceLastSuccess] int  NOT NULL,
    [Password] nvarchar(128)  NOT NULL,
    [PasswordChangedDate] datetime  NULL,
    [PasswordSalt] nvarchar(128)  NOT NULL,
    [PasswordVerificationToken] nvarchar(128)  NULL,
    [PasswordVerificationTokenExpirationDate] datetime  NULL
);
GO

-- Creating table 'webpages_OAuthMembership'
CREATE TABLE [dbo].[webpages_OAuthMembership] (
    [Provider] nvarchar(30)  NOT NULL,
    [ProviderUserId] nvarchar(100)  NOT NULL,
    [UserId] int  NOT NULL,
    [UserProfile_UserId] int  NOT NULL
);
GO

-- Creating table 'webpages_Roles'
CREATE TABLE [dbo].[webpages_Roles] (
    [RoleId] int IDENTITY(1,1) NOT NULL,
    [RoleName] nvarchar(256)  NOT NULL
);
GO

-- Creating table 'EM_ProjectBaseInfo'
CREATE TABLE [dbo].[EM_ProjectBaseInfo] (
    [ProjectID] nvarchar(40)  NOT NULL,
    [ProjectFullName] nvarchar(max)  NOT NULL,
    [ProjectName] nvarchar(max)  NOT NULL,
    [ConstructionCompany] nvarchar(max)  NOT NULL,
    [ProjectType] nvarchar(max)  NOT NULL,
    [ProjectScale] nvarchar(max)  NOT NULL,
    [ProjectAddress] nvarchar(max)  NOT NULL,
    [EntryDate] nvarchar(max)  NOT NULL,
    [StartDate] nvarchar(max)  NOT NULL,
    [FinishedDate] nvarchar(max)  NOT NULL,
    [CompletionDate] nvarchar(max)  NOT NULL,
    [ConstructionPeriod] nvarchar(max)  NOT NULL,
    [DefectsLiabilityPeriod] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EM_ProjectContractBaseInfo'
CREATE TABLE [dbo].[EM_ProjectContractBaseInfo] (
    [ProjectContractID] int IDENTITY(1,1) NOT NULL,
    [ProjectID] nvarchar(max)  NOT NULL,
    [BiddingDate] nvarchar(max)  NOT NULL,
    [ContractPeriod] nvarchar(max)  NOT NULL,
    [OpenDate] nvarchar(max)  NOT NULL,
    [OpeningPeriod] nvarchar(max)  NOT NULL,
    [OpeningConditions] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [ContractAttachment] nvarchar(max)  NOT NULL,
    [EM_ProjectBaseInfo_ProjectID] nvarchar(40)  NOT NULL
);
GO

-- Creating table 'EM_ProjectContractDataInfo'
CREATE TABLE [dbo].[EM_ProjectContractDataInfo] (
    [PContractDataID] int IDENTITY(1,1) NOT NULL,
    [ContractMoney] nvarchar(max)  NOT NULL,
    [ProvisionalSums] nvarchar(max)  NOT NULL,
    [ContractNetAmount] nvarchar(max)  NOT NULL,
    [ConstructionPeriodMoney] nvarchar(max)  NOT NULL,
    [DefectPeriodMoeny] nvarchar(max)  NOT NULL,
    [GuaranteePeriodMoney] nvarchar(max)  NOT NULL,
    [HonestDepositMoney] nvarchar(max)  NOT NULL,
    [GuaranteeMoney] nvarchar(max)  NOT NULL,
    [AgainstRiskMoney] nvarchar(max)  NOT NULL,
    [ReviewMoeny] nvarchar(max)  NOT NULL,
    [ContractID] nvarchar(max)  NOT NULL,
    [EM_ProjectContractBaseInfo_ProjectContractID] int  NOT NULL
);
GO

-- Creating table 'EM_ProjectContractPayCondition'
CREATE TABLE [dbo].[EM_ProjectContractPayCondition] (
    [PContractPayConditionID] int IDENTITY(1,1) NOT NULL,
    [ContractID] nvarchar(max)  NOT NULL,
    [MeasurePayCondition] nvarchar(max)  NOT NULL,
    [AgainstRiskPayCondition] nvarchar(max)  NOT NULL,
    [GuaranteePayMoney] nvarchar(max)  NOT NULL,
    [GuaranteePayCondition] nvarchar(max)  NOT NULL,
    [MobilizeAdvanceMoneyLetter] nvarchar(max)  NOT NULL,
    [PerformanceBondPayCondition] nvarchar(max)  NOT NULL,
    [PayMode] nvarchar(max)  NOT NULL,
    [PayDutyMode] nvarchar(max)  NOT NULL,
    [EM_ProjectContractBaseInfo_ProjectContractID] int  NOT NULL
);
GO

-- Creating table 'EM_ProjectContractPerformance'
CREATE TABLE [dbo].[EM_ProjectContractPerformance] (
    [ProjectContractPerformanceID] int IDENTITY(1,1) NOT NULL,
    [ProjectID] nvarchar(max)  NOT NULL,
    [PersonID] nvarchar(max)  NOT NULL,
    [PersonName] nvarchar(max)  NOT NULL,
    [OnProjectID] nvarchar(max)  NOT NULL,
    [InPresentDate] nvarchar(max)  NOT NULL,
    [PerformanceProjectID] nvarchar(max)  NOT NULL,
    [PerformanceDuties] nvarchar(max)  NOT NULL,
    [OutDate] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [EM_ProjectBaseInfo_ProjectID] nvarchar(40)  NOT NULL
);
GO

-- Creating table 'EM_ProjectContractPersonInfo'
CREATE TABLE [dbo].[EM_ProjectContractPersonInfo] (
    [ContractPersonID] nvarchar(40)  NOT NULL,
    [ProjectContractID] nvarchar(max)  NOT NULL,
    [ContractDuties] nvarchar(max)  NOT NULL,
    [PersonID] nvarchar(max)  NOT NULL,
    [ContractPosition] nvarchar(max)  NOT NULL,
    [HoldCertificate] nvarchar(max)  NOT NULL,
    [Other] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [EM_ProjectContractBaseInfo_ProjectContractID] int  NOT NULL
);
GO

-- Creating table 'EM_ProjectExpandInfo'
CREATE TABLE [dbo].[EM_ProjectExpandInfo] (
    [ProjectExpandID] int IDENTITY(1,1) NOT NULL,
    [ProjectID] nvarchar(max)  NOT NULL,
    [ProjectName] nvarchar(max)  NOT NULL,
    [ContractMoney] decimal(18,0)  NOT NULL,
    [Mileage] int  NOT NULL,
    [RoadGrade] nvarchar(40)  NOT NULL,
    [TerrainCondition] nvarchar(max)  NOT NULL,
    [RoadbedWidth] smallint  NOT NULL,
    [Excavation] decimal(18,0)  NOT NULL,
    [Fill] nvarchar(max)  NOT NULL,
    [SoftFoundation] nvarchar(max)  NOT NULL,
    [BasicLevel] nvarchar(max)  NOT NULL,
    [RoadStructureTypeAndMileage] nvarchar(max)  NOT NULL,
    [BituminousConcretePavement] nvarchar(max)  NOT NULL,
    [CementConcretePavement] nvarchar(max)  NOT NULL,
    [BridgeStructureLengthLargestSpan] nvarchar(max)  NOT NULL,
    [GrandBridgeNum] nvarchar(max)  NOT NULL,
    [GreatBridgeNum] nvarchar(max)  NOT NULL,
    [MediumBridgeNum] nvarchar(max)  NOT NULL,
    [CulvertNum] nvarchar(max)  NOT NULL,
    [InterchangeNum] nvarchar(max)  NOT NULL,
    [InterchangeMainBridge] nvarchar(max)  NOT NULL,
    [TamperBridgeNum] nvarchar(max)  NOT NULL,
    [TamperBridgeMileage] nvarchar(max)  NOT NULL,
    [SuperLongTunnelNum] nvarchar(max)  NOT NULL,
    [LongTunnelNum] nvarchar(max)  NOT NULL,
    [MiddleTunnelNum] nvarchar(max)  NOT NULL,
    [ShortTunnelNum] nvarchar(max)  NOT NULL,
    [SideSlopeAfforestation] nvarchar(max)  NOT NULL,
    [MechanicalElectricalAndContent] nvarchar(max)  NOT NULL,
    [SupervisionTask] nvarchar(max)  NOT NULL,
    [FinishedDate] nvarchar(max)  NOT NULL,
    [SupervisorWorkload] nvarchar(max)  NOT NULL,
    [QualityGrade] nvarchar(max)  NOT NULL,
    [HousingConstruction] nvarchar(max)  NOT NULL,
    [GeneralSupervision] nvarchar(max)  NOT NULL,
    [ConstructionCompanyName] nvarchar(max)  NOT NULL,
    [ConstructionCompanyLinkman] nvarchar(max)  NOT NULL,
    [ConstructionCompanyPhoneNum] nvarchar(max)  NOT NULL,
    [RewardAndPunishment] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [EM_ProjectContractBaseInfo_ProjectContractID] int  NOT NULL
);
GO

-- Creating table 'EM_ProjectPersonManage'
CREATE TABLE [dbo].[EM_ProjectPersonManage] (
    [ProjectPersonID] int IDENTITY(1,1) NOT NULL,
    [ProjectID] nvarchar(max)  NOT NULL,
    [ProjectName] nvarchar(max)  NOT NULL,
    [DutiesName] nvarchar(max)  NOT NULL,
    [PersonID] nvarchar(max)  NOT NULL,
    [PersonName] nvarchar(max)  NOT NULL,
    [PersonComeType] nvarchar(max)  NOT NULL,
    [IsOnScene] nvarchar(max)  NOT NULL,
    [EntryDate] nvarchar(max)  NOT NULL,
    [ProjectPosition] nvarchar(max)  NOT NULL,
    [ExitDate] nvarchar(max)  NOT NULL,
    [ExitReason] nvarchar(max)  NOT NULL,
    [IsHaveOwnerReplied] nvarchar(max)  NOT NULL,
    [RepliedDate] nvarchar(max)  NOT NULL,
    [RepliedResult] nvarchar(max)  NOT NULL,
    [RepliedSuggestion] nvarchar(max)  NOT NULL,
    [RepliedNumber] nvarchar(max)  NOT NULL,
    [RepliedAttachment] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [EM_ProjectBaseInfo_ProjectID] nvarchar(40)  NOT NULL
);
GO

-- Creating table 'EM_ProjectTestPutOnFile'
CREATE TABLE [dbo].[EM_ProjectTestPutOnFile] (
    [TestPutonFileID] nvarchar(40)  NOT NULL,
    [ProjectID] nvarchar(40)  NOT NULL,
    [ProjectName] nvarchar(max)  NOT NULL,
    [PutonfileStartDate] datetime  NOT NULL,
    [PutonfileEndDate] datetime  NOT NULL,
    [PutonfileTimes] smallint  NOT NULL,
    [Description] nvarchar(400)  NOT NULL,
    [EM_ProjectBaseInfo_ProjectID] nvarchar(40)  NOT NULL
);
GO

-- Creating table 'PM_CertificateManage'
CREATE TABLE [dbo].[PM_CertificateManage] (
    [CertificateID] nvarchar(40)  NOT NULL,
    [FileNumber] nvarchar(40)  NOT NULL,
    [RegisterDate] datetime  NOT NULL,
    [ProjectID] nvarchar(max)  NOT NULL,
    [PositionStatus] nvarchar(max)  NOT NULL,
    [SubmitCorporationDate] nvarchar(max)  NOT NULL,
    [IsSubmitGraduationCertificate] nvarchar(max)  NOT NULL,
    [IsSubmitSupervisionCertificate] nvarchar(max)  NOT NULL,
    [IsSubmitPositionalCertificate] nvarchar(max)  NOT NULL,
    [IsSubmitSecurityCertificate] nvarchar(max)  NOT NULL,
    [IsSubmitConservationCertificate] nvarchar(max)  NOT NULL,
    [IsSubmitIdentificationCard] nvarchar(max)  NOT NULL,
    [ReturnBusinessUnitDate] nvarchar(max)  NOT NULL,
    [IsReturnGraduationCertificate] nvarchar(max)  NOT NULL,
    [IsReturnSupervisionCertificate] nvarchar(max)  NOT NULL,
    [IsReturnPositionalCertificate] nvarchar(max)  NOT NULL,
    [IsReturnSecurityCertificate] nvarchar(max)  NOT NULL,
    [IsReturnConservationCertificate] nvarchar(max)  NOT NULL,
    [IsReturnIdentificationCard] nvarchar(max)  NOT NULL,
    [GivebackSelfDate] nvarchar(max)  NOT NULL,
    [IsGivebackGraduationCertificate] nvarchar(max)  NOT NULL,
    [IsGivebackSupervisionCertificate] nvarchar(max)  NOT NULL,
    [IsGivebackPositionalCertificate] nvarchar(max)  NOT NULL,
    [IsGivebackSecurityCertificate] nvarchar(max)  NOT NULL,
    [IsGivebackConservationCertificate] nvarchar(max)  NOT NULL,
    [IsGivebackIdentificationCard] nvarchar(max)  NOT NULL,
    [Descriptions] nvarchar(max)  NOT NULL,
    [PersonID] bigint  NOT NULL
);
GO

-- Creating table 'PM_PersonBaseInfo'
CREATE TABLE [dbo].[PM_PersonBaseInfo] (
    [PersonID] bigint IDENTITY(1,1) NOT NULL,
    [PersonName] nvarchar(20)  NOT NULL,
    [Sex] bit  NOT NULL,
    [Birthday] datetime  NOT NULL,
    [IDNumber] nvarchar(20)  NOT NULL,
    [RegisterAddress] nvarchar(40)  NOT NULL,
    [ContactNumber] nvarchar(20)  NOT NULL,
    [AlternateNumber] nvarchar(20)  NOT NULL,
    [TwoInchPhoto] tinyint  NOT NULL
);
GO

-- Creating table 'PM_PersonCertificateInfo'
CREATE TABLE [dbo].[PM_PersonCertificateInfo] (
    [CertificateID] nvarchar(40)  NOT NULL,
    [CertificateName] nvarchar(30)  NOT NULL,
    [CertificateType] nvarchar(40)  NOT NULL,
    [CertificateNumber] nvarchar(40)  NOT NULL,
    [GotDate] datetime  NOT NULL,
    [Authority] nvarchar(30)  NOT NULL,
    [Descriptions] nvarchar(200)  NOT NULL,
    [PersonID] bigint  NOT NULL
);
GO

-- Creating table 'PM_PersonContractInfo'
CREATE TABLE [dbo].[PM_PersonContractInfo] (
    [ContractID] nvarchar(40)  NOT NULL,
    [Sex] nvarchar(max)  NOT NULL,
    [IDNumber] nvarchar(max)  NOT NULL,
    [ContractNumber] nvarchar(max)  NOT NULL,
    [EffectiveDate] nvarchar(max)  NOT NULL,
    [ExpiryDate] nvarchar(max)  NOT NULL,
    [SigningDate] nvarchar(max)  NOT NULL,
    [ContractPosition] nvarchar(max)  NOT NULL,
    [ContractSalary] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [PersonID] bigint  NOT NULL
);
GO

-- Creating table 'PM_PersonEducationalBackground1'
CREATE TABLE [dbo].[PM_PersonEducationalBackground1] (
    [EducationalBckID] uniqueidentifier  NOT NULL,
    [SchoolName] nvarchar(20)  NOT NULL,
    [EduStartDate] datetime  NOT NULL,
    [EduEndDate] datetime  NOT NULL,
    [SpecialtyName] nvarchar(20)  NOT NULL,
    [Degree] nvarchar(40)  NOT NULL,
    [Descriptions] nvarchar(400)  NOT NULL,
    [PersonID] bigint  NOT NULL
);
GO

-- Creating table 'PM_PersonInsuranceInfo'
CREATE TABLE [dbo].[PM_PersonInsuranceInfo] (
    [InsuranceID] nvarchar(40)  NOT NULL,
    [Sex] nvarchar(max)  NOT NULL,
    [IDNumber] nvarchar(max)  NOT NULL,
    [InsuranceNumber] nvarchar(max)  NOT NULL,
    [InsuranceType] nvarchar(max)  NOT NULL,
    [EffectiveDate] nvarchar(max)  NOT NULL,
    [ExpiryDate] nvarchar(max)  NOT NULL,
    [PositionStatus] nvarchar(max)  NOT NULL,
    [InsuredNumber] nvarchar(max)  NOT NULL,
    [InsuranceContent] nvarchar(max)  NOT NULL,
    [ProjectID] nvarchar(max)  NOT NULL,
    [PositionName] nvarchar(max)  NOT NULL,
    [Descriptions] nvarchar(max)  NOT NULL,
    [PersonID] bigint  NOT NULL
);
GO

-- Creating table 'PM_PersonPositionalTitlesInfo'
CREATE TABLE [dbo].[PM_PersonPositionalTitlesInfo] (
    [PositionalID] bigint IDENTITY(1,1) NOT NULL,
    [PositionalName] nvarchar(20)  NOT NULL,
    [PositionalType] nvarchar(40)  NOT NULL,
    [AssessmentDate] datetime  NOT NULL,
    [AssessmentBody] nvarchar(30)  NOT NULL,
    [Descriptions] nvarchar(80)  NOT NULL,
    [PersonID] bigint  NOT NULL
);
GO

-- Creating table 'PM_PersonRegister'
CREATE TABLE [dbo].[PM_PersonRegister] (
    [RegisterID] bigint IDENTITY(1,1) NOT NULL,
    [RegisterDate] datetime  NOT NULL,
    [RegisterCompany] nvarchar(30)  NOT NULL,
    [OldDBDesc] nvarchar(max)  NOT NULL,
    [NewDBDesc] nvarchar(max)  NOT NULL,
    [IsHaveIdentificationCard] nvarchar(max)  NOT NULL,
    [IsHaveGraduationCertificate] nvarchar(max)  NOT NULL,
    [IsHavePositionalCertificate] nvarchar(max)  NOT NULL,
    [IshaveSupervisionCertificate] nvarchar(max)  NOT NULL,
    [IsHaveSecurityCertificate] nvarchar(max)  NOT NULL,
    [IsHaveConservationCertificate] nvarchar(max)  NOT NULL,
    [IshaveTwoInchPhoto] nvarchar(max)  NOT NULL,
    [RegisterStatus] nvarchar(max)  NOT NULL,
    [NoCanRegisterCause] nvarchar(400)  NOT NULL,
    [Descriptions] nvarchar(300)  NOT NULL,
    [PersonID] bigint  NOT NULL
);
GO

-- Creating table 'PM_PersonTrainingExperience'
CREATE TABLE [dbo].[PM_PersonTrainingExperience] (
    [TrainingExpID] nvarchar(40)  NOT NULL,
    [InstitutionsName] nvarchar(30)  NOT NULL,
    [TrainingStartDate] datetime  NOT NULL,
    [TrainingEndDate] datetime  NOT NULL,
    [TrainingAddress] nvarchar(50)  NOT NULL,
    [TrainingContent] nvarchar(200)  NOT NULL,
    [GotCertificate] nvarchar(20)  NOT NULL,
    [Descriptions] nvarchar(400)  NOT NULL,
    [PersonID] bigint  NOT NULL
);
GO

-- Creating table 'PM_PersonWorkExperienceInfo'
CREATE TABLE [dbo].[PM_PersonWorkExperienceInfo] (
    [WorkExpID] nvarchar(40)  NOT NULL,
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
    [RefereesPhoneNumber] nvarchar(20)  NOT NULL,
    [PM_PersonBaseInfoPersonID] bigint  NOT NULL
);
GO

-- Creating table 'webpages_UsersInRoles'
CREATE TABLE [dbo].[webpages_UsersInRoles] (
    [webpages_Roles_RoleId] int  NOT NULL,
    [UserProfiles_UserId] int  NOT NULL
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

-- Creating primary key on [UserId] in table 'webpages_Membership'
ALTER TABLE [dbo].[webpages_Membership]
ADD CONSTRAINT [PK_webpages_Membership]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [Provider], [ProviderUserId] in table 'webpages_OAuthMembership'
ALTER TABLE [dbo].[webpages_OAuthMembership]
ADD CONSTRAINT [PK_webpages_OAuthMembership]
    PRIMARY KEY CLUSTERED ([Provider], [ProviderUserId] ASC);
GO

-- Creating primary key on [RoleId] in table 'webpages_Roles'
ALTER TABLE [dbo].[webpages_Roles]
ADD CONSTRAINT [PK_webpages_Roles]
    PRIMARY KEY CLUSTERED ([RoleId] ASC);
GO

-- Creating primary key on [ProjectID] in table 'EM_ProjectBaseInfo'
ALTER TABLE [dbo].[EM_ProjectBaseInfo]
ADD CONSTRAINT [PK_EM_ProjectBaseInfo]
    PRIMARY KEY CLUSTERED ([ProjectID] ASC);
GO

-- Creating primary key on [ProjectContractID] in table 'EM_ProjectContractBaseInfo'
ALTER TABLE [dbo].[EM_ProjectContractBaseInfo]
ADD CONSTRAINT [PK_EM_ProjectContractBaseInfo]
    PRIMARY KEY CLUSTERED ([ProjectContractID] ASC);
GO

-- Creating primary key on [PContractDataID] in table 'EM_ProjectContractDataInfo'
ALTER TABLE [dbo].[EM_ProjectContractDataInfo]
ADD CONSTRAINT [PK_EM_ProjectContractDataInfo]
    PRIMARY KEY CLUSTERED ([PContractDataID] ASC);
GO

-- Creating primary key on [PContractPayConditionID] in table 'EM_ProjectContractPayCondition'
ALTER TABLE [dbo].[EM_ProjectContractPayCondition]
ADD CONSTRAINT [PK_EM_ProjectContractPayCondition]
    PRIMARY KEY CLUSTERED ([PContractPayConditionID] ASC);
GO

-- Creating primary key on [ProjectContractPerformanceID] in table 'EM_ProjectContractPerformance'
ALTER TABLE [dbo].[EM_ProjectContractPerformance]
ADD CONSTRAINT [PK_EM_ProjectContractPerformance]
    PRIMARY KEY CLUSTERED ([ProjectContractPerformanceID] ASC);
GO

-- Creating primary key on [ContractPersonID] in table 'EM_ProjectContractPersonInfo'
ALTER TABLE [dbo].[EM_ProjectContractPersonInfo]
ADD CONSTRAINT [PK_EM_ProjectContractPersonInfo]
    PRIMARY KEY CLUSTERED ([ContractPersonID] ASC);
GO

-- Creating primary key on [ProjectExpandID] in table 'EM_ProjectExpandInfo'
ALTER TABLE [dbo].[EM_ProjectExpandInfo]
ADD CONSTRAINT [PK_EM_ProjectExpandInfo]
    PRIMARY KEY CLUSTERED ([ProjectExpandID] ASC);
GO

-- Creating primary key on [ProjectPersonID] in table 'EM_ProjectPersonManage'
ALTER TABLE [dbo].[EM_ProjectPersonManage]
ADD CONSTRAINT [PK_EM_ProjectPersonManage]
    PRIMARY KEY CLUSTERED ([ProjectPersonID] ASC);
GO

-- Creating primary key on [TestPutonFileID] in table 'EM_ProjectTestPutOnFile'
ALTER TABLE [dbo].[EM_ProjectTestPutOnFile]
ADD CONSTRAINT [PK_EM_ProjectTestPutOnFile]
    PRIMARY KEY CLUSTERED ([TestPutonFileID] ASC);
GO

-- Creating primary key on [CertificateID] in table 'PM_CertificateManage'
ALTER TABLE [dbo].[PM_CertificateManage]
ADD CONSTRAINT [PK_PM_CertificateManage]
    PRIMARY KEY CLUSTERED ([CertificateID] ASC);
GO

-- Creating primary key on [PersonID] in table 'PM_PersonBaseInfo'
ALTER TABLE [dbo].[PM_PersonBaseInfo]
ADD CONSTRAINT [PK_PM_PersonBaseInfo]
    PRIMARY KEY CLUSTERED ([PersonID] ASC);
GO

-- Creating primary key on [CertificateID] in table 'PM_PersonCertificateInfo'
ALTER TABLE [dbo].[PM_PersonCertificateInfo]
ADD CONSTRAINT [PK_PM_PersonCertificateInfo]
    PRIMARY KEY CLUSTERED ([CertificateID] ASC);
GO

-- Creating primary key on [ContractID] in table 'PM_PersonContractInfo'
ALTER TABLE [dbo].[PM_PersonContractInfo]
ADD CONSTRAINT [PK_PM_PersonContractInfo]
    PRIMARY KEY CLUSTERED ([ContractID] ASC);
GO

-- Creating primary key on [EducationalBckID] in table 'PM_PersonEducationalBackground1'
ALTER TABLE [dbo].[PM_PersonEducationalBackground1]
ADD CONSTRAINT [PK_PM_PersonEducationalBackground1]
    PRIMARY KEY CLUSTERED ([EducationalBckID] ASC);
GO

-- Creating primary key on [InsuranceID] in table 'PM_PersonInsuranceInfo'
ALTER TABLE [dbo].[PM_PersonInsuranceInfo]
ADD CONSTRAINT [PK_PM_PersonInsuranceInfo]
    PRIMARY KEY CLUSTERED ([InsuranceID] ASC);
GO

-- Creating primary key on [PositionalID] in table 'PM_PersonPositionalTitlesInfo'
ALTER TABLE [dbo].[PM_PersonPositionalTitlesInfo]
ADD CONSTRAINT [PK_PM_PersonPositionalTitlesInfo]
    PRIMARY KEY CLUSTERED ([PositionalID] ASC);
GO

-- Creating primary key on [RegisterID] in table 'PM_PersonRegister'
ALTER TABLE [dbo].[PM_PersonRegister]
ADD CONSTRAINT [PK_PM_PersonRegister]
    PRIMARY KEY CLUSTERED ([RegisterID] ASC);
GO

-- Creating primary key on [TrainingExpID] in table 'PM_PersonTrainingExperience'
ALTER TABLE [dbo].[PM_PersonTrainingExperience]
ADD CONSTRAINT [PK_PM_PersonTrainingExperience]
    PRIMARY KEY CLUSTERED ([TrainingExpID] ASC);
GO

-- Creating primary key on [WorkExpID] in table 'PM_PersonWorkExperienceInfo'
ALTER TABLE [dbo].[PM_PersonWorkExperienceInfo]
ADD CONSTRAINT [PK_PM_PersonWorkExperienceInfo]
    PRIMARY KEY CLUSTERED ([WorkExpID] ASC);
GO

-- Creating primary key on [webpages_Roles_RoleId], [UserProfiles_UserId] in table 'webpages_UsersInRoles'
ALTER TABLE [dbo].[webpages_UsersInRoles]
ADD CONSTRAINT [PK_webpages_UsersInRoles]
    PRIMARY KEY NONCLUSTERED ([webpages_Roles_RoleId], [UserProfiles_UserId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [webpages_Roles_RoleId] in table 'webpages_UsersInRoles'
ALTER TABLE [dbo].[webpages_UsersInRoles]
ADD CONSTRAINT [FK_webpages_UsersInRoles_webpages_Roles]
    FOREIGN KEY ([webpages_Roles_RoleId])
    REFERENCES [dbo].[webpages_Roles]
        ([RoleId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [UserProfiles_UserId] in table 'webpages_UsersInRoles'
ALTER TABLE [dbo].[webpages_UsersInRoles]
ADD CONSTRAINT [FK_webpages_UsersInRoles_UserProfile]
    FOREIGN KEY ([UserProfiles_UserId])
    REFERENCES [dbo].[UserProfile]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_webpages_UsersInRoles_UserProfile'
CREATE INDEX [IX_FK_webpages_UsersInRoles_UserProfile]
ON [dbo].[webpages_UsersInRoles]
    ([UserProfiles_UserId]);
GO

-- Creating foreign key on [webpages_Membership_UserId] in table 'UserProfile'
ALTER TABLE [dbo].[UserProfile]
ADD CONSTRAINT [FK_UserProfilewebpages_Membership]
    FOREIGN KEY ([webpages_Membership_UserId])
    REFERENCES [dbo].[webpages_Membership]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserProfilewebpages_Membership'
CREATE INDEX [IX_FK_UserProfilewebpages_Membership]
ON [dbo].[UserProfile]
    ([webpages_Membership_UserId]);
GO

-- Creating foreign key on [UserProfile_UserId] in table 'webpages_OAuthMembership'
ALTER TABLE [dbo].[webpages_OAuthMembership]
ADD CONSTRAINT [FK_UserProfilewebpages_OAuthMembership]
    FOREIGN KEY ([UserProfile_UserId])
    REFERENCES [dbo].[UserProfile]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserProfilewebpages_OAuthMembership'
CREATE INDEX [IX_FK_UserProfilewebpages_OAuthMembership]
ON [dbo].[webpages_OAuthMembership]
    ([UserProfile_UserId]);
GO

-- Creating foreign key on [EM_ProjectBaseInfo_ProjectID] in table 'EM_ProjectContractBaseInfo'
ALTER TABLE [dbo].[EM_ProjectContractBaseInfo]
ADD CONSTRAINT [FK_EM_ProjectBaseInfoEM_ProjectContractBaseInfo]
    FOREIGN KEY ([EM_ProjectBaseInfo_ProjectID])
    REFERENCES [dbo].[EM_ProjectBaseInfo]
        ([ProjectID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EM_ProjectBaseInfoEM_ProjectContractBaseInfo'
CREATE INDEX [IX_FK_EM_ProjectBaseInfoEM_ProjectContractBaseInfo]
ON [dbo].[EM_ProjectContractBaseInfo]
    ([EM_ProjectBaseInfo_ProjectID]);
GO

-- Creating foreign key on [EM_ProjectBaseInfo_ProjectID] in table 'EM_ProjectPersonManage'
ALTER TABLE [dbo].[EM_ProjectPersonManage]
ADD CONSTRAINT [FK_EM_ProjectBaseInfoEM_ProjectPersonManage]
    FOREIGN KEY ([EM_ProjectBaseInfo_ProjectID])
    REFERENCES [dbo].[EM_ProjectBaseInfo]
        ([ProjectID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EM_ProjectBaseInfoEM_ProjectPersonManage'
CREATE INDEX [IX_FK_EM_ProjectBaseInfoEM_ProjectPersonManage]
ON [dbo].[EM_ProjectPersonManage]
    ([EM_ProjectBaseInfo_ProjectID]);
GO

-- Creating foreign key on [EM_ProjectBaseInfo_ProjectID] in table 'EM_ProjectContractPerformance'
ALTER TABLE [dbo].[EM_ProjectContractPerformance]
ADD CONSTRAINT [FK_EM_ProjectBaseInfoEM_ProjectContractPerformance]
    FOREIGN KEY ([EM_ProjectBaseInfo_ProjectID])
    REFERENCES [dbo].[EM_ProjectBaseInfo]
        ([ProjectID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EM_ProjectBaseInfoEM_ProjectContractPerformance'
CREATE INDEX [IX_FK_EM_ProjectBaseInfoEM_ProjectContractPerformance]
ON [dbo].[EM_ProjectContractPerformance]
    ([EM_ProjectBaseInfo_ProjectID]);
GO

-- Creating foreign key on [EM_ProjectBaseInfo_ProjectID] in table 'EM_ProjectTestPutOnFile'
ALTER TABLE [dbo].[EM_ProjectTestPutOnFile]
ADD CONSTRAINT [FK_EM_ProjectBaseInfoEM_ProjectTestPutOnFile]
    FOREIGN KEY ([EM_ProjectBaseInfo_ProjectID])
    REFERENCES [dbo].[EM_ProjectBaseInfo]
        ([ProjectID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EM_ProjectBaseInfoEM_ProjectTestPutOnFile'
CREATE INDEX [IX_FK_EM_ProjectBaseInfoEM_ProjectTestPutOnFile]
ON [dbo].[EM_ProjectTestPutOnFile]
    ([EM_ProjectBaseInfo_ProjectID]);
GO

-- Creating foreign key on [EM_ProjectContractBaseInfo_ProjectContractID] in table 'EM_ProjectContractDataInfo'
ALTER TABLE [dbo].[EM_ProjectContractDataInfo]
ADD CONSTRAINT [FK_EM_ProjectContractBaseInfoEM_ProjectContractDataInfo]
    FOREIGN KEY ([EM_ProjectContractBaseInfo_ProjectContractID])
    REFERENCES [dbo].[EM_ProjectContractBaseInfo]
        ([ProjectContractID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EM_ProjectContractBaseInfoEM_ProjectContractDataInfo'
CREATE INDEX [IX_FK_EM_ProjectContractBaseInfoEM_ProjectContractDataInfo]
ON [dbo].[EM_ProjectContractDataInfo]
    ([EM_ProjectContractBaseInfo_ProjectContractID]);
GO

-- Creating foreign key on [EM_ProjectContractBaseInfo_ProjectContractID] in table 'EM_ProjectContractPayCondition'
ALTER TABLE [dbo].[EM_ProjectContractPayCondition]
ADD CONSTRAINT [FK_EM_ProjectContractBaseInfoEM_ProjectContractPayCondition]
    FOREIGN KEY ([EM_ProjectContractBaseInfo_ProjectContractID])
    REFERENCES [dbo].[EM_ProjectContractBaseInfo]
        ([ProjectContractID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EM_ProjectContractBaseInfoEM_ProjectContractPayCondition'
CREATE INDEX [IX_FK_EM_ProjectContractBaseInfoEM_ProjectContractPayCondition]
ON [dbo].[EM_ProjectContractPayCondition]
    ([EM_ProjectContractBaseInfo_ProjectContractID]);
GO

-- Creating foreign key on [EM_ProjectContractBaseInfo_ProjectContractID] in table 'EM_ProjectContractPersonInfo'
ALTER TABLE [dbo].[EM_ProjectContractPersonInfo]
ADD CONSTRAINT [FK_EM_ProjectContractBaseInfoEM_ProjectContractPersonInfo]
    FOREIGN KEY ([EM_ProjectContractBaseInfo_ProjectContractID])
    REFERENCES [dbo].[EM_ProjectContractBaseInfo]
        ([ProjectContractID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EM_ProjectContractBaseInfoEM_ProjectContractPersonInfo'
CREATE INDEX [IX_FK_EM_ProjectContractBaseInfoEM_ProjectContractPersonInfo]
ON [dbo].[EM_ProjectContractPersonInfo]
    ([EM_ProjectContractBaseInfo_ProjectContractID]);
GO

-- Creating foreign key on [EM_ProjectContractBaseInfo_ProjectContractID] in table 'EM_ProjectExpandInfo'
ALTER TABLE [dbo].[EM_ProjectExpandInfo]
ADD CONSTRAINT [FK_EM_ProjectContractBaseInfoEM_ProjectExpandInfo]
    FOREIGN KEY ([EM_ProjectContractBaseInfo_ProjectContractID])
    REFERENCES [dbo].[EM_ProjectContractBaseInfo]
        ([ProjectContractID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EM_ProjectContractBaseInfoEM_ProjectExpandInfo'
CREATE INDEX [IX_FK_EM_ProjectContractBaseInfoEM_ProjectExpandInfo]
ON [dbo].[EM_ProjectExpandInfo]
    ([EM_ProjectContractBaseInfo_ProjectContractID]);
GO

-- Creating foreign key on [PersonID] in table 'PM_CertificateManage'
ALTER TABLE [dbo].[PM_CertificateManage]
ADD CONSTRAINT [FK_PM_CertificateManagePM_PersonBaseInfo]
    FOREIGN KEY ([PersonID])
    REFERENCES [dbo].[PM_PersonBaseInfo]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PM_CertificateManagePM_PersonBaseInfo'
CREATE INDEX [IX_FK_PM_CertificateManagePM_PersonBaseInfo]
ON [dbo].[PM_CertificateManage]
    ([PersonID]);
GO

-- Creating foreign key on [PersonID] in table 'PM_PersonCertificateInfo'
ALTER TABLE [dbo].[PM_PersonCertificateInfo]
ADD CONSTRAINT [FK_PM_PersonCertificateInfoPM_PersonBaseInfo]
    FOREIGN KEY ([PersonID])
    REFERENCES [dbo].[PM_PersonBaseInfo]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PM_PersonCertificateInfoPM_PersonBaseInfo'
CREATE INDEX [IX_FK_PM_PersonCertificateInfoPM_PersonBaseInfo]
ON [dbo].[PM_PersonCertificateInfo]
    ([PersonID]);
GO

-- Creating foreign key on [PersonID] in table 'PM_PersonContractInfo'
ALTER TABLE [dbo].[PM_PersonContractInfo]
ADD CONSTRAINT [FK_PM_PersonContractInfoPM_PersonBaseInfo]
    FOREIGN KEY ([PersonID])
    REFERENCES [dbo].[PM_PersonBaseInfo]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PM_PersonContractInfoPM_PersonBaseInfo'
CREATE INDEX [IX_FK_PM_PersonContractInfoPM_PersonBaseInfo]
ON [dbo].[PM_PersonContractInfo]
    ([PersonID]);
GO

-- Creating foreign key on [PersonID] in table 'PM_PersonEducationalBackground1'
ALTER TABLE [dbo].[PM_PersonEducationalBackground1]
ADD CONSTRAINT [FK_PM_PersonEducationalBackgroundPM_PersonBaseInfo]
    FOREIGN KEY ([PersonID])
    REFERENCES [dbo].[PM_PersonBaseInfo]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PM_PersonEducationalBackgroundPM_PersonBaseInfo'
CREATE INDEX [IX_FK_PM_PersonEducationalBackgroundPM_PersonBaseInfo]
ON [dbo].[PM_PersonEducationalBackground1]
    ([PersonID]);
GO

-- Creating foreign key on [PersonID] in table 'PM_PersonInsuranceInfo'
ALTER TABLE [dbo].[PM_PersonInsuranceInfo]
ADD CONSTRAINT [FK_PM_PersonInsuranceInfoPM_PersonBaseInfo]
    FOREIGN KEY ([PersonID])
    REFERENCES [dbo].[PM_PersonBaseInfo]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PM_PersonInsuranceInfoPM_PersonBaseInfo'
CREATE INDEX [IX_FK_PM_PersonInsuranceInfoPM_PersonBaseInfo]
ON [dbo].[PM_PersonInsuranceInfo]
    ([PersonID]);
GO

-- Creating foreign key on [PersonID] in table 'PM_PersonTrainingExperience'
ALTER TABLE [dbo].[PM_PersonTrainingExperience]
ADD CONSTRAINT [FK_PM_PersonTrainingExperiencePM_PersonBaseInfo]
    FOREIGN KEY ([PersonID])
    REFERENCES [dbo].[PM_PersonBaseInfo]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PM_PersonTrainingExperiencePM_PersonBaseInfo'
CREATE INDEX [IX_FK_PM_PersonTrainingExperiencePM_PersonBaseInfo]
ON [dbo].[PM_PersonTrainingExperience]
    ([PersonID]);
GO

-- Creating foreign key on [PersonID] in table 'PM_PersonPositionalTitlesInfo'
ALTER TABLE [dbo].[PM_PersonPositionalTitlesInfo]
ADD CONSTRAINT [FK_PM_PersonPositionalTitlesInfoPM_PersonBaseInfo]
    FOREIGN KEY ([PersonID])
    REFERENCES [dbo].[PM_PersonBaseInfo]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PM_PersonPositionalTitlesInfoPM_PersonBaseInfo'
CREATE INDEX [IX_FK_PM_PersonPositionalTitlesInfoPM_PersonBaseInfo]
ON [dbo].[PM_PersonPositionalTitlesInfo]
    ([PersonID]);
GO

-- Creating foreign key on [PersonID] in table 'PM_PersonRegister'
ALTER TABLE [dbo].[PM_PersonRegister]
ADD CONSTRAINT [FK_PM_PersonRegisterPM_PersonBaseInfo]
    FOREIGN KEY ([PersonID])
    REFERENCES [dbo].[PM_PersonBaseInfo]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PM_PersonRegisterPM_PersonBaseInfo'
CREATE INDEX [IX_FK_PM_PersonRegisterPM_PersonBaseInfo]
ON [dbo].[PM_PersonRegister]
    ([PersonID]);
GO

-- Creating foreign key on [PM_PersonBaseInfoPersonID] in table 'PM_PersonWorkExperienceInfo'
ALTER TABLE [dbo].[PM_PersonWorkExperienceInfo]
ADD CONSTRAINT [FK_PM_PersonWorkExperienceInfoPM_PersonBaseInfo]
    FOREIGN KEY ([PM_PersonBaseInfoPersonID])
    REFERENCES [dbo].[PM_PersonBaseInfo]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PM_PersonWorkExperienceInfoPM_PersonBaseInfo'
CREATE INDEX [IX_FK_PM_PersonWorkExperienceInfoPM_PersonBaseInfo]
ON [dbo].[PM_PersonWorkExperienceInfo]
    ([PM_PersonBaseInfoPersonID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------