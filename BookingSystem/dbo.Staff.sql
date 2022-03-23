CREATE TABLE [dbo].[Staff] (
    [StaffID]  NCHAR (5)  NOT NULL,
    [Name]     NCHAR (50) NULL,
[Email]     NCHAR (50) NULL,
    [Address]  NCHAR (50) NULL,
    [Postcode] NCHAR (8)  NULL,
    [Phone]    NCHAR (11) NULL,
    [DOB]      NCHAR (10) NULL,
    [Password] NCHAR (25) NULL,
    PRIMARY KEY CLUSTERED ([StaffID] ASC)
);

