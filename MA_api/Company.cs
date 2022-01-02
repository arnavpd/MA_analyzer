using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA_api
{
    internal class Company
    {

        public int Team { get; set; }
        public string About { get; set; }
        public string Customers { get; set; }

        public int Revenue { get; set; }
        public string StartupId { get; set; }
        public string Keywords { get; set; }
        public int AskingPrice { get; set; }
        public string AnnualProfit { get; set; }
        public string Competitors { get; set; }


    }
}

/*CREATE TABLE [dbo].[Startups] (
    [StartupId] NVARCHAR (50) NOT NULL,
    [About] NVARCHAR(MAX) NULL, 
    [Team] INT NULL, 
    [Customers] INT NULL, 
    [Revenue] INT NULL, 
    [Keywords] NVARCHAR(MAX) NULL, 
    [AskingPrice] INT NULL, 
    [AnnualProfit] INT NULL, 
    [Competitors] NVARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([StartupId] ASC)
);

*/