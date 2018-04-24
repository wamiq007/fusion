CREATE TABLE [dbo].[Users] (
    [UserID]       INT            IDENTITY (1, 1) NOT NULL,
    [Username]     NVARCHAR (100) NULL,
    [Password]     NVARCHAR (50)  NULL,
    [FirstName]    NVARCHAR (100) NULL,
    [LastName]     NVARCHAR (100) NULL,
    [EmailAddress] VARCHAR (100)  NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserID] ASC),
    CONSTRAINT [IX_Users_Username] UNIQUE NONCLUSTERED ([UserID] ASC)
);

