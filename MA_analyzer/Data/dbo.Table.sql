CREATE TABLE [dbo].[Startups] ( -- creates new table
    [StartupId] NVARCHAR (50)  NOT NULL,
    [About]     NVARCHAR (MAX) NULL,
    [Team] INT NOT NULL, 
    [Customers] NVARCHAR (50) NOT NULL,
    [Revenue] INT NOT NULL,
    [Keywords] NVARCHAR(MAX) NULL,
    [Askingprice] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([StartupId] ASC)
); 

select * from Startups -- shows data in the table

DROP TABLE [dbo].[Startups] -- delete the table completely 