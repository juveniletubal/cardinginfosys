/*
 Navicat Premium Data Transfer

 Source Server         : localhost
 Source Server Type    : SQL Server
 Source Server Version : 15002000
 Source Host           : localhost:1433
 Source Catalog        : hrrs_db
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002000
 File Encoding         : 65001

 Date: 19/01/2024 13:10:20
*/


-- ----------------------------
-- Table structure for master_tbl
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[master_tbl]') AND type IN ('U'))
	DROP TABLE [dbo].[master_tbl]
GO

CREATE TABLE [dbo].[master_tbl] (
  [PropertyNo] int  NOT NULL,
  [UnitUser] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Department] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [ContactNo] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Status] int  NULL
)
GO

ALTER TABLE [dbo].[master_tbl] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of master_tbl
-- ----------------------------
INSERT INTO [dbo].[master_tbl] ([PropertyNo], [UnitUser], [Department], [ContactNo], [Status]) VALUES (N'0', N'DFG', N'CMO - ICTD', N'1010101010', N'1')
GO

INSERT INTO [dbo].[master_tbl] ([PropertyNo], [UnitUser], [Department], [ContactNo], [Status]) VALUES (N'1', N'WEWE', N'', N'', N'0')
GO

INSERT INTO [dbo].[master_tbl] ([PropertyNo], [UnitUser], [Department], [ContactNo], [Status]) VALUES (N'9', N'', N'SELECT DEPARTMENT', N'', N'0')
GO

INSERT INTO [dbo].[master_tbl] ([PropertyNo], [UnitUser], [Department], [ContactNo], [Status]) VALUES (N'12', N'', N'SELECT DEPARTMENT', N'', N'0')
GO

INSERT INTO [dbo].[master_tbl] ([PropertyNo], [UnitUser], [Department], [ContactNo], [Status]) VALUES (N'44', N'', N'SELECT DEPARTMENT', N'', N'0')
GO

INSERT INTO [dbo].[master_tbl] ([PropertyNo], [UnitUser], [Department], [ContactNo], [Status]) VALUES (N'45', N'', N'SELECT DEPARTMENT', N'', N'0')
GO

INSERT INTO [dbo].[master_tbl] ([PropertyNo], [UnitUser], [Department], [ContactNo], [Status]) VALUES (N'46', N'', N'SELECT DEPARTMENT', N'', N'0')
GO

INSERT INTO [dbo].[master_tbl] ([PropertyNo], [UnitUser], [Department], [ContactNo], [Status]) VALUES (N'47', N'', N'SELECT DEPARTMENT', N'', N'0')
GO

INSERT INTO [dbo].[master_tbl] ([PropertyNo], [UnitUser], [Department], [ContactNo], [Status]) VALUES (N'123', N'DFG', N'CMO - ICTD', N'11111111111', N'0')
GO

INSERT INTO [dbo].[master_tbl] ([PropertyNo], [UnitUser], [Department], [ContactNo], [Status]) VALUES (N'1234', N'', N'', N'', N'0')
GO

INSERT INTO [dbo].[master_tbl] ([PropertyNo], [UnitUser], [Department], [ContactNo], [Status]) VALUES (N'9090', N'JUVENILE', N'CMO - CPIO', N'12345678901', N'0')
GO

INSERT INTO [dbo].[master_tbl] ([PropertyNo], [UnitUser], [Department], [ContactNo], [Status]) VALUES (N'9999', N'', N'SELECT DEPARTMENT', N'', N'0')
GO

INSERT INTO [dbo].[master_tbl] ([PropertyNo], [UnitUser], [Department], [ContactNo], [Status]) VALUES (N'12345', N'', N'SELECT DEPARTMENT', N'12345678901', N'0')
GO

INSERT INTO [dbo].[master_tbl] ([PropertyNo], [UnitUser], [Department], [ContactNo], [Status]) VALUES (N'101010', N'HAKDOG', N'CMO - ICTD', N'09123456789', N'0')
GO


-- ----------------------------
-- Table structure for transaction_tbl
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[transaction_tbl]') AND type IN ('U'))
	DROP TABLE [dbo].[transaction_tbl]
GO

CREATE TABLE [dbo].[transaction_tbl] (
  [SequenceNo] int  IDENTITY(1,1) NOT NULL,
  [PropertyNo] int  NULL,
  [Date] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [TimeIn] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [TimeOut] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Diagnosis] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [AssignedStaff] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Name] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Category] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Type] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Remarks] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Status] int  NULL
)
GO

