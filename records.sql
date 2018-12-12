CREATE TABLE [dbo].[records] (
    [ticketno]  INT             NOT NULL,
    [item]      NCHAR (15)      NOT NULL,
    [vehicle]   NCHAR (15)      NOT NULL,
    [datentime] DATETIME        NOT NULL,
    [firstwt]   DECIMAL (18, 2) NOT NULL,
    [secondwt]  DECIMAL (18, 2) NOT NULL,
    [netwt]     DECIMAL (18, 2) NOT NULL,
    [harvester] NCHAR(20)		NOT NULL, 
    PRIMARY KEY CLUSTERED ([ticketno] ASC)
);

