CREATE TABLE [dbo].[customer] (
    [Id]        INT           NOT NULL,
    [myName]    NVARCHAR (50) NOT NULL,
    [myAddress] NVARCHAR (50) NOT NULL,
    [myPhone]   VARCHAR (20)  NOT NULL,
    [myEmail]   VARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