ALTER TABLE [dbo].[transaction_tbl] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of transaction_tbl
-- ----------------------------
SET IDENTITY_INSERT [dbo].[transaction_tbl] ON
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'1', N'123', N'10/14/2023', N'06:40 pm', N'06:40 pm', N'', N'', N'', NULL, NULL, NULL, N'0')
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'2', N'1234', N'10/14/2023', N'06:40 pm', N'06:40 pm', N'', N'', N'', NULL, NULL, NULL, N'0')
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'3', N'1234', N'10/14/2023', N'06:40 pm', N'06:40 pm', N'DFBDF', N'DFBV', N'DFVDFB', NULL, NULL, NULL, N'0')
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'4', N'123', N'10/14/2023', N'06:40 pm', N'06:40 pm', N'', N'', N'', NULL, NULL, NULL, N'0')
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'5', N'1', N'10/14/2023', N'06:40 pm', N'06:40 pm', N'', N'', N'', NULL, NULL, NULL, N'0')
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'6', N'1', N'10/14/2023', N'06:40 pm', N'06:40 pm', N'', N'', N'', NULL, NULL, NULL, N'0')
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'7', N'1', N'10/14/2023', N'06:40 pm', N'06:40 pm', N'', N'', N'', NULL, NULL, NULL, N'0')
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'14', N'47', N'10/14/2023', N'06:40 pm', N'06:40 pm', N'', N'', N'', NULL, NULL, NULL, N'1')
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'16', N'12345', N'10/14/2023', N'06:40 pm', N'06:40 pm', N'GUBA ANG NAWONG', N'', N'', N'SOFTWARE', N'SELECT SOFTWARE TYPE', N'DONE', N'0')
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'17', N'101010', N'10/23/2023', N'08:00 am', N'10:00 am', N'FFFFF', N'GGG', N'JUVENILE', N'HARDWARE', N'POWER SUPPLY', N'DONE', N'0')
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'20', N'9090', N'12/18/2023', N'10:41 am', N'10:41 am', N'WALA LNG', N'BYAN', N'SAMSODON CRUZA', N'HARDWARE', N'RAM', N'HAKDOG', N'0')
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'21', N'123', N'12/18/2023', N'11:31 am', N'11:31 am', N'DGGDDG', N'GDG', N'DFDFB', N'SOFTWARE', N'SELECT SOFTWARE TYPE', N'DGG', N'0')
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'8', N'12', N'10/14/2023', N'05:40 pm', N'06:40 pm', N'', N'', N'', NULL, NULL, NULL, N'0')
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'9', N'9', N'10/14/2023', N'06:40 pm', N'06:40 pm', N'', N'', N'', NULL, NULL, NULL, N'0')
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'10', N'0', N'10/14/2023', N'06:40 pm', N'06:40 pm', N'', N'', N'', NULL, NULL, NULL, N'1')
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'12', N'45', N'10/14/2023', N'06:40 pm', N'06:40 pm', N'', N'', N'', NULL, NULL, NULL, N'0')
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'18', N'9999', N'12/17/2023', N'11:00 pm', N'11:00 pm', N'', N'', N'', N'HARDWARE', N'MOTHER BOARD', N'', N'0')
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'19', N'9999', N'12/17/2023', N'11:02 pm', N'11:02 pm', N'GGGGGGGGGG', N'', N'', N'COMMON ICT SERVICES', N'ASSESSMENT HW SW PW', N'', N'0')
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'11', N'44', N'10/14/2023', N'06:40 pm', N'06:40 pm', N'', N'', N'', NULL, NULL, NULL, N'0')
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'13', N'46', N'10/14/2023', N'06:40 pm', N'06:40 pm', N'', N'', N'', NULL, NULL, NULL, N'0')
GO

INSERT INTO [dbo].[transaction_tbl] ([SequenceNo], [PropertyNo], [Date], [TimeIn], [TimeOut], [Diagnosis], [AssignedStaff], [Name], [Category], [Type], [Remarks], [Status]) VALUES (N'15', N'44', N'10/14/2023', N'06:40 pm', N'06:40 pm', N'', N'', N'', N'SOFTWARE', N'OPERATING SYSTEM', NULL, N'0')
GO

SET IDENTITY_INSERT [dbo].[transaction_tbl] OFF
GO


-- ----------------------------
-- Primary Key structure for table master_tbl
-- ----------------------------
ALTER TABLE [dbo].[master_tbl] ADD CONSTRAINT [PK_master_tbl] PRIMARY KEY CLUSTERED ([PropertyNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for transaction_tbl
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[transaction_tbl]', RESEED, 21)
GO


-- ----------------------------
-- Foreign Keys structure for table transaction_tbl
-- ----------------------------
ALTER TABLE [dbo].[transaction_tbl] ADD CONSTRAINT [PropertyNo] FOREIGN KEY ([PropertyNo]) REFERENCES [dbo].[master_tbl] ([PropertyNo]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

