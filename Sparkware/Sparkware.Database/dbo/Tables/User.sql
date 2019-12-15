CREATE TABLE [dbo].[User] (
    [Id]          UNIQUEIDENTIFIER  NOT NULL DEFAULT newid(),
    [FirstName]   NVARCHAR (250)   NOT NULL,
    [LastName]    NVARCHAR (250)   NOT NULL,
    [Username]    NVARCHAR (250)   NOT NULL,
    [DateOfBirth] DATETIME         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

