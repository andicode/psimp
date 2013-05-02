
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/02/2013 13:53:55
-- Generated from EDMX file: C:\Users\Nothing\Documents\Visual Studio 2012\Projects\PSIMP\PSIMP\PSIMP.Models\PSIMPDB.edmx
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

IF OBJECT_ID(N'[dbo].[FK_UserFoldersUserProfile]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserFolders] DROP CONSTRAINT [FK_UserFoldersUserProfile];
GO
IF OBJECT_ID(N'[dbo].[FK_UserFilesUserFolders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserFiles] DROP CONSTRAINT [FK_UserFilesUserFolders];
GO
IF OBJECT_ID(N'[dbo].[FK_UserFoldersUserFolders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserFolders] DROP CONSTRAINT [FK_UserFoldersUserFolders];
GO
IF OBJECT_ID(N'[dbo].[FK_AM_ProjectApplicationBaseInfoAM_ApplicationContent_CapitalFundCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AM_ApplicationContent_CapitalFundCategory] DROP CONSTRAINT [FK_AM_ProjectApplicationBaseInfoAM_ApplicationContent_CapitalFundCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_AM_ProjectApplicationBaseInfoAM_ApplicationContent_VehicleCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AM_ApplicationContent_VehicleCategory] DROP CONSTRAINT [FK_AM_ProjectApplicationBaseInfoAM_ApplicationContent_VehicleCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_AM_LaiWenRecordInfoAM_LaiWenCircularizeDetail]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AM_LaiWenCircularizeDetail] DROP CONSTRAINT [FK_AM_LaiWenRecordInfoAM_LaiWenCircularizeDetail];
GO
IF OBJECT_ID(N'[dbo].[FK_AM_LaiWenRecordInfoAM_LaiWenRepliedInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AM_LaiWenRepliedInfo] DROP CONSTRAINT [FK_AM_LaiWenRecordInfoAM_LaiWenRepliedInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_AMG_AssetBaseInfoAMG_AssetAllocateInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AMG_AssetAllocateInfo] DROP CONSTRAINT [FK_AMG_AssetBaseInfoAMG_AssetAllocateInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_AMG_AssetBaseInfoAMG_AssetRepairInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AMG_AssetRepairInfo] DROP CONSTRAINT [FK_AMG_AssetBaseInfoAMG_AssetRepairInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_AMG_AssetBaseInfoAMG_AssetUseInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AMG_AssetUseInfo] DROP CONSTRAINT [FK_AMG_AssetBaseInfoAMG_AssetUseInfo];
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
IF OBJECT_ID(N'[dbo].[FK_PM_PersonBaseInfoPM_CertificateManage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PM_CertificateManage] DROP CONSTRAINT [FK_PM_PersonBaseInfoPM_CertificateManage];
GO
IF OBJECT_ID(N'[dbo].[FK_PM_PersonBaseInfoPM_PersonRegister]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PM_PersonRegister] DROP CONSTRAINT [FK_PM_PersonBaseInfoPM_PersonRegister];
GO
IF OBJECT_ID(N'[dbo].[FK_PM_PersonBaseInfoPM_PersonCertificateInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PM_PersonCertificateInfo] DROP CONSTRAINT [FK_PM_PersonBaseInfoPM_PersonCertificateInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_PM_PersonBaseInfoPM_PersonInsuranceInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PM_PersonInsuranceInfo] DROP CONSTRAINT [FK_PM_PersonBaseInfoPM_PersonInsuranceInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_PM_PersonBaseInfoPM_PersonTrainingExperience]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PM_PersonTrainingExperience] DROP CONSTRAINT [FK_PM_PersonBaseInfoPM_PersonTrainingExperience];
GO
IF OBJECT_ID(N'[dbo].[FK_PM_PersonBaseInfoPM_PersonPositionalTitlesInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PM_PersonPositionalTitlesInfo] DROP CONSTRAINT [FK_PM_PersonBaseInfoPM_PersonPositionalTitlesInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_PM_PersonBaseInfoPM_PersonEducationalBackground]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PM_PersonEducationalBackground1] DROP CONSTRAINT [FK_PM_PersonBaseInfoPM_PersonEducationalBackground];
GO
IF OBJECT_ID(N'[dbo].[FK_PM_PersonBaseInfoPM_PersonWorkExperienceInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PM_PersonWorkExperienceInfo] DROP CONSTRAINT [FK_PM_PersonBaseInfoPM_PersonWorkExperienceInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_VM_VehicleLoanInfoVM_PaymentDetailInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VM_PaymentDetailInfo] DROP CONSTRAINT [FK_VM_VehicleLoanInfoVM_PaymentDetailInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_VM_VehicleBaseInfoVM_VehicleAllocateInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VM_VehicleAllocateInfo] DROP CONSTRAINT [FK_VM_VehicleBaseInfoVM_VehicleAllocateInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_VM_VehicleBaseInfoVM_VehicleLeaseInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VM_VehicleLeaseInfo] DROP CONSTRAINT [FK_VM_VehicleBaseInfoVM_VehicleLeaseInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_VM_VehicleBaseInfoVM_VehicleUseInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VM_VehicleUseInfo] DROP CONSTRAINT [FK_VM_VehicleBaseInfoVM_VehicleUseInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_VM_VehicleBaseInfoVM_VehicleYearInspection]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VM_VehicleYearInspection] DROP CONSTRAINT [FK_VM_VehicleBaseInfoVM_VehicleYearInspection];
GO
IF OBJECT_ID(N'[dbo].[FK_VM_VehicleBaseInfoVM_VehicleOperatingCost]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VM_VehicleOperatingCost] DROP CONSTRAINT [FK_VM_VehicleBaseInfoVM_VehicleOperatingCost];
GO
IF OBJECT_ID(N'[dbo].[FK_VM_VehicleBaseInfoVM_VehicleLoanInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VM_VehicleLoanInfo] DROP CONSTRAINT [FK_VM_VehicleBaseInfoVM_VehicleLoanInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_VM_VehicleBaseInfoVM_VehicleInsurance]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VM_VehicleInsurance] DROP CONSTRAINT [FK_VM_VehicleBaseInfoVM_VehicleInsurance];
GO
IF OBJECT_ID(N'[dbo].[FK_VM_VehicleRepairVM_VehicleRepairDetailList]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VM_VehicleRepairDetailList] DROP CONSTRAINT [FK_VM_VehicleRepairVM_VehicleRepairDetailList];
GO
IF OBJECT_ID(N'[dbo].[FK_VM_VehicleBaseInfoVM_VehicleRepair]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VM_VehicleRepair] DROP CONSTRAINT [FK_VM_VehicleBaseInfoVM_VehicleRepair];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserProfile]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserProfile];
GO
IF OBJECT_ID(N'[dbo].[UserFiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserFiles];
GO
IF OBJECT_ID(N'[dbo].[UserFolders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserFolders];
GO
IF OBJECT_ID(N'[dbo].[AM_ApplicationContent_CapitalFundCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AM_ApplicationContent_CapitalFundCategory];
GO
IF OBJECT_ID(N'[dbo].[AM_ApplicationContent_VehicleCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AM_ApplicationContent_VehicleCategory];
GO
IF OBJECT_ID(N'[dbo].[AM_ApplicationRepliedDetail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AM_ApplicationRepliedDetail];
GO
IF OBJECT_ID(N'[dbo].[AM_LaiWenCircularizeDetail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AM_LaiWenCircularizeDetail];
GO
IF OBJECT_ID(N'[dbo].[AM_LaiWenRecordInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AM_LaiWenRecordInfo];
GO
IF OBJECT_ID(N'[dbo].[AM_LaiWenRepliedInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AM_LaiWenRepliedInfo];
GO
IF OBJECT_ID(N'[dbo].[AM_ProjectApplicationBaseInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AM_ProjectApplicationBaseInfo];
GO
IF OBJECT_ID(N'[dbo].[AM_ProjectApplicationRepliedInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AM_ProjectApplicationRepliedInfo];
GO
IF OBJECT_ID(N'[dbo].[AMG_AssetAllocateInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AMG_AssetAllocateInfo];
GO
IF OBJECT_ID(N'[dbo].[AMG_AssetBaseInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AMG_AssetBaseInfo];
GO
IF OBJECT_ID(N'[dbo].[AMG_AssetRepairInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AMG_AssetRepairInfo];
GO
IF OBJECT_ID(N'[dbo].[AMG_AssetUseInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AMG_AssetUseInfo];
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
IF OBJECT_ID(N'[dbo].[VM_PaymentDetailInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VM_PaymentDetailInfo];
GO
IF OBJECT_ID(N'[dbo].[VM_VehicleAllocateInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VM_VehicleAllocateInfo];
GO
IF OBJECT_ID(N'[dbo].[VM_VehicleBaseInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VM_VehicleBaseInfo];
GO
IF OBJECT_ID(N'[dbo].[VM_VehicleInsurance]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VM_VehicleInsurance];
GO
IF OBJECT_ID(N'[dbo].[VM_VehicleLeaseInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VM_VehicleLeaseInfo];
GO
IF OBJECT_ID(N'[dbo].[VM_VehicleLoanInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VM_VehicleLoanInfo];
GO
IF OBJECT_ID(N'[dbo].[VM_VehicleOperatingCost]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VM_VehicleOperatingCost];
GO
IF OBJECT_ID(N'[dbo].[VM_VehicleRepair]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VM_VehicleRepair];
GO
IF OBJECT_ID(N'[dbo].[VM_VehicleRepairDetailList]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VM_VehicleRepairDetailList];
GO
IF OBJECT_ID(N'[dbo].[VM_VehicleUseInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VM_VehicleUseInfo];
GO
IF OBJECT_ID(N'[dbo].[VM_VehicleYearInspection]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VM_VehicleYearInspection];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserProfile'
CREATE TABLE [dbo].[UserProfile] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserFiles'
CREATE TABLE [dbo].[UserFiles] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [FileName] nvarchar(max)  NOT NULL,
    [FileType] nvarchar(max)  NOT NULL,
    [FileSize] nvarchar(max)  NOT NULL,
    [Remark] nvarchar(max)  NOT NULL,
    [IsShared] bit  NOT NULL,
    [FolderID] bigint  NOT NULL,
    [SharedRemark] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserFolders'
CREATE TABLE [dbo].[UserFolders] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [FolderName] nvarchar(max)  NOT NULL,
    [UserId] int  NOT NULL,
    [IsSys] bit  NOT NULL,
    [ParentID] bigint  NULL
);
GO

-- Creating table 'AM_ApplicationContent_CapitalFundCategory'
CREATE TABLE [dbo].[AM_ApplicationContent_CapitalFundCategory] (
    [ApplicationCapitalCategoryID] uniqueidentifier  NOT NULL,
    [ProjectApplicationID] uniqueidentifier  NOT NULL,
    [ApplicationType] nvarchar(50)  NOT NULL,
    [AssetName] nvarchar(max)  NOT NULL,
    [SpecificationMode] nvarchar(40)  NOT NULL,
    [Quantity] int  NOT NULL,
    [Unit] nvarchar(20)  NOT NULL,
    [Money] decimal(18,0)  NOT NULL,
    [TotalMoney] decimal(18,0)  NOT NULL,
    [Description] nvarchar(500)  NOT NULL,
    [AM_ProjectApplicationBaseInfo_ProjectApplicationID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'AM_ApplicationContent_VehicleCategory'
CREATE TABLE [dbo].[AM_ApplicationContent_VehicleCategory] (
    [ApplicationVehicleCategoryID] uniqueidentifier  NOT NULL,
    [ProjectApplicationID] uniqueidentifier  NOT NULL,
    [ApplicationType] uniqueidentifier  NOT NULL,
    [PlateNumber] nvarchar(40)  NOT NULL,
    [Mileage] nvarchar(40)  NOT NULL,
    [CarPart] uniqueidentifier  NOT NULL,
    [ItemName] nvarchar(40)  NOT NULL,
    [ItemMoney] decimal(18,0)  NOT NULL,
    [ItemQuantity] int  NOT NULL,
    [TotalMoney] decimal(18,0)  NOT NULL,
    [Description] nvarchar(400)  NOT NULL,
    [AM_ProjectApplicationBaseInfo_ProjectApplicationID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'AM_ApplicationRepliedDetail'
CREATE TABLE [dbo].[AM_ApplicationRepliedDetail] (
    [ApplicationRepliedDetailID] uniqueidentifier  NOT NULL,
    [RepliedPersonID] uniqueidentifier  NOT NULL,
    [RepliedResult] bit  NOT NULL,
    [RepliedSuggestion] nvarchar(300)  NOT NULL,
    [RepliedDate] datetime  NOT NULL,
    [RepliedPersonPosition] nvarchar(50)  NOT NULL,
    [RepliedDepartment] nvarchar(50)  NOT NULL,
    [RepliedStatus] bit  NOT NULL
);
GO

-- Creating table 'AM_LaiWenCircularizeDetail'
CREATE TABLE [dbo].[AM_LaiWenCircularizeDetail] (
    [LaiWenCircularizeID] uniqueidentifier  NOT NULL,
    [LaiWenRecordID] uniqueidentifier  NOT NULL,
    [CircularizeStatus] bit  NOT NULL,
    [CircularizedPersonID] uniqueidentifier  NOT NULL,
    [CircularizedDate] datetime  NOT NULL,
    [Description] nvarchar(400)  NOT NULL,
    [AM_LaiWenRecordInfo_LaiWenRecordID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'AM_LaiWenRecordInfo'
CREATE TABLE [dbo].[AM_LaiWenRecordInfo] (
    [LaiWenRecordID] uniqueidentifier  NOT NULL,
    [LaiWenUnit] nvarchar(40)  NOT NULL,
    [LaiWenType] nvarchar(50)  NOT NULL,
    [LaiWenMode] nvarchar(40)  NOT NULL,
    [FileSubject] nvarchar(200)  NOT NULL,
    [LaiWenSerialNumber] nvarchar(40)  NOT NULL,
    [IncomeFileDate] datetime  NOT NULL,
    [IncomeFileNum] int  NOT NULL,
    [FileAttachment] tinyint  NOT NULL,
    [ProjectID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'AM_LaiWenRepliedInfo'
CREATE TABLE [dbo].[AM_LaiWenRepliedInfo] (
    [LaiWenRepliedID] uniqueidentifier  NOT NULL,
    [RepliedDepartment] nvarchar(40)  NOT NULL,
    [RepliedUserID] uniqueidentifier  NOT NULL,
    [RepliedStatus] bit  NOT NULL,
    [RepliedResult] bit  NOT NULL,
    [RepliedSuggestion] nvarchar(400)  NOT NULL,
    [RepliedDate] datetime  NOT NULL,
    [LaiWenRecordID] uniqueidentifier  NOT NULL,
    [Description] nvarchar(400)  NOT NULL,
    [AM_LaiWenRecordInfo_LaiWenRecordID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'AM_ProjectApplicationBaseInfo'
CREATE TABLE [dbo].[AM_ProjectApplicationBaseInfo] (
    [ProjectApplicationID] uniqueidentifier  NOT NULL,
    [ApplicationSerialNumber] nvarchar(40)  NOT NULL,
    [ApplicationDate] datetime  NOT NULL,
    [ApplicationProjectID] uniqueidentifier  NOT NULL,
    [ApplicationPersonID] uniqueidentifier  NOT NULL,
    [ApplicationReason] nvarchar(100)  NOT NULL,
    [ApplicationContent] nvarchar(200)  NOT NULL,
    [Description] nvarchar(500)  NOT NULL
);
GO

-- Creating table 'AM_ProjectApplicationRepliedInfo'
CREATE TABLE [dbo].[AM_ProjectApplicationRepliedInfo] (
    [ApplicationRepliedID] uniqueidentifier  NOT NULL,
    [ProjectApplicationID] uniqueidentifier  NOT NULL,
    [ProjectManagerReplied] nvarchar(200)  NOT NULL,
    [ChiefDepartmentReplied] nvarchar(200)  NOT NULL,
    [CountersignatureReplied] nvarchar(300)  NOT NULL,
    [LeadershipReplied] nvarchar(200)  NOT NULL,
    [BossReplied] nvarchar(200)  NOT NULL,
    [Description] nvarchar(400)  NOT NULL
);
GO

-- Creating table 'AMG_AssetAllocateInfo'
CREATE TABLE [dbo].[AMG_AssetAllocateInfo] (
    [AssetAllocateID] uniqueidentifier  NOT NULL,
    [AssetBaseInfoID] uniqueidentifier  NOT NULL,
    [LeaveFromCompany] nvarchar(40)  NOT NULL,
    [LeaveToCompany] nvarchar(40)  NOT NULL,
    [AllocateDate] datetime  NOT NULL,
    [AllocateReason] nvarchar(400)  NOT NULL,
    [OperationUserID] uniqueidentifier  NOT NULL,
    [Description] nvarchar(200)  NOT NULL,
    [Other1] int  NOT NULL,
    [Other2] int  NOT NULL,
    [AMG_AssetBaseInfo_AssetBaseInfoID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'AMG_AssetBaseInfo'
CREATE TABLE [dbo].[AMG_AssetBaseInfo] (
    [AssetBaseInfoID] uniqueidentifier  NOT NULL,
    [AssetSerialNumber] nvarchar(40)  NOT NULL,
    [AssetType] int  NOT NULL,
    [AssetName] nvarchar(40)  NOT NULL,
    [AssetSpecificationModel] nvarchar(40)  NOT NULL,
    [Unit] nvarchar(20)  NOT NULL,
    [BuyDate] datetime  NOT NULL,
    [Quantity] int  NOT NULL,
    [UnitPrice] decimal(18,0)  NOT NULL,
    [SumPrice] decimal(18,0)  NOT NULL,
    [AssetStatus] int  NOT NULL,
    [Description] nvarchar(200)  NOT NULL,
    [Other1] nvarchar(10)  NOT NULL,
    [Other2] nvarchar(10)  NOT NULL,
    [Other3] nvarchar(10)  NOT NULL
);
GO

-- Creating table 'AMG_AssetRepairInfo'
CREATE TABLE [dbo].[AMG_AssetRepairInfo] (
    [AssetRepairID] uniqueidentifier  NOT NULL,
    [AssetBaseInfoID] uniqueidentifier  NOT NULL,
    [RepairType] int  NOT NULL,
    [RepairReason] nvarchar(40)  NOT NULL,
    [RepairMoney] decimal(18,0)  NOT NULL,
    [RepairDate] datetime  NOT NULL,
    [OperationUserID] uniqueidentifier  NOT NULL,
    [Description] nvarchar(300)  NOT NULL,
    [Other1] nvarchar(10)  NOT NULL,
    [Other2] int  NOT NULL,
    [AMG_AssetBaseInfo_AssetBaseInfoID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'AMG_AssetUseInfo'
CREATE TABLE [dbo].[AMG_AssetUseInfo] (
    [AssetUseID] uniqueidentifier  NOT NULL,
    [AssetBaseInfoID] uniqueidentifier  NOT NULL,
    [AssetUseCompany] nvarchar(40)  NOT NULL,
    [Number] int  NOT NULL,
    [UseDate] decimal(18,0)  NOT NULL,
    [UsePerson] nvarchar(40)  NOT NULL,
    [UseReason] nvarchar(300)  NOT NULL,
    [Description] nvarchar(200)  NOT NULL,
    [Other] nvarchar(20)  NOT NULL,
    [AMG_AssetBaseInfo_AssetBaseInfoID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'EM_ProjectBaseInfo'
CREATE TABLE [dbo].[EM_ProjectBaseInfo] (
    [ProjectID] uniqueidentifier  NOT NULL,
    [ProjectFullName] nvarchar(50)  NOT NULL,
    [ProjectName] nvarchar(40)  NOT NULL,
    [ConstructionCompany] nvarchar(50)  NOT NULL,
    [ProjectType] uniqueidentifier  NOT NULL,
    [ProjectScale] real  NOT NULL,
    [ProjectAddress] nvarchar(20)  NOT NULL,
    [EntryDate] datetime  NOT NULL,
    [StartDate] datetime  NOT NULL,
    [FinishedDate] datetime  NOT NULL,
    [CompletionDate] datetime  NOT NULL,
    [ConstructionPeriod] int  NOT NULL,
    [DefectsLiabilityPeriod] int  NOT NULL,
    [Description] nvarchar(500)  NOT NULL
);
GO

-- Creating table 'EM_ProjectContractBaseInfo'
CREATE TABLE [dbo].[EM_ProjectContractBaseInfo] (
    [ProjectContractID] uniqueidentifier  NOT NULL,
    [ProjectID] uniqueidentifier  NOT NULL,
    [BiddingDate] datetime  NOT NULL,
    [ContractPeriod] int  NOT NULL,
    [OpenDate] datetime  NOT NULL,
    [OpeningPeriod] int  NOT NULL,
    [OpeningConditions] nvarchar(400)  NOT NULL,
    [Description] nvarchar(400)  NOT NULL,
    [ContractAttachment] tinyint  NOT NULL,
    [EM_ProjectBaseInfo_ProjectID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'EM_ProjectContractDataInfo'
CREATE TABLE [dbo].[EM_ProjectContractDataInfo] (
    [PContractDataID] uniqueidentifier  NOT NULL,
    [ContractMoney] decimal(18,0)  NOT NULL,
    [ProvisionalSums] decimal(18,0)  NOT NULL,
    [ContractNetAmount] decimal(18,0)  NOT NULL,
    [ConstructionPeriodMoney] decimal(18,0)  NOT NULL,
    [DefectPeriodMoeny] decimal(18,0)  NOT NULL,
    [GuaranteePeriodMoney] decimal(18,0)  NOT NULL,
    [HonestDepositMoney] decimal(18,0)  NOT NULL,
    [GuaranteeMoney] decimal(18,0)  NOT NULL,
    [AgainstRiskMoney] decimal(18,0)  NOT NULL,
    [ReviewMoeny] decimal(18,0)  NOT NULL,
    [ContractID] uniqueidentifier  NOT NULL,
    [EM_ProjectContractBaseInfo_ProjectContractID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'EM_ProjectContractPayCondition'
CREATE TABLE [dbo].[EM_ProjectContractPayCondition] (
    [PContractPayConditionID] uniqueidentifier  NOT NULL,
    [ContractID] uniqueidentifier  NOT NULL,
    [MeasurePayCondition] nvarchar(300)  NOT NULL,
    [AgainstRiskPayCondition] nvarchar(300)  NOT NULL,
    [GuaranteePayMoney] nvarchar(300)  NOT NULL,
    [GuaranteePayCondition] nvarchar(300)  NOT NULL,
    [MobilizeAdvanceMoneyLetter] nvarchar(300)  NOT NULL,
    [PerformanceBondPayCondition] nvarchar(300)  NOT NULL,
    [PayMode] nvarchar(50)  NOT NULL,
    [PayDutyMode] nvarchar(50)  NOT NULL,
    [EM_ProjectContractBaseInfo_ProjectContractID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'EM_ProjectContractPerformance'
CREATE TABLE [dbo].[EM_ProjectContractPerformance] (
    [ProjectContractPerformanceID] uniqueidentifier  NOT NULL,
    [ProjectID] uniqueidentifier  NOT NULL,
    [PersonID] uniqueidentifier  NOT NULL,
    [PersonName] nvarchar(20)  NOT NULL,
    [OnProjectID] uniqueidentifier  NOT NULL,
    [InPresentDate] datetime  NOT NULL,
    [PerformanceProjectID] uniqueidentifier  NOT NULL,
    [PerformanceDuties] nvarchar(40)  NOT NULL,
    [OutDate] datetime  NOT NULL,
    [Description] nvarchar(400)  NOT NULL,
    [EM_ProjectBaseInfo_ProjectID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'EM_ProjectContractPersonInfo'
CREATE TABLE [dbo].[EM_ProjectContractPersonInfo] (
    [ContractPersonID] uniqueidentifier  NOT NULL,
    [ProjectContractID] uniqueidentifier  NOT NULL,
    [ContractDuties] nvarchar(20)  NOT NULL,
    [PersonID] uniqueidentifier  NOT NULL,
    [ContractPosition] nvarchar(20)  NOT NULL,
    [HoldCertificate] nvarchar(50)  NOT NULL,
    [Other] nvarchar(80)  NOT NULL,
    [Description] nvarchar(300)  NOT NULL,
    [EM_ProjectContractBaseInfo_ProjectContractID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'EM_ProjectExpandInfo'
CREATE TABLE [dbo].[EM_ProjectExpandInfo] (
    [ProjectExpandID] uniqueidentifier  NOT NULL,
    [ProjectID] uniqueidentifier  NOT NULL,
    [ProjectName] nvarchar(30)  NOT NULL,
    [ContractMoney] decimal(18,0)  NOT NULL,
    [Mileage] real  NOT NULL,
    [RoadGrade] nvarchar(20)  NOT NULL,
    [TerrainCondition] nvarchar(400)  NOT NULL,
    [RoadbedWidth] int  NOT NULL,
    [Excavation] decimal(18,0)  NOT NULL,
    [EarthStoneFill] nvarchar(40)  NOT NULL,
    [SoftFoundation] nvarchar(40)  NOT NULL,
    [BasicLevel] nvarchar(40)  NOT NULL,
    [RoadStructureTypeAndMileage] nvarchar(40)  NOT NULL,
    [BituminousConcretePavement] nvarchar(40)  NOT NULL,
    [CementConcretePavement] nvarchar(40)  NOT NULL,
    [BridgeStructureLengthLargestSpan] nvarchar(40)  NOT NULL,
    [GrandBridgeNum] int  NOT NULL,
    [GreatBridgeNum] int  NOT NULL,
    [MediumBridgeNum] int  NOT NULL,
    [CulvertNum] int  NOT NULL,
    [InterchangeNum] int  NOT NULL,
    [InterchangeMainBridge] int  NOT NULL,
    [TamperBridgeNum] int  NOT NULL,
    [TamperBridgeMileage] nvarchar(40)  NOT NULL,
    [SuperLongTunnelNum] nvarchar(40)  NOT NULL,
    [LongTunnelNum] nvarchar(40)  NOT NULL,
    [MiddleTunnelNum] nvarchar(40)  NOT NULL,
    [ShortTunnelNum] nvarchar(40)  NOT NULL,
    [SideSlopeAfforestation] nvarchar(40)  NOT NULL,
    [MechanicalElectricalAndContent] nvarchar(40)  NOT NULL,
    [SupervisionTask] nvarchar(500)  NOT NULL,
    [FinishedDate] datetime  NOT NULL,
    [SupervisorWorkload] nvarchar(40)  NOT NULL,
    [QualityGrade] nvarchar(20)  NOT NULL,
    [HousingConstruction] nvarchar(40)  NOT NULL,
    [GeneralSupervision] uniqueidentifier  NOT NULL,
    [ConstructionCompanyName] nvarchar(40)  NOT NULL,
    [ConstructionCompanyLinkman] nvarchar(40)  NOT NULL,
    [ConstructionCompanyPhoneNum] nvarchar(40)  NOT NULL,
    [RewardAndPunishment] nvarchar(400)  NOT NULL,
    [Description] nvarchar(400)  NOT NULL,
    [EM_ProjectContractBaseInfo_ProjectContractID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'EM_ProjectPersonManage'
CREATE TABLE [dbo].[EM_ProjectPersonManage] (
    [ProjectPersonID] uniqueidentifier  NOT NULL,
    [ProjectID] uniqueidentifier  NOT NULL,
    [ProjectName] nvarchar(20)  NOT NULL,
    [DutiesName] nvarchar(20)  NOT NULL,
    [PersonID] uniqueidentifier  NOT NULL,
    [PersonName] nvarchar(20)  NOT NULL,
    [PersonComeType] nvarchar(60)  NOT NULL,
    [IsOnScene] int  NOT NULL,
    [EntryDate] datetime  NOT NULL,
    [ProjectPosition] nvarchar(50)  NOT NULL,
    [ExitDate] datetime  NOT NULL,
    [ExitReason] nvarchar(400)  NOT NULL,
    [IsHaveOwnerReplied] bit  NOT NULL,
    [RepliedDate] datetime  NOT NULL,
    [RepliedResult] bit  NOT NULL,
    [RepliedSuggestion] nvarchar(200)  NOT NULL,
    [RepliedNumber] nvarchar(40)  NOT NULL,
    [RepliedAttachment] tinyint  NOT NULL,
    [Description] nvarchar(400)  NOT NULL,
    [EM_ProjectBaseInfo_ProjectID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'EM_ProjectTestPutOnFile'
CREATE TABLE [dbo].[EM_ProjectTestPutOnFile] (
    [TestPutonFileID] uniqueidentifier  NOT NULL,
    [ProjectID] uniqueidentifier  NOT NULL,
    [ProjectName] nvarchar(20)  NOT NULL,
    [PutonfileStartDate] datetime  NOT NULL,
    [PutonfileEndDate] datetime  NOT NULL,
    [PutonfileTimes] int  NOT NULL,
    [Description] nvarchar(400)  NOT NULL,
    [EM_ProjectBaseInfo_ProjectID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'PM_CertificateManage'
CREATE TABLE [dbo].[PM_CertificateManage] (
    [CertificateID] uniqueidentifier  NOT NULL,
    [FileNumber] nvarchar(40)  NOT NULL,
    [PersonID] nvarchar(40)  NOT NULL,
    [RegisterDate] datetime  NOT NULL,
    [ProjectID] uniqueidentifier  NOT NULL,
    [PositionStatus] bit  NOT NULL,
    [SubmitCorporationDate] datetime  NOT NULL,
    [IsSubmitGraduationCertificate] bit  NOT NULL,
    [IsSubmitSupervisionCertificate] bit  NOT NULL,
    [IsSubmitPositionalCertificate] bit  NOT NULL,
    [IsSubmitSecurityCertificate] bit  NOT NULL,
    [IsSubmitConservationCertificate] bit  NOT NULL,
    [IsSubmitIdentificationCard] bit  NOT NULL,
    [ReturnBusinessUnitDate] datetime  NOT NULL,
    [IsReturnGraduationCertificate] bit  NOT NULL,
    [IsReturnSupervisionCertificate] bit  NOT NULL,
    [IsReturnPositionalCertificate] bit  NOT NULL,
    [IsReturnSecurityCertificate] bit  NOT NULL,
    [IsReturnConservationCertificate] bit  NOT NULL,
    [IsReturnIdentificationCard] bit  NOT NULL,
    [GivebackSelfDate] datetime  NOT NULL,
    [IsGivebackGraduationCertificate] bit  NOT NULL,
    [IsGivebackSupervisionCertificate] bit  NOT NULL,
    [IsGivebackPositionalCertificate] bit  NOT NULL,
    [IsGivebackSecurityCertificate] bit  NOT NULL,
    [IsGivebackConservationCertificate] bit  NOT NULL,
    [IsGivebackIdentificationCard] bit  NOT NULL,
    [Descriptions] nvarchar(400)  NOT NULL,
    [PM_PersonBaseInfo_PersonID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'PM_PersonBaseInfo'
CREATE TABLE [dbo].[PM_PersonBaseInfo] (
    [PersonID] uniqueidentifier  NOT NULL,
    [PersonName] nvarchar(20)  NOT NULL,
    [Sex] bit  NOT NULL,
    [Birthday] datetime  NOT NULL,
    [IDNumber] nvarchar(20)  NOT NULL,
    [RegisterAddress] nvarchar(50)  NOT NULL,
    [ContactPhoneNumber] nvarchar(20)  NOT NULL,
    [AlternatePhoneNumber] nvarchar(20)  NOT NULL,
    [TwoInchPhoto] varbinary(max)  NULL
);
GO

-- Creating table 'PM_PersonCertificateInfo'
CREATE TABLE [dbo].[PM_PersonCertificateInfo] (
    [CertificateID] uniqueidentifier  NOT NULL,
    [CertificateName] nvarchar(30)  NOT NULL,
    [CertificateType] nvarchar(40)  NOT NULL,
    [CertificateNumber] nvarchar(40)  NOT NULL,
    [GotDate] datetime  NOT NULL,
    [Authority] nvarchar(40)  NOT NULL,
    [Descriptions] nvarchar(400)  NOT NULL,
    [PersonID] uniqueidentifier  NOT NULL,
    [PM_PersonBaseInfo_PersonID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'PM_PersonContractInfo'
CREATE TABLE [dbo].[PM_PersonContractInfo] (
    [ContractID] uniqueidentifier  NOT NULL,
    [PersonID] uniqueidentifier  NOT NULL,
    [Sex] bit  NOT NULL,
    [IDNumber] nvarchar(20)  NOT NULL,
    [ContractNumber] nvarchar(40)  NOT NULL,
    [EffectiveDate] datetime  NOT NULL,
    [ExpiryDate] bit  NOT NULL,
    [SigningDate] datetime  NOT NULL,
    [ContractPosition] nvarchar(20)  NOT NULL,
    [ContractSalary] decimal(18,0)  NOT NULL,
    [Description] nvarchar(400)  NOT NULL
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
    [PersonID] uniqueidentifier  NOT NULL,
    [PM_PersonBaseInfo_PersonID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'PM_PersonInsuranceInfo'
CREATE TABLE [dbo].[PM_PersonInsuranceInfo] (
    [InsuranceID] uniqueidentifier  NOT NULL,
    [PersonID] uniqueidentifier  NOT NULL,
    [Sex] nvarchar(max)  NOT NULL,
    [IDNumber] nvarchar(40)  NOT NULL,
    [InsuranceNumber] nvarchar(50)  NOT NULL,
    [InsuranceType] nvarchar(max)  NOT NULL,
    [EffectiveDate] datetime  NOT NULL,
    [ExpiryDate] datetime  NOT NULL,
    [PositionStatus] bit  NOT NULL,
    [InsuredNumber] nvarchar(50)  NOT NULL,
    [InsuranceContent] nvarchar(max)  NOT NULL,
    [ProjectID] uniqueidentifier  NOT NULL,
    [PositionName] nvarchar(40)  NOT NULL,
    [InsuranceStatus] int  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [PM_PersonBaseInfo_PersonID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'PM_PersonPositionalTitlesInfo'
CREATE TABLE [dbo].[PM_PersonPositionalTitlesInfo] (
    [PositionalID] uniqueidentifier  NOT NULL,
    [PositionalName] nvarchar(20)  NOT NULL,
    [PositionalType] nvarchar(40)  NOT NULL,
    [AssessmentDate] datetime  NOT NULL,
    [AssessmentBody] nvarchar(40)  NOT NULL,
    [Descriptions] nvarchar(200)  NOT NULL,
    [PersonID] uniqueidentifier  NOT NULL,
    [PM_PersonBaseInfo_PersonID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'PM_PersonRegister'
CREATE TABLE [dbo].[PM_PersonRegister] (
    [RegisterID] uniqueidentifier  NOT NULL,
    [PersonID] uniqueidentifier  NOT NULL,
    [RegisterDate] datetime  NOT NULL,
    [RegisterCompany] nvarchar(30)  NOT NULL,
    [OldDBDesc] nvarchar(max)  NOT NULL,
    [NewDBDesc] nvarchar(max)  NOT NULL,
    [IsHaveIdentificationCard] bit  NOT NULL,
    [IsHaveGraduationCertificate] bit  NOT NULL,
    [IsHavePositionalCertificate] bit  NOT NULL,
    [IshaveSupervisionCertificate] bit  NOT NULL,
    [IsHaveSecurityCertificate] bit  NOT NULL,
    [IsHaveConservationCertificate] bit  NOT NULL,
    [IshaveTwoInchPhoto] bit  NOT NULL,
    [RegisterStatus] int  NOT NULL,
    [NoCanRegisterCause] nvarchar(400)  NOT NULL,
    [Descriptions] nvarchar(300)  NOT NULL,
    [PM_PersonBaseInfo_PersonID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'PM_PersonTrainingExperience'
CREATE TABLE [dbo].[PM_PersonTrainingExperience] (
    [TrainingExpID] uniqueidentifier  NOT NULL,
    [InstitutionsName] nvarchar(30)  NOT NULL,
    [TrainingStartDate] datetime  NOT NULL,
    [TrainingEndDate] datetime  NOT NULL,
    [TrainingAddress] nvarchar(50)  NOT NULL,
    [TrainingContent] nvarchar(200)  NOT NULL,
    [GotCertificate] nvarchar(20)  NOT NULL,
    [Descriptions] nvarchar(400)  NOT NULL,
    [PersonID] uniqueidentifier  NOT NULL,
    [PM_PersonBaseInfo_PersonID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'PM_PersonWorkExperienceInfo'
CREATE TABLE [dbo].[PM_PersonWorkExperienceInfo] (
    [WorkExpID] uniqueidentifier  NOT NULL,
    [WorkStartDate] datetime  NOT NULL,
    [WorkEndDate] datetime  NOT NULL,
    [CompanyName] nvarchar(40)  NOT NULL,
    [Character] nvarchar(20)  NOT NULL,
    [SectorClass] nvarchar(20)  NOT NULL,
    [AtProject] nvarchar(20)  NOT NULL,
    [PositionName] nvarchar(20)  NOT NULL,
    [Salary] decimal(18,0)  NOT NULL,
    [ContractStatus] bit  NOT NULL,
    [WorkContent] nvarchar(400)  NOT NULL,
    [RefereesName] nvarchar(20)  NOT NULL,
    [RefereesPhoneNumber] nvarchar(20)  NOT NULL,
    [PersonID] uniqueidentifier  NOT NULL,
    [PM_PersonBaseInfo_PersonID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'VM_PaymentDetailInfo'
CREATE TABLE [dbo].[VM_PaymentDetailInfo] (
    [PaymentDetailID] int IDENTITY(1,1) NOT NULL,
    [VehicleLoanID] nvarchar(40)  NOT NULL,
    [VehicleID] nvarchar(max)  NOT NULL,
    [PaymentDate] nvarchar(max)  NOT NULL,
    [MonthlyPlanPrincipal] nvarchar(max)  NOT NULL,
    [MonthlyPlaceInterest] nvarchar(max)  NOT NULL,
    [MonthlyPlanAmount] nvarchar(max)  NOT NULL,
    [MonthlyRealityPrincipal] nvarchar(max)  NOT NULL,
    [MonthlyRealityInterest] nvarchar(max)  NOT NULL,
    [MonthlyRealityAmount] nvarchar(max)  NOT NULL,
    [RemainPrincipal] nvarchar(max)  NOT NULL,
    [RemainInterest] nvarchar(max)  NOT NULL,
    [RemainTotalLoans] nvarchar(max)  NOT NULL,
    [DepositMoney] decimal(18,0)  NOT NULL,
    [BankAccountBalance] nvarchar(max)  NOT NULL,
    [OperatorUserID] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [VM_VehicleLoanInfo_VehicleLoanID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'VM_VehicleAllocateInfo'
CREATE TABLE [dbo].[VM_VehicleAllocateInfo] (
    [VehicleAllocateID] uniqueidentifier  NOT NULL,
    [VehicleID] uniqueidentifier  NOT NULL,
    [LeaveFromCompany] uniqueidentifier  NOT NULL,
    [LeaveToCompany] uniqueidentifier  NOT NULL,
    [AllocateDate] datetime  NOT NULL,
    [AllocateReason] nvarchar(400)  NOT NULL,
    [OperationUserID] uniqueidentifier  NOT NULL,
    [Description] nvarchar(400)  NOT NULL,
    [Other1] nvarchar(40)  NOT NULL,
    [Other2] nvarchar(40)  NOT NULL,
    [VM_VehicleBaseInfo_VehicleID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'VM_VehicleBaseInfo'
CREATE TABLE [dbo].[VM_VehicleBaseInfo] (
    [VehicleID] uniqueidentifier  NOT NULL,
    [VehicleBrand] nvarchar(40)  NOT NULL,
    [MotorModelNumber] nvarchar(40)  NOT NULL,
    [VehicleLicensePlate] nvarchar(20)  NOT NULL,
    [VehicleSource] bit  NOT NULL,
    [PayMode] bit  NOT NULL,
    [BuyCost] decimal(18,0)  NOT NULL,
    [VehicleOwner] nvarchar(50)  NOT NULL,
    [DrivingLicense] nvarchar(40)  NOT NULL,
    [BuyDate] datetime  NOT NULL,
    [UseStatus] int  NOT NULL,
    [Description] nvarchar(400)  NOT NULL
);
GO

-- Creating table 'VM_VehicleInsurance'
CREATE TABLE [dbo].[VM_VehicleInsurance] (
    [VehicleInsuranceID] uniqueidentifier  NOT NULL,
    [VehicleID] uniqueidentifier  NOT NULL,
    [TakeEffectiveDate] datetime  NOT NULL,
    [LoseEfficacyDate] datetime  NOT NULL,
    [ComeinInsuranceDate] datetime  NOT NULL,
    [InsuranceMoney] decimal(18,0)  NOT NULL,
    [Other1] nvarchar(200)  NOT NULL,
    [Other2] nvarchar(200)  NOT NULL,
    [Description] nvarchar(400)  NOT NULL,
    [VM_VehicleBaseInfo_VehicleID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'VM_VehicleLeaseInfo'
CREATE TABLE [dbo].[VM_VehicleLeaseInfo] (
    [VehicleLeaseID] uniqueidentifier  NOT NULL,
    [VehicleID] uniqueidentifier  NOT NULL,
    [ContractStatus] int  NOT NULL,
    [ContractStartDate] datetime  NOT NULL,
    [ContractEndDate] datetime  NOT NULL,
    [MonthlyLeaseMoney] decimal(18,0)  NOT NULL,
    [LeasePersonName] nvarchar(20)  NOT NULL,
    [LeasePersonPhoneNum] nvarchar(40)  NOT NULL,
    [PurchaseDate] datetime  NOT NULL,
    [IsMailToCompany] bit  NOT NULL,
    [Description] nvarchar(200)  NOT NULL,
    [ContractAttachment] tinyint  NOT NULL,
    [VM_VehicleBaseInfo_VehicleID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'VM_VehicleLoanInfo'
CREATE TABLE [dbo].[VM_VehicleLoanInfo] (
    [VehicleLoanID] uniqueidentifier  NOT NULL,
    [VehicleID] uniqueidentifier  NOT NULL,
    [Borrowers] nvarchar(40)  NOT NULL,
    [GuaranteeUnitName] nvarchar(40)  NOT NULL,
    [GuaranteeUnitPhone] nvarchar(40)  NOT NULL,
    [GuaranteeMoney] decimal(18,0)  NOT NULL,
    [LoanDeposit] decimal(18,0)  NOT NULL,
    [LoanSum] decimal(18,0)  NOT NULL,
    [LoanInterest] decimal(18,0)  NOT NULL,
    [LoanTotalSum] decimal(18,0)  NOT NULL,
    [DownPaymentRatio] real  NOT NULL,
    [DownPayment] decimal(18,0)  NOT NULL,
    [LoanPeriod] int  NOT NULL,
    [YearRate] real  NOT NULL,
    [StatementDate] datetime  NOT NULL,
    [MonthlyPaymentMoney] decimal(18,0)  NOT NULL,
    [PaymentBankName] nvarchar(40)  NOT NULL,
    [PaymentBankAccountNum] nvarchar(40)  NOT NULL,
    [PaymentStartDate] datetime  NOT NULL,
    [PaymentDueDate] datetime  NOT NULL,
    [Description] nvarchar(400)  NOT NULL,
    [VM_VehicleBaseInfo_VehicleID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'VM_VehicleOperatingCost'
CREATE TABLE [dbo].[VM_VehicleOperatingCost] (
    [VehicleOperatingCostID] uniqueidentifier  NOT NULL,
    [VehicleID] uniqueidentifier  NOT NULL,
    [VehicleUseType] nvarchar(60)  NOT NULL,
    [VehicleDriver] nvarchar(40)  NOT NULL,
    [CostType] int  NOT NULL,
    [TotalCost] decimal(18,0)  NOT NULL,
    [Other] nvarchar(100)  NOT NULL,
    [Description] nvarchar(200)  NOT NULL,
    [VM_VehicleBaseInfo_VehicleID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'VM_VehicleRepair'
CREATE TABLE [dbo].[VM_VehicleRepair] (
    [VehicleRepairID] uniqueidentifier  NOT NULL,
    [VehicleID] uniqueidentifier  NOT NULL,
    [ApplicationSerialNumber] nvarchar(40)  NOT NULL,
    [MileageNumber] real  NOT NULL,
    [RepairDate] datetime  NOT NULL,
    [RepairGrade] int  NOT NULL,
    [RepairFactoryName] nvarchar(40)  NOT NULL,
    [RepairPhoneNumber] nvarchar(40)  NOT NULL,
    [Other1] nvarchar(80)  NOT NULL,
    [Other2] nvarchar(40)  NOT NULL,
    [Description] nvarchar(200)  NOT NULL,
    [VM_VehicleBaseInfo_VehicleID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'VM_VehicleRepairDetailList'
CREATE TABLE [dbo].[VM_VehicleRepairDetailList] (
    [VehicleRepairDetailID] uniqueidentifier  NOT NULL,
    [VehicleRepairID] uniqueidentifier  NOT NULL,
    [VehicleID] uniqueidentifier  NOT NULL,
    [PartsName] nvarchar(100)  NOT NULL,
    [Quantity] int  NOT NULL,
    [ApplicationUnitprice] decimal(18,0)  NOT NULL,
    [ApplicationCost] decimal(18,0)  NOT NULL,
    [CheckUnitPrice] decimal(18,0)  NOT NULL,
    [CheckCost] decimal(18,0)  NOT NULL,
    [RealityUnitprice] decimal(18,0)  NOT NULL,
    [RealityCost] decimal(18,0)  NOT NULL,
    [LaborCost] decimal(18,0)  NOT NULL,
    [Description] nvarchar(400)  NOT NULL,
    [VM_VehicleRepair_VehicleRepairID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'VM_VehicleUseInfo'
CREATE TABLE [dbo].[VM_VehicleUseInfo] (
    [VehicleUseInfoID] uniqueidentifier  NOT NULL,
    [VehicleID] uniqueidentifier  NOT NULL,
    [UseAddress] nvarchar(100)  NOT NULL,
    [VehicleUseType] nvarchar(60)  NOT NULL,
    [VehicleDriver] nvarchar(40)  NOT NULL,
    [VehicleStartDate] datetime  NOT NULL,
    [VehicleEndDate] datetime  NOT NULL,
    [UsePurpose] nvarchar(400)  NOT NULL,
    [Description] nvarchar(200)  NOT NULL,
    [Other] nvarchar(50)  NOT NULL,
    [VM_VehicleBaseInfo_VehicleID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'VM_VehicleYearInspection'
CREATE TABLE [dbo].[VM_VehicleYearInspection] (
    [VehicleYearInspectionID] uniqueidentifier  NOT NULL,
    [VehicleID] uniqueidentifier  NOT NULL,
    [InspectionDate] datetime  NOT NULL,
    [InspectionResult] bit  NOT NULL,
    [InspectionTimes] int  NOT NULL,
    [Other1] nvarchar(50)  NOT NULL,
    [Other2] nvarchar(50)  NOT NULL,
    [Description] nvarchar(200)  NOT NULL,
    [VM_VehicleBaseInfo_VehicleID] uniqueidentifier  NOT NULL
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

-- Creating primary key on [ID] in table 'UserFiles'
ALTER TABLE [dbo].[UserFiles]
ADD CONSTRAINT [PK_UserFiles]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'UserFolders'
ALTER TABLE [dbo].[UserFolders]
ADD CONSTRAINT [PK_UserFolders]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ApplicationCapitalCategoryID] in table 'AM_ApplicationContent_CapitalFundCategory'
ALTER TABLE [dbo].[AM_ApplicationContent_CapitalFundCategory]
ADD CONSTRAINT [PK_AM_ApplicationContent_CapitalFundCategory]
    PRIMARY KEY CLUSTERED ([ApplicationCapitalCategoryID] ASC);
GO

-- Creating primary key on [ApplicationVehicleCategoryID] in table 'AM_ApplicationContent_VehicleCategory'
ALTER TABLE [dbo].[AM_ApplicationContent_VehicleCategory]
ADD CONSTRAINT [PK_AM_ApplicationContent_VehicleCategory]
    PRIMARY KEY CLUSTERED ([ApplicationVehicleCategoryID] ASC);
GO

-- Creating primary key on [ApplicationRepliedDetailID] in table 'AM_ApplicationRepliedDetail'
ALTER TABLE [dbo].[AM_ApplicationRepliedDetail]
ADD CONSTRAINT [PK_AM_ApplicationRepliedDetail]
    PRIMARY KEY CLUSTERED ([ApplicationRepliedDetailID] ASC);
GO

-- Creating primary key on [LaiWenCircularizeID] in table 'AM_LaiWenCircularizeDetail'
ALTER TABLE [dbo].[AM_LaiWenCircularizeDetail]
ADD CONSTRAINT [PK_AM_LaiWenCircularizeDetail]
    PRIMARY KEY CLUSTERED ([LaiWenCircularizeID] ASC);
GO

-- Creating primary key on [LaiWenRecordID] in table 'AM_LaiWenRecordInfo'
ALTER TABLE [dbo].[AM_LaiWenRecordInfo]
ADD CONSTRAINT [PK_AM_LaiWenRecordInfo]
    PRIMARY KEY CLUSTERED ([LaiWenRecordID] ASC);
GO

-- Creating primary key on [LaiWenRepliedID] in table 'AM_LaiWenRepliedInfo'
ALTER TABLE [dbo].[AM_LaiWenRepliedInfo]
ADD CONSTRAINT [PK_AM_LaiWenRepliedInfo]
    PRIMARY KEY CLUSTERED ([LaiWenRepliedID] ASC);
GO

-- Creating primary key on [ProjectApplicationID] in table 'AM_ProjectApplicationBaseInfo'
ALTER TABLE [dbo].[AM_ProjectApplicationBaseInfo]
ADD CONSTRAINT [PK_AM_ProjectApplicationBaseInfo]
    PRIMARY KEY CLUSTERED ([ProjectApplicationID] ASC);
GO

-- Creating primary key on [ApplicationRepliedID] in table 'AM_ProjectApplicationRepliedInfo'
ALTER TABLE [dbo].[AM_ProjectApplicationRepliedInfo]
ADD CONSTRAINT [PK_AM_ProjectApplicationRepliedInfo]
    PRIMARY KEY CLUSTERED ([ApplicationRepliedID] ASC);
GO

-- Creating primary key on [AssetAllocateID] in table 'AMG_AssetAllocateInfo'
ALTER TABLE [dbo].[AMG_AssetAllocateInfo]
ADD CONSTRAINT [PK_AMG_AssetAllocateInfo]
    PRIMARY KEY CLUSTERED ([AssetAllocateID] ASC);
GO

-- Creating primary key on [AssetBaseInfoID] in table 'AMG_AssetBaseInfo'
ALTER TABLE [dbo].[AMG_AssetBaseInfo]
ADD CONSTRAINT [PK_AMG_AssetBaseInfo]
    PRIMARY KEY CLUSTERED ([AssetBaseInfoID] ASC);
GO

-- Creating primary key on [AssetRepairID] in table 'AMG_AssetRepairInfo'
ALTER TABLE [dbo].[AMG_AssetRepairInfo]
ADD CONSTRAINT [PK_AMG_AssetRepairInfo]
    PRIMARY KEY CLUSTERED ([AssetRepairID] ASC);
GO

-- Creating primary key on [AssetUseID] in table 'AMG_AssetUseInfo'
ALTER TABLE [dbo].[AMG_AssetUseInfo]
ADD CONSTRAINT [PK_AMG_AssetUseInfo]
    PRIMARY KEY CLUSTERED ([AssetUseID] ASC);
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

-- Creating primary key on [PaymentDetailID] in table 'VM_PaymentDetailInfo'
ALTER TABLE [dbo].[VM_PaymentDetailInfo]
ADD CONSTRAINT [PK_VM_PaymentDetailInfo]
    PRIMARY KEY CLUSTERED ([PaymentDetailID] ASC);
GO

-- Creating primary key on [VehicleAllocateID] in table 'VM_VehicleAllocateInfo'
ALTER TABLE [dbo].[VM_VehicleAllocateInfo]
ADD CONSTRAINT [PK_VM_VehicleAllocateInfo]
    PRIMARY KEY CLUSTERED ([VehicleAllocateID] ASC);
GO

-- Creating primary key on [VehicleID] in table 'VM_VehicleBaseInfo'
ALTER TABLE [dbo].[VM_VehicleBaseInfo]
ADD CONSTRAINT [PK_VM_VehicleBaseInfo]
    PRIMARY KEY CLUSTERED ([VehicleID] ASC);
GO

-- Creating primary key on [VehicleInsuranceID] in table 'VM_VehicleInsurance'
ALTER TABLE [dbo].[VM_VehicleInsurance]
ADD CONSTRAINT [PK_VM_VehicleInsurance]
    PRIMARY KEY CLUSTERED ([VehicleInsuranceID] ASC);
GO

-- Creating primary key on [VehicleLeaseID] in table 'VM_VehicleLeaseInfo'
ALTER TABLE [dbo].[VM_VehicleLeaseInfo]
ADD CONSTRAINT [PK_VM_VehicleLeaseInfo]
    PRIMARY KEY CLUSTERED ([VehicleLeaseID] ASC);
GO

-- Creating primary key on [VehicleLoanID] in table 'VM_VehicleLoanInfo'
ALTER TABLE [dbo].[VM_VehicleLoanInfo]
ADD CONSTRAINT [PK_VM_VehicleLoanInfo]
    PRIMARY KEY CLUSTERED ([VehicleLoanID] ASC);
GO

-- Creating primary key on [VehicleOperatingCostID] in table 'VM_VehicleOperatingCost'
ALTER TABLE [dbo].[VM_VehicleOperatingCost]
ADD CONSTRAINT [PK_VM_VehicleOperatingCost]
    PRIMARY KEY CLUSTERED ([VehicleOperatingCostID] ASC);
GO

-- Creating primary key on [VehicleRepairID] in table 'VM_VehicleRepair'
ALTER TABLE [dbo].[VM_VehicleRepair]
ADD CONSTRAINT [PK_VM_VehicleRepair]
    PRIMARY KEY CLUSTERED ([VehicleRepairID] ASC);
GO

-- Creating primary key on [VehicleRepairDetailID] in table 'VM_VehicleRepairDetailList'
ALTER TABLE [dbo].[VM_VehicleRepairDetailList]
ADD CONSTRAINT [PK_VM_VehicleRepairDetailList]
    PRIMARY KEY CLUSTERED ([VehicleRepairDetailID] ASC);
GO

-- Creating primary key on [VehicleUseInfoID] in table 'VM_VehicleUseInfo'
ALTER TABLE [dbo].[VM_VehicleUseInfo]
ADD CONSTRAINT [PK_VM_VehicleUseInfo]
    PRIMARY KEY CLUSTERED ([VehicleUseInfoID] ASC);
GO

-- Creating primary key on [VehicleYearInspectionID] in table 'VM_VehicleYearInspection'
ALTER TABLE [dbo].[VM_VehicleYearInspection]
ADD CONSTRAINT [PK_VM_VehicleYearInspection]
    PRIMARY KEY CLUSTERED ([VehicleYearInspectionID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'UserFolders'
ALTER TABLE [dbo].[UserFolders]
ADD CONSTRAINT [FK_UserFoldersUserProfile]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[UserProfile]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserFoldersUserProfile'
CREATE INDEX [IX_FK_UserFoldersUserProfile]
ON [dbo].[UserFolders]
    ([UserId]);
GO

-- Creating foreign key on [FolderID] in table 'UserFiles'
ALTER TABLE [dbo].[UserFiles]
ADD CONSTRAINT [FK_UserFilesUserFolders]
    FOREIGN KEY ([FolderID])
    REFERENCES [dbo].[UserFolders]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserFilesUserFolders'
CREATE INDEX [IX_FK_UserFilesUserFolders]
ON [dbo].[UserFiles]
    ([FolderID]);
GO

-- Creating foreign key on [ParentID] in table 'UserFolders'
ALTER TABLE [dbo].[UserFolders]
ADD CONSTRAINT [FK_UserFoldersUserFolders]
    FOREIGN KEY ([ParentID])
    REFERENCES [dbo].[UserFolders]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserFoldersUserFolders'
CREATE INDEX [IX_FK_UserFoldersUserFolders]
ON [dbo].[UserFolders]
    ([ParentID]);
GO

-- Creating foreign key on [AM_ProjectApplicationBaseInfo_ProjectApplicationID] in table 'AM_ApplicationContent_CapitalFundCategory'
ALTER TABLE [dbo].[AM_ApplicationContent_CapitalFundCategory]
ADD CONSTRAINT [FK_AM_ProjectApplicationBaseInfoAM_ApplicationContent_CapitalFundCategory]
    FOREIGN KEY ([AM_ProjectApplicationBaseInfo_ProjectApplicationID])
    REFERENCES [dbo].[AM_ProjectApplicationBaseInfo]
        ([ProjectApplicationID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AM_ProjectApplicationBaseInfoAM_ApplicationContent_CapitalFundCategory'
CREATE INDEX [IX_FK_AM_ProjectApplicationBaseInfoAM_ApplicationContent_CapitalFundCategory]
ON [dbo].[AM_ApplicationContent_CapitalFundCategory]
    ([AM_ProjectApplicationBaseInfo_ProjectApplicationID]);
GO

-- Creating foreign key on [AM_ProjectApplicationBaseInfo_ProjectApplicationID] in table 'AM_ApplicationContent_VehicleCategory'
ALTER TABLE [dbo].[AM_ApplicationContent_VehicleCategory]
ADD CONSTRAINT [FK_AM_ProjectApplicationBaseInfoAM_ApplicationContent_VehicleCategory]
    FOREIGN KEY ([AM_ProjectApplicationBaseInfo_ProjectApplicationID])
    REFERENCES [dbo].[AM_ProjectApplicationBaseInfo]
        ([ProjectApplicationID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AM_ProjectApplicationBaseInfoAM_ApplicationContent_VehicleCategory'
CREATE INDEX [IX_FK_AM_ProjectApplicationBaseInfoAM_ApplicationContent_VehicleCategory]
ON [dbo].[AM_ApplicationContent_VehicleCategory]
    ([AM_ProjectApplicationBaseInfo_ProjectApplicationID]);
GO

-- Creating foreign key on [AM_LaiWenRecordInfo_LaiWenRecordID] in table 'AM_LaiWenCircularizeDetail'
ALTER TABLE [dbo].[AM_LaiWenCircularizeDetail]
ADD CONSTRAINT [FK_AM_LaiWenRecordInfoAM_LaiWenCircularizeDetail]
    FOREIGN KEY ([AM_LaiWenRecordInfo_LaiWenRecordID])
    REFERENCES [dbo].[AM_LaiWenRecordInfo]
        ([LaiWenRecordID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AM_LaiWenRecordInfoAM_LaiWenCircularizeDetail'
CREATE INDEX [IX_FK_AM_LaiWenRecordInfoAM_LaiWenCircularizeDetail]
ON [dbo].[AM_LaiWenCircularizeDetail]
    ([AM_LaiWenRecordInfo_LaiWenRecordID]);
GO

-- Creating foreign key on [AM_LaiWenRecordInfo_LaiWenRecordID] in table 'AM_LaiWenRepliedInfo'
ALTER TABLE [dbo].[AM_LaiWenRepliedInfo]
ADD CONSTRAINT [FK_AM_LaiWenRecordInfoAM_LaiWenRepliedInfo]
    FOREIGN KEY ([AM_LaiWenRecordInfo_LaiWenRecordID])
    REFERENCES [dbo].[AM_LaiWenRecordInfo]
        ([LaiWenRecordID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AM_LaiWenRecordInfoAM_LaiWenRepliedInfo'
CREATE INDEX [IX_FK_AM_LaiWenRecordInfoAM_LaiWenRepliedInfo]
ON [dbo].[AM_LaiWenRepliedInfo]
    ([AM_LaiWenRecordInfo_LaiWenRecordID]);
GO

-- Creating foreign key on [AMG_AssetBaseInfo_AssetBaseInfoID] in table 'AMG_AssetAllocateInfo'
ALTER TABLE [dbo].[AMG_AssetAllocateInfo]
ADD CONSTRAINT [FK_AMG_AssetBaseInfoAMG_AssetAllocateInfo]
    FOREIGN KEY ([AMG_AssetBaseInfo_AssetBaseInfoID])
    REFERENCES [dbo].[AMG_AssetBaseInfo]
        ([AssetBaseInfoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AMG_AssetBaseInfoAMG_AssetAllocateInfo'
CREATE INDEX [IX_FK_AMG_AssetBaseInfoAMG_AssetAllocateInfo]
ON [dbo].[AMG_AssetAllocateInfo]
    ([AMG_AssetBaseInfo_AssetBaseInfoID]);
GO

-- Creating foreign key on [AMG_AssetBaseInfo_AssetBaseInfoID] in table 'AMG_AssetRepairInfo'
ALTER TABLE [dbo].[AMG_AssetRepairInfo]
ADD CONSTRAINT [FK_AMG_AssetBaseInfoAMG_AssetRepairInfo]
    FOREIGN KEY ([AMG_AssetBaseInfo_AssetBaseInfoID])
    REFERENCES [dbo].[AMG_AssetBaseInfo]
        ([AssetBaseInfoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AMG_AssetBaseInfoAMG_AssetRepairInfo'
CREATE INDEX [IX_FK_AMG_AssetBaseInfoAMG_AssetRepairInfo]
ON [dbo].[AMG_AssetRepairInfo]
    ([AMG_AssetBaseInfo_AssetBaseInfoID]);
GO

-- Creating foreign key on [AMG_AssetBaseInfo_AssetBaseInfoID] in table 'AMG_AssetUseInfo'
ALTER TABLE [dbo].[AMG_AssetUseInfo]
ADD CONSTRAINT [FK_AMG_AssetBaseInfoAMG_AssetUseInfo]
    FOREIGN KEY ([AMG_AssetBaseInfo_AssetBaseInfoID])
    REFERENCES [dbo].[AMG_AssetBaseInfo]
        ([AssetBaseInfoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AMG_AssetBaseInfoAMG_AssetUseInfo'
CREATE INDEX [IX_FK_AMG_AssetBaseInfoAMG_AssetUseInfo]
ON [dbo].[AMG_AssetUseInfo]
    ([AMG_AssetBaseInfo_AssetBaseInfoID]);
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

-- Creating foreign key on [PM_PersonBaseInfo_PersonID] in table 'PM_CertificateManage'
ALTER TABLE [dbo].[PM_CertificateManage]
ADD CONSTRAINT [FK_PM_PersonBaseInfoPM_CertificateManage]
    FOREIGN KEY ([PM_PersonBaseInfo_PersonID])
    REFERENCES [dbo].[PM_PersonBaseInfo]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PM_PersonBaseInfoPM_CertificateManage'
CREATE INDEX [IX_FK_PM_PersonBaseInfoPM_CertificateManage]
ON [dbo].[PM_CertificateManage]
    ([PM_PersonBaseInfo_PersonID]);
GO

-- Creating foreign key on [PM_PersonBaseInfo_PersonID] in table 'PM_PersonRegister'
ALTER TABLE [dbo].[PM_PersonRegister]
ADD CONSTRAINT [FK_PM_PersonBaseInfoPM_PersonRegister]
    FOREIGN KEY ([PM_PersonBaseInfo_PersonID])
    REFERENCES [dbo].[PM_PersonBaseInfo]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PM_PersonBaseInfoPM_PersonRegister'
CREATE INDEX [IX_FK_PM_PersonBaseInfoPM_PersonRegister]
ON [dbo].[PM_PersonRegister]
    ([PM_PersonBaseInfo_PersonID]);
GO

-- Creating foreign key on [PM_PersonBaseInfo_PersonID] in table 'PM_PersonCertificateInfo'
ALTER TABLE [dbo].[PM_PersonCertificateInfo]
ADD CONSTRAINT [FK_PM_PersonBaseInfoPM_PersonCertificateInfo]
    FOREIGN KEY ([PM_PersonBaseInfo_PersonID])
    REFERENCES [dbo].[PM_PersonBaseInfo]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PM_PersonBaseInfoPM_PersonCertificateInfo'
CREATE INDEX [IX_FK_PM_PersonBaseInfoPM_PersonCertificateInfo]
ON [dbo].[PM_PersonCertificateInfo]
    ([PM_PersonBaseInfo_PersonID]);
GO

-- Creating foreign key on [PM_PersonBaseInfo_PersonID] in table 'PM_PersonInsuranceInfo'
ALTER TABLE [dbo].[PM_PersonInsuranceInfo]
ADD CONSTRAINT [FK_PM_PersonBaseInfoPM_PersonInsuranceInfo]
    FOREIGN KEY ([PM_PersonBaseInfo_PersonID])
    REFERENCES [dbo].[PM_PersonBaseInfo]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PM_PersonBaseInfoPM_PersonInsuranceInfo'
CREATE INDEX [IX_FK_PM_PersonBaseInfoPM_PersonInsuranceInfo]
ON [dbo].[PM_PersonInsuranceInfo]
    ([PM_PersonBaseInfo_PersonID]);
GO

-- Creating foreign key on [PM_PersonBaseInfo_PersonID] in table 'PM_PersonTrainingExperience'
ALTER TABLE [dbo].[PM_PersonTrainingExperience]
ADD CONSTRAINT [FK_PM_PersonBaseInfoPM_PersonTrainingExperience]
    FOREIGN KEY ([PM_PersonBaseInfo_PersonID])
    REFERENCES [dbo].[PM_PersonBaseInfo]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PM_PersonBaseInfoPM_PersonTrainingExperience'
CREATE INDEX [IX_FK_PM_PersonBaseInfoPM_PersonTrainingExperience]
ON [dbo].[PM_PersonTrainingExperience]
    ([PM_PersonBaseInfo_PersonID]);
GO

-- Creating foreign key on [PM_PersonBaseInfo_PersonID] in table 'PM_PersonPositionalTitlesInfo'
ALTER TABLE [dbo].[PM_PersonPositionalTitlesInfo]
ADD CONSTRAINT [FK_PM_PersonBaseInfoPM_PersonPositionalTitlesInfo]
    FOREIGN KEY ([PM_PersonBaseInfo_PersonID])
    REFERENCES [dbo].[PM_PersonBaseInfo]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PM_PersonBaseInfoPM_PersonPositionalTitlesInfo'
CREATE INDEX [IX_FK_PM_PersonBaseInfoPM_PersonPositionalTitlesInfo]
ON [dbo].[PM_PersonPositionalTitlesInfo]
    ([PM_PersonBaseInfo_PersonID]);
GO

-- Creating foreign key on [PM_PersonBaseInfo_PersonID] in table 'PM_PersonEducationalBackground1'
ALTER TABLE [dbo].[PM_PersonEducationalBackground1]
ADD CONSTRAINT [FK_PM_PersonBaseInfoPM_PersonEducationalBackground]
    FOREIGN KEY ([PM_PersonBaseInfo_PersonID])
    REFERENCES [dbo].[PM_PersonBaseInfo]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PM_PersonBaseInfoPM_PersonEducationalBackground'
CREATE INDEX [IX_FK_PM_PersonBaseInfoPM_PersonEducationalBackground]
ON [dbo].[PM_PersonEducationalBackground1]
    ([PM_PersonBaseInfo_PersonID]);
GO

-- Creating foreign key on [PM_PersonBaseInfo_PersonID] in table 'PM_PersonWorkExperienceInfo'
ALTER TABLE [dbo].[PM_PersonWorkExperienceInfo]
ADD CONSTRAINT [FK_PM_PersonBaseInfoPM_PersonWorkExperienceInfo]
    FOREIGN KEY ([PM_PersonBaseInfo_PersonID])
    REFERENCES [dbo].[PM_PersonBaseInfo]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PM_PersonBaseInfoPM_PersonWorkExperienceInfo'
CREATE INDEX [IX_FK_PM_PersonBaseInfoPM_PersonWorkExperienceInfo]
ON [dbo].[PM_PersonWorkExperienceInfo]
    ([PM_PersonBaseInfo_PersonID]);
GO

-- Creating foreign key on [VM_VehicleLoanInfo_VehicleLoanID] in table 'VM_PaymentDetailInfo'
ALTER TABLE [dbo].[VM_PaymentDetailInfo]
ADD CONSTRAINT [FK_VM_VehicleLoanInfoVM_PaymentDetailInfo]
    FOREIGN KEY ([VM_VehicleLoanInfo_VehicleLoanID])
    REFERENCES [dbo].[VM_VehicleLoanInfo]
        ([VehicleLoanID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VM_VehicleLoanInfoVM_PaymentDetailInfo'
CREATE INDEX [IX_FK_VM_VehicleLoanInfoVM_PaymentDetailInfo]
ON [dbo].[VM_PaymentDetailInfo]
    ([VM_VehicleLoanInfo_VehicleLoanID]);
GO

-- Creating foreign key on [VM_VehicleBaseInfo_VehicleID] in table 'VM_VehicleAllocateInfo'
ALTER TABLE [dbo].[VM_VehicleAllocateInfo]
ADD CONSTRAINT [FK_VM_VehicleBaseInfoVM_VehicleAllocateInfo]
    FOREIGN KEY ([VM_VehicleBaseInfo_VehicleID])
    REFERENCES [dbo].[VM_VehicleBaseInfo]
        ([VehicleID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VM_VehicleBaseInfoVM_VehicleAllocateInfo'
CREATE INDEX [IX_FK_VM_VehicleBaseInfoVM_VehicleAllocateInfo]
ON [dbo].[VM_VehicleAllocateInfo]
    ([VM_VehicleBaseInfo_VehicleID]);
GO

-- Creating foreign key on [VM_VehicleBaseInfo_VehicleID] in table 'VM_VehicleLeaseInfo'
ALTER TABLE [dbo].[VM_VehicleLeaseInfo]
ADD CONSTRAINT [FK_VM_VehicleBaseInfoVM_VehicleLeaseInfo]
    FOREIGN KEY ([VM_VehicleBaseInfo_VehicleID])
    REFERENCES [dbo].[VM_VehicleBaseInfo]
        ([VehicleID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VM_VehicleBaseInfoVM_VehicleLeaseInfo'
CREATE INDEX [IX_FK_VM_VehicleBaseInfoVM_VehicleLeaseInfo]
ON [dbo].[VM_VehicleLeaseInfo]
    ([VM_VehicleBaseInfo_VehicleID]);
GO

-- Creating foreign key on [VM_VehicleBaseInfo_VehicleID] in table 'VM_VehicleUseInfo'
ALTER TABLE [dbo].[VM_VehicleUseInfo]
ADD CONSTRAINT [FK_VM_VehicleBaseInfoVM_VehicleUseInfo]
    FOREIGN KEY ([VM_VehicleBaseInfo_VehicleID])
    REFERENCES [dbo].[VM_VehicleBaseInfo]
        ([VehicleID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VM_VehicleBaseInfoVM_VehicleUseInfo'
CREATE INDEX [IX_FK_VM_VehicleBaseInfoVM_VehicleUseInfo]
ON [dbo].[VM_VehicleUseInfo]
    ([VM_VehicleBaseInfo_VehicleID]);
GO

-- Creating foreign key on [VM_VehicleBaseInfo_VehicleID] in table 'VM_VehicleYearInspection'
ALTER TABLE [dbo].[VM_VehicleYearInspection]
ADD CONSTRAINT [FK_VM_VehicleBaseInfoVM_VehicleYearInspection]
    FOREIGN KEY ([VM_VehicleBaseInfo_VehicleID])
    REFERENCES [dbo].[VM_VehicleBaseInfo]
        ([VehicleID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VM_VehicleBaseInfoVM_VehicleYearInspection'
CREATE INDEX [IX_FK_VM_VehicleBaseInfoVM_VehicleYearInspection]
ON [dbo].[VM_VehicleYearInspection]
    ([VM_VehicleBaseInfo_VehicleID]);
GO

-- Creating foreign key on [VM_VehicleBaseInfo_VehicleID] in table 'VM_VehicleOperatingCost'
ALTER TABLE [dbo].[VM_VehicleOperatingCost]
ADD CONSTRAINT [FK_VM_VehicleBaseInfoVM_VehicleOperatingCost]
    FOREIGN KEY ([VM_VehicleBaseInfo_VehicleID])
    REFERENCES [dbo].[VM_VehicleBaseInfo]
        ([VehicleID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VM_VehicleBaseInfoVM_VehicleOperatingCost'
CREATE INDEX [IX_FK_VM_VehicleBaseInfoVM_VehicleOperatingCost]
ON [dbo].[VM_VehicleOperatingCost]
    ([VM_VehicleBaseInfo_VehicleID]);
GO

-- Creating foreign key on [VM_VehicleBaseInfo_VehicleID] in table 'VM_VehicleLoanInfo'
ALTER TABLE [dbo].[VM_VehicleLoanInfo]
ADD CONSTRAINT [FK_VM_VehicleBaseInfoVM_VehicleLoanInfo]
    FOREIGN KEY ([VM_VehicleBaseInfo_VehicleID])
    REFERENCES [dbo].[VM_VehicleBaseInfo]
        ([VehicleID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VM_VehicleBaseInfoVM_VehicleLoanInfo'
CREATE INDEX [IX_FK_VM_VehicleBaseInfoVM_VehicleLoanInfo]
ON [dbo].[VM_VehicleLoanInfo]
    ([VM_VehicleBaseInfo_VehicleID]);
GO

-- Creating foreign key on [VM_VehicleBaseInfo_VehicleID] in table 'VM_VehicleInsurance'
ALTER TABLE [dbo].[VM_VehicleInsurance]
ADD CONSTRAINT [FK_VM_VehicleBaseInfoVM_VehicleInsurance]
    FOREIGN KEY ([VM_VehicleBaseInfo_VehicleID])
    REFERENCES [dbo].[VM_VehicleBaseInfo]
        ([VehicleID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VM_VehicleBaseInfoVM_VehicleInsurance'
CREATE INDEX [IX_FK_VM_VehicleBaseInfoVM_VehicleInsurance]
ON [dbo].[VM_VehicleInsurance]
    ([VM_VehicleBaseInfo_VehicleID]);
GO

-- Creating foreign key on [VM_VehicleRepair_VehicleRepairID] in table 'VM_VehicleRepairDetailList'
ALTER TABLE [dbo].[VM_VehicleRepairDetailList]
ADD CONSTRAINT [FK_VM_VehicleRepairVM_VehicleRepairDetailList]
    FOREIGN KEY ([VM_VehicleRepair_VehicleRepairID])
    REFERENCES [dbo].[VM_VehicleRepair]
        ([VehicleRepairID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VM_VehicleRepairVM_VehicleRepairDetailList'
CREATE INDEX [IX_FK_VM_VehicleRepairVM_VehicleRepairDetailList]
ON [dbo].[VM_VehicleRepairDetailList]
    ([VM_VehicleRepair_VehicleRepairID]);
GO

-- Creating foreign key on [VM_VehicleBaseInfo_VehicleID] in table 'VM_VehicleRepair'
ALTER TABLE [dbo].[VM_VehicleRepair]
ADD CONSTRAINT [FK_VM_VehicleBaseInfoVM_VehicleRepair]
    FOREIGN KEY ([VM_VehicleBaseInfo_VehicleID])
    REFERENCES [dbo].[VM_VehicleBaseInfo]
        ([VehicleID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VM_VehicleBaseInfoVM_VehicleRepair'
CREATE INDEX [IX_FK_VM_VehicleBaseInfoVM_VehicleRepair]
ON [dbo].[VM_VehicleRepair]
    ([VM_VehicleBaseInfo_VehicleID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------