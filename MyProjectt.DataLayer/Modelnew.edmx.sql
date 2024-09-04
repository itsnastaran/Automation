
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/29/2024 23:54:45
-- Generated from EDMX file: D:\Git\myprojects\MyProjectt\MyProjectt.DataLayer\Modelnew.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [projectmain];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AttachFile_Letter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AttachFile] DROP CONSTRAINT [FK_AttachFile_Letter];
GO
IF OBJECT_ID(N'[dbo].[FK_Letter_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Letter] DROP CONSTRAINT [FK_Letter_User];
GO
IF OBJECT_ID(N'[dbo].[FK_News_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[News] DROP CONSTRAINT [FK_News_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Note_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Note] DROP CONSTRAINT [FK_Note_User];
GO
IF OBJECT_ID(N'[dbo].[FK_ReferenceLetter_Letter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReferenceLetter] DROP CONSTRAINT [FK_ReferenceLetter_Letter];
GO
IF OBJECT_ID(N'[dbo].[FK_ReferenceLetter_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReferenceLetter] DROP CONSTRAINT [FK_ReferenceLetter_User];
GO
IF OBJECT_ID(N'[dbo].[FK_ReferenceLetter_User1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReferenceLetter] DROP CONSTRAINT [FK_ReferenceLetter_User1];
GO
IF OBJECT_ID(N'[dbo].[FK_Remember_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Remember] DROP CONSTRAINT [FK_Remember_User];
GO
IF OBJECT_ID(N'[dbo].[FK_SendLetter_Letter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SendLetter] DROP CONSTRAINT [FK_SendLetter_Letter];
GO
IF OBJECT_ID(N'[dbo].[FK_SendLetter_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SendLetter] DROP CONSTRAINT [FK_SendLetter_User];
GO
IF OBJECT_ID(N'[dbo].[FK_SendNote_Note]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SendNote] DROP CONSTRAINT [FK_SendNote_Note];
GO
IF OBJECT_ID(N'[dbo].[FK_SendNote_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SendNote] DROP CONSTRAINT [FK_SendNote_User];
GO
IF OBJECT_ID(N'[dbo].[FK_User_UserType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_User_UserType];
GO
IF OBJECT_ID(N'[dbo].[FK_UserLog_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserLog] DROP CONSTRAINT [FK_UserLog_User];
GO
IF OBJECT_ID(N'[dbo].[FK_UserSetJob_Job]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSetJob] DROP CONSTRAINT [FK_UserSetJob_Job];
GO
IF OBJECT_ID(N'[dbo].[FK_UserSetJob_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSetJob] DROP CONSTRAINT [FK_UserSetJob_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AttachFile]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AttachFile];
GO
IF OBJECT_ID(N'[dbo].[Job]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Job];
GO
IF OBJECT_ID(N'[dbo].[Letter]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Letter];
GO
IF OBJECT_ID(N'[dbo].[News]', 'U') IS NOT NULL
    DROP TABLE [dbo].[News];
GO
IF OBJECT_ID(N'[dbo].[Note]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Note];
GO
IF OBJECT_ID(N'[dbo].[ReferenceLetter]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReferenceLetter];
GO
IF OBJECT_ID(N'[dbo].[Remember]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Remember];
GO
IF OBJECT_ID(N'[dbo].[SendLetter]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SendLetter];
GO
IF OBJECT_ID(N'[dbo].[SendNote]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SendNote];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO
IF OBJECT_ID(N'[dbo].[UserLog]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserLog];
GO
IF OBJECT_ID(N'[dbo].[UserSetJob]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSetJob];
GO
IF OBJECT_ID(N'[dbo].[UserType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserType];
GO
IF OBJECT_ID(N'[projectmainModel1StoreContainer].[Vw_jobss]', 'U') IS NOT NULL
    DROP TABLE [projectmainModel1StoreContainer].[Vw_jobss];
GO
IF OBJECT_ID(N'[projectmainModel1StoreContainer].[VW_Users]', 'U') IS NOT NULL
    DROP TABLE [projectmainModel1StoreContainer].[VW_Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AttachFile'
CREATE TABLE [dbo].[AttachFile] (
    [ID_AttachID] int IDENTITY(1,1) NOT NULL,
    [FileDate] varbinary(max)  NOT NULL,
    [FileName] nvarchar(100)  NOT NULL,
    [FileSize] int  NULL,
    [LetterID] int  NULL
);
GO

-- Creating table 'Job'
CREATE TABLE [dbo].[Job] (
    [JobID] int IDENTITY(1,1) NOT NULL,
    [JobName] nvarchar(50)  NOT NULL,
    [Job_LevelId] int  NULL,
    [DeterminaljobLevelid] int  NULL
);
GO

-- Creating table 'Letter'
CREATE TABLE [dbo].[Letter] (
    [LetterID] int IDENTITY(1,1) NOT NULL,
    [LetterSubject] nvarchar(100)  NOT NULL,
    [LetterAbstract] nchar(100)  NOT NULL,
    [LetterText] nvarchar(max)  NOT NULL,
    [LetterNumber] nvarchar(50)  NOT NULL,
    [SecurityType] tinyint  NOT NULL,
    [LetterTypeAction] tinyint  NOT NULL,
    [LetterFollow] tinyint  NOT NULL,
    [LetterAttachment] tinyint  NOT NULL,
    [LetterResponse] tinyint  NOT NULL,
    [CreateDate] datetime  NULL,
    [SendDate] datetime  NULL,
    [BayganiType] tinyint  NULL,
    [LetterType] tinyint  NOT NULL,
    [DraftType] tinyint  NOT NULL,
    [UserID] int  NOT NULL,
    [AnswerDeadline] datetime  NULL,
    [Reference] nvarchar(50)  NOT NULL,
    [ReplyRetterID] int  NULL,
    [LetterFile] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'News'
CREATE TABLE [dbo].[News] (
    [NewID] int IDENTITY(1,1) NOT NULL,
    [UserID] int  NOT NULL,
    [Subject] nvarchar(200)  NOT NULL,
    [NewsText] nvarchar(max)  NOT NULL,
    [CreateDate] datetime  NULL,
    [FileNews] varbinary(max)  NULL,
    [FileName] nvarchar(100)  NULL,
    [SendDate] datetime  NULL,
    [IsSend] tinyint  NULL
);
GO

-- Creating table 'Note'
CREATE TABLE [dbo].[Note] (
    [NoteID] int IDENTITY(1,1) NOT NULL,
    [SubjectNote] nvarchar(50)  NULL,
    [SubjectMatn] nvarchar(max)  NULL,
    [UserID_Sender] int  NULL,
    [FullNameSender] nvarchar(100)  NULL,
    [CreateDateNod] datetime  NULL
);
GO

-- Creating table 'ReferenceLetter'
CREATE TABLE [dbo].[ReferenceLetter] (
    [ReferenceLetterID] int IDENTITY(1,1) NOT NULL,
    [LetterID] int  NOT NULL,
    [UserIDReference] int  NOT NULL,
    [UserIDReciveID] int  NOT NULL,
    [FullNameRecive] nvarchar(100)  NOT NULL,
    [FullNameReference] nvarchar(100)  NOT NULL,
    [ReferenceDate] datetime  NULL,
    [ReadType] int  NULL,
    [Description] nvarchar(200)  NOT NULL,
    [LevelNumbers] int  NULL,
    [IsShow] bigint  NULL
);
GO

-- Creating table 'Remember'
CREATE TABLE [dbo].[Remember] (
    [RememberID] int IDENTITY(1,1) NOT NULL,
    [Subject] nvarchar(100)  NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [CreateDate] datetime  NOT NULL,
    [RememberDate] datetime  NOT NULL,
    [IsRead] tinyint  NOT NULL,
    [UserID] int  NOT NULL
);
GO

-- Creating table 'SendLetter'
CREATE TABLE [dbo].[SendLetter] (
    [SendLetterID] int IDENTITY(1,1) NOT NULL,
    [SendDateLetter] datetime  NOT NULL,
    [LetterID] int  NOT NULL,
    [UserID] int  NOT NULL,
    [UserID_SendLetters] int  NULL,
    [IsRead] bigint  NULL,
    [FullNameReciveLetters] nvarchar(100)  NULL,
    [IsShow] bigint  NULL,
    [FullNameSender] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'SendNote'
CREATE TABLE [dbo].[SendNote] (
    [SendNoteID] int IDENTITY(1,1) NOT NULL,
    [UserID_Recive] int  NULL,
    [NoteID] int  NULL,
    [SendDate] datetime  NULL,
    [FullName] nvarchar(100)  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [UserID] int IDENTITY(1,1) NOT NULL,
    [UserFirstName] nvarchar(50)  NOT NULL,
    [UserFamily] nvarchar(50)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [UserName] nchar(10)  NOT NULL,
    [PersonalCode] varchar(50)  NOT NULL,
    [UserEmail] varchar(50)  NOT NULL,
    [Gender] tinyint  NOT NULL,
    [Activity] tinyint  NOT NULL,
    [UserTell] nvarchar(50)  NOT NULL,
    [BirthDate] datetime  NULL,
    [UserImage] nchar(1000)  NOT NULL,
    [UserSignatures] nchar(1000)  NOT NULL,
    [CreateDate] datetime  NOT NULL,
    [UserTypeID] int  NOT NULL
);
GO

-- Creating table 'UserLog'
CREATE TABLE [dbo].[UserLog] (
    [LoginID] int IDENTITY(1,1) NOT NULL,
    [UserID] int  NOT NULL,
    [ComputerName] nvarchar(50)  NOT NULL,
    [IPAddress] nvarchar(50)  NOT NULL,
    [EnterDateTime] datetime  NULL,
    [ExitDateTime] datetime  NULL,
    [SomHors] real  NULL
);
GO

-- Creating table 'UserSetJob'
CREATE TABLE [dbo].[UserSetJob] (
    [SID] int IDENTITY(1,1) NOT NULL,
    [UserID] int  NOT NULL,
    [JobID] int  NOT NULL,
    [SetDateJob] datetime  NULL,
    [EndDateJob] datetime  NULL,
    [Status] tinyint  NULL
);
GO

-- Creating table 'UserType'
CREATE TABLE [dbo].[UserType] (
    [UserTypeID] int IDENTITY(1,1) NOT NULL,
    [TypeName] nvarchar(50)  NULL,
    [CodeType] int  NULL
);
GO

-- Creating table 'Vw_jobss'
CREATE TABLE [dbo].[Vw_jobss] (
    [JobID] int  NOT NULL,
    [JobName] nvarchar(50)  NOT NULL,
    [Job_LevelId] int  NULL,
    [DeterminaljobLevelid] int  NULL,
    [countchild] int  NULL
);
GO

-- Creating table 'VW_Users'
CREATE TABLE [dbo].[VW_Users] (
    [UserID] int  NOT NULL,
    [UserFirstName] nvarchar(50)  NOT NULL,
    [UserFamily] nvarchar(50)  NOT NULL,
    [UserName] nvarchar(50)  NOT NULL,
    [PersonalCode] varchar(50)  NOT NULL,
    [UserEmail] varchar(50)  NOT NULL,
    [FarsiGender] varchar(50)  NOT NULL,
    [FarsiActivity] varchar(50)  NOT NULL,
    [UserTell] nvarchar(50)  NOT NULL,
    [BirthDate] datetime  NULL,
    [UserImage] nchar(1000)  NOT NULL,
    [UserSignturess] nchar(1000)  NOT NULL,
    [CreateDate] datetime  NOT NULL,
    [Gender] tinyint  NOT NULL,
    [Activity] tinyint  NOT NULL,
    [JobName] nvarchar(50)  NOT NULL,
    [EndDateJob] datetime  NULL,
    [status] tinyint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID_AttachID] in table 'AttachFile'
ALTER TABLE [dbo].[AttachFile]
ADD CONSTRAINT [PK_AttachFile]
    PRIMARY KEY CLUSTERED ([ID_AttachID] ASC);
GO

-- Creating primary key on [JobID] in table 'Job'
ALTER TABLE [dbo].[Job]
ADD CONSTRAINT [PK_Job]
    PRIMARY KEY CLUSTERED ([JobID] ASC);
GO

-- Creating primary key on [LetterID] in table 'Letter'
ALTER TABLE [dbo].[Letter]
ADD CONSTRAINT [PK_Letter]
    PRIMARY KEY CLUSTERED ([LetterID] ASC);
GO

-- Creating primary key on [NewID] in table 'News'
ALTER TABLE [dbo].[News]
ADD CONSTRAINT [PK_News]
    PRIMARY KEY CLUSTERED ([NewID] ASC);
GO

-- Creating primary key on [NoteID] in table 'Note'
ALTER TABLE [dbo].[Note]
ADD CONSTRAINT [PK_Note]
    PRIMARY KEY CLUSTERED ([NoteID] ASC);
GO

-- Creating primary key on [ReferenceLetterID] in table 'ReferenceLetter'
ALTER TABLE [dbo].[ReferenceLetter]
ADD CONSTRAINT [PK_ReferenceLetter]
    PRIMARY KEY CLUSTERED ([ReferenceLetterID] ASC);
GO

-- Creating primary key on [RememberID] in table 'Remember'
ALTER TABLE [dbo].[Remember]
ADD CONSTRAINT [PK_Remember]
    PRIMARY KEY CLUSTERED ([RememberID] ASC);
GO

-- Creating primary key on [SendLetterID] in table 'SendLetter'
ALTER TABLE [dbo].[SendLetter]
ADD CONSTRAINT [PK_SendLetter]
    PRIMARY KEY CLUSTERED ([SendLetterID] ASC);
GO

-- Creating primary key on [SendNoteID] in table 'SendNote'
ALTER TABLE [dbo].[SendNote]
ADD CONSTRAINT [PK_SendNote]
    PRIMARY KEY CLUSTERED ([SendNoteID] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [UserID] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([UserID] ASC);
GO

-- Creating primary key on [LoginID] in table 'UserLog'
ALTER TABLE [dbo].[UserLog]
ADD CONSTRAINT [PK_UserLog]
    PRIMARY KEY CLUSTERED ([LoginID] ASC);
GO

-- Creating primary key on [SID] in table 'UserSetJob'
ALTER TABLE [dbo].[UserSetJob]
ADD CONSTRAINT [PK_UserSetJob]
    PRIMARY KEY CLUSTERED ([SID] ASC);
GO

-- Creating primary key on [UserTypeID] in table 'UserType'
ALTER TABLE [dbo].[UserType]
ADD CONSTRAINT [PK_UserType]
    PRIMARY KEY CLUSTERED ([UserTypeID] ASC);
GO

-- Creating primary key on [JobID], [JobName] in table 'Vw_jobss'
ALTER TABLE [dbo].[Vw_jobss]
ADD CONSTRAINT [PK_Vw_jobss]
    PRIMARY KEY CLUSTERED ([JobID], [JobName] ASC);
GO

-- Creating primary key on [UserID], [UserFirstName], [UserFamily], [UserName], [PersonalCode], [UserEmail], [FarsiGender], [FarsiActivity], [UserTell], [UserImage], [UserSignturess], [CreateDate], [Gender], [Activity], [JobName], [status] in table 'VW_Users'
ALTER TABLE [dbo].[VW_Users]
ADD CONSTRAINT [PK_VW_Users]
    PRIMARY KEY CLUSTERED ([UserID], [UserFirstName], [UserFamily], [UserName], [PersonalCode], [UserEmail], [FarsiGender], [FarsiActivity], [UserTell], [UserImage], [UserSignturess], [CreateDate], [Gender], [Activity], [JobName], [status] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [LetterID] in table 'AttachFile'
ALTER TABLE [dbo].[AttachFile]
ADD CONSTRAINT [FK_AttachFile_Letter]
    FOREIGN KEY ([LetterID])
    REFERENCES [dbo].[Letter]
        ([LetterID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AttachFile_Letter'
CREATE INDEX [IX_FK_AttachFile_Letter]
ON [dbo].[AttachFile]
    ([LetterID]);
GO

-- Creating foreign key on [JobID] in table 'UserSetJob'
ALTER TABLE [dbo].[UserSetJob]
ADD CONSTRAINT [FK_UserSetJob_Job]
    FOREIGN KEY ([JobID])
    REFERENCES [dbo].[Job]
        ([JobID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserSetJob_Job'
CREATE INDEX [IX_FK_UserSetJob_Job]
ON [dbo].[UserSetJob]
    ([JobID]);
GO

-- Creating foreign key on [UserID] in table 'Letter'
ALTER TABLE [dbo].[Letter]
ADD CONSTRAINT [FK_Letter_User]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[User]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Letter_User'
CREATE INDEX [IX_FK_Letter_User]
ON [dbo].[Letter]
    ([UserID]);
GO

-- Creating foreign key on [LetterID] in table 'ReferenceLetter'
ALTER TABLE [dbo].[ReferenceLetter]
ADD CONSTRAINT [FK_ReferenceLetter_Letter]
    FOREIGN KEY ([LetterID])
    REFERENCES [dbo].[Letter]
        ([LetterID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReferenceLetter_Letter'
CREATE INDEX [IX_FK_ReferenceLetter_Letter]
ON [dbo].[ReferenceLetter]
    ([LetterID]);
GO

-- Creating foreign key on [LetterID] in table 'SendLetter'
ALTER TABLE [dbo].[SendLetter]
ADD CONSTRAINT [FK_SendLetter_Letter]
    FOREIGN KEY ([LetterID])
    REFERENCES [dbo].[Letter]
        ([LetterID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SendLetter_Letter'
CREATE INDEX [IX_FK_SendLetter_Letter]
ON [dbo].[SendLetter]
    ([LetterID]);
GO

-- Creating foreign key on [UserID] in table 'News'
ALTER TABLE [dbo].[News]
ADD CONSTRAINT [FK_News_User]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[User]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_News_User'
CREATE INDEX [IX_FK_News_User]
ON [dbo].[News]
    ([UserID]);
GO

-- Creating foreign key on [UserID_Sender] in table 'Note'
ALTER TABLE [dbo].[Note]
ADD CONSTRAINT [FK_Note_User]
    FOREIGN KEY ([UserID_Sender])
    REFERENCES [dbo].[User]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Note_User'
CREATE INDEX [IX_FK_Note_User]
ON [dbo].[Note]
    ([UserID_Sender]);
GO

-- Creating foreign key on [NoteID] in table 'SendNote'
ALTER TABLE [dbo].[SendNote]
ADD CONSTRAINT [FK_SendNote_Note]
    FOREIGN KEY ([NoteID])
    REFERENCES [dbo].[Note]
        ([NoteID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SendNote_Note'
CREATE INDEX [IX_FK_SendNote_Note]
ON [dbo].[SendNote]
    ([NoteID]);
GO

-- Creating foreign key on [UserIDReciveID] in table 'ReferenceLetter'
ALTER TABLE [dbo].[ReferenceLetter]
ADD CONSTRAINT [FK_ReferenceLetter_User]
    FOREIGN KEY ([UserIDReciveID])
    REFERENCES [dbo].[User]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReferenceLetter_User'
CREATE INDEX [IX_FK_ReferenceLetter_User]
ON [dbo].[ReferenceLetter]
    ([UserIDReciveID]);
GO

-- Creating foreign key on [UserIDReference] in table 'ReferenceLetter'
ALTER TABLE [dbo].[ReferenceLetter]
ADD CONSTRAINT [FK_ReferenceLetter_User1]
    FOREIGN KEY ([UserIDReference])
    REFERENCES [dbo].[User]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReferenceLetter_User1'
CREATE INDEX [IX_FK_ReferenceLetter_User1]
ON [dbo].[ReferenceLetter]
    ([UserIDReference]);
GO

-- Creating foreign key on [UserID] in table 'Remember'
ALTER TABLE [dbo].[Remember]
ADD CONSTRAINT [FK_Remember_User]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[User]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Remember_User'
CREATE INDEX [IX_FK_Remember_User]
ON [dbo].[Remember]
    ([UserID]);
GO

-- Creating foreign key on [UserID] in table 'SendLetter'
ALTER TABLE [dbo].[SendLetter]
ADD CONSTRAINT [FK_SendLetter_User]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[User]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SendLetter_User'
CREATE INDEX [IX_FK_SendLetter_User]
ON [dbo].[SendLetter]
    ([UserID]);
GO

-- Creating foreign key on [UserID_Recive] in table 'SendNote'
ALTER TABLE [dbo].[SendNote]
ADD CONSTRAINT [FK_SendNote_User]
    FOREIGN KEY ([UserID_Recive])
    REFERENCES [dbo].[User]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SendNote_User'
CREATE INDEX [IX_FK_SendNote_User]
ON [dbo].[SendNote]
    ([UserID_Recive]);
GO

-- Creating foreign key on [UserTypeID] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [FK_User_UserType]
    FOREIGN KEY ([UserTypeID])
    REFERENCES [dbo].[UserType]
        ([UserTypeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_User_UserType'
CREATE INDEX [IX_FK_User_UserType]
ON [dbo].[User]
    ([UserTypeID]);
GO

-- Creating foreign key on [UserID] in table 'UserLog'
ALTER TABLE [dbo].[UserLog]
ADD CONSTRAINT [FK_UserLog_User]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[User]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserLog_User'
CREATE INDEX [IX_FK_UserLog_User]
ON [dbo].[UserLog]
    ([UserID]);
GO

-- Creating foreign key on [UserID] in table 'UserSetJob'
ALTER TABLE [dbo].[UserSetJob]
ADD CONSTRAINT [FK_UserSetJob_User]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[User]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserSetJob_User'
CREATE INDEX [IX_FK_UserSetJob_User]
ON [dbo].[UserSetJob]
    ([UserID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------