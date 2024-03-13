// Photo
CREATE TABLE [dbo].[Photo] (
    [Idx]         INT             IDENTITY (1, 1) NOT NULL,
    [uIdx]        INT             NOT NULL,
    [photo]       VARBINARY (MAX) NULL,
    [isRepresent] BIT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Idx] ASC),
    FOREIGN KEY ([uIdx]) REFERENCES [dbo].[User] ([idx])
);
//User
CREATE TABLE [dbo].[User] (
    [idx]      INT           IDENTITY (1, 1) NOT NULL,
    [userName] NVARCHAR (10) NOT NULL,
    [uid]      VARCHAR (15)  NOT NULL,
    [pwd]      VARCHAR (20)  NOT NULL,
    [nickName] NVARCHAR (15) NOT NULL,
    [dob]      DATE          NOT NULL,
    [isAdmin]  BIT           NOT NULL,
    [isLock]   BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([idx] ASC),
    UNIQUE NONCLUSTERED ([uid] ASC),
    UNIQUE NONCLUSTERED ([nickName] ASC)
);





