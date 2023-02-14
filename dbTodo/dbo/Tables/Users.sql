CREATE TABLE [dbo].[Users] (
    [IdUser] INT           IDENTITY (1, 1) NOT NULL,
    [Nom]    NVARCHAR (50) NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([IdUser] ASC)
);

