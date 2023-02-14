CREATE TABLE [dbo].[Todo] (
    [Id]    INT            IDENTITY (1, 1) NOT NULL,
    [Title] NVARCHAR (250) NOT NULL,
    [Done]  BIT            CONSTRAINT [DF_Todo_Done] DEFAULT ((0)) NULL,
    CONSTRAINT [PK_Todo] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_Todo]
    ON [dbo].[Todo]([Title] ASC);

