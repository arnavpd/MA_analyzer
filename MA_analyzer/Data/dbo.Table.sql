CREATE TABLE [dbo].[Startups] ( -- creates new table
    [StartupId] NVARCHAR (50)  NOT NULL,
    [About]     NVARCHAR (MAX) NOT NULL,
    [Team] INT NULL, 
    [Customers] NVARCHAR (50) NOT NULL,
    [Revenue] INT NULL,
    [Keywords] NVARCHAR(MAX) NOT NULL,
    [AskingPrice] INT NOT NULL,
    [AnnualProfit] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([StartupId] ASC)
); 

select * from Startups -- shows data in the table

DROP TABLE [dbo].[Startups] -- delete the table completely 